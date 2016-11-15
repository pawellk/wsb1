using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalkulator
{
    
    public class liczenie
    {
        
        public double a = 0;
        
        public double b = 0;
        
        public char działanie;
        
        public double licz()
        {
            if (działanie == '+')
                return a + b;
            if (działanie == '-')
                return a - b;
            if (działanie == '*')
                return a * b;
            if (działanie == '/')
                return a / b;

            else
                return 0;
        }
    }
}
