using ExamModule2.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamModule2.Entities
{
    /// <summary>
    /// Entità bibicletta
    /// </summary>
    public class Bicicletta : EntityBase
    {
        /// <summary>
        /// Numero Telaio della bicicletta
        /// </summary>
        public int NumeroTelaio { get; set; }

        /// <summary>
        /// Se la bicicletta è elettrica
        /// </summary>
        public bool IsElettrica { get; set; }
       
    }
}
