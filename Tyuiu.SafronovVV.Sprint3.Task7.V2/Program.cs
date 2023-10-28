using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SafronovVV.Sprint3.Task7.V2.Lib;

namespace Tyuiu.SafronovVV.Sprint3.Task7.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Сафронов В. В. | АСОиУБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Сафронов Владислав Валерьевич | АСОиУБ-23-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая выводит таблицу значений функции            *");
            Console.WriteLine("*         cos x                                                           *");
            Console.WriteLine("* F(x) = -------- - sin x * 12x + 2                                       *");
            Console.WriteLine("*        x - 0,7                                                          *");
            Console.WriteLine("* (произвести табулирование) F(x) на заданном диапазоне [-5; 5] с шагом 1 *");
            Console.WriteLine("* При делениии на ноль вернуть значение 0.                                *");
            Console.WriteLine("* Значеие округлить до двух знаков после запятой.                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Начало шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+-----------+-----------+");
            Console.WriteLine("|     x     |    F(x)   |");
            Console.WriteLine("+-----------+-----------+");

            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("| {0,6:d}    |   {1, 6:f2}  |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+-----------+-----------+");

            Console.ReadKey();
        }
    }
}
