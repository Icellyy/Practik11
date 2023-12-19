using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Компьютерный практикум № 11
            //Задача 1. Используя двузначное случайное число, вывести на экран информацию о четности или нечетности этого числа с использованием тернарной операции.


            //Random marg = new Random();                                           //создал рандомное число 
            //int number = marg.Next(10,99);                                        //указал значения этого рандомного числа 
            //Console.WriteLine(number);                                            //вывел его 
            //string inf = (number % 2 == 0) ? "Четное число" : "Нечетное число";   //если оно делить без сотатка на 2 тогда "1" если не делиться "2"
            //Console.WriteLine(inf);                                               //вывел переменную inf


            //Задача 2.Используя случайное число в диапазоне от 1 до 7, вывести на экран название дня недели.


            //Random marg = new Random();                           //создал рандомное число
            //int number = marg.Next(1,7);                          //указал значения от 1 до 7
            //Console.WriteLine(number);                            //вывел его 
            //switch (number)                                       //использую switch
            //{
            //case 1: Console.WriteLine("Понедельник"); break;
            //case 2: Console.WriteLine("Вторник"); break;
            //case 3: Console.WriteLine("Среда"); break;
            //case 4: Console.WriteLine("Четверг"); break;
            //case 5: Console.WriteLine("Пятница"); break;
            //case 6: Console.WriteLine("Суббота"); break;
            //case 7: Console.WriteLine("Воскресенье"); break;
            //default: Console.WriteLine("ERROR"); break;
            //}


            //Задача 3.Даны три целых положительных числа. Если все они четные, каждое число уменьшить в 2 раза, если хотя бы одно из них четное, увеличить каждое число в 2 раза, если четных чисел нет, каждое число увеличить на 1.


            //Console.Write("Введите значение числа a = "); 
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("Введите значение числа b = ");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("Введите значение числа c = ");
            //int c = int.Parse(Console.ReadLine());
            //if (a % 2 == 0 && b % 2 == 0 && c % 2 == 0)                       // если все числа четные, тогда /2
            //{
            //    a /= 2;
            //    b /= 2;
            //    c /= 2;
            //}
            //else if (a % 2 == 0 || b % 2 == 0 || c % 2 == 0)                  // если хотя бы одно число четное, тогда переменная *2
            //{
            //    a *= 2;
            //    b *= 2;
            //    c *= 2;
            //}
            //else                                                              // если нет четных чисел, тогда к переменной ++
            //{
            //    a++;
            //    b++;
            //    c++;
            //}
            //Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);           // вывожу результат


            //Задача 4 тест, оцениваемый в целочисленных баллах от нуля до ста.Вывести на экран оценку тестируемого в зависимости от набранного количества баллов: от 90 до 100 – «отлично», от 70 до 89 – «хорошо», от 50 до 69 – «удовлетворительно», менее 50 – «неудовлетворительно».


            //Console.Write("Введите кол-во баллов за тест = ");    //вывожу в консоль слова "Введите кол-во баллов за тест = "
            //int ball = int.Parse(Console.ReadLine());             //создал переменную типа int и ввожу её значения  консоли
            //if (ball >= 90)                                       //условие >= 90 Отлично
            //{
            //        Console.WriteLine("Отлично");
            //}
            //else if (ball >= 79 && ball <= 89)                    //условие >= 79 && <=89 Хорошо
            //{
            //        Console.WriteLine("Хорошо");
            //    }
            //else if (ball >= 50 && ball <= 69)                   //условие >= 50 && <= 69 Удовлетворительно 
            //{
            //        Console.WriteLine("удовлетворительно");
            //    }
            //else if (ball <= 50)                                  //условие <= 50 неудовлетворительно
            //{
            //        Console.WriteLine("неудовлетворительно");
            //    }
            //Console.ReadKey();  
        }
    }
    }

