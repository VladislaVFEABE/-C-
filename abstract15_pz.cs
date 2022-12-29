using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp3
{
    abstract class Figura
    {
      
        public abstract void VivodvsexFigur();
    }
   
    class Rectanglee : Figura
    {
        public int storonaA, storonaB, storonaC, storonaD, peremiter, ploshadb;
        public void GetInfo(int storonaA, int storonaB, int storonaC, int storonaD, int peremiter, int ploshadb)
        {
            this.storonaA = storonaA;
            this.storonaB = storonaB;
            this.storonaC = storonaC;
            this.storonaD = storonaD;
            this.peremiter = peremiter;
            this.ploshadb = ploshadb;
        }
        public override void VivodvsexFigur()
        {
            ForegroundColor = ConsoleColor.White;
            Write("Вы работаете с Прямоугольнинокм\n");
            Write("Введите сторону А: \n");
            storonaA = int.Parse(Console.ReadLine());
            Write("Введите сторону B: \n");
            storonaB = int.Parse(Console.ReadLine());
            Write("Введите сторону C: \n");
            storonaC = int.Parse(Console.ReadLine());
            Write("Введите сторону D: \n");
            storonaD = int.Parse(Console.ReadLine());
            peremiter = storonaA + storonaB + storonaC + storonaD;
            Write($"Периметр найден: {peremiter}\n");
            ploshadb = storonaA * storonaB * storonaC * storonaD;
            Write($"\nПлощадь найдена {ploshadb}\n");
            Write($"Введенные данные\n сторона А:{storonaA}, сторона В: {storonaB}\n  сторона C: {storonaC}\n сторона D: {storonaD}\n Пермиетр: {peremiter}\n  Площадь:{ploshadb}");
        }
    }
    // класс самолета
    class Circle : Figura
    {
        public int storonaA, storonaB, storonaC, storonaD;
        public double radius;
        public double peremiter;
        public double ploshadb;
        public void GetInfo(int storonaA, int storonaB, int storonaC, int storonaD, int peremiter, double ploshadb,double radius)
        {
            this.storonaA = storonaA;
            this.storonaB = storonaB;
            this.storonaC = storonaC;
            this.storonaD = storonaD;
            this.peremiter = peremiter;
            this.ploshadb = ploshadb;
            this.radius = radius;
        }
        public override void VivodvsexFigur()
        {
            ForegroundColor = ConsoleColor.White;
            Write("Вы работаете с Кругом\n");
            Write("Введите радиус круга");
            radius = Convert.ToDouble(Console.ReadLine());
            peremiter = 2 * radius * Math.PI;
            Write($"Периметр найден: {peremiter}\n");
            ploshadb = Math.PI * Math.Pow(radius, 2);
            Write($"\nПлощадь найдена:{ploshadb}\n");
            Write($"Введенные данные\n Радиус:{radius}\n Пермиетр: {peremiter}\n Площадь:{ploshadb}");
        }
    }
    // класс машины
    class Triangle : Figura
    {
        public int storonaA, storonaB, storonaC, storonaD, peremiter, poluperimter;
        double ploshadb;
        public void GetInfo(int storonaA, int storonaB, int storonaC, int storonaD, int peremiter, double ploshadb, int poluperimter)
        {
            this.storonaA = storonaA;
            this.storonaB = storonaB;
            this.storonaC = storonaC;
            this.storonaD = storonaD;
            this.peremiter = peremiter;
            this.ploshadb = ploshadb;
            this.poluperimter = poluperimter;
        }
        public override void VivodvsexFigur()
        {
            ForegroundColor = ConsoleColor.White;
            Write("\nВы работаете с Треугольником\n");
            Write("Введите сторону А: \n");
            storonaA = int.Parse(Console.ReadLine());
            Write("Введите сторону B: \n");
            storonaB = int.Parse(Console.ReadLine());
            Write("Введите сторону C: \n");
            storonaC = int.Parse(Console.ReadLine());
            peremiter = storonaA + storonaB + storonaC;
            Write($"Периметр найден: {peremiter}\n");
            poluperimter = peremiter / 3;
            Write($"Полупериметр найден: {poluperimter}");
            ploshadb = Math.Sqrt(poluperimter * (poluperimter - storonaA) * (poluperimter - storonaB) * (poluperimter - storonaC));
            Write($"Площадь найдена: {ploshadb}");
            Write($"Введенные данные\n сторона А:{storonaA}, сторона В: {storonaB}\n  сторона C: {storonaC}\n Пермиетр: {peremiter}\n Полупериметр:{poluperimter}\n Площадь:{ploshadb}");
        }
    }
}