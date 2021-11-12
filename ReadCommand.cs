using System;
using System.Collections.Generic;
using System.Text;

namespace SF_9_practicum
{
    class ReadCommand
    {
        public delegate void NumEnterHandler(int num);
        public event NumEnterHandler NumEntered;

        public void ReadEnter()
        {
            Console.WriteLine("Выберите тип сортировки.");
            Console.Write("Введите 1 - по возрастанию, введите 2 - по убыванию: ");

            try
            {
                string inData = Console.ReadLine();

                if (inData == "")
                    throw new ArgumentNullException();

                int num = int.Parse(inData);

                if (num == 1 || num == 2)
                {
                    NumEntered?.Invoke(num);
                }
                else
                {
                    throw new CommandExeption("Введена не зарегистрированная команда.");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
