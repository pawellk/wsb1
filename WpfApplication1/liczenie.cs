using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalkulator
{
    /// <summary>
    /// Ta klasa odpowiada za same operacje liczenia, nie zawiera GUI.
    /// </summary>
    public class liczenie
    {
        /// <summary>
        /// Liczby a i b to dwie liczby używane w każdym działaniu
        /// </summary>
        public double a = 0;
        /// <summary>
        /// Liczby a i b to dwie liczby używane w każdym działaniu
        /// </summary>
        public double b = 0;
        /// <summary>
        /// przechowuje znak działania np. + to suma a * to iloczyn
        /// </summary>
        public char działanie;
        /// <summary>
        /// metoda odpowiadająca za właściwe liczenie
        /// </summary>
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
