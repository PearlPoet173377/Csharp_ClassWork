using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;
using App.Command;


namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ICommand> commands = new List<ICommand>();
            List<Persona> persons = new List<Persona>();
            commands.Add(new ListPersonCommand(persons));
            commands.Add(new ListNumberOfPersonsCommand(persons));
            commands.Add(new AvgAgeCommand(persons));
            commands.Add(new MaxAgeCommand(persons));
            commands.Add(new MinAgeCommand(persons));
            commands.Add(new AddPersonCommand(persons));
            commands.Add(new LoadFromFileCommand());
            commands.Add(new SaveToFileCommand());
            commands.Add(new ExitCommand());

            MenuRunner menuRunner = new MenuRunner(commands);
            menuRunner.MenuRun();
        }
    }
}
