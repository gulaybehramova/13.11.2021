using System;
using System.Collections;
using System.Collections.Generic;

namespace _13._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student("Elnur", "Huseynov");
            Student stu2 = new Student("Elnur", "Ibrahimli");
            Student stu3 = new Student("Togrul", "Piriyev");
            Student stu4 = new Student("Hesen", "Seyfullayev");

            string[] skills = { "C#", "Javascript" };
            Teacher teacher1 = new Teacher("Elcin", "Aghayev",skills);
            Teacher teacher2 = new Teacher("Agil", "Bashirov", skills);
            


            ArrayList arrayList = new ArrayList();
            arrayList.Add(stu4);
            arrayList.Add(stu3);
            arrayList.Add(stu2);
            arrayList.Add(stu1);
            arrayList.Add(teacher1);
            arrayList.Add(teacher2);

            foreach (var item in GetStudents(arrayList))
            {
                Console.WriteLine(item);
            }
        }

        public static List<Student> GetStudents(ArrayList list)
        {
            List<Student> newList = new List<Student>();
            foreach (var item in list)
            {
                if(item is Student)
                {
                    newList.Add((Student)item);
                }
            }
            return newList;
        }
    }
}
