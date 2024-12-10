using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app1
{
    class lab3
    {
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
            Console.WriteLine("9. Ex 9");
            Console.WriteLine("10. Ex 10");


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
                 case 9:
                    ex9();
                    break;
                case 10:
                    ex10();
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

    struct Point2D
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public void Reset()
        {
            X = 0;
            Y = 0;
        }

        public void IncrX(double dx)
        {
            X += dx;
        }

        public void IncrY(double dy)
        {
            Y += dy;
        }

        public void Print2DPoint()
        {
            Console.WriteLine($"Point: ({X}, {Y})");
        }

        public double Dist(Point2D other)
        {
            return Math.Sqrt(Math.Pow(other.X - X, 2) + Math.Pow(other.Y - Y, 2));
        }
    }    
            static void ex1()
    {
         const double radius = 2.0;
            Point2D[] points = new Point2D[4];

            // Pobieranie współrzędnych dla 4 punktów
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Podaj współrzędne punktu {i + 1}:");
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());
                points[i] = new Point2D(x, y);
            }

            while (true)
            {
                Console.WriteLine("Podaj współrzędne piątego punktu:");
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());

                if (x < 0 || y < 0)
                {
                    Console.WriteLine("Ujemna współrzędna. Koniec programu.");
                    break;
                }

                Point2D fifthPoint = new Point2D(x, y);

                bool insideCircle = false;
                for (int i = 0; i < 4; i++)
                {
                    double distance = fifthPoint.Dist(points[i]);
                    if (distance <= radius)
                    {
                        Console.WriteLine($"Punkt znajduje się wewnątrz okręgu o środku ({points[i].X}, {points[i].Y}) i promieniu {radius}.");
                        insideCircle = true;
                        
                    }
                }

                if (!insideCircle)
                {
                    double minDistance = double.MaxValue;
                    foreach (var point in points)
                    {
                        double distance = fifthPoint.Dist(point);
                        if (distance < minDistance)
                        {
                            minDistance = distance;
                        }
                    }

                    Console.WriteLine($"Punkt nie znajduje się wewnątrz żadnego okręgu. Najbliższa odległość do punktu: {minDistance}");
                }

                   if (insideCircle)
                {
                    break; 
                }
            }

            Console.WriteLine("Współrzędne wszystkich punktów:");
            foreach (var point in points)
            {
                point.Print2DPoint();
            }
            Console.ReadKey();
    }

    //     struct Point2Da
    // {
    //     private double X;
    //     private double Y;

    //     public void SetCoordinates(double x, double y)
    //     {
    //         X = x;
    //         Y = y;
    //     }

    //     public void Print2DaPoint()
    //     {
    //         Console.WriteLine($"Point: ({X}, {Y})");
    //     }
    // }

    //     struct Point2Db
    // {
    //     private double X;
    //     private double Y;

    //     public void SetCoordinates(double x, double y)
    //     {
    //         X = x;
    //         Y = y;
    //     }

    //     public void Print2DbPoint()
    //     {
    //         Console.WriteLine($"Point: ({X}, {Y})");
    //     }
    // }

//     struct Point2Dc
// {
//     private double X;
//     private double Y;

//     // W tym przypadku wystąpi błąd
//     // public Point2D()
//     // {
//     //     X = 0;
//     //     Y = 0;
//     // }
// }
// struct Point2D
// {
//     private double X;
//     private double Y;

//     // Tutaj też wystąpi błąd
//     // private double X = 0; // Błąd kompilacji
//     // private double Y = 0; // Błąd kompilacji

