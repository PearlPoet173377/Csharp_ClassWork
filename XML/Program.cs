using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace XML
{
    class Program
    {
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }



            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }



        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Person("Name 1", 19));
            persons.Add(new Person("Name 2", 22));



            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("persons.xml");
                XmlElement root = doc.DocumentElement;
                //XmlNodeList children = root.ChildNodes;

                foreach(XmlElement node in root.ChildNodes)
                {
                    if(node.Name !="Person")
                    {
                        continue;
                    }
                    string Name = node.GetAttribute("Name");
                    string sAge = node.GetAttribute("Age");
                    int nAge = int.Parse(sAge);
                    Person person = new Person(Name, nAge);

                    persons.Add(person);

                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            foreach(Person person in persons)
            {
                Console.WriteLine($"{person.Name}, {person.Age}");
            }
            Console.ReadKey();
        }

        public static void OutputElement(XmlElement el, int level)
        {
            string tab = new string('\t', level);
            Console.WriteLine($"{tab}{el.Name}:{el.NodeType}, attr={el.HasAttributes}, nodes={el.HasChildNodes}");
            if (el.HasChildNodes)
            {
                foreach (XmlLinkedNode child in el.ChildNodes)
                {
                    if (child is XmlText)
                    {
                        Console.WriteLine($"{tab}\t{child.Name}:{child.NodeType}, {child.Value}");
                    }
                    else
                    {
                        OutputElement(child as XmlElement, level + 1);
                    }
                }
            }
        }
    }
}

