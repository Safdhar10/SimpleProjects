using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_Calculator
{
    class Calculate
    {
        public double ConvertCurrencyFormat(string input)
        {
            double value;
            if (char.IsDigit(input[0]))
            {
                value = double.Parse(input);
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 2; i < input.Length; i++)
                {
                    if (char.IsDigit(input[i]))
                    {
                        sb.Append(input[i]);
                    }
                    else if(input[i]=='.')
                    {
                        sb.Append(input[i]);
                    }
                }
                value = double.Parse(sb.ToString());
            }
            return value;
        }
        public double CalculateEmi(double Principal,double Rate,int N)
        {
            double Emi;
            double rate = (Rate / 100) / 12;
            Emi = Principal * rate * ((Math.Pow((1+rate),N))/(Math.Pow((1+rate),N)-1));
            return Emi;
        }
        public double CalculateLoan(double Emi, double Rate, int N)
        {
            double Principal;
            double rate = (Rate / 100) / 12;
            Principal = Emi / (rate * ((Math.Pow((1 + rate), N)) / (Math.Pow((1 + rate), N) - 1)));
            return Principal;
        }
        public double CalculateInterest(double Principal, double emi, int N)
        {
            double _interest;
            double _totalPay = emi * N;
            _interest = (Math.Pow(_totalPay, (1 / N)) / Math.Pow(Principal, (1 / N))) - 1;
            return _interest;
        }
        public double CalculateTenure(double Principal, double Rate, double emi)
        {
            double _tenure;
            double rate = (Rate / 100) / 12;
            _tenure = Math.Log10(emi / (emi - Principal * rate)) / Math.Log10(1 + rate);
            return _tenure;
        }
    }
}
