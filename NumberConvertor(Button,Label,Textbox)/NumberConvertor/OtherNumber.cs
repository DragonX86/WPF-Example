using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberConvertor
{
    class OtherNumber : SystemConverter
    {
        private string nondecimal;
        private int isdecimal;
        private int basis;

        public OtherNumber(int number, int basis)
        {
            nondecimal = fromDecimal(number, basis);
            this.basis = basis;
            this.isdecimal = number;
        }

        public string GetValue()
        {
            if (nondecimal != null)
            {
                return nondecimal;
            }
            else
            {
                return "";
            }
        }

        public int GetDecimal()
        {
            if (nondecimal != null)
            {
                return isdecimal;
            }
            else
            {
                return 0;
            }
        }
    }
}
