using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyExercises.Models
{
    public class DiceHand
    {
        // vi gör private så att spelaren ska inte kunna ha access till denne utanför
        private Dice[] dices { get; set; } = []; // Creating a array that we can give (get;set) a value of number of dices inside.
        // The last " = [];" is to make it nullable without it creating problems.

        public DiceHand(int amountOfDices) // constructor that allow us to specify the amount of dices in the hand.
        {
            dices = new Dice[amountOfDices];

            for (int i = 0; i < dices.Length; i++)
            {
                dices[i] = new(); // Här skapas tärningar (instanser av Dice i  arrayen dices) längs värdet i "i". 
            }
        }

        public void ShowAllDices()
        {
            int index = 0;
            foreach (var item in dices)
            {
                ++index;
                Console.WriteLine($"Tärning {index} har värdet: {item.value}");
            }
        }

        public void RollAll()
        {
            foreach (var item in dices)
            {
                item.Roll();
            }
            ShowAllDices();
        }
    }
}
