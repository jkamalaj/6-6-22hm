using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string option;
            do
            {
                Console.WriteLine("1.Product elave et");
                Console.WriteLine("2.Product sat");
                Console.WriteLine("3.Productlara bax");
                Console.WriteLine("4.Menudan cix");

                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.WriteLine("Product elave etmek emeliyyat");
                        break;
                    case "2":
                        Console.WriteLine("Product satmaq emeliyyat");
                        break;
                    case "3":
                        Console.WriteLine("Productlara baxmaq emeliyyat");
                            break;
                    default:
                        Console.WriteLine("duzgun secin");
                        break;
                }

            } while (true);
        }
    }
}
