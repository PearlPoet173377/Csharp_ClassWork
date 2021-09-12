using System.Collections.Generic;
using static System.Console;
using App.Command;

namespace App
{
    class MaxAgeCommand : ICommand
    {
        private List<Persona> persons;

        public MaxAgeCommand(List<Persona> persons)
        {
            this.persons = persons;
        }

        public string GetMenuRow()
        {
            return "Max age person";
        }

        public bool Run()
        {
            if (persons.Count > 0)
            {

                Persona maxAgePerson = persons[0];

                foreach (Persona persona in persons)
                {
                    if (persona.Age > maxAgePerson.Age)
                    {
                        maxAgePerson = persona;
                    }
                }
                WriteLine($"Max age person: {maxAgePerson.Name}, age: {maxAgePerson.Age}");
            }
            else
            {
                WriteLine("List empty");
            }

            return false;
        }
    }
}