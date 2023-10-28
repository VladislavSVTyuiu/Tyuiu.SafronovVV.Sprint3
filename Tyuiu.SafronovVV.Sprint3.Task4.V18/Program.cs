using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SafronovVV.Sprint3.Task4.V18.Lib;

namespace Tyuiu.SafronovVV.Sprint3.Task4.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #3 | Выполнил: Сафронов В. В. | АСОиУб-23-1";
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                            *");
            Console.WriteLine("* Тема:  алгоритмы циклической структуры                                               *");
            Console.WriteLine("* Задание #4                                                                           *");
            Console.WriteLine("* Вариант #18                                                                          *");
            Console.WriteLine("* Выполнил: Сафронов Владислав Валерьевич | АСОиУб-23-1                                *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                             *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5,                                     *");
            Console.WriteLine("* вычислить значение функции y=sin(x)/cos(x)                                           *");
            Console.WriteLine("* При х = 0 прервать цикл. Полученные значения суммировать.                            *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");


            int startvalue = -5;
            int stopvalue = 5;

            Console.WriteLine("Старт шага: " + startvalue);
            Console.WriteLine("Стоп шага: " + stopvalue);



            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                            *");
            Console.WriteLine("****************************************************************************************");

            Console.WriteLine("Сумма ряда = " + ds.Calculate(startvalue, stopvalue));

            Console.ReadLine();
        }
    }
}
