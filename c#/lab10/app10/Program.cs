using System;
using System.Threading;

class Program
{
    static bool isRunning = true;

    static void Main(string[] args)
    {
        Console.Clear();

        // Ustawienie wysokości choinki
        int treeHeight = 20;

        // Wątek główny rysujący choinkę
        Thread animationThread = new Thread(() => AnimateTree(treeHeight));
        animationThread.Start();

        Console.WriteLine("naciśnij dowolny klawisz, aby zakończyć...");
        Console.ReadKey();
        isRunning = false;
        animationThread.Join();
    }

    static void AnimateTree(int treeHeight)
    {
        Random random = new Random();
        while (isRunning)
        {
            Console.Clear();

            // Rysowanie choinki linia po linii
            for (int i = 0; i < treeHeight; i++)
            {
                DrawTreeLine(i, treeHeight, random);
            }

            // Rysowanie pnia choinki
            DrawTrunk(treeHeight);

   
            Thread.Sleep(300); 
        }
    }

    static void DrawTreeLine(int line, int treeHeight, Random random)
    {
        // Obliczanie ilości spacji i ozdób
        int spaces = treeHeight - line - 1;
        int ornaments = line * 2 + 1;

        // Rysowanie spacji
        Console.Write(new string(' ', spaces));

        // Rysowanie ozdób
        for (int i = 0; i < ornaments; i++)
        {
            // Losowy wybór znaku ozdoby
            char ornament = GetRandomOrnament(random);
            Console.Write(ornament);
        }

        Console.WriteLine(); 
    }

    static char GetRandomOrnament(Random random)
    {
     
        char[] ornaments = { 'o', '*', '_', '+', 'x', '.', '^', ' ' };
        return ornaments[random.Next(ornaments.Length)];
    }

    static void DrawTrunk(int treeHeight)
    {
        int trunkWidth = treeHeight / 3;
        int trunkHeight = treeHeight / 4;
        int spaces = treeHeight - trunkWidth / 2 - 1;

        for (int i = 0; i < trunkHeight; i++)
        {
            Console.Write(new string(' ', spaces));
            Console.WriteLine(new string('|', trunkWidth));
        }
    }
}
