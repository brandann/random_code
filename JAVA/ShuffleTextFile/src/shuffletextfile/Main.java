/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package shuffletextfile;

/**
 *
 * @author brandan
 */
public class Main {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        String[] list = null;
        Shuffle s = new Shuffle();
        list = s.shuffle("dictionary.txt");
        //for(String string : list)
            //System.out.println(string);
        s.save("Scrambled_Dictionary.txt", list);
    }
}
