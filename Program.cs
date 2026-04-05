using System;

public class SayaMusicTrack
{
    private int id;
    private string playCount;
    private string title;

    public SayaMusicTrack(string title)
    {
        this.title = title;

        Random random = new Random();
        this.id = random.Next(10000, 100000);

        this.playCount = "0";
    }

    public void IncreasePlayCount(int count)
    {
        int currentCount = int.Parse(this.playCount);
        currentCount += count;

        this.playCount = currentCount.ToString();
    }

    public void PrintTrackDetails()
    {
        Console.WriteLine($"ID         : {id}");
        Console.WriteLine($"Title      : {title}");
        Console.WriteLine($"Play Count : {playCount}");
    }
}



class Program
{
    static void Main(string[] args)
    {
        SayaMusicTrack track1 = new SayaMusicTrack("Bohemian Rhapsody");

        Console.WriteLine("Detail Awal:");
        track1.PrintTrackDetails();

        track1.IncreasePlayCount(150);
        track1.IncreasePlayCount(50);

        Console.WriteLine("\nSetelah PlayCount Ditambah:");
        track1.PrintTrackDetails();

        Console.ReadLine();
    }
}