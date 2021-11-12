using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SF_9_practicum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Person = new List<string>();
            Person.Add("Иванов");
            Person.Add("Петров");
            Person.Add("Сидоров");
            Person.Add("Григорьев");
            Person.Add("Алексеев");

            Console.WriteLine("Выберите тип сортировки.");
            Console.WriteLine("Введите 1 - по возрастанию, введите 2 - по убыванию: ");
            int num = int.Parse(Console.ReadLine());

            SortedUp(Person);

            foreach (var P in Person)
            {
                Console.WriteLine(P);
            }

            Console.WriteLine("");

            SortedDown(Person);

            foreach (var P in Person)
            {
                Console.WriteLine(P);
            }
        }

        public static void SortedUp(List<string> person)
        {
            person.Sort();
        }

        public static void SortedDown(List<string> person)
        {
            person.Sort();
            person.Reverse();
        }
    }
}
