using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class MyArr
    {
        int[] arr;
        public int Length;

        public MyArr()
        {
            Console.WriteLine("Введите размер массива");
            Length = int.Parse(Console.ReadLine());
            arr = new int[Length];
        }

        public void CheckIndex(int index)
        {
            if (index < 0 || index >= Length)
                throw new ArgumentOutOfRangeException(nameof(index), "Данное число вне диапазона");
        }

        public int this[int index]
        {
            get
            {
                CheckIndex(index);
                return arr[index];
            }
            set
            {
                CheckIndex(index);
                arr[index] = value;
            }
        }
        // Перегружаем индексатор
        public int this[double index]
        {
            get
            {
                int dindex = (int)Math.Round(index);
                CheckIndex(dindex);
                return arr[dindex];
            }
            set
            {
                int dindex = (int)Math.Round(index);
                CheckIndex(dindex);
                arr[dindex] = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyArr arr = new MyArr();
            Random rnd = new Random();
            for(int i=0; i<arr.Length; i++)
            {
                arr[i]=rnd.Next(0,150);  
            }
            Console.WriteLine("Получившийся массив: ");
            for (int i = 0; i < arr.Length; i++)
                Console.Write("{0}\t", arr[i]);
            while (true)
            {
                Console.WriteLine("\nВведите индекс для поиска числа (или 'выйти' для завершения):");
                string input = Console.ReadLine();
                if (input.ToLower() == "выйти")
                    break;

                if (int.TryParse(input, out int index))
                {
                    try
                    {
                        int number = arr[index - 1];  
                        Console.WriteLine($"Число по индексу {index}: {number}");
                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else if (double.TryParse(input, out double doubleIndex))
                {
                    try
                    {
                        int number = arr[doubleIndex - 1];
                        Console.WriteLine($"Число по индексу {doubleIndex}: {number}");
                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Пожалуйста, введите корректный индекс (число)");
                }
            }

            Console.ReadLine();
        }
    }
}