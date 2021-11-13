using System;
using System.Collections.Generic;
using System.Text;

namespace _13._11._2021
{
    class Teacher:Human
    {
        public Teacher(string name, string surname, string[] skills) : base(name, surname)
        {
            Skills = skills;
        }
        string[] Skills;
    }
}
