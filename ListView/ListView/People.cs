using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListView
{
    class People
    {
        public People(string family, int point)
        {
            Family = family;
            Point = point;
        }

        public string Family { get; set; }         
        public int Point  { get; set; }
    }
}
