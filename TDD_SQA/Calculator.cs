using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_SQA
{
    internal class Calculator
    {
        public Calculator() 
        {
            
        }

        public int add(int integer1, int integer2)
        {
            int summ = integer1 + integer2;
            return summ;
        }

        public double add(double float1, double float2)
        {
            double summ = float1 + float2;
            return summ;
        }

        public string add(string s1, string s2)
        {
            string summ = s1 + s2;
            return summ;
        }

        public int substract(int integer1, int integer2)
        {
            int ans = integer1 - integer2;
            return ans;
        }

        public int multiply(int integer1, int integer2)
        {
            int prod = integer1 * integer2;
            return prod;
        }

        public double divide(int integer1, int integer2)
        {
            double divide = integer1 / Convert.ToDouble(integer2); 
            return divide;
        }




    }
}
