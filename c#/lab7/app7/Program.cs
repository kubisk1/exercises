using System;
using System.Collections.Generic;

namespace app7
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
                    case 0:
                        kontynuacja = false;
                        break;
                    default:
                        Console.WriteLine("Niepoprawny wybór.");
                        break;
                }
            }
        }

        public interface ICepikData
        {
            string TypPojazdu { get; }
            string Marka { get; }
            int Pojemność { get; }
            int LiczbaMiejsc { get; }
            string VIN { get; }
            string NrRejestracyjny { get; }
            int RokProdukcji { get; }
            string Kolor { get; }
            string PolisaNr { get; }
            string ImieNazwisko { get; }
            string AdresZamieszkania { get; }
            string PESEL { get; }
            string NrPrawaJazdy { get; }
            DateTime DataUzyskaniaPrawaJazdy { get; }
            int RokZakupu { get; }
        }

        public interface IStatData
        {
            string TypPojazdu { get; }
            string Marka { get; }
            int Pojemność { get; }
            int LiczbaMiejsc { get; }
            int RokProdukcji { get; }
        }

        public interface IPoliceData : ICepikData
        {
            int LiczbaPunktowKarnych { get; }
        }

        public class Auto : ICepikData, IStatData, IPoliceData
        {
            // Dane o pojeździe
            public string TypPojazdu { get; set; }
            public string Marka { get; set; }
            public int Pojemność { get; set; }
            public int LiczbaMiejsc { get; set; }
            public string VIN { get; set; }
            public string NrRejestracyjny { get; set; }
            public int RokProdukcji { get; set; }
            public string Kolor { get; set; }
            public string PolisaNr { get; set; }

            // Dane o właścicielu
            public string ImieNazwisko { get; set; }
            public string AdresZamieszkania { get; set; }
            public string PESEL { get; set; }
            public string NrPrawaJazdy { get; set; }
            public DateTime DataUzyskaniaPrawaJazdy { get; set; }
            public int RokZakupu { get; set; }
            public int LiczbaPunktowKarnych { get; set; }

            public Auto(string typPojazdu, string marka, int pojemność, int liczbaMiejsc, string vin, string nrRejestracyjny,
                        int rokProdukcji, string kolor, string polisaNr, string imieNazwisko, string adresZamieszkania, string pesel,
                        string nrPrawaJazdy, DateTime dataUzyskaniaPrawaJazdy, int rokZakupu, int liczbaPunktowKarnych)
            {
                TypPojazdu = typPojazdu;
                Marka = marka;
                Pojemność = pojemność;
                LiczbaMiejsc = liczbaMiejsc;
                VIN = vin;
                NrRejestracyjny = nrRejestracyjny;
                RokProdukcji = rokProdukcji;
                Kolor = kolor;
                PolisaNr = polisaNr;
                ImieNazwisko = imieNazwisko;
                AdresZamieszkania = adresZamieszkania;
                PESEL = pesel;
                NrPrawaJazdy = nrPrawaJazdy;
                DataUzyskaniaPrawaJazdy = dataUzyskaniaPrawaJazdy;
                RokZakupu = rokZakupu;
                LiczbaPunktowKarnych = liczbaPunktowKarnych;
            }
        }

        static void ex1()
        {
            List<ICepikData> cepikDataList = new List<ICepikData>();
            List<IStatData> statDataList = new List<IStatData>();
            List<IPoliceData> policeDataList = new List<IPoliceData>();

            var auto1 = new Auto("Osobowy", "Toyota", 1600, 5, "1HGCM82633A123456", "KR12345", 2015, "Czarny", "POL12345",
                                 "Jan Kowalski", "Kraków, ul. Główna 10", "82010112345", "B1234567", DateTime.Parse("2000-01-01"),
                                 2015, 5);

            cepikDataList.Add(auto1);
            statDataList.Add(auto1);
            policeDataList.Add(auto1);

            Console.WriteLine("Dane ICepikData:");
            foreach (var item in cepikDataList)
                Console.WriteLine($"{item.TypPojazdu}, {item.Marka}, {item.ImieNazwisko}");

            Console.WriteLine("Dane IStatData:");
            foreach (var item in statDataList)
                Console.WriteLine($"{item.TypPojazdu}, {item.Marka}, {item.RokProdukcji}");

            Console.WriteLine("Dane IPoliceData:");
            foreach (var item in policeDataList)
                Console.WriteLine($"{item.ImieNazwisko}, Punkty karne: {item.LiczbaPunktowKarnych}");
        }

         public struct Point2D
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

            // Operator dodawania dwóch punktów
            public static Point2D operator +(Point2D p1, Point2D p2) => new Point2D(p1.X + p2.X, p1.Y + p2.Y);

            // Operator true i false
            public static bool operator true(Point2D p) => p.X != 0 || p.Y != 0;
            public static bool operator false(Point2D p) => p.X == 0 && p.Y == 0;

            // Operator porównania ==
            public static bool operator ==(Point2D p1, Point2D p2) => p1.X == p2.X && p1.Y == p2.Y;
            public static bool operator !=(Point2D p1, Point2D p2) => !(p1 == p2);

            // Operator porównania < i >
            public static bool operator <(Point2D p1, Point2D p2) => p1.X < p2.X && p1.Y < p2.Y;
            public static bool operator >(Point2D p1, Point2D p2) => p2 < p1;

            // Operator inkrementacji
            public static Point2D operator ++(Point2D p) => new Point2D(p.X + 1, p.Y + 1);

            // Operator dekrementacji
            public static Point2D operator --(Point2D p) => new Point2D(p.X - 1, p.Y - 1);


            public static implicit operator Point2D(int x) => new Point2D(x, 0);

            // Explicit conversion to int for the sum of coordinates
            public static explicit operator int(Point2D p) => (int)(p.X + p.Y);
        }

        static void ex2()
        {
                Point2D p1 = new Point2D(2, 3);
            Point2D p2 = new Point2D(3, 4);

            // Dodawanie punktów
            Point2D p3 = p1 + p2;
            p3.Print2DPoint();  

            // Operator true i false
            if (p1) Console.WriteLine("p1 is non-zero"); 

            // Porównanie punktów
            Console.WriteLine(p1 == p2); 

            // Inkrementacja i dekrementacja
            p1++;
            p1.Print2DPoint();  
            p1--;
            p1.Print2DPoint(); 

            // Konwersja implicit z int na Point2D
            Point2D p4 = 5;
            p4.Print2DPoint();  

            // Konwersja explicit do int (suma współrzędnych)
            int suma = (int)p2;
            Console.WriteLine($"Suma współrzędnych p2: {suma}");  
        }

        static void ex3()
        {
             // Zdefiniowanie delegata
            Operation operationDelegate;

            // Tworzenie obiektu kalkulatora i przypisanie metod do delegata
            Calculator calculator = new Calculator();

            operationDelegate = calculator.Add;
            operationDelegate += calculator.Subtract;
            operationDelegate += calculator.Multiply;
            operationDelegate += calculator.Divide;

            // Wywołanie delegata
            operationDelegate.Invoke(10, 2);
        }

        // Delegat i klasa do ćwiczenia 3
        public delegate void Operation(int a, int b);

        public class Calculator
        {
            public void Add(int a, int b) => Console.WriteLine($"Suma: {a + b}");
            public void Subtract(int a, int b) => Console.WriteLine($"Różnica: {a - b}");
            public void Multiply(int a, int b) => Console.WriteLine($"Iloczyn: {a * b}");
            public void Divide(int a, int b) => Console.WriteLine(b != 0 ? $"Iloraz: {a / b}" : "Dzielenie przez zero!");
        
        }
    }
}
