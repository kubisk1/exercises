using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace app1
{
    class lab1
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

        static void ex1()
    {
           Console.WriteLine("Ćw1");
            Console.WriteLine("Hello World!");
             Console.ReadKey();
    }

        static void ex2()
    {
            Console.WriteLine("Ćw2");
            Console.WriteLine("Sum of products:");
            int number_1 = Convert.ToInt32(Console.ReadLine());
            int number_2 = Convert.ToInt32(Console.ReadLine());

            int sum = number_1 + number_2;
            Console.WriteLine($"Sum of products: {number_1} + {number_2} = {sum}");
             Console.ReadKey();
            
            Console.WriteLine("Devision:");
            double num_d1 = Convert.ToDouble(Console.ReadLine());
            double num_d2 = Convert.ToDouble(Console.ReadLine());

                if (num_d2 != 0)
            {
                double res_dev = num_d1 / num_d2;
                Console.WriteLine($"Result: {num_d1} / {num_d2} = {res_dev}");
            }
                else
            {
                Console.WriteLine("Cant devide");
            }
            Console.ReadKey();

            Console.WriteLine("Result of math operations");

            Console.WriteLine($"-1 + 4 * 6 = {-1 + 4 * 6}");
            Console.WriteLine($"(35 + 5) % 7 = {(35 + 5) % 7}");
            Console.WriteLine($"14 + -4 * 6 / 11 = {14 + -4 * 6 / 11}");
            Console.WriteLine($"2 + 15 / 6 * 1 - 7 % 2 = {2 + 15 / 6 * 1 - 7 % 2}");

            Console.ReadKey();

    }

        static void ex3()
    {
         
        Console.WriteLine("Podaj pierwszą liczbę:");
        int liczba1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj drugą liczbę:");
        int liczba2 = int.Parse(Console.ReadLine());


        Console.WriteLine($"Drugi numer: {liczba2}. Pierwszy numer: {liczba1}.");

        Console.ReadKey();

    }

        static void ex4()
    {
              
        Console.WriteLine("Podaj pierwszą liczbę:");
        int liczba1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Podaj drugą liczbę:");
        int liczba2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Podaj trzecią liczbę:");
        int liczba3 = Convert.ToInt32(Console.ReadLine());

        int iloczyn = liczba1 * liczba2 * liczba3;

        Console.WriteLine($"Iloczyn: {liczba3} x {liczba2} x {liczba1} = {iloczyn}");

        Console.ReadKey();


    }
        static void ex5()
    {
       Console.WriteLine("Podaj liczbę do wyświetlenia prostokąta:");
        string number = Console.ReadLine();

        // Draw square
        Console.WriteLine($"{number}{number}{number}{number}");
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine($"{number}  {number}");
        }
        Console.WriteLine($"{number}{number}{number}{number}");

        Console.ReadKey();

    }
        static void ex6()
    {
        int ii = 75400;
        double id = 7.54;


        string formattedString = string.Format("Wartość int to {0}, a wartość double to {1:F2}", ii, id);
        Console.WriteLine(formattedString);


        string concatenatedString = "Cyfra int " + ii + ", a to cyfra double " + id.ToString("F2");
        Console.WriteLine(concatenatedString);


        Console.WriteLine(string.Format("---{0,40}---", ii));
        Console.WriteLine(string.Format("---{0,-40}---", id.ToString("F2")));

      
        int intVal = 57300;
        double doubleVal = 5.73;
        Console.WriteLine(string.Format("{0:c}", intVal));    
        Console.WriteLine(string.Format("{0:d}", intVal));   
        Console.WriteLine(string.Format("{0:e}", doubleVal)); 
        Console.WriteLine(string.Format("{0:f}", doubleVal)); 
        Console.WriteLine(string.Format("{0:r}", doubleVal)); 
        Console.WriteLine(string.Format("{0:x}", intVal));    

        float flo = 220.022f;
        Console.WriteLine(string.Format("{0:0.00000}", flo));
        Console.WriteLine(string.Format("{0:0.0}", flo));
        Console.WriteLine(string.Format("{0:0,0}", flo));
        Console.WriteLine(string.Format("{0:,}", flo));
        Console.WriteLine(string.Format("{0:0%}", flo));
        Console.WriteLine(string.Format("{0:0e+0}", flo));

        double num1 = 123.4, num2 = -1234, num3 = 0;
        Console.WriteLine(string.Format("{0:#,##0.0;(#,##0)Minus;Zero}", num1));
        Console.WriteLine(string.Format("{0:#,##0.0;(#,##0)Minus;Zero}", num2));
        Console.WriteLine(string.Format("{0:#,##0.0;(#,##0)Minus;Zero}", num3));

        DateTime d = DateTime.Now;
        Console.WriteLine(string.Format("{0:d}", d));
        Console.WriteLine(string.Format("{0:D}", d));
        Console.WriteLine(string.Format("{0:t}", d));
        Console.WriteLine(string.Format("{0:T}", d));
        Console.WriteLine(string.Format("{0:f}", d));
        Console.WriteLine(string.Format("{0:F}", d));
        Console.WriteLine(string.Format("{0:g}", d));
        Console.WriteLine(string.Format("{0:G}", d));
        Console.WriteLine(string.Format("{0:M}", d));
        Console.WriteLine(string.Format("{0:r}", d));
        Console.WriteLine(string.Format("{0:s}", d));
        Console.WriteLine(string.Format("{0:u}", d));
        Console.WriteLine(string.Format("{0:U}", d));
        Console.WriteLine(string.Format("{0:Y}", d));

        Console.ReadKey();

    }
        static void ex7()
    {

        Console.WriteLine("Podaj temperaturę w stopniach Celsjusza:");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double kelvin = celsius + 273;
        double fahrenheit = celsius * 18 / 10 + 32;

        Console.WriteLine($"Temperatura w Kelvinach: {kelvin}");
        Console.WriteLine($"Temperatura w Fahrenheicie: {fahrenheit}");

        Console.ReadKey();

    }
        static void ex8()
    {
        
        Console.WriteLine("Podaj pierwszą liczbę:");
        int liczba1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj drugą liczbę:");
        int liczba2 = int.Parse(Console.ReadLine());

        
        bool wynik = (liczba1 < 0 && liczba2 > 0) || (liczba1 > 0 && liczba2 < 0);
        Console.WriteLine(wynik);

        Console.ReadKey();
    }
        }
    }

    
    
      

