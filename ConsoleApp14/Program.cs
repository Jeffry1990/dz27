using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit=true;
            while (exit)
            {
                string day;
                Console.Write("Напишите любой день недели или exit чтобы завершить: ");
                day = Console.ReadLine();

                switch (day)
                {
                    case "понедельник":
                    case "вторник":
                    case "среда":
                    case "четверг":
                    case "пятница":
                    case "суббота":
                    case "воскресенье":
                        Console.WriteLine("день недели");
                        continue;
                    default:
                        Console.WriteLine("Я такого дня недели не знаю");
                        continue;
                    case "exit":
                        Console.WriteLine("Выход из программы");
                        break;
                }
                break;
            }
        }
        }
    }
    

