namespace ConsoleApp1
{
    class VoixCalc
    {
        static void Main()
        {
            //double amount = 1.11; //количество биткоинов от одного человека
            //int peopleCount = 60; // количество человек
            //int totalMoney = (int)amount * peopleCount; // ← исправьте ошибку в этой строке
            //Console.WriteLine(totalMoney);
            Console.WriteLine("VoixCalc 1.0.0 by VOIX\n\nHello, please enter your first number here: ");
            double a = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Please enter your second number here: ");
            double b = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Please enter a desirable arithmetic operation (+, -, *, /): ");
            string user_input = Console.ReadLine();


            switch (user_input)
            {
                case "+":
                    Console.WriteLine("Result is: " + (a + b));
                    break;
                case "-":
                    Console.WriteLine("Result is: " + (a - b));
                    break;
                case "*":
                    Console.WriteLine("Result is: " + (a * b));
                    break;
                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("Error 1: You cannot divine by zero.\nExiting...");
                    }
                    else
                    {
                        Console.WriteLine("Result is " + (a / b));
                    }
                    break;
                default:
                    Console.WriteLine("Error 2: Unrecognized symbol.");
                    break;

            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

            

        }
    }
}

