using ExamModule2.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamModule2.Managers
{
    /// <summary>
    /// Interfaccia per tutti gli oggetti che si occupano
    /// di fare CRUD su uno specifico sistema di storage
    /// /(es. filesystem, database SQL, file xml, ecc)
    /// </summary>
    /// <typeparam name="TEntity">Tipo di entità trattata</typeparam>
    public interface IManager<TEntity>
        where TEntity : class, IEntity
    {
        /// <summary>
        /// Crea l'entità passata sullo storage
        /// </summary>
        /// <param name="entityDaCreare">Entità da creare</param>
        void Crea(TEntity entityDaCreare);

        /// <summary>
        /// Aggiorna l'entità passata nello storage
        /// </summary>
        /// <param name="entityDaModificare">Entità da aggiornare</param>
        void Aggiorna(TEntity entityDaModificare);


        /// <summary>
        /// Carica tutte le entità nello storage
        /// </summary>
        /// <returns>Ritorna la lista di entità presenti</returns>
        IList<TEntity> Carica();
    }
}
