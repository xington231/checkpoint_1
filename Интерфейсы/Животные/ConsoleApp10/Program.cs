using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Interfaces
{
    internal class Program
    {
        interface IAnimal
        {
            string Name { get; set; }
            void makeSound();

        }
        public class Dog: IAnimal
        {
            public string Name { get; set; }
            public Dog(string name)
            {
                Name = name;
            }
            public void makeSound()
            {
                Console.WriteLine("Гав!");
            }
        }
        public class Cat : IAnimal
        {
            public string Name { get; set; }
            public Cat(string name)
            {
                Name = name;
            }
            public void makeSound()
            {
                Console.WriteLine("Мяу");
            }
        }
        static void Main(string[] args)
        {
            Cat cat = new Cat("Мурка");
            cat.makeSound();
            Dog dog = new Dog("Арчи");
            dog.makeSound();
        }
    }
}
