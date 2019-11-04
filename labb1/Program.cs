using System;

namespace labb1
{
    class Program
    {
        public static Calculator calc = new Calculator();
        public static bool isPlaying = true;

        private static void PrintMenu()
        {
            Console.WriteLine("1. Add two numbers \n" +
                "2. Multiply two numbers \n" +
                "3. Sum the numbers between to numbers \n" +
                "4. Add number to memory \n" +
                "5. Clear memory \n" +
                "6. Print calculator contents \n" +
                "7. Quit");
        }

        public static void AskForNumbers()
        {
            Console.WriteLine("Enter first value");
            calc.FirstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second value");
            calc.SecondNumber = Convert.ToInt32(Console.ReadLine());

        }

        public static void GetUserInput()
        {
            var userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    AskForNumbers();
                    var summedValue = calc.SumNumbers();
                    Console.WriteLine("The sum is: " + summedValue + "\n");
                    break;
                case "2":
                    AskForNumbers();
                    var multipliedValue = calc.MultiplyNumbers();
                    Console.WriteLine("The sum multiplied is: " + multipliedValue + "\n");
                    break;
                case "3":
                    AskForNumbers();
                    var sumBetween = calc.SumInBetween();
                    Console.WriteLine("The sum between the numbers is: " + sumBetween + "\n");
                    break;
                case "4":
                    Console.WriteLine("Enter number to save: ");
                    calc.NumberInMemory = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Number successfully added to memory \n");
                    break;
                case "5":
                    calc.Init();
                    Console.WriteLine("Number in memory cleared \n");
                    break;
                case "6":
                    Console.WriteLine(calc + "\n");
                    break;
                case "7":
                    Console.WriteLine("Goodbye!");
                    isPlaying = false;
                    break;
                default:
                    break;  
            }
        }


        static void Main(string[] args)
        {
            while(isPlaying)
            {
                PrintMenu();
                GetUserInput();
            }
        }

    }

}
