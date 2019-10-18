using ExamModule2.Entities;
using ExamModule2.Entities.Abstract;
using ExamModule2.Managers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamModule2.Procedures
{
    public class BiciclettaWorkflow
    {
        public static void EseguiCreaModificaCancella()
        {
            //Istanzio il manager delle automobili
            Console.WriteLine();
            Console.WriteLine("ESECUZIONE DEL WORKFLOW BICICLETTA...");
            Console.WriteLine();
            //TxtFileLibroManager manager = new TxtFileLibroManager();
            IManager<Bicicletta> manager = new JsonBiciclettaManager();

            //Visualizzazione contenuto database
            Console.WriteLine("Lettura del database...");
            var bicicletteInArchivio = manager.Carica();
            Console.WriteLine($"Trovate {bicicletteInArchivio.Count} biciclette in archivio");
            foreach (var currentBicicletta in bicicletteInArchivio)
                Console.WriteLine($"Lettura: {currentBicicletta.Marca}, {currentBicicletta.Modello}, " +
                    $"{currentBicicletta.NumeroTelaio}, {currentBicicletta.IsElettrica} (ID:{currentBicicletta.Id})");
            Console.WriteLine("");

            //Creazione di un nuova bicicletta => "C" di CRUD
            Console.WriteLine("Creazione di una nuova bicicletta...");
            var nuovaBicicletta = new Bicicletta
            {
                Marca = "Legnano",
                Modello = "Corsa",
                NumeroTelaio = 12,
                IsElettrica = true
            };
            manager.Crea(nuovaBicicletta);
            Console.WriteLine("La nuova bicicletta dovrebbe essere stata creata su disco!");
            Console.WriteLine();

            //Creazione di un nuova bicicletta => "C" di CRUD
            Console.WriteLine("Creazione di un'altra bicicletta...");
            var nuovaBicicletta2 = new Bicicletta
            {
                Marca = "Abici",
                Modello = "Giorno",
                NumeroTelaio = 10,
                IsElettrica = false

            };
            manager.Crea(nuovaBicicletta2);
            Console.WriteLine("La nuova bicicletta dovrebbe essere stata creata su disco!");
            Console.WriteLine();

            //Leggiamo i libri dal disco => "R" di CRUD
            Console.WriteLine("Lettura del database...");
            bicicletteInArchivio = manager.Carica();
            Console.WriteLine($"Trovati {bicicletteInArchivio.Count} biciclette in archivio");
            foreach (var currentBicicletta in bicicletteInArchivio)
                Console.WriteLine($"Lettura: {currentBicicletta.Marca}, {currentBicicletta.Modello}, " +
                    $"{currentBicicletta.NumeroTelaio}, {currentBicicletta.IsElettrica} (ID:{currentBicicletta.Id})");
            Console.WriteLine("");
           

            //Cerchiamo un libro con "esempio" nel titolo
            //Console.WriteLine("Caricamento dei soli libri con 'esempio' nel titolo...");
            //libriInArchivio = manager.Carica("esempio");
            //Console.WriteLine($"Trovati {libriInArchivio.Count} libri in archivio con 'esempio'...");
            //foreach (var currentLibro in libriInArchivio)
            //    Console.WriteLine($"Lettura: {currentLibro.Titolo} (ID:{currentLibro.Id})");
            //Console.WriteLine("");

        }
    }
}
