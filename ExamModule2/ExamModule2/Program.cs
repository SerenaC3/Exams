using ExamModule2.Procedures;
using System;

namespace ExamModule2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Menu di selezione
            Console.WriteLine("**************************");
            Console.WriteLine("***********MENU***********");
            Console.WriteLine("**************************");
            Console.WriteLine("* A - Catalogo Biciclette");
            Console.WriteLine("* B - Catalogo Automobili");
            string selezione = Console.ReadLine();

            //Selezione dell'opzione
            switch (selezione)
            {
                case "A":
                    BiciclettaWorkflow.EseguiCreaModificaCancella();
                    break;
                case "B":
                    AutomobileWorkflow.EseguiCreaModificaCancella();
                    break;
                default:
                    Console.WriteLine("Opzione non valida, inserisci A o B!");
                    break;
            }

            
        }
    }
}
