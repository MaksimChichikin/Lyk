using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirieshka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arrUsers = new Users[] { new Users("god"), new Users("tor"), new Users("peglin") };
        Start:
            Console.WriteLine("Для регистрации введите:(р)\nДля авторизации введите:(а)");
            var input = Console.ReadLine();
            bool successfull = false; while (!successfull)
            {
                if (input == "а")
                {
                    Console.WriteLine("Напишите свое имя пользователя:");
                    var username = Console.ReadLine();
                    var password = Console.ReadLine(); foreach (Users user in arrUsers)
                    {
                        if (username == user.username)
                        {
                            Archery archery = new Archery();
                            archery.ShootChangeHandler = ShowShoot;
                            archery.Start();
                            Console.ReadLine(); successfull = true; break;
                        }
                    }
                    if (!successfull)
                    {
                        Console.WriteLine("Ваше имя пользователя или пароль неверны, попробуйте еще раз");
                    }
                }
                else if (input == "р")
                {
                    Console.WriteLine("Введите имя пользователя:");
                    var username = Console.ReadLine();
                    Array.Resize(ref arrUsers, arrUsers.Length + 1);
                    arrUsers[arrUsers.Length - 1] = new Users(username);
                    successfull = true;
                    goto Start;
                }
                else { Console.WriteLine("Попробуйте еще раз");
                    break; }
            }
        }
        public static void ShowShoot(int result)
        {
            Console.WriteLine($"Выстрел: {result}");
        }
    }
    }

