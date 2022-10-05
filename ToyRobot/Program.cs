using System;
using System.Threading.Tasks;

namespace ToyRobot
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Welcome to Toy Robot");
            Console.WriteLine("Available action: \nPLACE X,Y,F  \nMOVE \nLEFT \nRIGHT \nREPORT \n");
            Console.WriteLine("Enter your command now(type 'exit' to close the app):");

            var arena = new Arena(5, 5);
            arena.AddRobot();
            string action;
            do
            {
                action = Console.ReadLine();
                try
                {
                    var result = await arena.TakeSigleActionAsync(action);
                    if (!string.IsNullOrEmpty(result))
                    {
                        Console.WriteLine(result);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            } while (action.ToLower() != "exit");
        }
    }
}
