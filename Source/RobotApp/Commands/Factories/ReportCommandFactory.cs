using System;
using System.Collections.Generic;
using System.Text;

namespace RobotApp.Commands.Factories
{
    public class ReportCommandFactory : CommandFactory
    {
        public override ICommand Create(string[] args) => new ReportCommand(args);
    }
}
