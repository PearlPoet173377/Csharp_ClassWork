using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace App.Command
{
    class ListNumberOfPersonsCommand : ICommand
    {
        private List<Persona> persons;
        public ListNumberOfPersonsCommand(List<Persona> persons)
        {
            this.persons = persons;
        }
        public string GetMenuRow()
        {
            return "Write person list";
        }

        public bool Run()
        {
            WriteLine($"Count person: {persons.Count}");
            return false;
        }
    }
}
