using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace App.Command
{
    class ListPersonCommand : ICommand
    {
        private List<Persona> persons;
        public ListPersonCommand(List<Persona> persons)
        {
            this.persons = persons;
        }
        public string GetMenuRow()
        {
            return "Write all persons";
        }

        public bool Run()
        {
            
            foreach(Persona person in persons)
            {
                WriteLine($"{person.Name}, {person.Age}");
            }
            return false;
        }
    }
}
