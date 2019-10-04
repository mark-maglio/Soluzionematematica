using System;

namespace ClassLibrary1
{
    public class Operazioni
    {
        public static int Somma(int a, int b)
        {
            int s = a + b;
            return s;
        }
        public static int Sottrazione(int a, int b)
        {
            int s = a - b;
            return s;
        }
        public static int Moltiplicazione(int a, int b)
        {
            int m = a * b;
            return m;
        }
        public static double Divisione(double n1, double n2)
        {
            if (n2 == 0)
            {
                throw new Exception("N2 = 0");
            }
            double d = n1 / n2;
            return d;
        }
        public static int Min(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            else return b;
        }
        public static int Max(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else return b;
        }
        public static int Pot(int n1, int n2)
        {
            int p = 1 ;
            int contatore = 0;
            do
            {
                p = p * n1;
                contatore++;
            } while (contatore < n2);
            return p;
        }
    }
}
