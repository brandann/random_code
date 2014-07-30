/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package panelextractionconsolidation;
import java.io.*;
import java.util.*;
/**
 *
 * @author brandan
 */
public class PanelExtractionConsolidation {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) 
    {
        int panelCount = 0;
        final int ARGS_INPUTFILE = 0;
	final int ARGS_OUTPUTFILE = 1;
        final int TEMP_ID = 0;
	final String SPLIT_TOKEN = ",";
        
        String inputPath = args[ARGS_INPUTFILE];
	String outputPath = args[ARGS_OUTPUTFILE];
		
        String[] temp;
		
        PrintWriter outputFile;
	Scanner fileInputScanner;
	Scanner keyboard = new Scanner(System.in);
        
        PanelCompressor panels = new PanelCompressor();
	
	try
        {
            outputFile = new PrintWriter(outputPath);
            File inputFile = new File(inputPath);
            fileInputScanner = new Scanner(inputFile);
			
            System.out.println("Input File: " + inputPath);
            System.out.println("Output File: " + outputPath);
		
            while(fileInputScanner.hasNextLine())
            {
                temp = fileInputScanner.nextLine().split(SPLIT_TOKEN);
                if(panels.panelExists(temp[TEMP_ID]))
                {
                    panels.appendPanel(temp);
                }
                else
                {
                    panels.addPanel(temp);
                    panelCount++;
                }
		
            }
            
            for(int i = 0; i < panelCount; i++)
            {
                outputFile.print(panels.print(i));
            }
            outputFile.close( );
	}
	catch(IOException e)
	{
            System.out.println("Problem reading from file.");
            System.out.println(e);
	}
            System.out.println("I'm finished, press enter to close");
            keyboard.next( );
    }
    
        
}
