namespace VoixCalc
{
    class VoixCalc
    {
        static void Main()
        {
            Console.WriteLine("VoixCalc 1.0.0 by Aruchomu\n\nHello, please enter your first number here: ");
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
                        Console.WriteLine("Error 1: You cannot divine by zero.\nFinishing...");
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

