using RobotApp.Commands;
using RobotApp.Domain.Exceptions;
using System;

namespace Robot
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHelp();

            while (true)
            {
                Console.Write("> ");
                string input = Console.ReadLine();

                try
                {
                    Command
                        .Initialize()
                        .CreateCommand(input)
                        .Execute();
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("The entered input is not in the correct format. Please try again.");
                }
                catch (InvalidCommandException)
                {
                    Console.WriteLine("Command not recognized. Note that command is case-sensitive. Please try again.");
                }
                catch (PositionOutOfBoundsException)
                {
                    Console.WriteLine("Position is outside of valid boundary.");
                }
                catch (NullInputException)
                {
                    Console.WriteLine("Received null input. If you are running this app within a docker container, please run in interactive mode.");
                    Environment.Exit(-1);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("The application has encountered an unexpected error. " + ex.ToString());
                    Environment.Exit(-1);
                }
            }
        }

        private static void PrintHelp()
        {
            Console.WriteLine("Commands:");
            Console.WriteLine("PLACE X,Y,F");
            Console.WriteLine("MOVE");
            Console.WriteLine("LEFT");
            Console.WriteLine("RIGHT");
            Console.WriteLine("REPORT");
        }
    }
}
