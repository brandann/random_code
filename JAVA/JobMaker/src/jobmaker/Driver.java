/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package jobmaker;

import java.awt.Color;
import java.awt.Font;

/**
 *
 * @author brandan
 */
public class Driver {
    
    
    
    
    
    
    public final Color D_COLOR = new Color(0x414141);
    public final Color L_COLOR = new Color(0xA2B2CE);
    public final Color E_COLOR = new Color(0xF0243C);
    public final Font L_FONT = new Font(Font.SANS_SERIF, Font.BOLD, 36);
    public final Font S_FONT = new Font(Font.SANS_SERIF, Font.PLAIN, 10);
    public final int FRAME_HEIGHT = 480;
    public final int FRAME_WIDTH  = 640;
    public final int LOC = 200;
    public final String REV_LOG_FILE = "rev_log.txt";
    public final String JOB_INFORMATION_FILE = "job_information.csv";
    public final String FRAME_TITLE_PREFIX = "Create/Revise Job Helper";
    public final String STATE_TITLE = "Home";
    public final String NEW_TITLE = "New Job";
    public final String WORKORDER_TITLE = "Load Workorder";
    public final String REVISE_TITLE = "Revise / Resubmit Job";
    public final String BRANDAN_NOTE = "(c) Brandan Haertel 2013";
    public final String MISSING_INFORMATION = "<-- Missing!";
    public final String SPACER = " - ";
	
    public String currentFolderPath;
    public String workorderFolderPath;
    public String caddShopsFolderPath;
    public String company;
    public String pm;
    public String pe;
    public String makeFate;
    public String workoderFile;
    public String updatePath;
    public String title;
    public String revDate;
    public String[][] revisions; //10x3
	//00	[Title] [Date] [Revision Number]
	//01	[Title] [Date] [Revision Number]
	//02	[Title] [Date] [Revision Number]
	//03	[Title] [Date] [Revision Number]
	//04	[Title] [Date] [Revision Number]
	//05	[Title] [Date] [Revision Number]
	//06	[Title] [Date] [Revision Number]
	//07	[Title] [Date] [Revision Number]
	//08	[Title] [Date] [Revision Number]
        //09	[Title] [Date] [Revision Number]
}

