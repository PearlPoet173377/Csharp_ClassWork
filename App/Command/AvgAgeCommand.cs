using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace App.Command
{
    class AvgAgeCommand : ICommand
    {
        private List<Persona> persons;

        public AvgAgeCommand(List<Persona> persons)
        {
            this.persons = persons;
        }

        public string GetMenuRow()
        {
            return "Avg age: ";
        }

        public bool Run()
        {
            if (persons.Count > 0)
            {

                int ageSum = 0;

                foreach (Persona persona in persons)
                {
                    ageSum += persona.Age;
                }
                WriteLine($"Avg age: {ageSum / persons.Count}");
            }
            else
            {
                WriteLine("List empty");
            }

            return false;
        }
    }
}
