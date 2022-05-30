using System;

namespace calculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Podaj pierwsza liczbę:");


                var a = GetInput(); 

                Console.WriteLine("Jaka operację chcesz wykonać?");
                var action = Console.ReadLine();

                Console.WriteLine("Podaj drugą liczbę:");

                var b = GetInput();

                var result = Calculate(a, b, action);

                Console.WriteLine("Wynik twoejgo działania to: " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
                    
        }

        private static int GetInput()
        {
            if (!int.TryParse(Console.ReadLine(), out int input))
            {
                throw new Exception("Podana wartość jest nieprawidłowa!");
            }
            return input;
        }
        private static int Calculate(int a, int b, string action)
        {
            switch (action)
            {
                case "+":
                    return a + b;
                    break;
                case "-":
                    return a - b;
                    break;
                case "*":
                    return a * b;
                    break;
                case "/":
                    return a / b;
                    break;
                default:
                    throw new Exception("Wybrałeś złą operację");
            }
        }

    }
}
