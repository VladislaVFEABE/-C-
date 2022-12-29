using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.String;


namespace ConsoleApp3
{
    class task9
    {
       public void taskone() //30
       {
             
       }

        public void tasktwo() //31 неверная
        {
            ForegroundColor = ConsoleColor.White;
            Write("Введите значение переменной m\n");
            int m = int.Parse(Console.ReadLine());
            for (int i = 2; i <= m; i += 2)
            {
                Console.WriteLine(i);
            }
            Write("Задача решена");
        }
        public void doubleAverage() //32
        {
            ForegroundColor = ConsoleColor.White;
            int sredten = (1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10) / 10;
            Write($"Среднее арифм чисел от 1 до 10 ={sredten}\n");
            int sredsorok = (20 + 21 + 22 + 23 + 24 + 25 + 26 + 27 + 28 + 29 + 30 + 31 + 32 + 33 + 34 + 35 + 36 + 37 + 38 + 39 + 40) / 20;
            Write($"Среднее арифм чисел от 20 до 40 ={sredsorok}\n");
            Write("Vvedite A \n");
            int a = int.Parse(Console.ReadLine());
            Write("Vvedite B \n");
            int b = int.Parse(Console.ReadLine());
            int sredarifm = (a + b) / 2;
            Write($"A = {a} + B = {b} = Среднее африм {sredarifm}");
            
        }
    }
}
