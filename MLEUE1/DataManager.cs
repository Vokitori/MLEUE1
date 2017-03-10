﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MLEUE1
{
    class DataManager
    {
        public List<List<Wine>> QualityList = new List<List<Wine>>();
        public List<Wine> train = new List<Wine>();
        public List<Wine> test = new List<Wine>();

        public DataManager() {
        }

        public void Load(string path) {
            try
            {
                string line;
                StreamReader file =
                   new StreamReader(path);
                file.ReadLine();
                while ((line = file.ReadLine()) != null)
                {
                    string[] parts = file.ReadLine().Split(new char[] { ';' }, 12);
                    Wine tempWine = new Wine();
                    tempWine.FixedAcidity = Double.Parse(parts[0]);
                    tempWine.VolatileAcidity = Double.Parse(parts[1]);
                    tempWine.CitricAcid = Double.Parse(parts[2]);
                    tempWine.ResidualSugar = Double.Parse(parts[3]);
                    tempWine.Chlorides = Double.Parse(parts[4]);
                    tempWine.FreeSulfurDioxide = Double.Parse(parts[5]);
                    tempWine.TotalSulfurDioxide = Double.Parse(parts[6]);
                    tempWine.Density = Double.Parse(parts[7]);
                    tempWine.PH = Double.Parse(parts[8]);
                    tempWine.Sulphates = Double.Parse(parts[9]);
                    tempWine.Alcohol = Double.Parse(parts[10]);
                    tempWine.Quality = Int32.Parse(parts[11]);

                    QualityList[tempWine.Quality].Add(tempWine);

                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }
            catch
            {
                Console.WriteLine("Some Error");
            }
        }

        public void setTestData()
        {
            Random r = new Random();
            int random;
                train = new List<Wine>();
                test = new List<Wine>();
            
            for (int outerCount = 0; outerCount < QualityList.Count; outerCount++)
            {
                for (int innerCount = 0; innerCount < QualityList[outerCount].Count; innerCount++)
                {
                    random = (int)(r.NextDouble() * (QualityList[outerCount].Count*0.10 - innerCount));
                    test.Add(QualityList[outerCount][random]);
                    QualityList[outerCount].RemoveAt(random);
                }
            }
            for (int i = 0; i < QualityList.Count; i++)
            {
                train.AddRange(QualityList[i]);
            }
        }

    }
}
