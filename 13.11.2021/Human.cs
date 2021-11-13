using System;
using System.Collections.Generic;
using System.Text;

namespace _13._11._2021
{
  abstract class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Human(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public override string ToString()
        {
            return $"{ Name},{ Surname}";
        }
    }
}
