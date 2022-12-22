using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Computer
{
    class Computer
    {
        private decimal _price;
        private string _modelName;
        private RAM _ram;
        private HDD _hdd;

        public Computer(decimal price, string modelName) : this(price, modelName, null, null) 
        {
        }
        public Computer(decimal price, string modelName, RAM ram, HDD hdd)
        {
            _price = price;
            _modelName = modelName;
            this._ram = ram;
            this._hdd = hdd;
        }
        public string GetInformation()
        {
            if (_ram != null && _hdd != null)
            {
                return String.Concat(_price + _modelName + _hdd.GetInformation() + _ram.GetInformation());
            }
            else return String.Concat(_price + _modelName);
        }


    }
}