// }
           static void ex2()
    {
        // //a
        // Point2Da point;
        // point.SetCoordinates(2.0, 3.0);  // Ustawienie współrzędnych
        // point.Print2DaPoint();             // Wypisanie współrzędnych

        // // Próba wywołania ToString()
        // Console.WriteLine(point.ToString());

        // //b
        // Point2Db point = new Point2Db();  
        // point.Print2DbPoint();           

        // point.SetCoordinates(5.0, 7.0); 
        // point.Print2DbPoint();           


    }
            static void ex3()
    {
        int intCount = 0;
        int floatCount = 0;
        int stringCount = 0;

            while (true)
            {
                Console.WriteLine("Wprowadź dane (-1 aby zakończyć):");
                string input = Console.ReadLine();

                if (input == "-1")
                {
                    break;
                }

                if (int.TryParse(input, out int intResult))
                {
                    intCount++;
                }

                else if (float.TryParse(input, out float floatResult))
                {
                    floatCount++;
                }

                else
                {
                    stringCount++;
                }
            }

            // Wyświetlanie liczników
            Console.WriteLine($"Liczba wprowadzonych int: {intCount}");
            Console.WriteLine($"Liczba wprowadzonych float: {floatCount}");
            Console.WriteLine($"Liczba wprowadzonych string: {stringCount}");
    }
    enum DaysOfWeek
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
           static void ex4()
    {
            Console.WriteLine("Podaj numer dnia tygodnia (1-7):");
            int dayNumber = Convert.ToInt32(Console.ReadLine());

            // Konwersja numeru na odpowiedni dzień tygodnia
            if (Enum.IsDefined(typeof(DaysOfWeek), dayNumber))
            {
                DaysOfWeek day = (DaysOfWeek)dayNumber;
                Console.WriteLine($"Dzień tygodnia to: {day}");
            }
            else
            {
                Console.WriteLine("Niepoprawny numer dnia tygodnia.");
            }
            Console.ReadKey();
    }
            static void ex5()
    {
        Console.WriteLine("Podaj znak:");
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();

            // Sprawdzanie, czy znak jest samogłoską
            if ("aeiouąęAEIOUĄĘ".IndexOf(input) >= 0)
            {
                Console.WriteLine("To jest samogłoska.");
            }
            // Sprawdzanie, czy znak jest cyfrą
            else if (char.IsDigit(input))
            {
                Console.WriteLine("To jest cyfra.");
            }
            // Jeśli nie, to jest innym znakiem
            else
            {
                Console.WriteLine("To jest inny znak.");
            }
            Console.ReadKey();

    }
           static void ex6()
    {
        Console.WriteLine("Podaj łańcuch znaków:");
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i]);
                if (i < input.Length - 1)
                {
                    Console.Write(" "); // Dodanie spacji po każdym znaku, oprócz ostatniego
                }
            }
            Console.WriteLine();
            Console.ReadKey();

    }
            static void ex7()
    {
        // Przepełnienie podczas kompilacji
        //int maxInt = 2147483647 + 1; 
        // Przepełnienie podczas wykonywania programu
            try
            {
                checked
                {
                    int maxInt = int.MaxValue;
                    Console.WriteLine("Wartość maksymalna int: " + maxInt);
                    int overflowInt = maxInt + 1; 
                    Console.WriteLine("Overflow value: " + overflowInt);
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Błąd przepełnienia podczas wykonywania: " + ex.Message);
            }
            Console.ReadKey();

    }

    public struct Coords
    {
        public int x, y;
        public Coords(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }

    public class Point
    {
        public int x, y;
        public Point(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }
           static void ex8()
    {
        Coords coords = new Coords(1, 2);
            Point point = new Point(1, 2);

            Console.WriteLine($"Before modification: Coords ({coords.x}, {coords.y}), Point ({point.x}, {point.y})");

            Fun1(point);  // Modyfikacja obiektu klasy (typ referencyjny)
            Fun2(coords); // Modyfikacja struktury (typ wartościowy)

            Console.WriteLine($"After modification: Coords ({coords.x}, {coords.y}), Point ({point.x}, {point.y})");

            // Porównanie wartości i referencji
            Coords coords1 = new Coords(1, 2);
            Coords coords2 = new Coords(1, 2);
            Point point1 = new Point(1, 2);
            Point point2 = new Point(1, 2);

            Console.WriteLine("Object.Equals (coords1, coords2): " + Object.Equals(coords1, coords2));  // true
            Console.WriteLine("Object.Equals (point1, point2): " + Object.Equals(point1, point2));  // false
            Console.WriteLine("ReferenceEquals (point1, point2): " + Object.ReferenceEquals(point1, point2));  // false

            Console.ReadKey();
        }

        static void Fun1(Point p)
        {
            p.x = 100;
            p.y = 200;
        }

        static void Fun2(Coords c)
        {
            c.x = 100;
            c.y = 200;
        }   

    
     static int Calculate(string expression)
        {
            int result = 0;
            string number = string.Empty;
            char currentOperator = '+';

            foreach (char c in expression)
            {
                if (char.IsDigit(c))
                {
                    number += c;
                }
                else if (c == '+' || c == '-')
                {
                    result = PerformOperation(result, currentOperator, number);
                    currentOperator = c; // Ustawienie nowego operatora
                    number = string.Empty; // Resetowanie numeru
                }
                else
                {
                    throw new FormatException("Nieprawidłowy znak.");
                }
            }

            result = PerformOperation(result, currentOperator, number); // Ostatnia operacja
            return result;
        }

        static int PerformOperation(int currentResult, char op, string number)
        {
            int num = int.Parse(number);
            return op == '+' ? currentResult + num : currentResult - num;
        }

            static void ex9()
    {
            Console.WriteLine("Podaj wyrażenie (np. 12+2-3):");
            string input = Console.ReadLine();

            try
            {
                int result = Calculate(input);
                Console.WriteLine($"Wynik: {result}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Błędne dane wejściowe: " + ex.Message);
            }
            Console.ReadKey();
    }
           static void ex10()
    {
         // Niejawna konwersja (implicit)
            int intVal = 100;
            double doubleVal = intVal;  // int -> double
            Console.WriteLine($"Niejawna konwersja int na double: {doubleVal}");

            float floatVal = 20.5f;
            double doubleVal2 = floatVal;  // float -> double
            Console.WriteLine($"Niejawna konwersja float na double: {doubleVal2}");

            char charVal = 'A';
            int intFromChar = charVal;  // char -> int
            Console.WriteLine($"Niejawna konwersja char na int: {intFromChar}");

            byte byteVal = 255;
            int intFromByte = byteVal;  // byte -> int
            Console.WriteLine($"Niejawna konwersja byte na int: {intFromByte}");

            // Jawna konwersja (explicit)
            double doubleVal3 = 123.456;
            int intFromDouble = (int)doubleVal3;  // double -> int (utraty danych)
            Console.WriteLine($"Jawna konwersja double na int: {intFromDouble}");

            long longVal = 1234567890;
            int intFromLong = (int)longVal;  // long -> int (utraty danych)
            Console.WriteLine($"Jawna konwersja long na int: {intFromLong}");

            float floatVal2 = 123.45f;
            byte byteFromFloat = (byte)floatVal2;  // float -> byte (utraty danych)
            Console.WriteLine($"Jawna konwersja float na byte: {byteFromFloat}");

            string strNumber = "123";
            int intFromString = int.Parse(strNumber);  // string -> int (konwersja jawna)
            Console.WriteLine($"Jawna konwersja string na int: {intFromString}");
    }


    }
}