using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Computer
{
    public class HDD : Memory
    {
        public HDD(byte type, string capacity, string name) : base(type, capacity, name) 
        {
        }
    }
}
