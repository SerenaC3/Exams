using System;
using System.Collections.Generic;
using System.Text;

namespace ExamModule2.Entities.Abstract
{
    public abstract class EntityBase : IEntity
    {
        /// <summary>
        /// Id primario
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Marca dell'entità
        /// </summary>
        public string Marca { get; set; }


        /// <summary>
        /// Modello dell'entità
        /// </summary>
        public string Modello { get; set; }
        
    }
}
