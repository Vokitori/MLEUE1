using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLEUE1
{
    class DataGuesser
    {
        public int NearestNeighborK { get; set; }

        public DataGuesser(int nearestNeighborK = 3)
        {
            NearestNeighborK = nearestNeighborK;
        }

        public int GuessQuality(Data selected, List<Data> train)
        {
            DataSimilarityComparator comparator = new DataSimilarityComparator(selected);
            train.Sort(comparator);

            double quality = 0;
            for (int j = 0; j < NearestNeighborK; j++)
            {
                quality += train[j].Quality;
            }
            quality /= NearestNeighborK;
            return (int)Math.Round(quality);
        }
    }
}
