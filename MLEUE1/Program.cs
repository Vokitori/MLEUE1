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
            List<Data> test = new List<Data>();
            List<Data> train = new List<Data>();
            DataGuesser guesser = new DataGuesser(3);
            for (int i = 0; i < test.Count; i++)
            {
                int quality = guesser.GuessQuality(test[i], train);

            }
        }
    }
}
