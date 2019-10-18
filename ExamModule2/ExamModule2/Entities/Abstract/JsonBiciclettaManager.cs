using System;
using System.Collections.Generic;
using System.Text;

namespace ExamModule2.Entities.Abstract
{
    public class JsonBiciclettaManager : JsonManagerBase<Bicicletta>
    {
        protected override void RemapNuoviValoriSuEntityInLista(
           Bicicletta entitySorgente, Bicicletta entityDestinazione)
        {
            entityDestinazione.Marca = entitySorgente.Marca;
            entityDestinazione.Modello = entitySorgente.Modello;
            entityDestinazione.NumeroTelaio = entitySorgente.NumeroTelaio;
            entityDestinazione.IsElettrica = entitySorgente.IsElettrica;

        }
    }
}
