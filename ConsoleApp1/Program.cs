using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("Podaj liczbę czarnuchu ");
                var number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Co robimy czarnuchu? ");
                var operation = Console.ReadLine();
                Console.WriteLine("Podaj 2 liczbę czarnuchu ");
                var number2 = int.Parse(Console.ReadLine());

                var result = 0;
                switch (operation)
                {

                    case "+":
                        result = number1 + number2;
                        break;
                    case "-":
                        result = number1 - number2;
                        break;

                    default:
                        throw new Exception("Nieprawidlowa operacja czarnuchu! ");
                        break;
                }
                Console.WriteLine("wynik to " + result + " Czarnuchu!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            

            

            
        }
    }
} 