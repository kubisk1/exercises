using System;
using System.Collections.Generic;

public class Tree
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Tree(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

public class Fir : Tree
{
    public class Bauble
    {
        public string Color { get; set; }
        public string BaubleType { get; set; }

        public Bauble(string color, string baubleType)
        {
            Color = color;
            BaubleType = baubleType;
        }
    }

    private List<Bauble> baubles;

    public Fir(string name, int age) : base(name, age)
    {
        baubles = new List<Bauble>();
    }

    protected List<Bauble> GetBaubles()
    {
        return baubles;
    }

    public void AddBauble(string color, string baubleType)
    {
        baubles.Add(new Bauble(color, baubleType));
    }

    public void RemoveBauble(int index)
    {
        if (index >= 0 && index < baubles.Count)
        {
            baubles.RemoveAt(index);
        }
    }

    public string? this[int index]
    {
        get
        {
            if (index >= 0 && index < baubles.Count)
            {
                return baubles[index].Color;
            }
            return null;
        }
        set
        {
            if (index >= 0 && index < baubles.Count)
            {
                baubles[index].Color = value;
            }
        }
    }

    public int this[string color]
    {
        get
        {
            int count = 0;
            foreach (var bauble in baubles)
            {
                if (bauble.Color == color)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

public class ChristmasTree : Fir
{
    public ChristmasTree(string name, int age) : base(name, age) { }

    public string this[int index]
    {
        get
        {
            var baublesList = GetBaubles();
            if (index >= 0 && index < baublesList.Count)
            {
                return baublesList[index].BaubleType;
            }
            return null;
        }
        set
        {
            var baublesList = GetBaubles();
            if (index >= 0 && index < baublesList.Count)
            {
                baublesList[index].Color = value;
            }
        }
    }

    public new string? BaubleColor(int index)
    {
        return base[index];
    }
}

public class ChristmasTreeA : ChristmasTree
{
    public ChristmasTreeA(string name, int age) : base(name, age) { }

    public string this[int index]
    {
        get
        {
            var baublesList = GetBaubles();
            if (index >= 0 && index < baublesList.Count)
            {
                return baublesList[index].BaubleType;
            }
            return null;
        }
        set
        {
            var baublesList = GetBaubles();
            if (index >= 0 && index < baublesList.Count)
            {
                baublesList[index].Color = value;
            }
        }
    }

    public new string? BaubleColor(int index)
    {
        return base.BaubleColor(index);
    }
}

public class ChristmasTreeB : ChristmasTreeA
{
    public ChristmasTreeB(string name, int age) : base(name, age) { }

    public string this[int index]
    {
        get
        {
            var baublesList = GetBaubles();
            if (index >= 0 && index < baublesList.Count)
            {
                return $"{baublesList[index].Color}_{baublesList[index].BaubleType}";
            }
            return null;
        }
    }
}

public sealed class ChristmasTreeC : ChristmasTreeB
{
    public ChristmasTreeC(string name, int age) : base(name, age) { }
}

public abstract class Home
{
    public abstract int Price();
}

public class House : Home
{
    private int price;
    public House(int price)
    {
        this.price = price;
    }
    public override int Price()
    {
        return price;
    }
}

public class Apartment : Home
{
    private int price;
    public Apartment(int price)
    {
        this.price = price;
    }
    public override int Price()
    {
        return price;
    }
}

public class Program
{
    public static void Main()
    {

        ChristmasTreeB treeB = new ChristmasTreeB("Pine", 5);
        treeB.AddBauble("red", "star");
        treeB.AddBauble("blue", "ball");
        treeB.AddBauble("green", "angel");

        Console.WriteLine(treeB[0]);  
        Console.WriteLine(treeB[1]);  
        Console.WriteLine(((ChristmasTreeA)treeB)[0]); 

       
        ChristmasTreeC treeC = new ChristmasTreeC("Spruce", 7);
        treeC.AddBauble("gold", "star");
        Console.WriteLine(treeC[0]);  

       
        List<Home> homes = new List<Home>
        {
            new House(100000),
            new Apartment(80000)
        };

        foreach (var home in homes)
        {
            Console.WriteLine($"Home price: {home.Price()}");
        }
    }
    }

