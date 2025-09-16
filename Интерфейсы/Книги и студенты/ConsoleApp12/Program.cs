using System;

namespace Interfaces3
{
    internal class Program
    {
        public class Student : IComparable<Student>
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int Grade { get; set; }

            public Student(string name, int age, int grade)
            {
                Name = name;
                Age = age;
                Grade = grade;
            }

            public int CompareTo(Student other)
            {
                if (other == null) return 1;

                int nameCompare = string.Compare(Name, other.Name);
                if (nameCompare != 0) return nameCompare;

                int ageCompare = Age.CompareTo(other.Age);
                if (ageCompare != 0) return ageCompare;

                return Grade.CompareTo(other.Grade);
            }

            public override string ToString()
            {
                return $"Имя: {Name}, Возраст: {Age}, Класс: {Grade}";
            }
        }

        public class Book : IComparable<Book>
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public int Price { get; set; }

            public Book(string title, string author, int price)
            {
                Title = title;
                Author = author;
                Price = price;
            }

            public int CompareTo(Book other)
            {
                if (other == null) return 1;

                int titleCompare = string.Compare(Title, other.Title);
                if (titleCompare != 0) return titleCompare;

                int authorCompare = string.Compare(Author, other.Author);
                if (authorCompare != 0) return authorCompare;

                return Price.CompareTo(other.Price);
            }

            public override string ToString()
            {
                return $"Автор: {Author} - Книга: '{Title}' Цена: {Price}";
            }

        }

        static void Main(string[] args)
        {
            Student[] students = new[]
            {
                new Student("Анастасия", 17, 1),
                new Student("Роман", 14, 7),
                new Student("Анна", 9, 3)
            };

            Array.Sort(students);

            Console.WriteLine("Студенты:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Book[] books = new[]
           {
                new Book("Мертвые души", "Гоголь", 500),
                new Book("Анна Каренина", "Толстой", 700),
                new Book("Евгений Онегин", "Пушкин", 1000)
            };

            Array.Sort(books);

            Console.WriteLine("Книги:");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
