using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAIZEN_Calculator
{
    internal class Buttons
    {
        public double nr1 { get; set; }
        public double nr2 { get; set; }
        public double nr3 { get; set; }
        public double nr4 { get; set; }
        public double nr5 { get; set; }
        public double nr6 { get; set; }
        public double nr7 { get; set; }
        public double nr8 { get; set; }
        public double nr9 { get; set; }
        public double nr0 { get; set; }

       public double num1 = 0;
       public double num2;
       public string option;
       public double result;

        public void Equal()
        { 

            if (option.Equals("+"))
                result = num1 + num2;

            if (option.Equals("-"))
                result = num1 - num2;

            if (option.Equals("*"))
                result = num1 * num2;

            if (option.Equals("/"))
                result = num1 / num2;

        }
    }
}
