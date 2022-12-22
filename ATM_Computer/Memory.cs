using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Computer
{
    public class Memory
    {
        private byte _type;
        private string _capacity;
        private string _name;

        public Memory(byte type, string capacity, string name)
        {
            _type = type;
            _capacity = capacity;
            _name = name;
        }

        public string GetInformation() => String.Concat(_name + (TypeOfMemory)_type + _capacity);
    }
}
