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
    class Rectangle
    {
        public int Xa;
        public int Xb;
        public int Xc;
        public int Xd;
        public int Ya;
        public int Yb;
        public int Yc;
        public int Yd;
        public string figure;
        


        public void GetInfo(int Xa, int Xb, int Xc, int Xd, int Ya, int Yb, int Yc, int Yd)
        {
            this.Xa = Xa;
            this.Xb = Xb;
            this.Xc = Xc;
            this.Xd = Xd;
            this.Ya = Ya;
            this.Yb = Yb;
            this.Yc = Yc;
            this.Yd = Yd;
            
        }
       
        public void raschet() //33
        {
            ForegroundColor = ConsoleColor.White;
            Write("\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Write("B--------------------C\n");
            Write("|\n|                    |\n");
            Write("|\n|                    |\n");
            Write("A--------------------D\n");
            Console.ForegroundColor = ConsoleColor.White;
            figure = "Прямуогольник\n";
            Write($"Заданная фигура {figure}");
            Write("Введите x сторону  А\n");
             Xa = Convert.ToInt32(Console.ReadLine());
            Write("Введите y сторону  А\n");
            Ya = Convert.ToInt32(Console.ReadLine());
            Write($"Веденные вами данные стороны A: ({Xa},{Ya})\n");
            Write("Введите x сторону  B\n");
            Xb = Convert.ToInt32(Console.ReadLine());
            Write("Введите y сторону  B\n");
            Yb = Convert.ToInt32(Console.ReadLine());
            Write($"Веденные вами данные стороны B: ({Xb},{Yb})\n");
            Write("Введите x сторону  C\n");
             Xc = Convert.ToInt32(Console.ReadLine());
            Write("Введите y сторону  C\n");
            Yc = Convert.ToInt32(Console.ReadLine());
            Write($"Веденные вами данные стороны C: ({Xc},{Yc})\n");
            Write("Введите x сторону  D\n");
             Xd = Convert.ToInt32(Console.ReadLine());
            Write("Введите y сторону  D\n");
             Yd = Convert.ToInt32(Console.ReadLine());
            Write($"Веденные вами данные стороны D: ({Xd},{Yd})\n");
            if(Xa > Ya && Xb < Xa && Ya > Yb && Xc > Yc && Xd < Xc && Yc > Yd)
            {
                Write("Точка попала в прямоугольник\n");
            }
            else
            {
                Write("Точка непопала введи данные сного \n");
            }
            GetInfo(Xa, Xb, Xc, Xd, Ya, Yb, Yc, Yd);
            Write($"Заданная фигура: {figure} Сторона А: {Xa},{Ya} Сторона B: {Xb},{Yb} Сторона C: {Xc},{Yc} Сторона D: {Xd}, {Yd}");
        }


   
    }
}
