using RobotApp.Commands;
using RobotApp.Commands.Factories;
using RobotApp.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RobotApp.Commands
{
    public class Command
    {
        private readonly Dictionary<string, CommandFactory> factories;

        private Command()
        {
            factories = new Dictionary<string, CommandFactory>
            {
                { "PLACE", new PlaceCommandFactory() },
                { "MOVE", new MoveCommandFactory() },
                { "LEFT", new LeftCommandFactory() },
                { "RIGHT", new RightCommandFactory() },
                { "REPORT", new ReportCommandFactory() }
            };
        }

        public static Command Initialize() => new Command();

        public ICommand CreateCommand(string input)
        {
            if (input == null)
            {
                throw new NullInputException();
            }

            var actionArgs = GetActionAndArguments(input);
            string action = actionArgs.Item1;
            string[] args = actionArgs.Item2;

            if (!this.factories.ContainsKey(action))
            {
                throw new InvalidCommandException();
            }

            return this.factories[action].Create(args);
        }

        private Tuple<string, string[]> GetActionAndArguments(string input)
        {
            string action = null;
            string[] args = null;

            var items = input.Split(' ').ToList();
            action = items[0];

            items.RemoveAt(0);
            args = items.Count > 0 ? items.ToArray() : null;

            return new Tuple<string, string[]>(action, args);
        }
    }
}
