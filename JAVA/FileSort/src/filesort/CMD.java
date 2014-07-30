/*
 * CMD.java
 */
package filesort;

import Calendar.DateAD;
import java.io.*;
import java.util.*;

/**
 * CMD.java
 * CMD
 * Automated class reading in a reservation list
 * and adding it, or creating a sorted data base.
 * @version 1.0
 * @author Brandan Haertel
 * Compiler: jdk1.7.0_09
 * Tested on: Windows 8 64bit AMD A8, Windows 7 64bit Intel I7
 * History:
 *      3/4/2013: Version 1.0 released to public!
 */
public class CMD {
    /**
     * Constructor
     * @param resPath reservation file path
     * @param dataPath database file path
     * @param inClean cleans the database if true
     * @throws ClassNotFoundException
     * @throws IOException 
     */
    public CMD(String resPath, String dataPath, boolean inClean) 
            throws ClassNotFoundException, IOException
    {
        importReservationList = new ArrayList<>();
        databaseReservationList = new ArrayList<>();
        databaseCount = 0;
        reservationPath = resPath;
        databasePath = dataPath;
        clean  = inClean;
        
        getDatabase(databasePath);
        if(!clean)
        {
            getReservations(reservationPath);
        }
        else
        {
            setClean();
        }
        removeDuplicates();
        Sorts.quickSort(database);
        makeDatabase();
        writeReservations(reservationPath);
    }
    
    /**
     * cleans the database of reservations before the current date.
     */
    private void setClean()
    {
        DateAD today = new DateAD();
        int reservation = 0;
        while (reservation < databaseReservationList.size())
        {
            if(today.compareTo(databaseReservationList.get(reservation)
                    .getDepartureDate()) > 0)
            {
                databaseReservationList.remove(reservation);
                reservation = 0;
            }
            reservation++;
        }
    }
    
    /**
     * loads reservations into an Arraylist for processing.
     * @param path reservation file path
     */
    private void getReservations(String path)
    {
        File inFile = new File(path);
        Scanner fileInputScanner;
        String[] infoIn = new String[4];
        databaseCount = 0;
        
        try
        {
            fileInputScanner = new Scanner(inFile);
            while(fileInputScanner.hasNextLine())
            {
                fileInputScanner.nextLine();
                databaseCount++;
            }
            fileInputScanner.close();
        }
        catch(IOException e)
        {
            System.out.println("CMD_New//getReservations -- "
                    + "Unable to count reservation file");
        }
        
        databaseCount = databaseCount / DATABASE_LINE_COUNT;
        
        if(databaseCount > 0)
        {
            try
            {
                fileInputScanner = new Scanner(inFile);
                while(fileInputScanner.hasNextLine())
                {
                    for(int i = 0; i < 4; i++)
                    {
                        infoIn[i] = fileInputScanner.nextLine();
                    }
                    importReservationList.add(
                            new Reservation(infoIn[0], 
                            new DateAD(infoIn[1]), 
                            new DateAD(infoIn[2])));
                }    
                fileInputScanner.close();
            }
            catch(IOException e)
            {
                System.out.println("CMD_New//getNewReservations -- "
                        + "Unable to cast reservation file into a list");
            }
        }
    }
    
    /**
     * loads the database into an Arraylist for processing.
     * @param path database file path
     * @throws ClassNotFoundException
     * @throws IOException 
     */
    private void getDatabase(String path) 
            throws ClassNotFoundException, IOException
    {
        ObjectInputStream in;
        databaseCount = 0;
        Reservation[] temp = null;
        Object temp2 = null;
        File inFile = new File(databasePath);
        
        if(inFile.exists() && inFile.canRead())
        {
            in = new ObjectInputStream(new FileInputStream(path));
        
            try
            {
                temp2 = in.readObject();
                temp = (Reservation[]) temp2;

                in.close();

                if(temp != null)
                {
                    for(int i = 0; i < temp.length; i++)
                    {
                        databaseReservationList.add(temp[i]);
                    }
                }
            }
            catch(IOException e)
            {
                in.close();
                System.out.println("CMD_New//getDatabase -- "
                        + "Unable to load database file");
            }
        }
    }
    
    /**
     * creates a new textfile with a appended name that contains the
     * current database information for review
     * @param myPath path of the reservation file in use for reference.
     */
    private void writeReservations(String myPath)
    {
        String path = myPath.replace(".txt", "_db.txt");
        //String path = myPath.substring(0, myPath.indexOf("."));

	File fileObject;
        PrintWriter fileOutput;

        fileObject = new File(path);

        //need to creat a text file here if one does not exist!
        if(!fileObject.exists())
        {
            try
            {
                fileObject.createNewFile();
            }
            catch(IOException e)
            {
            }
        }
        try
        {
            fileOutput = new PrintWriter(new FileOutputStream(path));  
            if(database.length > 0)
            {
                for(int i = 0; i < database.length; i++)
                {
                    fileOutput.println(
                            database[i].getName().toString());
                    fileOutput.println(
                            database[i].getArrivalDate().toString());
                    fileOutput.println(
                            database[i].getDepartureDate().toString());
                    fileOutput.println();
                }
            }
            fileOutput.close( );
       }
       catch(IOException e)
       {
          System.out.println("Problem reading from file.");
       }
    }
    
    /**
     * prints the contents of the database to the console.
     */
    private void printDatabase()
    {
        if(database.length > 0)
        {
            for(int i = 0; i < database.length; i++)
            {
                System.out.println(database[i].toString());
            }
        }
        else
        {
            System.out.println("CMD_New//printDatabase -- No database items");
        }
    }
    
    /**
     * writes the database information to the binary file of database path.
     */
    private void makeDatabase()
    {
        printDatabase();
        if(database.length > 0)
        {
            ObjectOutputStream out;
            try
            {
                out = new ObjectOutputStream(
                        new FileOutputStream(databasePath));
                out.writeObject(database);
                out.close();
            }
            catch(IOException e)
            {}
        }
        
        System.out.println("Database File Path:");
        System.out.println(databasePath);
    }
    
    /**
     * removes all duplicates from the database, 
     * after new entries have been added then creates the database array
     * to be saved out.
     */
    private void removeDuplicates()  //i am here!
    {
        for(int i = 0; i < importReservationList.size(); i++)
        {
            databaseReservationList.add(importReservationList.get(i));
        }
        
        for(int i = 0; i < databaseReservationList.size(); i++)
        {
            int j = 0;
            boolean done = false;
            while(!done)
            {
                if(!(i == j))
                {
                    if(j == databaseReservationList.size())
                    {
                        done = true;
                    }
                    else if(databaseReservationList.get(i).equals(
                            databaseReservationList.get(j)))
                    {
                        databaseReservationList.remove(j);
                        j = 0;
                    }
                    else
                    {
                        j++;
                    }
                }
                else
                {
                    j++;
                }
            }
        }

        database = new Reservation[databaseReservationList.size() - 1];
        database = databaseReservationList.toArray(database);
    }
    private final int DATABASE_LINE_COUNT = 4;
    private Reservation[] database;
    private ArrayList<Reservation> importReservationList;
    private ArrayList<Reservation> databaseReservationList;
    private int databaseCount;
    private String reservationPath;
    private String databasePath;
    boolean clean;
}