using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLEUE1
{
    class Data : ICloneable
    {
        public List<double> Attributes = new List<double>();
        public int Quality { get; set; }

        public object Clone()
        {
            Data data = new Data();
            for (int i = 0; i < Attributes.Count; i++)
            {
                data.Attributes.Add(Attributes[i]);
            }
            data.Quality = Quality;
            return data;
        }

        public override string ToString()
        {
            string baseString = "Data: ";
            for (int i = 0; i < Attributes.Count; i++)
            {
                baseString += "Attribute " + i + " :" + Attributes[i]+"\n";
            }

            baseString += "Quality: " + Quality;
            return baseString;
        }
    }
}
