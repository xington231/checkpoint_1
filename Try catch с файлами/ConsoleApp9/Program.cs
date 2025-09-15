using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main()
        {

            try
            {
                Console.Write("Введите путь к файлу: ");
                string path = Console.ReadLine();
                string text = File.ReadAllText(path);
                Console.WriteLine("Содержимое файла: ");
                Console.WriteLine(text);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Неверный путь файла, " + ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Директория не найдена, " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Непредвиденная ошибка, " + ex.Message);
            }

            finally
            {
                Console.WriteLine("Нажмите Esc чтобы выйти");
                while (Console.ReadKey(true).Key != ConsoleKey.Escape) { }
            }
            
        }

    }
}
