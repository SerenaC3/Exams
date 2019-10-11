using System;
using System.Collections.Generic;
using System.Text;

namespace ExamModule1
{
    public class Product
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public static void StampaRubrica(List<Product> rubrica)
        {
            Console.WriteLine("*** Visualizzazione contenuto rubrica***");
            for (var index = 0; index < rubrica.Count; index++)
            {
                Console.WriteLine($" => {rubrica[index].Code}, {rubrica[index].Name}");
                //Console.WriteLine(" => " + rubrica[index].Code + ", " + rubrica[index].Name);
            }
        }

    }
}
