/*
 * FileSort.java
 */

package filesort;

import java.io.*;
import java.util.Scanner;

/**
 * FileSort.java
 * CMD
 * main class that reads in args and makes sure all filepath
 * exists before creating the "real" class
 * @version 1.0
 * @author Brandan Haertel
 * Compiler: jdk1.7.0_09
 * Tested on: Windows 8 64bit AMD A8, Windows 7 64bit Intel I7
 * History:
 *      3/4/2013: Version 1.0 released to public!
 */
public class FileSort {

    /**
     * main
     * @param args the command line arguments
     */
    public static void main(String[] args) 
            throws ClassNotFoundException, IOException
    {
        boolean clean = false;
        
        String reservationPath = "reservations.txt";
        String databasePath = "reservations.dat";
        
        if(args.length > 0)
        {
            if(args[0].equalsIgnoreCase("-clean"))
            {
                clean = !clean;
            }
            else if (fileExist(args[0]))
            {
                reservationPath = args[0];
            }
            else
            {
                System.out.println("The reservation file you "
                        + "entered does not exist/n"
                        + "Please enter a new file path");
                reservationPath = getValidFile();
            }
        }
        if(args.length > 1)
        {
            if (fileExist(args[0]))
            {
                databasePath = args[1];
            }
        }
        if(!fileExist(reservationPath));
        {
            System.out.println("Please enter a reservation file path...");
            reservationPath = getValidFile();
        }
        if(!fileExist(databasePath));
        {
            System.out.println("Please enter a reservation "
                    + "*database* file path...");
            databasePath = getValidFile();
        }
        CMD cmd = new CMD(reservationPath, databasePath, clean);
    }
    
    /**
     * method that loops until a file that is valid and can
     * read is found from paths entered in from the user
     * @return String path verified path string
     */
    private static String getValidFile()
    {
        while(true)
        {
            String path = "";
            File inFile;
            Scanner keybored = new Scanner(System.in);
            
            path = keybored.nextLine();
            inFile = new File(path);
            
            if(inFile.exists() && inFile.canRead())
            {
                return path;
            }
            System.out.println("That path did not work, "
                    + "please try anouther path...");
        }
    }
    
    /**
     * makes sure that path exists (a precheck before getValidFile()
     * @param path string path of file to check
     * @return boolean true if file exists, false if file does not exist
     */
    private static boolean fileExist(String path)
    {
        File inFile = new File(path);
        if(!inFile.exists() || !inFile.canRead())
        {
            return false;
        }
        return true;
    }
}