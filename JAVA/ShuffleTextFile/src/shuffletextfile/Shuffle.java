/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package shuffletextfile;

import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.ArrayList;
import java.util.Random;
import java.util.Scanner;

/**
 *
 * @author brandan
 */
public class Shuffle {
   
    public Shuffle()
    {}
    
    public String[] shuffle(String path)
    {
        System.out.println("Shuffle path");
        String[] Array = load(path);
        //for(String s : Array)
            //System.out.println(s);
        if (Array != null)
            return shuffle(Array);
        logError("text file returned null");
        return Array;
    }
    
    public String[] shuffle(String[] a)
    {
        Random rand = new Random();
        for(int i = 0; i < a.length*3; i++)
        {
            swap(a,rand.nextInt(a.length),rand.nextInt(a.length));
        }
        return a;
    }
    
    public boolean save(String path, String[] a)
    {
        PrintWriter fileOutput;
        try{
            fileOutput = new PrintWriter(new FileOutputStream(path));
            for (String s : a)
                fileOutput.println(s);
            fileOutput.close();
            return true;
        }
        catch(IOException e){
            System.out.println("Error: write");
            return false;
        }
    }
    
    private static void swap(String[] a, int f, int l)
    {
        String temp = a[f];
        a[f] = a[l];
        a[l] = temp;
    }
    
    private String[] load(String path)
    {
        String[] Array = null;
        Scanner fileInputScanner;
        ArrayList<String> list = new ArrayList();
        try{
            fileInputScanner = new Scanner(new File(path));
            while(fileInputScanner.hasNextLine()){
                String in = fileInputScanner.nextLine();
                //System.out.println(in);
                list.add(in);
            }
            fileInputScanner.close();
        }
        catch(Exception e){
            System.out.println("Error: readTextFile");
            return Array;
        }
        
        Array = new String[list.size()];
        Array = list.toArray(Array);
        
        return Array;
    }
    
    private void logError(String s)
    {
        System.out.println("Error: " + s);
    }
}
