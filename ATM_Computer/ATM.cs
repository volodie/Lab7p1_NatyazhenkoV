using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Computer
{
    public class ATM
    {
        private int _tenRubles;
        private int _twentyRubles;
        private int _fiftyRubles;
        private int _oneHudredRubles;

        public ATM(int ten, int twenty, int fifty, int oneHandred)
        {
            _tenRubles = ten;
            _twentyRubles = twenty;
            _fiftyRubles = fifty;
            _oneHudredRubles = oneHandred;
        }

        public void AddMoney(int amount, int denomination)
        {
            switch (denomination)
            {
                case 10:
                    _tenRubles += amount;
                    break;
                case 20:
                    _twentyRubles += amount;
                    break;
                case 50:
                    _fiftyRubles += amount;
                    break;
                case 100:
                    _oneHudredRubles += amount;
                    break;
            }
        }
        public void GetMoney(int amount, int denomination)
        {
            var result = amount / denomination;
            switch (denomination)
            {
                case 10:
                    _tenRubles -= amount;
                    Console.WriteLine("You will get {0} banknote(s) of {1} rubles ", result, denomination);
                    break;
                case 20:
                    _twentyRubles -= amount;
                    Console.WriteLine("You will get {0} banknote(s) of {1} rubles ", result, denomination);
                    break;
                case 50:
                    _fiftyRubles -= amount;
                    Console.WriteLine("You will get {0} banknote(s) of {1} rubles ", result, denomination);
                    break;
                case 100:
                    _oneHudredRubles -= amount;
                    Console.WriteLine("You will get {0} banknote(s) of {1} rubles ", result, denomination);
                    break;
            }
        }
    }
}
