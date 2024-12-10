using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace app5
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
            Console.WriteLine("9. Ex 9");


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


         Console.Write("Podaj liczbę: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Pętla for");
        for(int j = 1; j<=number;j++)
        {
            for(int i =1; i<=j; i++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }

        for(int j = 1; j<=number;j++)
        {
            for(int i =1; i<=j; i++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }

        Console.WriteLine("Pętla while");
                    int row = 1;
            while (row <= number)
            {
                int col = 1;
                while (col <= row)
                {
                    Console.Write(col);
                    col++;
                }
                Console.WriteLine();
                row++;
            }
                    row = 1;
            while (row <= number)
            {
                int col = 1;
                while (col <= row)
                {
                    Console.Write(row);
                    col++;
                }
                Console.WriteLine();
                row++;
            }

                        Console.WriteLine("\nWzór z pętlą do-while:");
            int rowDo = 1;
            do
            {
                int colDo = 1;
                do
                {
                    Console.Write(colDo);
                    colDo++;
                } while (colDo <= rowDo);

                Console.WriteLine();
                rowDo++;
            } while (rowDo <= number);

             rowDo = 1;
            do
            {
                int colDo = 1;
                do
                {
                    Console.Write(rowDo);
                    colDo++;
                } while (colDo <= rowDo);

                Console.WriteLine();
                rowDo++;
            } while (rowDo <= number);
       


        Console.ReadKey();





    }

 
        static void ex2()
    {

        Int32 i = 23;
        object o = i;
        i = 123;
        Console.WriteLine(i + ", " + (Int32) o);
        
        //roztaje wypisane 123, 23, dzieje się tak ponieważ typ object o zawiera dane zmiennej przed zmianą, dlatego
        //rzutowanie zmienia wartość 123 na 23 (unboxing)
        //long j = (long)o;
        // po próbie wykonania tej operacji wyskakuje błąd: 
        //Unhandled exception. System.InvalidCastException: Unable to cast object of type 'System.Int32' to type 'System.Int64'.

    }
        

        static void ex3()
    {


            // 1. Zdefiniowanie zmiennej nullable bez inicjalizacji
            int? nullableInt = null; // jawne przypisanie wartości null

            // Próba wypisania wartości nullableInt bez przypisanej wartości
            Console.WriteLine("Próba wypisania wartości nullableInt:");
            Console.WriteLine(nullableInt.HasValue ? nullableInt.ToString() : "null");

            // 2. Użycie metod GetValueOrDefault i HasValue
            Console.WriteLine("\nUżycie GetValueOrDefault i HasValue:");

            // Użycie HasValue do sprawdzenia, czy zmienna ma wartość
            if (nullableInt.HasValue)
            {
                Console.WriteLine("Zmienna nullableInt ma wartość: " + nullableInt.Value);
            }
            else
            {
                Console.WriteLine("Zmienna nullableInt nie ma przypisanej wartości.");
            }

            // Użycie GetValueOrDefault z podaną wartością domyślną
            Console.WriteLine("Wartość nullableInt lub domyślna (0): " + nullableInt.GetValueOrDefault(0));

            // Pobranie liczby z konsoli
            Console.Write("\nPodaj liczbę: ");
            string input = Console.ReadLine();

            // Użycie TryParse do bezpiecznego parsowania
            if (int.TryParse(input, out int number))
            {
                // 3. Przypisanie wartości do nullableInt i wypisanie jej ponownie
                nullableInt = number;

                Console.WriteLine("\nPo przypisaniu wartości do nullableInt:");

                // Ponowne użycie HasValue
                if (nullableInt.HasValue)
                {
                    Console.WriteLine("Zmienna nullableInt ma wartość: " + nullableInt.Value);
                }
                else
                {
                    Console.WriteLine("Zmienna nullableInt nadal nie ma przypisanej wartości.");
                }

                // Ponowne użycie GetValueOrDefault
                Console.WriteLine("Wartość nullableInt lub domyślna (0): " + nullableInt.GetValueOrDefault(0));
            }
            else
            {
                Console.WriteLine("Podano nieprawidłową wartość lub null.");
            }
        }


    

        static void ex4()
    {
        int? i = null; // Zmienna nullable
            int j = 10;    // Zwykła zmienna int

            // Porównanie za pomocą operatorów <, > i ==
            Console.WriteLine("Porównanie i == j: " + (i == j));   // Porównanie na równość
            Console.WriteLine("Porównanie i < j: " + (i < j));     // Porównanie na mniejsze niż
            Console.WriteLine("Porównanie i > j: " + (i > j));     // Porównanie na większe niż

            // Przypisanie wartości do nullable i ponowne porównanie
            i = 10;
            Console.WriteLine("\nPo przypisaniu wartości 10 do i:");
            Console.WriteLine("Porównanie i == j: " + (i == j));   // Porównanie na równość
            Console.WriteLine("Porównanie i < j: " + (i < j));     // Porównanie na mniejsze niż
            Console.WriteLine("Porównanie i > j: " + (i > j));     // Porównanie na większe niż


    }

        // Deklaracja funkcji `puts` z libc.so.6 dla Linuxa
        [DllImport("libc.so.6", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int puts(string str);

        // Deklaracja funkcji `fflush` z libc.so.6 dla Linuxa
        [DllImport("libc.so.6", CallingConvention = CallingConvention.Cdecl)]
        public static extern int fflush(IntPtr stream);
        static void ex5()
    {

           // Łańcuch do wypisania
            string message = "Hello from P/Invoke in C#!";

            // Wywołanie funkcji puts z P/Invoke
            puts(message);

            // Wywołanie funkcji fflush z argumentem `IntPtr.Zero`, co odpowiada funkcji `_flushall`
            fflush(IntPtr.Zero);

            Console.WriteLine("\nOperacja zakończona.");

    }

    public class Stack
{
    private List<int> _stack = new List<int>();

    public void AddItem(int item)
    {
        _stack.Add(item);
    }

    public void DeleteItem()
    {
        if (_stack.Any())
        {
            _stack.RemoveAt(0);
        }
    }

    public int ShowTheNumberOfItems()
    {
        return _stack.Count;
    }

    public int ShowMinItem()
    {
        return _stack.Min();
    }

    public int ShowMaxItem()
    {
        return _stack.Max();
    }

    public int FindAnItem(int item)
    {
        int index = _stack.IndexOf(item);
        return index == -1 ? -1 : index + 1;
    }

    public void PrintAllItems()
    {
        foreach (var item in _stack)
        {
            Console.WriteLine(item);
        }
    }

    public void ClearAll()
    {
        _stack.Clear();
    }
}

        static void ex6()
    {
        Random random = new Random();
        Stack stack1 = new Stack();
        Stack stack2 = new Stack();
        Stack stack3 = new Stack();

        for (int i = 0; i < 100; i++)
        {
            stack1.AddItem(random.Next(1, 200));
            stack2.AddItem(random.Next(1, 200));
        }

        HashSet<int> evenNumbers = new HashSet<int>();

        foreach (var i in Enumerable.Range(0, 100))
        {
            if (stack1.FindAnItem(i) % 2 == 0)
            {
                evenNumbers.Add(stack1.FindAnItem(i));
            }
            if (stack2.FindAnItem(i) % 2 == 0)
            {
                evenNumbers.Add(stack2.FindAnItem(i));
            }
        }

        foreach (var number in evenNumbers)
        {
            stack3.AddItem(number);
        }

        stack3.PrintAllItems();

    }

    public class Matrix
{
    private int[] _matrix;
    private int c;
    private int l;

    public Matrix(int rows, int cols, int[] values)
    {
        c = cols;
        l = rows;
        _matrix = new int[rows * cols];

        for (int i = 0; i < _matrix.Length; i++)
        {
            if (i < values.Length)
            {
                _matrix[i] = values[i];
            }
            else
            {
                _matrix[i] = 0;
            }
        }
    }

    public void AddElem(int row, int col, int value)
    {
        if (row < l && col < c && row >= 0 && col >= 0)
        {
            _matrix[row * c + col] += value;
        }
    }

    public (int, int) GetSize()
    {
        return (l, c);
    }

    public int[] GetMatrixValues()
    {
        return (int[])_matrix.Clone();
    }

    public static Matrix AddMatrix(Matrix m1, Matrix m2)
    {
        int newRows = Math.Max(m1.l, m2.l);
        int newCols = Math.Max(m1.c, m2.c);
        int[] newValues = new int[newRows * newCols];

        for (int i = 0; i < newRows; i++)
        {
            for (int j = 0; j < newCols; j++)
            {
                int val1 = (i < m1.l && j < m1.c) ? m1._matrix[i * m1.c + j] : 0;
                int val2 = (i < m2.l && j < m2.c) ? m2._matrix[i * m2.c + j] : 0;
                newValues[i * newCols + j] = val1 + val2;
            }
        }
        return new Matrix(newRows, newCols, newValues);
    }
}
        static void ex7()
    {
        //example usecase of class Martix
        


    }


    public class Matrix2D
{
    protected int[][] _matrix;
    protected int c;
    protected int l;

    public Matrix2D(int rows, int cols, int[] values)
    {
        c = cols;
        l = rows;
        _matrix = new int[rows][];
        for (int i = 0; i < rows; i++)
        {
            _matrix[i] = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                int index = i * cols + j;
                _matrix[i][j] = index < values.Length ? values[index] : 0;
            }
        }
    }

    public static Matrix2D Add(Matrix2D m1, Matrix2D m2)
    {
        int rows = Math.Max(m1.l, m2.l);
        int cols = Math.Max(m1.c, m2.c);
        int[] newValues = new int[rows * cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                int val1 = (i < m1.l && j < m1.c) ? m1._matrix[i][j] : 0;
                int val2 = (i < m2.l && j < m2.c) ? m2._matrix[i][j] : 0;
                newValues[i * cols + j] = val1 + val2;
            }
        }
        return new Matrix2D(rows, cols, newValues);
    }

    public static Matrix2D Subtract(Matrix2D m1, Matrix2D m2)
    {
        int rows = Math.Max(m1.l, m2.l);
        int cols = Math.Max(m1.c, m2.c);
        int[] newValues = new int[rows * cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                int val1 = (i < m1.l && j < m1.c) ? m1._matrix[i][j] : 0;
                int val2 = (i < m2.l && j < m2.c) ? m2._matrix[i][j] : 0;
                newValues[i * cols + j] = val1 - val2;
            }
        }
        return new Matrix2D(rows, cols, newValues);
    }
}
        static void ex8()
    {
       
        

    }

    public class Book
{
    public string Title { get; }
    public string Author { get; }
    public double Price { get; }
    public string ISBN { get; }
    public DateTime Date { get; }

