using System;
using System.Collections.Generic;
using System.Text;

namespace RobotApp.Commands.Factories
{
    public class LeftCommandFactory : CommandFactory
    {
        public override ICommand Create(string[] args) => new LeftCommand(args);
    }
}
