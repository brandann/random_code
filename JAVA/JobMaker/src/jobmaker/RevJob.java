/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package jobmaker;

import java.awt.BorderLayout;
import java.awt.FlowLayout;
import java.awt.GridLayout;
import javax.swing.JButton;
import javax.swing.JFrame;
import static javax.swing.JFrame.EXIT_ON_CLOSE;
import javax.swing.JLabel;
import javax.swing.JPanel;

/**
 *
 * @author brandan
 */
public class RevJob extends JFrame{
    public RevJob(Driver d){
        this.d = d;
        setSize(d.FRAME_WIDTH, d.FRAME_HEIGHT);
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        setTitle(d.FRAME_TITLE_PREFIX + d.SPACER + d.REVISE_TITLE);
        setLocation(d.LOC, d.LOC);
        setLayout(new BorderLayout());
        setVisible(true);
        initComponents();
    }
    
    public void initComponents(){
        okButton = new JButton("OK");
        brandanLabel = new JLabel(d.BRANDAN_NOTE);
        brandanLabel = new JLabel(d.REVISE_TITLE);
        mainPanel = new JPanel(new GridLayout());
        brandanPanel = new JPanel(new BorderLayout());
        titlePanel = new JPanel(new FlowLayout());
    }
    
    Driver d;
    JButton okButton;
    JLabel brandanLabel;
    JLabel titleLabel;
    JPanel mainPanel;
    JPanel brandanPanel;
    JPanel titlePanel;
}