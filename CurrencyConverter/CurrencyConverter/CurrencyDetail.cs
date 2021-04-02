using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public class CurrencyDetail
    {
        //191df415b7-f9a2494e96-qqxhve
        private string _currencyAbbrevation;
        private double _currencyRate;
        public string CurrencyAbbrevation
        {
            get
            {
                return _currencyAbbrevation;
            }
            set
            {
                _currencyAbbrevation = value;
            }
        }
       
        public double CurrencyRate
        {
            get
            {
                return _currencyRate;
            }
            set
            {
                _currencyRate = value;
            }
        }
    }
}
