using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seterrachooser
{
    public class SeterraChooser
    {
        public string ChooseMaps()
        {
            // If you are running this program on your own computer, replace all the file paths in the following 4 lines with
            // the file paths of where the CSV files are located on your computer.
            string[] smallMaps = File.ReadAllLines("C:\\Users\\astro\\Documents\\smallMaps.csv");
            string[] mediumMaps = File.ReadAllLines("C:\\Users\\astro\\Documents\\mediumMaps.csv");
            string[] largeMaps = File.ReadAllLines("C:\\Users\\astro\\Documents\\largeMaps.csv");
            string[] hugeMaps = File.ReadAllLines("C:\\Users\\astro\\Documents\\hugeMaps.csv");

            string[] categories = { "Pin", "Pin Hard", "Place Labels", "Multiple Choice", "Shownext", "Type" };
            int mapCount = 0;
            Random random = new Random();
            List<string> mapNames = new List<string>();
            List<string> categoryList = new List<string>();
            List<string> smallMapList = new List<string>();
            List<string> mediumMapList = new List<string>();
            List<string> largeMapList = new List<string>();
            List<string> hugeMapList = new List<string>();
            int randomNumber = 0;
            while (mapCount < 3)
            {
                string mapChoice = smallMaps[random.Next(0, smallMaps.Length)];
                if (!mapNames.Contains(mapChoice))
                {
                    int bigRandomNumber = random.Next(1, 101);
                    if (bigRandomNumber <= 20)
                    {
                        randomNumber = 0;
                    }
                    else if (bigRandomNumber <= 30)
                    {
                        randomNumber = 1;
                    }
                    else if (bigRandomNumber <= 50)
                    {
                        randomNumber = 2;
                    }
                    else if (bigRandomNumber <= 65)
                    {
                        randomNumber = 3;
                    }
                    else if (bigRandomNumber <= 75)
                    {
                        randomNumber = 4;
                    }
                    else if (bigRandomNumber <= 100)
                    {
                        randomNumber = 5;
                    }
                    string category = categories[randomNumber];
                    if (!categoryList.Contains(category))
                    {
                        mapNames.Add(mapChoice);
                        categoryList.Add(category);
                        smallMapList.Add(mapChoice + " --- " + category);
                        mapCount++;
                    }
                }
            }
            mapNames.Clear();
            categoryList.Clear();
            mapCount = 0;
            while (mapCount < 4)
            {
                string mapChoice = mediumMaps[random.Next(0, mediumMaps.Length)];
                if (!mapNames.Contains(mapChoice))
                {
                    int bigRandomNumber = random.Next(1, 101);
                    if (bigRandomNumber <= 20)
                    {
                        randomNumber = 0;
                    }
                    else if (bigRandomNumber <= 30)
                    {
                        randomNumber = 1;
                    }
                    else if (bigRandomNumber <= 50)
                    {
                        randomNumber = 2;
                    }
                    else if (bigRandomNumber <= 65)
                    {
                        randomNumber = 3;
                    }
                    else if (bigRandomNumber <= 75)
                    {
                        randomNumber = 4;
                    }
                    else if (bigRandomNumber <= 100)
                    {
                        randomNumber = 5;
                    }
                    string category = categories[randomNumber];
                    if (!categoryList.Contains(category))
                    {
                        mapNames.Add(mapChoice);
                        categoryList.Add(category);
                        mediumMapList.Add(mapChoice + " --- " + category);
                        mapCount++;
                    }
                }
            }
            mapNames.Clear();
            categoryList.Clear();
            mapCount = 0;
            while (mapCount < 4)
            {
                string mapChoice = largeMaps[random.Next(0, largeMaps.Length)];
                if (!mapNames.Contains(mapChoice))
                {
                    int bigRandomNumber = random.Next(1, 101);
                    if (bigRandomNumber <= 20)
                    {
                        randomNumber = 0;
                    }
                    else if (bigRandomNumber <= 30)
                    {
                        randomNumber = 1;
                    }
                    else if (bigRandomNumber <= 50)
                    {
                        randomNumber = 2;
                    }
                    else if (bigRandomNumber <= 65)
                    {
                        randomNumber = 3;
                    }
                    else if (bigRandomNumber <= 75)
                    {
                        randomNumber = 4;
                    }
                    else if (bigRandomNumber <= 100)
                    {
                        randomNumber = 5;
                    }
                    string category = categories[randomNumber];
                    if (!categoryList.Contains(category))
                    {
                        mapNames.Add(mapChoice);
                        categoryList.Add(category);
                        largeMapList.Add(mapChoice + " --- " + category);
                        mapCount++;
                    }
                }
            }
            mapNames.Clear();
            categoryList.Clear();
            mapCount = 0;
            while (mapCount < 4)
            {
                string mapChoice = hugeMaps[random.Next(0, hugeMaps.Length)];
                if (!mapNames.Contains(mapChoice))
                {
                    int bigRandomNumber = random.Next(1, 101);
                    if (bigRandomNumber <= 20)
                    {
                        randomNumber = 0;
                    }
                    else if (bigRandomNumber <= 30)
                    {
                        randomNumber = 1;
                    }
                    else if (bigRandomNumber <= 50)
                    {
                        randomNumber = 2;
                    }
                    else if (bigRandomNumber <= 65)
                    {
                        randomNumber = 3;
                    }
                    else if (bigRandomNumber <= 75)
                    {
                        randomNumber = 4;
                    }
                    else if (bigRandomNumber <= 100)
                    {
                        randomNumber = 5;
                    }
                    string category = categories[randomNumber];
                    if (!categoryList.Contains(category))
                    {
                        mapNames.Add(mapChoice);
                        categoryList.Add(category);
                        hugeMapList.Add(mapChoice + " --- " + category);
                        mapCount++;
                    }
                }
            }
            string returnString = smallMapList[0] + "\n" + smallMapList[1] + "\n" + smallMapList[2] + "\n" +
                 mediumMapList[0] + "\n" + mediumMapList[1] + "\n" + mediumMapList[2] + "\n" + mediumMapList[3] + "\n" +
                  largeMapList[0] + "\n" + largeMapList[1] + "\n" + largeMapList[2] + "\n" + largeMapList[3] + "\n" +
                  hugeMapList[0] + "\n" + hugeMapList[1] + "\n" + hugeMapList[2];
            return returnString;
        }
    }
}
