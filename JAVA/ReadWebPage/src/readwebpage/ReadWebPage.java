/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package readwebpage;
import java.io.BufferedReader; 
import java.io.InputStreamReader;
import java.net.URL; 
import java.net.URLConnection;
/**
 *
 * @author brandan
 */
public class ReadWebPage {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        try {
            URL databasePath = new URL("http://greenrock.comule.com/NSMLib/");
            URLConnection connection = databasePath.openConnection();
            BufferedReader in = new BufferedReader(new
            InputStreamReader(connection.getInputStream()));
            String inputLine;
            while ((inputLine = in.readLine()) != null) {
                System.out.println(inputLine);
            }
            in.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
