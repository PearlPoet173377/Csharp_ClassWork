using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace App.Command
{
    class MinAgeCommand : ICommand
    {
        private List<Persona> persons;

        public MinAgeCommand(List<Persona> persons)
        {
            this.persons = persons;
        }

        public string GetMenuRow()
        {
            return "Min age person: ";
        }

        public bool Run()
        {
            if (persons.Count > 0)
            {

                Persona minAgePerson = persons[0];

                foreach (Persona persona in persons)
                {
                    if (persona.Age < minAgePerson.Age)
                    {
                        minAgePerson = persona;
                    }
                }
                WriteLine($"Min age person: {minAgePerson.Name}, age: {minAgePerson.Age}");
            }
            else
            {
                WriteLine("List empty");
            }

            return false;
        }
    }
}
