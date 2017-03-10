using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLEUE1
{
    class Wine : Data
    {
        public double FixedAcidity { get { return Attributes[0]; } set { Attributes[0] = value; } }
        public double VolatileAcidity { get { return Attributes[1]; } set { Attributes[1] = value; } }
        public double CitricAcid { get { return Attributes[2]; } set { Attributes[2] = value; } }
        public double ResidualSugar { get { return Attributes[3]; } set { Attributes[3] = value; } }
        public double Chlorides { get { return Attributes[4]; } set { Attributes[4] = value; } }
        public double FreeSulfurDioxide { get { return Attributes[5]; } set { Attributes[5] = value; } }
        public double TotalSulfurDioxide { get { return Attributes[6]; } set { Attributes[6] = value; } }
        public double Density { get { return Attributes[7]; } set { Attributes[7] = value; } }
        public double PH { get { return Attributes[8]; } set { Attributes[8] = value; } }
        public double Sulphates { get { return Attributes[9]; } set { Attributes[9] = value; } }
        public double Alcohol { get { return Attributes[10]; } set { Attributes[10] = value; } }
    }
}
