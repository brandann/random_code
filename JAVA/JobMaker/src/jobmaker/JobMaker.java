/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package jobmaker;

import javax.swing.JFrame;

/**
 *
 * @author brandan
 */
public class JobMaker {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Driver d = new Driver();
        JFrame s = new State(d);
    }
}
