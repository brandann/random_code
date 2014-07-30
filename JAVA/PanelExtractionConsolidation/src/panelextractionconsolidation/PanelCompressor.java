/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package panelextractionconsolidation;

/**
 *
 * @author brandan
 */
public class PanelCompressor 
{
    String print = "";
    int panelCount = 0;
    
    
    public PanelCompressor()
    {
        
    }
    
    public boolean panelExists(String in)
    {
        for(int i = 0; i < PANELS_COLUMNS; i++)
	{
            if(panels[PANELS_ID][i].equals(in)) {return true;}
	}
	return false;
    }
    
    public void appendPanel(String[] temp)
    {
        for(int i = 0; i < PANELS_COLUMNS; i++)
	{
            if(panels[PANELS_ID][i].equals(temp[TEMP_ID])) 
            {
                switch (temp[TEMP_FACE]) 
                {
                    case "W1":
                        panels[PANELS_WIDTH_1][i] = temp[TEMP_WIDTH];
                        break;
                    case "W2":
                        panels[PANELS_WIDTH_2][i] = temp[TEMP_WIDTH];
                        break;
                    case "W3":
                        panels[PANELS_WIDTH_3][i] = temp[TEMP_WIDTH];
                        break;
                    case "W4":
                        panels[PANELS_WIDTH_4][i] = temp[TEMP_WIDTH];
                        break;
                    case "SR":
                        panels[PANELS_SOFFIT_RETURN][i] = temp[TEMP_WIDTH];
                        break;
                }
		panels[PANELS_HEIGHT][i] = temp[TEMP_HEIGHT];
		break;
            }
	}
    }
    
    public void addPanel(String[] temp)
    {
        for(int i = 0; i < PANELS_COLUMNS; i++)
	{
            if(panels[PANELS_ID][i].equals(null))
            {
                panels[PANELS_ID][i] = temp[TEMP_ID];
                switch (temp[TEMP_FACE]) 
                {
                    case "W1":
                        panels[PANELS_WIDTH_1][i] = temp[TEMP_WIDTH];
                        break;
                    case "W2":
                        panels[PANELS_WIDTH_2][i] = temp[TEMP_WIDTH];
                        break;
                    case "W3":
                        panels[PANELS_WIDTH_3][i] = temp[TEMP_WIDTH];
                        break;
                    case "W4":
                        panels[PANELS_WIDTH_4][i] = temp[TEMP_WIDTH];
                        break;
                    case "SR":
                        panels[PANELS_SOFFIT_RETURN][i] = temp[TEMP_WIDTH];
                        break;
                }
                panels[PANELS_HEIGHT][i] = temp[TEMP_HEIGHT];
                break;
            }
        }
    }
    
    public String print(int i)
    {
        for(int j = 0; j < PANELS_ROWS; j++)
        {
            print += panels[j][i] + ",";
        }
        return print;
    }
    final int PANELS_ROWS = 7;
    final int PANELS_COLUMNS = 100;
    final int PANELS_ID = 0;
    final int PANELS_WIDTH_1 = 1;
    final int PANELS_WIDTH_2 = 2;
    final int PANELS_WIDTH_3 = 3;
    final int PANELS_WIDTH_4 = 4;
    final int PANELS_HEIGHT = 5;
    final int PANELS_SOFFIT_RETURN = 6;
    final int TEMP_ID = 0;
    final int TEMP_FACE = 1;
    final int TEMP_WIDTH = 2;
    final int TEMP_HEIGHT = 3;
    final int TEMP_SOFFIT_RETURN = 4;
    String[][] panels = new String[PANELS_ROWS][PANELS_COLUMNS];
}