    public Book(string title, string author, double price, string isbn, DateTime date)
    {
        Title = title;
        Author = author;
        Price = price;
        ISBN = isbn;
        Date = date;
    }
}

public class BookLibrary
{
    private static readonly BookLibrary _instance = new BookLibrary();
    private List<Book> _books = new List<Book>();

    private BookLibrary() { }

    public static BookLibrary Instance => _instance;

    public void Add(Book book)
    {
        if (_books.All(b => b.ISBN != book.ISBN))
        {
            _books.Add(book);
        }
    }

    public void Remove(string isbn)
    {
        _books.RemoveAll(b => b.ISBN == isbn);
    }

    public Book FindByISBN(string isbn)
    {
        return _books.FirstOrDefault(b => b.ISBN == isbn);
    }

    public List<Book> FindByAuthor(string author)
    {
        return _books.Where(b => b.Author == author).ToList();
    }

    public List<Book> FindByTitle(string title)
    {
        return _books.Where(b => b.Title == title).ToList();
    }

    public List<Book> FindByPrice(double price)
    {
        return _books.Where(b => b.Price == price).ToList();
    }

    public void PrintAllBooks()
    {
        foreach (var book in _books)
        {
            Console.WriteLine($"{book.Title} by {book.Author}, ISBN: {book.ISBN}, Price: {book.Price}");
        }
    }

    public bool ContainsBook(string isbn)
    {
        return _books.Any(b => b.ISBN == isbn);
    }
}
        static void ex9()
        {

        BookLibrary library = BookLibrary.Instance;

        Book book1 = new Book("Title1", "Author1", 29.99, "ISBN001", DateTime.Now);
        Book book2 = new Book("Title2", "Author2", 39.99, "ISBN002", DateTime.Now);

        library.Add(book1);
        library.Add(book2);
        library.PrintAllBooks();

        library.Remove("ISBN001");
        library.PrintAllBooks();

        }

    
        }
    }

    
    
      

