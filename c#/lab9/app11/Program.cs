using System;
using System.Runtime.InteropServices;

public class DisposeExample : IDisposable
{
  
    private IntPtr unmanagedMemory;
    private bool disposed = false;

    public DisposeExample(int size)
    {
        unmanagedMemory = Marshal.AllocHGlobal(size);
        Console.WriteLine($"Alokowano {size} bajtów pamięci niezarządzanej.");
    }

    ~DisposeExample()
    {
        Dispose(false);
    }
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                Console.WriteLine("Zwolnienie zasobów zarządzanych.");
                // Przykład: components.Dispose();
            }


            if (unmanagedMemory != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(unmanagedMemory);
                unmanagedMemory = IntPtr.Zero;
                Console.WriteLine("Zwolniono pamięć niezarządzaną.");
            }

            disposed = true;
        }
    }
}

class Program
{
    static void Main()
    {
        using (DisposeExample example = new DisposeExample(100))
        {
            Console.WriteLine("Korzystanie z obiektu DisposeExample.");
        }

        Console.WriteLine("Obiekt DisposeExample został zwolniony.");
    }
}
