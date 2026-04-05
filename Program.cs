using System;
public class SayaMusicTrack
{
    private int id;
    private int playCount; 
    private string title;

    public SayaMusicTrack(string title)
    {
        Random rnd = new Random();
        this.id = rnd.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        this.playCount += count;
    }

    public void PrintTrackDetails()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        SayaMusicTrack lagu = new SayaMusicTrack("Lagu TP KPL");
        lagu.IncreasePlayCount(100);
        lagu.PrintTrackDetails();
    }
}