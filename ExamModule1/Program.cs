using System;
using System.Collections.Generic;

namespace ExamModule1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chiedo inserimento di un numero da 1 a 10
            Console.WriteLine("Inserisci un numero da 1 a 10");

            //Controllo se il numero inserito è tra 1 e 10
            var Prodotto = FunzioniControllo.LeggiNumeroInteroDaConsole(1, 10);

            List<Product> rubrica = new List<Product>();


            //Itero per il numero  richiesto
            for (int index = 0; index < Prodotto; index++)
            {
                //Richiamo una funzione a cui passo la rubrica
                //e l'indice corrente e questa mi aggiunge il prodotto
                AggiungiProdottoARubricaInPosizione(rubrica);
            }

            //Itero la rubrica e stampo a video (con for) tutti i prodotti
            Product.StampaRubrica(rubrica);

        }

        private static void AggiungiProdottoARubricaInPosizione(List<Product> rubrica)
        {
            //Richiedo il nome e cognome della persona
            Console.Write("Codice Prodotto: ");
            var code = Console.ReadLine();
            Console.Write("Nome Prodotto: ");
            var name = Console.ReadLine();

            //Creo oggetto Person da inserire in rubrica
            Product ProdottoInfo = new Product
            {
                Code = code,
                Name = name
            };

            //Aggiungo persona a rubrica
            rubrica.Add(ProdottoInfo);
        }


    }
}
