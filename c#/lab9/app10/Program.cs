using System;

public class KeyPressEvent
{
    public delegate void KeyPressHandler();
    public event KeyPressHandler OnDigit;
    public event KeyPressHandler OnCharacter;

    public void Start()
    {
        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            char keyChar = keyInfo.KeyChar;

            if (char.IsDigit(keyChar))
            {
                OnDigit?.Invoke();
            }
            else if (char.IsLetter(keyChar))
            {
                OnCharacter?.Invoke();
            }
            else
            {
                break;
            }
        }
    }
}

class Program
{
    static void Main()
    {
        KeyPressEvent keyPressEvent = new KeyPressEvent();
        keyPressEvent.OnDigit += () => Console.WriteLine("Naciśnięto cyfrę!");
        keyPressEvent.OnCharacter += () => Console.WriteLine("Naciśnięto literę!");

        keyPressEvent.Start();
    }
}
