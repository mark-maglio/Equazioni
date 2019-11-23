using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    class Equazioni
    {
        public static bool Determinata(double a, double b)
        {
            if ( a != b && b!=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool InDeterminata(double a, double b)
        {
            if (a == b && a != b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsIncosisted(double a, double b)
        {
            if (a == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsDegree2(double a)
        {
            if (a != 0)
            {
                return true;
            }
            else
                return false;
        }
        public static double Delta(double a, double b, double c)
        {
            return (b * b) - 4 * a * c;

        }
        public static string EquationDegree1(double a, double b)
        {
            if (a == 0 || b == 0)
            {
                return "Indeterminato";
            }
            if (a != 0 || b == 0)
            {
                return "Impossibile";
            }
            double risultato = -b / a;

            return risultato.ToString();
        }
    }
}