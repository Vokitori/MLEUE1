using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLEUE1
{
    class DataSimilarityComparator : Comparer<Data>
    {
        private Data data;
        public DataSimilarityComparator(Data candiate)
        {
            this.data = candiate;
        }

        public override int Compare(Data data1, Data data2)
        {
            double squaredDist1 = 0;
            for (int i = 0; i < data.Attributes.Count(); i++)
            {
                squaredDist1 += Math.Pow(data1.Attributes[i] - data.Attributes[i], 2);
            }
            double squaredDist2 = 0;
            for (int i = 0; i < data.Attributes.Count(); i++)
            {
                squaredDist1 += Math.Pow(data2.Attributes[i] - data.Attributes[i], 2);
            }
            if (squaredDist1 > squaredDist2)
            {
                return 1;
            }
            if (squaredDist1 < squaredDist2)
            {
                return -1;
            }
            return 0;
        }
    }
}
