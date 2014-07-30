/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package jobmaker;

import java.awt.BorderLayout;
import java.awt.FlowLayout;
import java.awt.Font;
import java.awt.GridLayout;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;

/**
 *
 * @author brandan
 */
public class State extends JFrame{
    public State(Driver d){
        this.d = d;
        setSize(d.FRAME_WIDTH, d.FRAME_HEIGHT);
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        setTitle(d.FRAME_TITLE_PREFIX + d.SPACER + d.STATE_TITLE);
        setLocation(d.LOC, d.LOC);
        setLayout(new BorderLayout());
        setVisible(true);
        initComponents();
    }
    
    public void initComponents(){
        okButton = new JButton("OK");
        brandanLabel = new JLabel(d.BRANDAN_NOTE);
        titleLabel = new JLabel(d.STATE_TITLE);
        mainPanel = new JPanel(new GridLayout());
        brandanPanel = new JPanel(new BorderLayout());
        titlePanel = new JPanel(new FlowLayout());
        
        titleLabel.setFont(d.L_FONT);
        titleLabel.setText(d.STATE_TITLE);
        titleLabel.setForeground(d.L_COLOR);
        titlePanel.setBackground(d.D_COLOR);
        titlePanel.add(titleLabel);
        
        brandanLabel.setFont(d.S_FONT);
        brandanLabel.setForeground(d.L_COLOR);
        brandanPanel.setBackground(d.D_COLOR);
        brandanPanel.add(brandanLabel, BorderLayout.EAST);
        
        add(titlePanel, BorderLayout.NORTH);
        add(brandanPanel, BorderLayout.SOUTH);
    }
    
    Driver d;
    JButton okButton;
    JLabel brandanLabel;
    JLabel titleLabel;
    JPanel mainPanel;
    JPanel brandanPanel;
    JPanel titlePanel;
}
