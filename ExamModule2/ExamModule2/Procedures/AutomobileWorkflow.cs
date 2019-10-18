using ExamModule2.Entities;
using ExamModule2.Entities.Abstract;
using ExamModule2.Managers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamModule2.Procedures
{
    public class AutomobileWorkflow
    {
        public static void EseguiCreaModificaCancella()
        {
            //Istanzio il manager delle automobili
            Console.WriteLine();
            Console.WriteLine("ESECUZIONE DEL WORKFLOW AUTOMOBILE...");
            Console.WriteLine();
            //TxtFileLibroManager manager = new TxtFileLibroManager();
            IManager<Automobile> manager = new JsonAutomobileManager();

            //Visualizzazione contenuto database
            Console.WriteLine("Lettura del database...");
            var automobiliInArchivio = manager.Carica();
            Console.WriteLine($"Trovate {automobiliInArchivio.Count} automobili in archivio");
            foreach (var currentAutomobile in automobiliInArchivio)
                Console.WriteLine($"Lettura: {currentAutomobile.Marca}, {currentAutomobile.Modello}," +
                    $" {currentAutomobile.NumeroCavalli}, {currentAutomobile.IsDiesel}," +
                    $" {currentAutomobile.DataImmatricolazione} (ID:{currentAutomobile.Id})");
            Console.WriteLine("");

            //Creazione di un nuova automobile => "C" di CRUD
            Console.WriteLine("Creazione di una nuova automobile...");
            Random randomGenerator = new Random();
            var nuovaAutomobile = new Automobile
            {
                Marca = "Seat",
                Modello = "Leon",
                NumeroCavalli = 1200,
                IsDiesel = true,
                DataImmatricolazione = DateTime.Now,
            };
            manager.Crea(nuovaAutomobile);
            Console.WriteLine("La nuova automobile dovrebbe essere stata creata su disco!");
            Console.WriteLine();

            //Creazione di un nuova automobile => "C" di CRUD
            Console.WriteLine("Creazione di un'altra automobile...");
            var nuovaAutomobile2 = new Automobile
            {
                Marca = "Lancia",
                Modello = "Ypsilon",
                NumeroCavalli = 1000,
                IsDiesel = false,
                DataImmatricolazione = DateTime.Now,

            };
            manager.Crea(nuovaAutomobile2);
            Console.WriteLine("La nuova automobile dovrebbe essere stata creata su disco!");
            Console.WriteLine();

            //Leggiamo i libri dal disco => "R" di CRUD
            Console.WriteLine("Lettura del database...");
            automobiliInArchivio = manager.Carica();
            Console.WriteLine($"Trovati {automobiliInArchivio.Count} automobili in archivio");
            foreach (var currentAutomobile in automobiliInArchivio)
                Console.WriteLine($"Lettura: {currentAutomobile.Marca}, {currentAutomobile.Modello}," +
                    $" {currentAutomobile.NumeroCavalli}, {currentAutomobile.IsDiesel}," +
                    $" {currentAutomobile.DataImmatricolazione} (ID:{currentAutomobile.Id})");
            Console.WriteLine("");
            Console.WriteLine("");



            //Cerchiamo un'automobile in base al modello
            Console.WriteLine("Scrivi il modello di automobile che stai cercando: ");
            string ModelloDaCercare = Console.ReadLine();
            Console.WriteLine($"Caricamento delle automobili del modello: {ModelloDaCercare}");
            automobiliInArchivio = manager.Carica();
            Console.WriteLine($"Trovati {automobiliInArchivio.Count} automobili in archivio con 'esempio'...");
            foreach (var currentAutomobile in automobiliInArchivio)
                Console.WriteLine($"Lettura: {currentAutomobile.Marca}, {currentAutomobile.NumeroCavalli} (ID:{currentAutomobile.Id})");
            Console.WriteLine("");

        }

        //public IList<Automobile> Carica(string testoDaCercareNelTitolo)
        //{
            //Uso il metodo base per ottenere tutti i libri
           // IList<Automobile> tutteLeAutomobili = Carica();
            //IList<Automobile> automobiliCorrispondentiAlCriterioDiRicerca = new List<Automobile>();

            //Scorro tutti i libri
           // foreach (Automobile currentAutomobile in tutteLeAutomobili)
            //{
                //Se il libro corrente contiene nel Titolo il 
                //testo specificato, aggiungo il libro "libriCorrispondentiAlCriterioDiRicerca"

                //Recupero l'indice del testo ricercato nel titolo
                //var indiceTesto = currentAutomobile.Modello.IndexOf(testoDaCercareNelTitolo);

                //Se l'indice è >= 0
                //if (indiceTesto < 0)
                 //   continue;

                //Aggiungo l'elemento in uscita
                //automobiliCorrispondentiAlCriterioDiRicerca.Add(currentAutomobile);
           // }

            //Ritorno la lista di quelli corrispondenti
            //return automobiliCorrispondentiAlCriterioDiRicerca;
        //}

    }
}
