using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyExercises.Models
{
    public class Dice
    {
        public int value { get; private set; }

        public Dice() // konstruktor utan parametrar. Default
        {

        }

        public Dice(int Value) // konstruktor med parametrar för att kunna ange värden till specifierade parameter.
        {
            this.value = Value;
            // Säger att man är helt 100% att denna är klassens värde/variabel/data set. För att undvika variabler med samma namn utanför
            //  kanske också från variabler som finns någon annan stans i klassen. - Med denna kan vi nu instansiera klassen och ange en värde som argument.
        }

        public void Roll()
        {
            int newRadomValue = Random.Shared.Next(1, 7);
            value = newRadomValue;
        }
    }
}
