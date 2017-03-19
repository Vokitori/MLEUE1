using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MLEUE1 {
    class DataManager {
        private List<List<Data>> QualityList = new List<List<Data>>();
        public List<Data> train = new List<Data>();
        public List<Data> test = new List<Data>();
        public List<Data> testCompaire = new List<Data>();

        private int _categoryNumber { get; set; }

        public DataManager(int categoryNumber) {
            _categoryNumber = categoryNumber;
        }

        public void Load(string path) {
            try {
                QualityList = new List<List<Data>>();
                for (int i = 0; i < _categoryNumber; i++) {
                    QualityList.Add(new List<Data>());
                }
                string line;
                StreamReader file = new StreamReader(path);
                file.ReadLine();

                while ((line = file.ReadLine()) != null) {
                    if (line.Trim().Length < 1)
                        continue;
                    string[] parts = line.Split(new char[] { ';' }, 12);
                    if (parts.Length < 12)
                        continue;
                    Wine tempWine = new Wine();
                    for (int i = 0; i < 11; i++) {
                        tempWine.Attributes.Add(Double.Parse(parts[i].Trim(), System.Globalization.CultureInfo.InvariantCulture));
                    }
                    tempWine.Quality = Int32.Parse(parts[11].Trim(), System.Globalization.CultureInfo.InvariantCulture);
                    QualityList[tempWine.Quality].Add(tempWine);

                }
            } catch (FileNotFoundException) {
                Console.WriteLine("File not found.");
            } catch (Exception e) {
                Console.WriteLine(e);
            }
        }

        public void setTestData() {
            Random r = new Random();
            int random;
            train = new List<Data>();
            test = new List<Data>();
            testCompaire = new List<Data>();

            for (int outerCount = 0; outerCount < QualityList.Count; outerCount++) {
                int tenPercent = (int)(QualityList[outerCount].Count * 0.10);
                for (int innerCount = 0; innerCount < tenPercent; innerCount++) {
                    random = (int)(r.NextDouble() * (QualityList[outerCount].Count));
                    test.Add(QualityList[outerCount][random]);
                    QualityList[outerCount].RemoveAt(random);
                }
            }
            for (int i = 0; i < QualityList.Count; i++) {
                train.AddRange(QualityList[i]);
            }

            for (int i = 0; i < test.Count; i++)
            {
                testCompaire.Add((Data)test[i].Clone());
            }

            for (int i = 0; i < test.Count; i++) {
                test[i].Quality = -1;
            }
        }

    }
}
