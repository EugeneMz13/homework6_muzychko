using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_6
{
    public class Minivan: Car
    {
        public override int GetNumberOfSeats()
        {
            return 10;
        }

        public new int GetYear()
        {
            return base.GetYear()+1;
        }


    }
}
