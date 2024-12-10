using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Lab4
{
    class Program
    {

        public static void Main(string[] args) 
        {
            Run();
        }


        public static void Run()
        {
         bool kontynuacja = true;
        while (kontynuacja)
        {
            Console.WriteLine("Wybierz ćwiczenie do uruchomienia:");
            Console.WriteLine("1. Ex 1");
            Console.WriteLine("2. Ex 2");
            Console.WriteLine("3. Ex 3");
            Console.WriteLine("4. Ex 4");
            Console.WriteLine("5. Ex 5");
            Console.WriteLine("6. Ex 6");
            Console.WriteLine("7. Ex 7");
            Console.WriteLine("8. Ex 8");


            Console.WriteLine("0. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ex1();
                    break;
                case 2:
                    ex2();
                    break;
                case 3:
                    ex3();
                    break;
                case 4:
                    ex4();
                    break;
                case 5:
                    ex5();
                    break;
                case 6:
                    ex6();
                    break;
                case 7:
                    ex7();
                    break;
                case 8:
                    ex8();
                    break;

                case 0:
                    kontynuacja = false;
                    break;
                default:
                    Console.WriteLine("Niepoprawny wybór.");
                    break;
            }
        }


    }

    static void Fun1(in int i)
    {
     //   int i += 100;
        Console.WriteLine($"Wewnątrz funkcji 1: {i}");
    }

   static void Fun2(out int i)
    {
         i = 100;
        Console.WriteLine($"Wewnątrz funkcji 2: {i}");

    }

    static void Fun3(ref int i)
    {
         i +=100;
        Console.WriteLine($"Wewnątrz funkcji 3: {i}");
    }

    static void Fun4(int i)
    {
         i += 100;
        Console.WriteLine($"Wewnątrz funkcji 4: {i}");
    }

    public class Point
    {
        public int x, y;

       
        public Point(int p1, int p2)
        {
            x = p1;
            y = p2;
        }

        public override string ToString()
        {
            return $"x: {x}, y: {y}";
        }
    }

    public static void Fun5(Point p)
    {
        // Tworzymy nowy obiekt Point i przypisujemy go do parametru p
        p = new Point(20, 30); 
        Console.WriteLine("Wartości wewnątrz Fun5: " + p.ToString());

        // Przypisujemy do obiektu wskaźnik null
        p = null;
    }

    public static void Fun6(ref Point p)
    {
        // Tworzymy nowy obiekt Point i przypisujemy go do parametru p
        p = new Point(40, 50); 
        Console.WriteLine("Wartości wewnątrz Fun6: " + p.ToString());

        // Przypisujemy do obiektu wskaźnik null
        p = null;
    }


        static void ex1()
    {
        int x = 10;
        Console.WriteLine($"Przed wywołaniem {x}");
        Fun1(x);
        Console.WriteLine($"Po wywołaniu {x}");

        int y;
        Fun2(out y);
        Console.WriteLine($"Po wywołaniu {y}");

        Console.WriteLine($"Przed wywołaniem {x}");
        Fun3(ref x);
        Console.WriteLine($"Po wywołaniu {x}");

        Console.WriteLine($"Przed wywołaniem {x}");
        Fun4(x);
        Console.WriteLine($"Po wywołaniu {x}");

        short s = 5;
        Console.WriteLine($"Przed wywołaniem {s}");
        Fun4(s);
        Console.WriteLine($"Po wywołaniu {s}");

        Console.ReadKey();

        // Tworzymy obiekt Point
        Point point1 = new Point(5, 10);
        Point point2 = new Point(15, 20);

        Console.WriteLine("Przed wywołaniem Fun5: " + point1.ToString());
        Fun5(point1);

        Console.WriteLine("Po wywołaniu Fun5: " + (point1 != null ? point1.ToString() : "null"));

        Console.WriteLine("Przed wywołaniem Fun6: " + point2.ToString());
        Fun6(ref point2);

        Console.WriteLine("Po wywołaniu Fun6: " + (point2 != null ? point2.ToString() : "null"));

        Console.ReadKey();



    }

    public unsafe void swap (int* p, int *q)
    {
        int temp = *p;
        *p = *q;
        *q = temp;
    }

    public static unsafe void ex2()
    {
        int[] list = {10, 100, 200};
        fixed(int *ptr = list)
        for ( int i = 0; i < 3; i++) {
        Console.WriteLine("Adres [{0}]={1}",i,(int)(ptr + i));
        Console.WriteLine("Wartość[{0}]={1}", i, *(ptr + i));
        }
        Console.ReadKey();

        //po usunięciu unsafe pojawiają się błędy
        
    }
        

        static void ex3()
    {
        int[] tablica = new int[10];

        for (int i = 0; i < tablica.Length; i++)
        {
            tablica[i] = i + 1;
        }

        Console.WriteLine("Podaj indeks (0-9), pod który chcesz wstawić nowy element:");
        int indeks = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Podaj wartość, którą chcesz wstawić:");
        int nowaWartosc = Convert.ToInt32(Console.ReadLine());

        // Wstawianie elementu i przesunięcie pozostałych
        for (int i = tablica.Length - 1; i > indeks; i--)
        {
            tablica[i] = tablica[i - 1];
        }
        tablica[indeks] = nowaWartosc;

        // Wyświetlanie zmodyfikowanej tablicy
        Console.WriteLine("Zmodyfikowana tablica:");
        foreach (var item in tablica)
        {
            Console.Write(item + " ");
        }
         


    }

        static void ex4()
    {
        int[] tablica = new int[5];

        for(int i =0; i <5; i++)
        {
            Console.WriteLine("Podaj liczbę:");
            tablica[i] = Convert.ToInt32(Console.ReadLine());

        }

            Console.WriteLine("Odwrócona tablica");
        for (int i = tablica.Length-1; i >=0; i--)
        {
            Console.WriteLine(tablica[i] + " ");
        }


    }
        static void ex5()
    {
        int[] tablica = { 1, 2, 2, 3, 3 };

        int liczbaPowtorzen = 0;

        // Zliczanie powtarzających się liczb
        for (int i = 0; i < tablica.Length; i++)
        {
            for (int j = i + 1; j < tablica.Length; j++)
            {
                if (tablica[i] == tablica[j])
                {
                    liczbaPowtorzen++;
                    break;
                }
            }
        }

        Console.WriteLine($"Liczba powtarzających się liczb: {liczbaPowtorzen}");

    }

        static void ex6()
    {
        int[,] tablica1 = new int[5, 5];
        int[,] tablica2 = new int[5, 5];
        int[,] wynik = new int[5,5];

        Random rand = new Random();

        for(int i =0; i<5;i++)
        {
            for(int j =0; j<5; j++)
            {
                tablica1[i,j] = rand.Next(1,10);
                tablica2[i,j] = rand.Next(1,10);
                wynik[i,j] = tablica1[i,j]+tablica2[i,j];
                Console.Write(wynik[i, j] + " ");

            }
            Console.WriteLine();
        }
        Console.WriteLine("Właściwości tablicy wynikowej:");
        Console.WriteLine($"Length: {wynik.Length}");
        Console.WriteLine($"LongLength: {wynik.LongLength}");
        Console.WriteLine($"Rank: {wynik.Rank}");
    }
        static void ex7()
    {
        int[,] macierz = {
            { 1, 0, -1 },
            { 0, 0, 1 },
            { -1, -1, 0 }
        };

        // Obliczenie wyznacznika macierzy 3x3
        int wyznacznik = macierz[0, 0] * macierz[1, 1] * macierz[2, 2] + macierz[1, 0] * macierz[2, 1] * macierz[0, 2]
                       + macierz[2,0] * macierz[0, 1] * macierz[1, 2] - macierz[0, 2] * macierz[1, 1] * macierz[1, 0]
                       - macierz[1, 2] * macierz[2, 1] * macierz[0, 0] - macierz[2, 2] * macierz[0, 1] * macierz[1, 0];

        Console.WriteLine($"Wyznacznik macierzy wynosi: {wyznacznik}");

    }
        static void ex8()
    {
        int[][] tablica = new int[5][];
        
        // Inicjalizacja tablicy z różną liczbą kolumn w każdym wierszu
        tablica[0] = new int[] { 1, 2, 3 };
        tablica[1] = new int[] { 4, 5, 6, 7, 8, 9 };
        tablica[2] = new int[] { 10, 11, 12, 13 };
        tablica[3] = new int[] { 14, 15, 16, 17, 18 };
        tablica[4] = new int[] { 19, 20, 21 };

        // Wypisanie tablicy w konsoli
        for (int i = 0; i < tablica.Length; i++)
        {
            for (int j = 0; j < tablica[i].Length; j++)
            {
                Console.Write(tablica[i][j] + " ");
            }
            Console.WriteLine(); 
        }
        

    }
        }
    }

    
    
      

