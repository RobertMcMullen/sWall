using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using UnityEngine;
using UnityEngine.UI;

public class Theme
{
    //TODO Figure out a way to select which theme, OPTIONS menu could be an idea

    //Checks file for the right theme
    public string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);//Contains the path to myDocuments, will read the file that is in there
    public string folderName = "Themes";
    public string fileName = "Themes.xml";
    public int themeNumber = 0;//Default it to select 1st theme

    private Color normalCol;
    private Color highCol;
    private Color pressedCol;
    private Color disCol;
    private Color[] allCol;//Contains an array of all the colors for setting a button
    
       

    public Theme()
    {
        path = path + "\\" + folderName + "\\" + fileName;
        allCol = new Color[4];        
        readThemes();   
        
    }
    
    private void readThemes()
    {
        try
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);
            var baseNode = xmlDoc.DocumentElement;

            foreach (XmlNode node in baseNode.ChildNodes)//Parse the xmlDoc for the specific image.
            {
                if (Int32.Parse(node.SelectSingleNode("num").InnerText).Equals(themeNumber))
                {
                    string normalInput = node.SelectSingleNode("NormalColor").InnerText;
                    string[] normalRGB = getRGB("NormalColor", node);
                    string[] highRGB = getRGB("HighlightedColor", node);
                    string[] pressRGB = getRGB("PressedColor", node);
                    string[] dissRGB = getRGB("DisabledColor", node);
                    //[0] = R
                    //[1] = G
                    //[2] = B
                    //These are stored as int from 0->255  
                    normalCol = convertRGBtoCol(normalRGB);
                    highCol = convertRGBtoCol(highRGB);
                    pressedCol = convertRGBtoCol(pressRGB);
                    disCol = convertRGBtoCol(dissRGB);

                }
            }
        }
        catch (FileNotFoundException e)
        {
            Debug.Log("FileDoesNotExist");
            string[] normalRGB = { "0", "204", "204" };
            string[] highRGB = { "128", "255", "255" };
            string[] pressRGB = { "51", "102", "102" };
            string[] dissRGB = { "55", "66", "77" };

            normalCol = convertRGBtoCol(normalRGB);
            highCol = convertRGBtoCol(highRGB);
            pressedCol = convertRGBtoCol(pressRGB);
            disCol = convertRGBtoCol(dissRGB);
        }


    }

    

    private string[] getRGB(string colType,XmlNode node)//Seperates the commas from the input string and saves the RBG values into an array
    {
        //Values are in the range of 0->255
        string input = node.SelectSingleNode(colType).InnerText;
        string[] RGB = input.Split(',');
        return RGB;
    }
    private Color convertRGBtoCol(string[] inputRGB)//Converst the string[] containing the RGB values into a Color variable
    {
        float R = Int32.Parse(inputRGB[0]);//Contains the color value from 0->255
        float G = Int32.Parse(inputRGB[1]);
        float B = Int32.Parse(inputRGB[2]);

        Color convertedCol = new Color(R/255,G/255,B/255);
        return convertedCol;

    }
    public Color[] getColArr()
    {

        allCol[0] = normalCol;
        allCol[1] = highCol;
        allCol[2] = pressedCol;
        allCol[3] = disCol;
        
        return allCol;

    }

    public void updateColors(Button[] allButtons, Text[] allText)
    {
        Color[] themeInUse = getColArr();
        for (int j = 0; j < allButtons.Length; j++)
        {
            ColorBlock cb = allButtons[j].colors;
            cb.normalColor = themeInUse[0];
            cb.highlightedColor = themeInUse[1];
            cb.pressedColor = themeInUse[2];
            cb.disabledColor = themeInUse[3];
            allButtons[j].colors = cb;
        }
        if (allText != null){
            
            for (int j = 0; j < allText.Length; j++)
            {                
                allText[j].color = themeInUse[0];               
                
            }
        }
    }
}
