using System;
using app1;

class Program
{
    static void Main(string[] args)
    {
          bool kontynuacja = true;
        while (kontynuacja)
        {
            Console.WriteLine("Wybierz ćwiczenie do uruchomienia:");
            Console.WriteLine("1. Lab 1");
            Console.WriteLine("3. Lab 3");
            // Console.WriteLine("4. Ex 4");
            // Console.WriteLine("5. Ex 5");
            // Console.WriteLine("6. Ex 6");
            // Console.WriteLine("7. Ex 7");
            // Console.WriteLine("8. Ex 8");
            Console.WriteLine("0. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    lab1.Run();
                    break;
                // case 2:
                //     lab2.Run();
                //     break;
                case 3:
                    lab3.Run();
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
}
