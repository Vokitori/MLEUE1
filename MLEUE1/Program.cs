using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLEUE1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataManager manager = new DataManager(10);
            manager.Load(@".\winequality-white.csv");
            manager.setTestData();
            for (int i = 0; i < manager.test.Count; i++)
            {
               Console.WriteLine( manager.test[i].ToString());
            }
            for (int i = 0; i < manager.testCompaire.Count; i++)
            {
                Console.WriteLine(manager.testCompaire[i].ToString());
            }
            DataGuesser guesser = new DataGuesser(3);
            for (int i = 0; i < manager.test.Count(); i++)
            {
                int quality = guesser.GuessQuality(manager.test[i], manager.train);
                Console.WriteLine(i + ": " + quality + " Realquality: "+ 
                    manager.testCompaire[i].Quality+" Distance: "+ (quality-manager.testCompaire[i].Quality));
                manager.test[i].Quality = quality;
            }
            Console.ReadKey();
        }
    }
}
