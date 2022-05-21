using System;
using System.Collections.Generic;
using System.Text;

namespace LookAndSay
{
    class LookAndSay
    {
        int number;

        public LookAndSay(int number)
        {
            this.number = number;
        }

        public int ConvertToLookAndSay()
        {
            string stringNr = number.ToString();
            StringBuilder result = new StringBuilder();

            char currentDigit = '0';
            char previousDigit = '0';
            int digitAmount = 0;
            for (int i = 0; i < stringNr.Length; i++)
            {
                if(digitAmount == 0)
                {
                    currentDigit = stringNr[i];
                    digitAmount++;
                }
                else
                {
                    if (currentDigit.Equals(stringNr[i]))
                    {
                        digitAmount++;
                    }
                    else
                    {
                        result.Append(digitAmount);
                        result.Append(stringNr[i - 1]);

                        digitAmount = 0;
                        i--;
                    }
                }
            }

            result.Append(digitAmount);
            result.Append(currentDigit);

            return int.Parse(result.ToString());
        }

        public int ConvertToNumber()
        {
            if (number.ToString().Length % 2 != 0)
            {
                throw new Exception("To convert to the number it reflects it must have an even number of digits!");
            }

            string stringNr = number.ToString();
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < stringNr.Length; i = i + 2)
            {
                int amount = int.Parse(stringNr[i].ToString());
                for (int j = 0; j < amount; j++)
                {
                    result.Append(stringNr[i+1]);
                }
            }

            return int.Parse(result.ToString());
        }
    }
}
