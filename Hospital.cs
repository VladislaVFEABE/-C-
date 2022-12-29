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
    class Hospit
    {
        public string Famka { get; set; }
        public string Name { get; set; }
        public string Otche { get; set; }
        public int nomerkarti { get; set; }
        public string diagnoz { get; set; }
        public Hospit(string famka, string name, string otche, int Nomerkarti, string Diagnoz)
        {
            Famka = famka;
            Name = name;
            Otche = otche;
            nomerkarti = Nomerkarti;
            diagnoz = Diagnoz;
        }

        public Hospit()
        {
        }

        public void Info()
        {
            ForegroundColor = ConsoleColor.White;
            List<Hospit> SpisokBoli = new List<Hospit>();
            SpisokBoli.Add(new Hospit("Гений", "Этого", "Мира", 15,"СПИД"));
            SpisokBoli.Add(new Hospit("Павлов", "Павел", "Павлович", 18, "СПИД"));
            SpisokBoli.Add(new Hospit("Чертов", "Павел", "Павлович", 20, "ВИЧ"));

            foreach (var peremen in SpisokBoli)
            {
                peremen.Output();
            }
            Write("Выберите действие для вывода: ");
            WriteLine("1) Поиск по имени\n");
            WriteLine("2) поиск по диагнозу");
            WriteLine("3) Поиск по номеру мед книги");
            int viborka = int.Parse(ReadLine());
            switch (viborka)
            {
                case 1:
                    WriteLine("Введите имя пациента: ");
                    string output_name = ReadLine();
                    foreach (var peremen in SpisokBoli)
                    {
                        if (peremen.Name.Equals(output_name))
                        {
                            peremen.Info();
                        }
                    }
                    break;
                case 2:
                    WriteLine("Введите Диагноз больного: \n");
                    output_name = ReadLine();
                    foreach (var peremen in SpisokBoli)
                    {
                        if (peremen.diagnoz.Equals(output_name))
                            peremen.Info();
                    }
                    break;
                case 3:
                    WriteLine("Введите номер мед карты");
                    output_name = ReadLine();
                    foreach (var peremen in SpisokBoli)
                    {
                        if (peremen.nomerkarti >= Convert.ToInt32(output_name))
                            peremen.Info();
                    }
                    break;
            }

        }
        public void Output()
        {
            Write($"Фамилия: { Famka}\n");
            Write($"Имя: { Name}\n");
            Write($"Отчество: { Otche}\n");
            Write($"Номер мед карты: {nomerkarti}\n");
            Write($"Диагноз: { diagnoz}\n");
        }

    }

}

