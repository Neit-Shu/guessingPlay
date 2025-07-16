using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();           
            int question = random.Next(101);
            int attempts = 0;
            Console.WriteLine("Привет! Сыграем? Я загадал число от 0 до 100. Попробуй угадать!");
            int answer;
            while (true)
            {
                Console.WriteLine("Твое число:");
               
                if (!int.TryParse(Console.ReadLine(), out answer))
                {
                    Console.WriteLine("Ошибка! Введите число:");
                    continue;
                }
                attempts++;
                if (answer == question)
                {
                    Console.WriteLine($"Победа! {attempts} попыток.");
                    break;
                }
                Console.WriteLine(answer > question ? "Меньше" : "Больше");
                }
                
            }
        }
    }

