using System;
using System.Collections.Generic;
using System.Text;

namespace ExamModule2.Entities.Abstract
{
    public class JsonAutomobileManager : JsonManagerBase<Automobile>
    {
        protected override void RemapNuoviValoriSuEntityInLista(
           Automobile entitySorgente, Automobile entityDestinazione)
        {
            entityDestinazione.Marca = entitySorgente.Marca;
            entityDestinazione.Modello = entitySorgente.Modello;
            entityDestinazione.NumeroCavalli = entitySorgente.NumeroCavalli;
            entityDestinazione.IsDiesel = entitySorgente.IsDiesel;
            entityDestinazione.DataImmatricolazione = entitySorgente.DataImmatricolazione;
        }

    }

}
