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
            Console.ReadKey();
        }
    }
}
