﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExamModule1
{
    class FunzioniControllo
    {
        public static int LeggiNumeroInteroDaConsole(int minValue, int maxValue)
        {
            //Leggo il valore stringa da console
            string valoreString;
            int valoreIntero = 0;

            //Predisposizione al fallimento
            bool isInteger = false;
            bool isInRange = false;

            do
            {
                try
                {
                    //Eseguo la lettura del valore da console
                  
                    valoreString = Console.ReadLine();

                    //Validazione e parsing del valore
                    valoreIntero = int.Parse(valoreString);
                    isInteger = true;

                    //Verifico se è nel range
                    if (valoreIntero >= minValue && valoreIntero <= maxValue)
                    {
                        //imposto il flag IsInRange
                        isInRange = true;
                    }
                    else
                    {
                        //Messaggio di errore
                        Console.WriteLine("Attenzione! Il valore immesso non è nel range indicato");

                        //Ripristino condizioni di predisposizione fallimento iniziali
                        valoreIntero = 0;
                        isInteger = false;
                        isInRange = false;
                    }
                }
                catch (Exception exc)
                {
                    //Messaggio di errore
                    Console.WriteLine("Attenzione! Il valore immesso non è un numero!");

                    //Ripristino condizioni di predisposizione fallimento iniziali
                    valoreIntero = 0;
                    isInteger = false;
                    isInRange = false;
                }
            }
            while (isInteger == false || isInRange == false);

            //Ritorno il valore intero
            return valoreIntero;
        }

    }
}
