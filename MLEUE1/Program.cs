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
            DataManager manager = new DataManager();
            manager.Load("");
            DataGuesser guesser = new DataGuesser(3);
            for (int i = 0; i < manager.test.Count(); i++)
            {
                int quality = guesser.GuessQuality(manager.test[i], manager.train);
                manager.test[i].Quality = quality;
            }
        }
    }
}
