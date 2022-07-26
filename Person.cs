using System;
using System.Collections.Generic;
using System.Text;

namespace ForVlad
{
    class Person : Human
    {
        public string Name { get; private set; } = "Maksym";
        public string SerName { get; private set; } = "Meshkov";
        public int Age { get; private set; } = 34;
        public int Weight { get; private set; } = 76;
        public int Growth { get; set; } = 177;
        private static Person person;

        public Person()
        {

        }

        public Person(string name, string serName, int age, int weight, int growth )
        {
            this.Name = name;
            this.SerName = serName;
            this.Age = age;
            this.Weight = weight;
            this.Growth = growth;
            person = new Person();
        }

        static Person()
        {
            if (person == null)
                person = new Person();
        }
    }
}
