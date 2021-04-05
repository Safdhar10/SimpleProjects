using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Generator
{
    class RandomGenerator
    {
        Random r = new Random();
        private char RadomLowerCaseChar()
        {
            return Convert.ToChar(r.Next(97, 122));
        }
        private char RandomUpperCaseChar()
        {
            return Convert.ToChar(r.Next(65, 90));
        }
        private int RandomInt()
        {
            return r.Next(1, 9);
        }
        private char RandomSymbol()
        {
            return Convert.ToChar(r.Next(33, 47));
        }
        public string RandomPasswordGenerator(int TotalLength,int NumberCount,int LetterCount,int UpperCaseCount,int SymbolCount)
        {
            string[] PasswordArray = new string[TotalLength];
            StringBuilder Password = new StringBuilder();
            for(int i=0;i<TotalLength;i++)
            {
                if(LetterCount>0)
                {
                    // PasswordArray[i] = RandomInt().ToString();
                    Password.Append(RadomLowerCaseChar().ToString());
                    LetterCount--;
                }
                else if(UpperCaseCount>0)
                {
                    //PasswordArray[i] = RadomLowerCaseChar().ToString(); 
                    Password.Append(RandomUpperCaseChar().ToString());
                    UpperCaseCount--;
                }
                else if(NumberCount>0)
                {
                    //PasswordArray[i] = RandomInt().ToString();
                    Password.Append(RandomInt().ToString());
                    NumberCount--;
                }
                else
                {
                    //PasswordArray[i] = RandomSymbol().ToString();
                    Password.Append(RandomSymbol().ToString());
                    SymbolCount--;
                }
            }

            for (int i = 0; i < Password.Length - 1; i++)
            {
                int j = r.Next(i, TotalLength);
                char temp = Password[i];
                Password[i] = Password[j];
                Password[j] = temp;
            }
            return Password.ToString();
        }
    }
}
