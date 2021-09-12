using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace App.Command
{
    class AddPersonCommand : ICommand
    {
        private List<Persona> persons;

        public AddPersonCommand(List<Persona> persons)
        {
            this.persons = persons;
        }

        public string GetMenuRow()
        {
            return "Add new Persona";
        }

        public bool Run()
        {
            WriteLine("Enter your name: ");
            string name = ReadLine();
            WriteLine("Enter your age: ");
            string age = ReadLine();
            Persona person = new Persona();
            person.Name = name;
            person.Age = int.Parse(age);
            persons.Add(person);
            return false;
        }
    }
}
