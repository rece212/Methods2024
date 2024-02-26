using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMethods
{
     class Class1
    {
        public string Results(int Value1,int value2, int value3, int value4)
        {
            int Value = (Value1 + value2 + value3 + value4) / 4;
            String strOutput = "Your result is " + Value + " meaning : ";
            if (Value <= 48)
            {
                strOutput += "Failed";
            }
            else if (Value == 49)
            {
                strOutput += "Passed (condoned)";
            }
            else if (Value >= 50 && Value <= 73)
            {
                strOutput += "Passed";
            }
            else if (Value == 74)
            {
                strOutput += "Distinction (condoned)";
            }
            else if ((Value >= 75))
            {
                strOutput += "Distinction";
            }

            return strOutput;
        }
        public string Results(int Value)
        {
            String strOutput = "Your result is " + Value + " meaning : ";
            if (Value <= 48)
            {
                strOutput += "Failed";
            }
            else if (Value == 49)
            {
                strOutput += "Passed (condoned)";
            }
            else if (Value >= 50 && Value <= 73)
            {
                strOutput += "Passed";
            }
            else if (Value == 74)
            {
                strOutput += "Distinction (condoned)";
            }
            else if ((Value >= 75))
            {
                strOutput += "Distinction";
            }

            return strOutput;
        }
    }
}
