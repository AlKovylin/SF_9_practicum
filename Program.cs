using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SF_9_practicum
{
    class Program
    {
        private static List<string> Person = new List<string>();

        static void Main(string[] args)
        {
            ReadCommand readCommand = new ReadCommand();
            readCommand.NumEntered += SortedList;

            Person.Add("Иванов");
            Person.Add("Петров");
            Person.Add("Сидоров");
            Person.Add("Григорьев");
            Person.Add("Алексеев");

            while (true)
            {
                try
                {
                    readCommand.ReadEnter();
                }
                catch (CommandExeption ex)//1 собственное
                {
                    Console.WriteLine(ex.Message);
                }
                catch (ArgumentNullException ex)//2
                {
                    Console.WriteLine("Значение равно NULL. " + ex.Message);
                }
                catch (FormatException ex)//3
                {
                    Console.WriteLine("Неверный формат. " + ex.Message);
                }
                catch (OverflowException ex)//4
                {
                    Console.WriteLine("Исключение переполнения. " + ex.Message);
                }
                catch(IOException ex)//5
                {
                    Console.WriteLine("Ошибка ввода-вывода. " + ex.Message);
                }
            }
        }

        public static void SortedList(int num)
        {
            switch (num)
            {
                case 1:
                    Person.Sort();
                    break;
                case 2:
                    Person.Sort();
                    Person.Reverse();
                    break;
            }
            Console.WriteLine();
            Display();
        }

        public static void Display()
        {
            foreach (var P in Person)
            {                
                Console.WriteLine(P);
            }
            Console.WriteLine();
        }
    }
}
