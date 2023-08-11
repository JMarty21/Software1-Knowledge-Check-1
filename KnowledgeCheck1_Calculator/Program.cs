using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//wow

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static Tuple<string?, string?> GetUserNumbers()
        {
            Console.WriteLine($"Enter 2 integers");
            var number1 = Console.ReadLine();
            var number2 = Console.ReadLine();

            return new Tuple<string?, string?> (number1, number2);
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var input = Console.ReadLine();
            var calculator = new Calculator();
            var result = GetUserNumbers();

            switch (input)
            {
                case "1":
                    if (int.TryParse(result.Item1, out int addNumOne) && int.TryParse(result.Item2, out int addNumTwo))
                    {
                        Console.Write($"{addNumOne} + {addNumTwo} = ");
                        Console.Write(calculator.Add(addNumOne, addNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "2":
                    if (int.TryParse(result.Item1, out int subNumOne) && int.TryParse(result.Item2, out int subNumTwo))
                    {
                        Console.Write($"{subNumOne} - {subNumTwo} = ");
                        Console.Write(calculator.Subtract(subNumOne, subNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "3":
                    if (int.TryParse(result.Item1, out int multiplyNumOne) && int.TryParse(result.Item2, out int multiplyNumTwo))
                    {
                        Console.Write($"{multiplyNumOne} * {multiplyNumTwo} = ");
                        Console.Write(calculator.Multiply(multiplyNumOne, multiplyNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "4":
                    if (double.TryParse(result.Item1, out double divNumOne) && double.TryParse(result.Item2, out double divNumTwo))
                    {
                        Console.Write($"{divNumOne} / {divNumTwo} = ");
                        Console.Write(calculator.Divide(divNumOne, divNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                default:
                    Console.WriteLine("Unknown input");
                    break;
            }
        }
    }
}