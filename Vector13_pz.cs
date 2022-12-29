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
    class Vector13_pz
    {
        public int vector;
        public int a1 = 5;
        public int a2 = 4;
        public int b1 = 8;
        public int b2 = 10;
        public int c1 = 4;
        public int c2 = 2;
        public int chislo = 4;

        public void GetInfo(int vector, int a1,int a2, int b1, int b2, int c1, int c2, int chislo) 
        {
            this.vector = vector;
            this.a1 = a1;
            this.a2 = a2;
            this.b1 = b1;
            this.b2 = b2;
            this.c1 = c1;
            this.c2 = c2;
            this.chislo = chislo;

        }
        public void OperationWithVektoram() //36
        {
            ForegroundColor = ConsoleColor.White;
            Write("НАжми циферку 1 и будет магия ");
            int vibor = Convert.ToInt32(Console.ReadLine());
            switch (vibor)
            {
                case 1:
                    slojeniemanshitnigga();
                    umnojenievektora();
                    umnojidelenienaceloechislo();
                    break;
                default:
                    ForegroundColor = ConsoleColor.Red;
                    Write("ВЫ ВЫБРАЛИ НЕ ТОТ ПУНКТ ПЕРЕВЫБИРАЙТЕ ");
                    break;

            }
        }
        public void slojeniemanshitnigga()
        {
            ForegroundColor = ConsoleColor.White;
             vector = (a1 + a2) + (b1 + b2) + (c1+c2);
            Write($"Их сложение {vector}\n");
            vector = (a1 - a2) - (b1 - b2) - (c1 - c2);
            Write($"Их вычитание {vector}\n");
          
        }
        public void umnojenievektora()
        {
            ForegroundColor = ConsoleColor.Yellow;
            vector = (a1 * b1) + (a2 * b2) + (c1 * c2);
            Write($"Их скалярное умножение {vector}\n");
        }
        public void umnojidelenienaceloechislo()
        {
            ForegroundColor = ConsoleColor.Green;
            vector = (a1 + b1 + a2 +b2 + c1 + c2) * chislo;
            Write($"Их умножение на число: {vector}\n");
            vector = (a1 * b1 + a2 * b2 + c1 * c2) / chislo;
            Write($"Их delenie на число: {vector}\n");
        }
    }
}
