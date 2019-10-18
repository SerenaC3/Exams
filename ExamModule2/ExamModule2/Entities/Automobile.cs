using ExamModule2.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamModule2.Entities
{
    public class Automobile : EntityBase
    {
        /// <summary>
        /// Numero Cavalli dell'auto
        /// </summary>
        public int NumeroCavalli { get; set; }

        /// <summary>
        /// Se l'auto è diesel
        /// </summary>
        public bool IsDiesel { get; set; }

        /// <summary>
        /// Data di immatricolazione
        /// </summary>
        public DateTime DataImmatricolazione { get; set; }
    }
}
