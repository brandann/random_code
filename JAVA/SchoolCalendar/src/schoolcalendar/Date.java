/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package schoolcalendar;

import java.util.ArrayList;

/**
 *
 * @author brandan
 */
public class Date {
    public String date;
    public String class1;
    public String[] c1InProgress;
    public String[] c1Completed;
    public String class2;
    public String[] c2InProgress;
    public String[] c2Completed;
    public String class3;
    public String[] c3InProgress;
    public String[] c3Completed;

    public Date(ArrayList<String> d){
        Driver driver = new Driver();
        int index = 0;
        date = d.get(index).substring(driver.YEAR_START);
        index++;
        
        class1 = d.get(index).substring(7);
        index++;
        String[] c1 = d.get(index).split(";");
        c1InProgress = c1[0].split("$");
        c1Completed  = c1[1].split("$");
        index++;
        
        class2 = d.get(index).substring(7);
        index++;
        String[] c2 = d.get(index).split(";");
        c2InProgress = c1[0].split("$");
        c2Completed  = c1[1].split("$");
        index++;
        
        class3 = d.get(index).substring(7);
        index++;
        String[] c3 = d.get(index).split(";");
        c3InProgress = c1[0].split("$");
        c3Completed  = c1[1].split("$");
        index++;
    }
    
    public String toStringPrint(){
        Driver driver = new Driver();
        String str = 
                "Date: " + date + "\n" +
                "Class: " + class1 + "\n";
        for(String s : c1InProgress)
            str = str + "\t" + s + "\n";
        str = str + "Class: " + class2 + "\n";
        for(String s : c2InProgress)
            str = str + "\t" + s + "\n";
        str = str + "Class: " + class3 + "\n";
        for(String s : c3InProgress)
            str = str + "\t" + s + "\n";
        str = str + driver.BREAK_TOKEN;
        return str;
    }
    
    public String toString(){
        Driver driver = new Driver();
        String str = 
                "Date: " + date + "\n" +
                "Class: " + class1 + "\n";
        for(String s : c1InProgress)
            str = str + driver.INPROGRESS_TOKEN + s + "\n";
        for(String s : c1Completed)
            str = str + driver.COMPLETED_TOKEN  + s + "\n";
        str = str + "Class: " + class2 + "\n";
        for(String s : c2InProgress)
            str = str + driver.INPROGRESS_TOKEN + s + "\n";
        for(String s : c2Completed)
            str = str + driver.COMPLETED_TOKEN  + s + "\n";
        str = str + "Class: " + class3 + "\n";
        for(String s : c3InProgress)
            str = str + driver.INPROGRESS_TOKEN + s + "\n";
        for(String s : c3Completed)
            str = str + driver.COMPLETED_TOKEN + s + "\n";
        str = str + driver.BREAK_TOKEN;
        return str;
    }
}
