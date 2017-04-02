using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3_3
{
    public class txt
    {
        string name; //название товара

        public string Txt
        {
            get { return name; }
            set { name = value; }
        }

        public txt()
        {
            Txt = "unknown";
        }

        public override string ToString()
        {
            return Txt;

        }
    }
}
