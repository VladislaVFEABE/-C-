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
    class paralgram12_pz
    {
        
        public int storonaA;
        public int storonaB;
        public int ugol;
        public int ugoltwo;

        public void GetInfo(int storonaA, int storonaB,  int ugol, int ugoltwo)
        {
        
            this.storonaA = storonaA;
            this.storonaB = storonaB;
            this.ugol = ugol;
            this.ugoltwo = ugoltwo;
          
        }
        public void chetotamosparalegramom() //35
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Write(" /---------------------/\n");
            Write(" |                     |\n");
            Write(" |                     |\n");
            Write(" |                     |\n");
            Write(" |                     |\n");
            Write(" |                     |\n");
            Write(" /---------------------/\n");
            Console.ForegroundColor = ConsoleColor.White;
           
            Write("Введите сторону А:\n");
            storonaA = Convert.ToInt32(Console.ReadLine());
            Write("Введите сторону B:\n");
            storonaB = Convert.ToInt32(Console.ReadLine());
            Write("Введите угол между A i B:\n ");
            ugol = Convert.ToInt32(Console.ReadLine());
            Write("Введите второй угол между A i B:\n ");
            ugoltwo = Convert.ToInt32(Console.ReadLine());
            GetInfo(storonaA, storonaB, ugol, ugoltwo);
            if (storonaA == storonaB & storonaB == storonaA & ugol == 90 | ugoltwo == 90)
            {
                Write($"Параллелограмм является квадратом\n");
            }
            
            else if(storonaA == 0 && storonaB == 0 && ugol == 0 && ugoltwo == 0)
            {
                Write("Поздравляю такого параллелограмма не существует\n");
            }
            else if(storonaA == storonaB & storonaB == storonaA)
            {
                Write($"Параллелограмм является ромбом \n");
            }

            else if (storonaA == storonaB & storonaB == storonaA && ugol == 90 & ugoltwo == 90)
            {

                Write($"Параллелограмм является прямоугольником ");
            }

            else
            {
                Write("Параллелограмм ни является ни какой фигурой\n");
            }

            Write($" Сторона А:{storonaA}, Сторона B: {storonaB},  \n Угол № 1: {ugol}, Угол № 2: {ugoltwo}");
        }
    }
}
