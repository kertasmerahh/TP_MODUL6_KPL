using System;
using System.Diagnostics;
public class SayaMusicTrack
{
    private int id;
    private int playCount; 
    private string title;

    public SayaMusicTrack(string title)
    {
        RDebug.Assert(title != null, "Judul tidak boleh null");
        Debug.Assert(title.Length <= 100, "Judul maksimal 100 karakter");

        Random rnd = new Random();
        this.id = rnd.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        
        Debug.Assert(count <= 10000000, "Input maksimal 10 juta");

        try
        {
            checked
            { 
                this.playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Play count melebihi batas maksimal!");
        }
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