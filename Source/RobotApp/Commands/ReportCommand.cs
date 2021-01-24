using Application;
using System;

namespace RobotApp.Commands
{
    public class ReportCommand : ICommand
    {
        public ReportCommand(string[] args)
        {

        }

        public void Execute()
        {
            var currentToy = Platform.Instance.GetCurrentToy();
            if (currentToy != null)
            {
                Console.WriteLine($"{currentToy.GetPosition().X},{currentToy.GetPosition().Y},{currentToy.GetDirection().ToString().ToUpper()}");
            }
            else
            {
                Console.WriteLine("No toy availbale. Run PLACE command first.");
            }
        }
    }
}
