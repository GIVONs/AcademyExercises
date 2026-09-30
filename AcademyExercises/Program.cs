namespace AcademyExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // I want a bakcpack (list), where I can store 1 object, in total 4 objects are inside, (banana, book, key, UserObject). 
            //  I want to be able to select one to be showcased (printed), Its all in a loop that wont close until i select that option

            List<string> Backpack = new List<string>();
            Backpack.Add("Banana");
            Backpack.Add("Book");
            Backpack.Add("Key");

            Console.WriteLine("""
                You're now looking inside of your backpack with 4 pockets and the forth is empty.
                What do you wish to do?:
                [1] - Look inside the first pocket?
                [2] - Look inside the second pocket?
                [3] - Look inside the third pocket?
                [4] - Store something inside the forth pocket?

                [5] - Show me all the contents.

                [6] - Exit and close your backpack?

                Tell me your option number: 
                """);

            bool LookingInBackpack = true;
            while (LookingInBackpack != false)
            {
                int mainOptions = 0;
                while (mainOptions != 6)
                {
                    mainOptions = Convert.ToInt16(Console.ReadLine());
                    if (mainOptions == 1)
                    {
                        Console.WriteLine($"There's a {Backpack[0]} in here!\n\nSelect another option between 1-6: ");
                    }
                    else if (mainOptions == 2)
                    {
                        Console.WriteLine($"There's a {Backpack[1]} in here!\n\nSelect another option between 1-6: ");

                    }
                    else if (mainOptions == 3)
                    {
                        Console.WriteLine($"There's a {Backpack[2]} in here!\n\nSelect another option between 1-6: ");

                    }
                    else if (mainOptions == 4)
                    {
                        // Yeah I'll maybe add a loop here to check if this thing is empty or not.
                        Console.WriteLine($"Yup it's empty. \n\nSo what do you want to store in here?\nAnswer here: ");
                        Backpack.Add(Console.ReadLine());
                        Console.WriteLine("\n\nSelect another option between 1-6: ");
                    }
                    else if (mainOptions == 5)
                    {
                        Console.WriteLine("Here are the contents.");
                        for (int i = 0; i < Backpack.Count; i++)
                        {
                            Console.WriteLine($"\nIn pocket {i + 1}: {Backpack[i]}");
                        }
                        Console.WriteLine("\nSelect another option between 1-6: ");

                    }
                    else if (mainOptions == 6)
                    {
                        LookingInBackpack = false;
                    }
                    else
                    {
                        Console.WriteLine("That's not a valid option, please choose another number between 1-6: ");
                    }
                }
            }
        }
    }
}
