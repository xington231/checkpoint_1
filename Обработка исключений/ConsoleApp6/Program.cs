using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;


namespace exceptioHandling
{
    internal class Program
    {
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string Email { get; set; }
        }


        static void Main(string[] args)
        {
            var faker = new Faker<Person>("ru")
                .RuleFor(p => p.FirstName, f => f.Name.FirstName())
                .RuleFor(p => p.LastName, f => f.Name.LastName())
                .RuleFor(p => p.Age, f => f.Random.Int(0, 18))
                .RuleFor(p => p.Email, (f, p) => f.Internet.Email(p.FirstName, p.LastName));
            List<Person> people = faker.Generate(10);
            List<Person> registeredUsers = new List<Person>();
            foreach (var person in people)
            {
                try 
                {
                    Console.WriteLine($"\n{person.FirstName} {person.LastName}, {person.Age} лет, email: {person.Email}");
                    if(person.Age < 14)
                    {
                        throw new ArgumentException( "Регистрация запрещена для пользователей младше 14 лет.");
                    }
                    registeredUsers.Add(person);
                    Console.WriteLine($"Пользователь {person.FirstName} успешно зарегистрирован!");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Пользователь {person.FirstName} {person.LastName}: {ex.Message} не добавлен в базу данных");

                }
            }

        }
    }
}
