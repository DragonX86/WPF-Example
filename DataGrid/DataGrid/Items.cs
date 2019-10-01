using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGrid
{
    class Items
    {
        public Items(int id, string family, int point)
        {
            Id = id;
            Family = family;
            Point = point;
        }

        public int Id { get; set; }
        public string Family { get; set; }
        public int Point { get; set; }
    }
}
