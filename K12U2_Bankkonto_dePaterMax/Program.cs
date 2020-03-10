using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K12U2_Bankkonto_dePaterMax
{
    class Program
    {
        static void Main(string[] args)
        {
            IO konto1 = new Konto(5000);
            Console.WriteLine("Bank balance: "+konto1.kontostand);
            int iEingabe;
            bool stop = true;

            do
            {
                Console.WriteLine("deposit (1), pay out (2), close (0): ");
                iEingabe = Convert.ToInt32(Console.ReadLine());

                switch (iEingabe)
                {
                    case 0:
                        stop = false;
                        break;
                    case 1:
                        konto1.kontostand += Eingabe();
                        break;
                    case 2:
                        konto1.kontostand -= Eingabe();
                        break;
                    default:
                        Console.WriteLine("Eingabe ist falsch");
                        break;
                }
                Console.WriteLine("Bank balance: " + konto1.kontostand);
            }
            while (stop == true);
        }
        static double Eingabe()
        {
            Console.WriteLine("amount: ");
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}
