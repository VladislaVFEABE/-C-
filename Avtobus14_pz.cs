using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp3
{
    class avtobus
    {
        
        public void switchauto()
        {
            Autobus aw = new Autobus();
            Autobus_two awtwo = new Autobus_two();
            ForegroundColor = ConsoleColor.White;
            WriteLine("Выберите что хотите сделать 1)Сесть в городской автобус: \n 2)Поехать на экскурсию: ");
            int viborka = int.Parse(ReadLine());
            switch (viborka)
            {
                case 1:
                    WriteLine("Обычная городская поездка");
                    aw.StoimostbVsexMest();
                    break;
                case 2:
                    WriteLine("Выезд на экскурсию");
                    awtwo.StoimostbEkskursii();
                    break;
            }
        }

    }
    class Autobus
    {
        public string marka = "Маршрутка 20 Городская";
        public int kolvomest;
        public int cenazabilet = 6;


        public void StoimostbVsexMest()
        {
            ForegroundColor = ConsoleColor.White;
            WriteLine("Сколько мест хотите забронировать: ");
            kolvomest = int.Parse(ReadLine());
            int formula = kolvomest * cenazabilet;
            WriteLine($"Марка автобуса: {marka}\nСтолько стоит один билет:{cenazabilet}\nСтолько мест купил: {kolvomest} \n Общяя стоимость всех мест:{formula}");
        }
    }
    class Autobus_two : Autobus
    {
        public string mmarka = "Маршрутка 20 Экскурсионная";
        public int cenaekskursii = 8;
        public int mesta;
        public void StoimostbEkskursii() 
        {
            ForegroundColor = ConsoleColor.White;
            WriteLine("Сколько мест хотите забронировать: ");
             mesta = int.Parse(ReadLine());
            int formulatwo = mesta * cenaekskursii;
            Write($"Введите новую цену за билет, прошлая цена была: {cenaekskursii}\n");
            int newcena = int.Parse(Console.ReadLine());
            int formulathree = mesta * newcena;
            WriteLine($"Марка автобуса: {mmarka}\nСтолько стоит один билет:{cenaekskursii}\nСтолько мест купили:{mesta}\n " +
                $"Общяя стоимость всех мест:{formulatwo},\n новая цена билета:{newcena}\n, Общая стоимость всех мест с новой ценой: {formulathree}");
        }

    }
}