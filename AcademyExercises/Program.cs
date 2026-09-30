using AcademyExercises.Models;

namespace AcademyExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
/*            while (true)
            {
                DiceHand hand = new DiceHand(5);

                Console.WriteLine($"The dices in hand are {hand}");
                Console.WriteLine($"Press any key to give it another try.");
                Console.ReadKey();
            }

            DiceHand hand = new DiceHand(10);
            hand.RollAll();

            Console.WriteLine($"Jag är spelberoende.");*/
            int returnValue = 0;
            while (true)
            {
                Console.Write("Hur stor tärnningshand vill du ha?: ");
                string? readInput = Console.ReadLine();
                bool successfullParse = int.TryParse(readInput, out returnValue);
                if (successfullParse)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Du skrev inte ett giltligt värde.");
                }

            }
            DiceHand hand = new DiceHand(returnValue);
            hand.RollAll();
        }
    }
}
