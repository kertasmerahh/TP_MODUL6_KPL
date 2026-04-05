using System;
using System.Diagnostics;

public class SayaMusicTrack
{
    private int id;
    private int playCount; 
    private string title;

    public SayaMusicTrack(string title)
    {

        Debug.Assert(title != null, "Title tidak boleh null!");
        Debug.Assert(title.Length <= 100, "Title maksimal 100 karakter!");

        Random rnd = new Random();
        this.id = rnd.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {

        Debug.Assert(count <= 10000000, "Input penambahan maksimal 10.000.000!");

        try
        {

            checked
            {
                this.playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Play count sudah melebihi batas maksimal integer!");
        }
    }

    public void PrintTrackDetails()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
        Console.WriteLine("-------------------------");
    }
}

class Program
{
    static void Main(string[] args)
    {

        SayaMusicTrack lagu1 = new SayaMusicTrack("Hanya Memuji");
        lagu1.IncreasePlayCount(1000);
        lagu1.PrintTrackDetails();

        lagu1.IncreasePlayCount(11000000);

        Console.WriteLine("Testing Overflow...");
        for (int i = 0; i < 300; i++)
        {
            lagu1.IncreasePlayCount(10000000);
        }
        lagu1.PrintTrackDetails();
    }
}