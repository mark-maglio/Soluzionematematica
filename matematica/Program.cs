using ClassLibrary1;
using System;

namespace matematica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci un numero");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("inserisci un'altro numero");
            int n2 = int.Parse(Console.ReadLine());
            try
            {
                double risultato = double.NaN;
                Console.WriteLine("che operazione vuoi ?(s/m/d/a/min/max/pot)");
                string risposta = Console.ReadLine();
                if (risposta == "s")
                {
                    risultato = Operazioni.Sottrazione(n1, n2);
                }
                else if (risposta == "m")
                {
                    risultato = Operazioni.Moltiplicazione(n1, n2);
                }
                if (risposta == "d")
                {
                    risultato = Operazioni.Divisione(n1, n2);
                }
                else if (risposta == "a")
                {
                    risultato = Operazioni.Somma(n1, n2);
                }
                if (risposta == "min")
                {
                    risultato = Operazioni.Min(n1, n2);
                }
                if (risposta == "max")
                {
                    risultato = Operazioni.Max(n1, n2);
                }
                if (risposta == "pot")
                {
                    risultato = Operazioni.Pot(n1, n2);
                }
                Console.WriteLine($"{risultato}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.ReadLine();
        }
    }
}