using ExamModule2.Managers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace ExamModule2.Entities.Abstract
{
    public abstract class JsonManagerBase<TEntity> : IManager<TEntity>
         where TEntity : class, IEntity
    {
        public void Aggiorna(TEntity entityDaModificare)
        {
            //Validazione dell'input
            if (entityDaModificare == null)
                throw new ArgumentNullException(nameof(entityDaModificare));

            //Se non ho "Id" eccezione
            if (entityDaModificare.Id <= 0)
                throw new InvalidOperationException("Attenzione! L'oggetto " +
                    $"non ha il campo 'Id' valorizzato! Prima crearlo!");

            //Carico tutti in memoria
            IList<TEntity> tuttiIDati = Carica();

            //Arrivato qui abbiamo la lista dati perfettamente aggiornata
            Salva(tuttiIDati);
        }

        protected abstract void RemapNuoviValoriSuEntityInLista(TEntity targetEntity, TEntity sourceEntity);


        public IList<TEntity> Carica()
        {
            //1) Percorso del file che contiene il json
            string basePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "jsons");
            var path = Path.Combine(basePath, $"{typeof(TEntity).Name}.json");

            //Se il file non esiste, ritorno lista vuota
            if (!File.Exists(path))
                return new List<TEntity>();

            //2) Lettura di tutto il file e non delle singole righe
            string json = File.ReadAllText(path);

            //3) De-serializzazione della stringa in oggetti strutturati
            List<TEntity> dati = JsonConvert.DeserializeObject<List<TEntity>>(json);
            return dati;
        }

        public void Crea(TEntity entityDaCreare)
        {
            // Validazione dell'input
            if (entityDaCreare == null)
                throw new ArgumentNullException(nameof(entityDaCreare));

            //Se ho già un "Id", eccezione
            if (entityDaCreare.Id > 0)
                throw new InvalidOperationException("Attenzione! L'oggetto " +
                    $"ha già il campo 'Id' impostato al valore {entityDaCreare.Id}!");

            //Contiamo quanti record ci sono nel database esistente
            //(ci serve per sapere quale "Id" dare al nuovo elemento
            //=> Carico tutti gli elementi in archivio
            IList<TEntity> tutti = Carica();
            var count = tutti.Count;

            //Prossimo "Id" => count + 1
            var prossimoId = count + 1;

            //Assegnazione Id al nuovo elemento
            entityDaCreare.Id = prossimoId;

            // Aggiungo nuovo elemento a lista esistente
            tutti.Add(entityDaCreare);

            //Salva tutta la lista insieme
            Salva(tutti);
        }

        private void Salva(IList<TEntity> allData)
        {
            //Validazione input
            if (allData == null)
                throw new ArgumentNullException(nameof(allData));

            //1) Percorso del file che contiene il json
            string basePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "jsons");
            var path = Path.Combine(basePath, $"{typeof(TEntity).Name}.json");

            if (!Directory.Exists(basePath))
                Directory.CreateDirectory(basePath);

            //Serializzazione della lista in JSON
            string json = JsonConvert.SerializeObject(allData, Newtonsoft.Json.Formatting.Indented);

            //Scrivo tutto il json nel file target
            File.WriteAllText(path, json);
        }

       
    }
}
