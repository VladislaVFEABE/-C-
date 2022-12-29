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
    class Program
    {
        static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.White;
            task9 task9 = new task9();
            Rectangle rect = new Rectangle();
            Hospit hospital = new Hospit();
            paralgram12_pz paral = new paralgram12_pz();
            Vector13_pz Vektor = new Vector13_pz();
            avtobus av = new avtobus();

            Write("Я 18 вариант\n");
            Write("ТУТ 3 ПРАКТИКИ\n");
            WriteLine("Введите номер задачи от 1 до 29\n");
            Write("с 30 кейса начинается с 9 пз на КЛАССАХ\n");
            int wibor = Convert.ToInt32(Console.ReadLine());
            switch (wibor)
            {
                case 1:
                    Funkciya();
                    break;
                case 2:
                    Treugolbnik();
                    break;
                case 3:
                    GrafikFunc();
                    break;
                case 4:
                    PriznakiTransporta();
                    break;
                case 5:
                    Vklad();
                    break;
                case 6:
                    Chess();
                    break;
                case 7:
                    Chislo();
                    break;
                case 8:
                    vtorayaPZ1zadacha();
                    break;
                case 9:
                    vtorayaPZ2zadacha();
                    break;
                case 10:
                    vtorayaPZ3zadacha();
                    break;
                case 11:
                    tretayaPZ1zadacha();
                    break;
                case 12:
                    tretayaPZ2zadacha();
                    break;
                case 13:
                    tretayaPZ3zadacha();
                    break;
                case 14:
                    tretayaPZ4zadacha();
                    break;
                case 15:
                    tretayaPZ5zadacha();
                    break;
                case 16:
                    chetvertayaPZ1zadacha();
                    break;
                case 17:
                    chetvertayaPZ2zadacha();
                    break;
                case 18:
                    chetvertayaPZ3zadacha();
                    break;
                case 19:
                    pyatayaPZ1zadacha();
                    break;
                case 20:
                    pyatayaPZ2zadacha();
                    break;
                case 21:
                    pyatayaPZ3zadacha();
                    break;
                case 22:
                    shestyaPZ1zadacha();
                    break;
                case 23:
                    shestyaPZ2zadacha();
                    break;
                case 24:
                    shestyaPZ3zadacha();
                    break;
                case 25:
                    shestyaPZ4zadacha();
                    break;
                case 26:
                    sedmayaPZ1zadacha();
                    break;
                case 27:
                    sedmayaPZ2zadacha();
                    break;
                case 28:
                    vosmayaPZ1zadacha();
                    break;
                case 29:
                    vosmayaPZ2zadacha();
                    break;
                case 30:
                    task9.taskone();
                    break;
                case 31:
                    task9.tasktwo();
                    break;
                case 32:
                    task9.doubleAverage();
                    break;
                case 33:
                    rect.raschet();
                    break;
                case 34:

                    hospital.Info();
                    break;
                case 35:
                    paral.chetotamosparalegramom();
                    break;
                case 36:
                    Vektor.OperationWithVektoram();
                    break;
                case 37:
                    av.switchauto();
                    break;
                case 38:
                    Figura rectangle = new Rectanglee();
                    Figura circle = new Circle();
                    Figura triangle = new Triangle();

                    rectangle.VivodvsexFigur();         
                    circle.VivodvsexFigur();       
                    triangle.VivodvsexFigur();   
                    break;
                default:
                    Write("Вы выбрали неверный номер задачи еще раз попробуйте");
                    break;

            }
            static void Funkciya() //1 задача 
            {
                ForegroundColor = ConsoleColor.White;
                Console.Write("Введите x: \n");
                double x = Convert.ToInt32(Console.ReadLine());
                double y = 0;
                if (x > Math.PI) y = Math.Sqrt(Math.E + Math.Sqrt(x)) - Math.Cos(x);
                if (1 <= x && x <= 2) y = Math.Pow(x, 2) + Math.Log(x);
                Console.WriteLine($"y = {Math.Round(y, 4)}");
            }
            static void Treugolbnik() //2
            {
                ForegroundColor = ConsoleColor.White;
                Write("Определить является ли треугольник со сторонами a,b,c прямоугольным\n");
                WriteLine("Введите сторону а:\n");
                int a = Convert.ToInt32(Console.ReadLine());
                WriteLine("Введите сторону b:\n");
                int b = Convert.ToInt32(Console.ReadLine());
                WriteLine("Введите сторону c:\n");
                int c = Convert.ToInt32(Console.ReadLine());
                if ((c * c == a * a + b * b))
                {
                    Console.WriteLine("Треугольник существует. Он прямоугольный.");
                }
                else
                {
                    Console.WriteLine("Треугольник существует. Он непрямоугольный.");
                }
            }
            static void GrafikFunc() //3
            {
                ForegroundColor = ConsoleColor.White;
                Write("y\n");
                Write("^\n");
                Write("|\n");
                Write("|\n");
                Write("|\n");
                Write("------------------->x\n");
                Write("|\n");
                Write("|\n");
                Write("|\n");
                Write("|\n");
                Write("|\n");

                int x, y;
                Console.WriteLine("Введите x");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите y");
                y = Convert.ToInt32(Console.ReadLine());
                if (x > 0 && x < 10 && y > 0 && y < 5)
                {
                    Write("На границе");
                }
                if (x < 0 && x > 10 && y < 0 && y > 5)
                {
                    Write("Да");
                }
                else
                {
                    Write("net");
                }
            }
            static void PriznakiTransporta() //4
            {
                ForegroundColor = ConsoleColor.White;
                Write("Дан признак т/с автомобиль(а), велосипед(в), мотоцикл(м), самолет(с), поезд(п) \n");
                Write("Вывести на экран максимальную скорость т/с в зависиммости от введнего признака\n");
                WriteLine("Введите скорость автомобиля\n");
                int speedauto = Convert.ToInt32(Console.ReadLine());
                Write($"Скорость автомобиля = {speedauto} км/ч \n");
                WriteLine("Введите скорость велосипеда \n");
                int speedvel = Convert.ToInt32(Console.ReadLine());
                Write($"Скорость  велосипеда = {speedvel} км/ч \n");
                WriteLine("Введите скорость мотоцикла \n");
                int speedmoto = Convert.ToInt32(Console.ReadLine());
                Write($"Скорость мотоцикла = {speedmoto} км/ч \n");
                WriteLine("Введите скорость самолета \n");
                int speedfly = Convert.ToInt32(Console.ReadLine());
                Write($"Скорость  самолета = {speedfly} км/ч \n");
                WriteLine("Введите скорость поезда \n");
                int speedtrain = Convert.ToInt32(Console.ReadLine());
                Write($"Скорость  поезда = {speedtrain} км/ч \n");
                if (speedauto > speedvel)
                {
                    Write("Автомобиль быстрее велосипеда\n");
                }
                else
                {
                    Write("Автомобиль медленее велосипеда\n");
                }
                if (speedvel > speedmoto)
                {
                    Write("Велосипед быстрее мотоцикла что странно кстати\n");
                }
                else
                {
                    Write("Велосипед медленее мотоцикла\n");
                }
                if (speedmoto > speedfly)
                {
                    Write("Мотоцикл быстрее самолета\n");
                }
                else
                {
                    Write("Мотоцикл медленее самолета\n");
                }
                if (speedfly > speedtrain)
                {
                    Write("Самолет быстрее поезда\n");
                }
                else
                {
                    Write("Самолет медленее поезда\n");
                }
                Write($"Введенные скорости {speedauto}, {speedvel}, {speedmoto}, {speedfly}, {speedtrain} км/ч");
            }
            static void Vklad() //5
            {
                ForegroundColor = ConsoleColor.White;
                Write("известен начальный вклад клиента в банк и процент годового дохода\n");
                Write("определить через сколько лет вклад превысит заданный размер и каков при этом будет размер вклада\n");
                WriteLine("Введите сумму вклада ");
                int vkladik = Convert.ToInt32(Console.ReadLine());
                WriteLine("Введите процент годового дохода");
                int procentik = Convert.ToInt32(Console.ReadLine());
                WriteLine("Введите на сколько дней хотите сделать вклад ");
                int day = Convert.ToInt32(Console.ReadLine());
                int result = (vkladik * procentik * day / 365) / 100;
                int godik = result / 365;
                Write($"Размер вклада будет {result}р. 00коп");
                Write($"Вклад превысит размер через {godik} дней(дня)");
            }
            static void Chess() //6
            {
                ForegroundColor = ConsoleColor.White;
                WriteLine("18. Пусть (k, l), (m, n) - поля шахматной доски: k,\n m - номера по горизонтали; l, n - номера по вертикали (l<k, m, n< 8).\n Определите можно ли с поля (k, l) попасть на поле (m, n) \nодним ходом пешки.");

                WriteLine("Введи натуральное число: ");
                int k = Convert.ToInt32(Console.ReadLine());
                WriteLine("Введи натуральное число: ");
                int m = Convert.ToInt32(Console.ReadLine());
                WriteLine("Введи натуральное число: ");
                int l = Convert.ToInt32(Console.ReadLine());
                WriteLine("Введи натуральное число: ");
                int n = Convert.ToInt32(Console.ReadLine());
                if ((k + l) % 2 == (m + n) % 2)
                {
                    WriteLine("Поля одного цвета пешка пойти сможет");
                }
                else
                {
                    WriteLine("Поля разного цвета не сможет");
                }
            }
            static void Chislo() //7
            {
                ForegroundColor = ConsoleColor.White;
                Console.Write("Введите число k (1 <= k <= 150): ");
                int k = Convert.ToInt32(Console.ReadLine());
                if (k % 3 == 0)
                {

                    Write("Кратно 3");
                }
                else
                {
                    Console.WriteLine("\nk не кратно 3");
                }
                if (k < 101)
                {
                    Write("Неверно");
                    Write("Введите число k(1 <= k <= 150): ");
                }
                if (k > 150)
                {
                    Write("\nНеверно");
                    Write("\nВведите число k(1 <= k <= 150): ");
                }

            }
            static void vtorayaPZ1zadacha() //8
            {
                ForegroundColor = ConsoleColor.White;
                Write("Введите переменную q\n");
                int q = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nС циклом while: \n");
                int i = 10;
                while (i <= q)
                {
                    Console.Write(" " + i);
                    i += 11;
                }
                Console.Write("\nС циклом do while: \n");
                i = 10;
                do
                {
                    Console.Write(" " + i);
                    i += 11;
                }
                while (i <= q);
                Console.Write("\nс циклом For: \n");
                for (i = 10; i <= q; i += 11)
                {
                    Console.Write(" " + i);
                }

            }
            static void vtorayaPZ2zadacha() //9
            {
                ForegroundColor = ConsoleColor.White;
                Write("пирамидка \n");
                for (int q = 0; q <= 4; q++)
                {
                    for (int k = 0; k < q; k++)
                    {
                        Console.Write(q);
                    }
                    Console.WriteLine();
                    for (int k = 0; k < q; k++)
                    {
                        Console.Write(q + 5);
                    }
                    Console.WriteLine();
                }
            }

            static void vtorayaPZ3zadacha() //10
            {
                ForegroundColor = ConsoleColor.White;
                for (int i = 100; i < 1000; i++)
                {
                    bool simple = true;
                    for (int j = 2; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            simple = false;
                            break;
                        }
                    }
                    if (simple)
                        Console.Write(i + " ");
                }
            }

            static void tretayaPZ1zadacha() //11
            {
                ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Введите число: ");
                int N = Convert.ToInt32(Console.ReadLine());
                int minI = 1, maxI = 1, _min = N % 10, _max = N % 10, counter = 1;
                N /= 10;
                while (N > 0)
                {
                    counter++;
                    if (N % 10 > _max)
                    {
                        _max = N % 10;
                        maxI = counter;
                    }
                    if (N % 10 < _min)
                    {
                        _min = N % 10;
                        minI = counter;
                    }
                    N /= 10;
                }
                Console.WriteLine("Считаем позицию числа от разряда единиц, начинаем отсчет с единицы, ищем первое вхождение.");
                Console.WriteLine($"Минимальне число {_min}, его номер по счету {minI}");
                Console.WriteLine($"Максимальное число {_max}, его номер по счету {maxI}");
            }
            static void tretayaPZ2zadacha() //12
            {
                ForegroundColor = ConsoleColor.White;
                int obsheevremya = 0; int obsheeudal = 0; int i = 0;
                Write("Введите номер команды\n");
                int kmd1 = Convert.ToInt32(Console.ReadLine());
                Write("Введите номер команды 2\n");
                int kmd2 = Convert.ToInt32(Console.ReadLine());
                Write($"Введите кол-во удалений для команды № {kmd1}\n");
                int udalenie1 = Convert.ToInt32(Console.ReadLine());
                Write($"Введите кол-во удалений  команды № {kmd2}\n");
                int udalenie2 = Convert.ToInt32(Console.ReadLine());
                Write("Введите время удаления для 1 команды\n");
                int time1 = Convert.ToInt32(Console.ReadLine());
                Write("Введите время удаления для 2 команды\n");
                int time2 = Convert.ToInt32(Console.ReadLine());

            }
            static void tretayaPZ3zadacha() //13
            {

            }
            static void tretayaPZ4zadacha() //14
            {
                ForegroundColor = ConsoleColor.White;
                Write("Введите переменную x");
                double x = Convert.ToDouble(Console.ReadLine());
                Write("П/2(A) = 1,57\n");
                double A = 1.57;
                Write("П(B) = 3,14\n");
                double B = 3.14;
                double H = (B - A) / 20;

                for (double i = 0; i <= 20; i++)
                {
                    Console.WriteLine("F(x)=({0:0.000}) = {1:0.000}", i, pomosh(i));
                }
            }
            static double pomosh(double x) //метод  с параметром double который принимает и возвращает только double
            {
                return Math.Tan(x / 2) + Math.Cos(x);
            }
            static void tretayaPZ5zadacha() //15
            {
                ForegroundColor = ConsoleColor.White;
                double X = 0.62; double E = Math.Pow(10, -3); double a = 0; double k = 0; double s = 0;
                double n = 0;
                a = X;
                while (Math.Abs(a) > E)
                {
                    double perem = 2 / 3 + Math.Sin(X) - 3 / 8 + Math.Sin(X) + Math.Pow(-1, n) + n / Math.Pow(n, 2) - 1;
                    a *= k;
                    s += a;
                    n++;

                }
                Write(n);
                Write(s);


            }
            static void chetvertayaPZ1zadacha() //16 неверная
            {
                ForegroundColor = ConsoleColor.White;
                int[] array = { 123, -23, 999, -3, -228, 231, -32, 555 };
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < 0 && i % 2 != 0)
                    {
                        array[i] = 1;
                        Write($"\n {array[i]}");
                    }
                }
            }
            static void chetvertayaPZ2zadacha() //17
            {
                ForegroundColor = ConsoleColor.White;
                Write("В одномерном массиве, состоящем из n вещественных элементов, вычислить:\n");
                Write("минимальный по модулю элемент массива\n");
                int[] array = { -100, 422, 525, 666, 555, 999, 412, 983 };
                int min = Math.Abs(array.Min());
                Write(min);
                //2 sposob
                //WriteLine(array[0]);
            }
            static void chetvertayaPZ3zadacha() //18
            {
                ForegroundColor = ConsoleColor.White;
                Write("В массиве содержатся результаты измерений температуры воздуха\n которые проводились ежедневно в течение декабря месяца. Определите:\n");
                Write("любые два самых холодных дня;\n");
                int[] myArray = new int[31];
                Random rand = new Random();
                for (int i = 0; i < myArray.Length; i++)
                {
                    myArray[i] = rand.Next(-40, 8);

                }
                Array.Sort(myArray);
                for (int i = 0; i < myArray.Length; i++)
                {
                    Write("\nДень декабря {0} , температура возуха = {1}\n", i + 1, myArray[i]);
                }
                Write("Самые холодные дни с температурой\n");
                Write(myArray[0]);
                Write(myArray[1]);
            }
            static void pyatayaPZ1zadacha() //19
            {
                ForegroundColor = ConsoleColor.White;
                Write("Vvedite кол-во чисел в массиве ");
                int k = 2;
                int n = Convert.ToInt32(Console.ReadLine());
                int[] massiv = new int[n];
                int factorial = 1;
                int kolvo = 0;
                Random rnd = new Random();
                for (int i = 2; i <= k; i++)
                {
                    factorial = factorial * i;
                }
                WriteLine(factorial);
                for (int i = 0; i < massiv.Length; i++)
                {
                    massiv[i] = rnd.Next(20);
                    WriteLine(massiv[i]);
                }
                for (int i = 0; i < massiv.Length; i++)
                {
                    if ((Math.Pow(2, k) < i) || (i < factorial))
                    {
                        kolvo = i + 1;
                    }
                }
                WriteLine("Количество цифр в диапозоне = {0}", kolvo);
            }
            static void pyatayaPZ2zadacha() //20
            {
                ForegroundColor = ConsoleColor.White;
                Random random = new Random();
                int[] array = new int[10];
                WriteLine("Массивчик: ");
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(-100, 666);
                    Console.Write(array[i] + " ");
                }
                Write("\nВведите k1: ");
                int k1 = Convert.ToInt32(Console.ReadLine());
                Write("\nВведите k2: ");
                int k2 = Convert.ToInt32(Console.ReadLine());
                WriteLine("\nПересобранный массивчик ");
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < 0)
                    {
                        array[i] -= k1;
                    }
                    else
                    {
                        array[i] += k2;
                    }
                    Write(array[i] + " ");

                }
            }
            static void pyatayaPZ3zadacha() //21
            {
                ForegroundColor = ConsoleColor.White;
                int[] massivchik = { 20, 30, 15, 16, 17, 18, 19, 13, 21, 22, 23, 24, 25, 26, 27, 28, 29, 14, 31, 32, 33, 34 };
                int[] b = new int[2];
                b[0] = massivchik[0];
                b[1] = massivchik[1];
                int position1 = 0; int position2 = 0;
                for (int i = 0; i < 22; i++)
                {
                    if (b[0] > massivchik[i])
                    {
                        b[0] = massivchik[i];
                        position1 = i + 1;
                    }
                }
                for (int i = 0; i < 2; i++)
                {
                    if (b[1] > massivchik[i])
                    {
                        if (massivchik[i] != b[0])
                        {
                            b[1] = massivchik[i];
                            position2 = i + 1;
                        }
                    }
                }
                Write("Результаты спортсменов пробижавших 100м\n");
                Write($"Первое место занял спортсмен с номером - {position1}, пробежавший за {b[0]}\n");
                Write($"\nВторое место занял спортсмен с номером - {position2}, пробежавший за {b[1]}\n");
            }
            static void shestyaPZ1zadacha() //22
            {
                ForegroundColor = ConsoleColor.White;
                int[,] res = new int[9, 9];
                Random rand = new Random();
                for (int i = 0; i < res.GetLength(0); i++)
                {
                    for (int j = 0; j < res.GetLength(1); j++)
                    {
                        res[i, j] = rand.Next(100);
                    }
                }
                int sum = 0;
                for (int i = 0; i < res.GetLength(0); i++)
                {
                    for (int j = 0; j < res.GetLength(1); j++)
                    {
                        if (res[i, j] % 4 == 0)
                            sum += res[i, j];
                    }
                }
                Console.WriteLine("sum = {0}", sum);
                Console.ReadLine();
            }

            static void shestyaPZ2zadacha() //23 переделать
            {
                ForegroundColor = ConsoleColor.White;
                int matrica = 10;
                int locMin = 0;
                Random random = new Random();

                int[,] array = new int[matrica, matrica];
                for (int i = 0; i < matrica; i++)
                {
                    for (int j = 0; j < matrica; j++)
                    {
                        Console.Write("{0,3}", array[i, j] = random.Next(5, 100));
                    }
                    Console.WriteLine();
                }

                // Подсчет количества локальных минимумов
                Console.WriteLine("\nРасположение локальных минимумов [строка, столбец]:");
                for (int i = 1; i < matrica - 1; i++)
                {
                    for (int j = 1; j < matrica - 1; j++)
                    {
                        if (
                                (array[i, j] < array[i, j - 1]) &&
                                (array[i, j] < array[i - 1, j]) &&
                                (array[i, j] < array[i, j + 1]) &&
                                (array[i, j] < array[i + 1, j])
                            )
                        {
                            locMin++;
                            Console.Write("[{0}, {1}] ", i + 1, j + 1);
                        }
                    }
                }
                Console.WriteLine("\n\nКоличество локальных минимумов: " + locMin);
            }

            static void shestyaPZ3zadacha() //24
            {
                ForegroundColor = ConsoleColor.White;
                double sredoc = 0;
                int[,] arr = new int[20, 10];
                Random rnd = new Random();
                Console.WriteLine("Исходный массивчик:\n");
                Write("Предметы\n");
                Write("Р|М| Ф |М | А |О | У |Л |М |И|\n");
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        arr[i, j] = rnd.Next(0, 6);
                    }
                }
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        sredoc += arr[i, j];
                        Console.Write("{0} |", arr[i, j]);
                    }
                }
                double result = sredoc / arr.Length;
                Write($"\nСредняя оценка ={result}\n");
                Write("Столбцы кол-во предметов\n");
                Write("Cтроки ученик класса с 1 по 20 \n");
            }
            static void shestyaPZ4zadacha() //25
            {

            }
            static void sedmayaPZ1zadacha() //26
            {
                ForegroundColor = ConsoleColor.White;
                Random rnd = new Random();
                int[,] sellTicket = new int[28, 36];
                for (int i = 0; i < sellTicket.GetLength(0); i++)
                {
                    Write("{0}) ", i + 1);
                    for (int j = 0; j < sellTicket.GetLength(1); j++)
                    {
                        sellTicket[i, j] = rnd.Next(0, 2);
                        Write(sellTicket[i, j]);
                    }
                    WriteLine();
                }
            }
            static void sedmayaPZ2zadacha() //27
            {
                ForegroundColor = ConsoleColor.White;
                Random random = new Random();
                Write("Введите кол-во команд\n");
                int str = Convert.ToInt32(Console.ReadLine());
                Write("Введите кол-во матчей\n");
                int sum = 0;
                int madmax = int.MinValue;
                int stb = Convert.ToInt32(Console.ReadLine());
                int[,] champ = new int[str, stb];
                Write("Полученный массив \n");
                for (int i = 0; i < champ.GetLength(0); i++)
                {
                    Write("Команда №{0}: ", i + 1);
                    for (int q = 0; q < champ.GetLength(1); q++)
                    {
                        sum += champ[i, q];
                        champ[i, q] = random.Next(0, 3);
                        Write("{0} ", champ[i, q]);
                        if (sum > madmax)
                        {
                            madmax = sum;
                            WriteLine("max:[{0}]", madmax);
                        }
                    }
                    WriteLine();

                }
                Write("2 – выигрыш, 1 – ничья, 0 – проигрыш");
            }
            static void vosmayaPZ1zadacha() //28
            {
                ForegroundColor = ConsoleColor.White;
                Random rand = new Random();
                int num1, num2;
                Console.Write("введите количество строк массива: ");
                int m = Convert.ToInt32(Console.ReadLine());
                Console.Write("введите количество столбцов массива: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int[,] arr = new int[m, n];

                Console.WriteLine("массив:");
                for (int i = 0; i < m; i++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        arr[i, k] = rand.Next(1, 9);
                        Console.Write(arr[i, k] + " ");
                    }
                    Console.WriteLine();
                }

                while (true)
                {
                    Console.Write("введите первый номер строки: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("введите второй номер строки: ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    if ((num1 < 1) || (num2 < 1)) Console.WriteLine("первую строку считаем с 1");
                    if ((num1 > m) || (num2 > m)) Console.WriteLine("введенное число больше, чем количество строк");
                    if ((num1 >= 1 && num1 <= m) && (num2 >= 1 && num2 <= m)) break;
                }

                for (int i = 0; i < m; i++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        if (i != num1 - 1) continue;
                        int temp = arr[num2 - 1, k];
                        arr[num2 - 1, k] = arr[i, k];
                        arr[i, k] = temp;
                    }
                }
                Console.WriteLine("поменяли:");
                for (int i = 0; i < m; i++)
                {
                    for (int k = 0; k < n; k++) Console.Write(arr[i, k] + " ");
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
            static void vosmayaPZ2zadacha() //29 неверная
            {
                ForegroundColor = ConsoleColor.White;
                Random rand = new Random();
                int count = 0;
                int[] arrayOne = { }; //создание пустого массива
                Console.Write("введите количество строк двумерного массива: ");
                int m = int.Parse(Console.ReadLine());
                Console.Write("введите количество столбцов двумерного массива: ");
                int n = int.Parse(Console.ReadLine());
                int[,] arrayTwo = new int[m, n];
                Console.WriteLine("двумерный массив:");
                for (int i = 0; i < m; i++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        arrayTwo[i, k] = rand.Next(1, 10); //заполнение пустого массива рандомно от 1 до 10
                        Console.Write(arrayTwo[i, k] + " ");
                        if (arrayTwo[i, k] % 2 != 0) continue; //проверка условия на четность и не = 0
                        Array.Resize(ref arrayOne, ++count);  //изменение размера массива
                        arrayOne[count - 1] = arrayTwo[i, k];
                    }
                    Console.WriteLine();
                }

                if (arrayOne.Length == 0)
                {
                    Write("Таких элементов нет");
                }
                else
                {
                    Console.WriteLine("Полученный одномерный массив:");
                    foreach (int i in arrayOne)
                    {
                        Console.Write(i + " ");
                    }
                }

            }
        }
    }
}
