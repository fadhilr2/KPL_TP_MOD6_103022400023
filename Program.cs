using System.Diagnostics; 

public class SayaMusicTrack
{
    private int id;
    private string playCount;
    private string title;

    public SayaMusicTrack(string title)
    {

        Debug.Assert(title != null, "Precondition gagal: Judul track tidak boleh null.");

        Debug.Assert(title.Length <= 100, "Precondition gagal: Judul track maksimal 100 karakter.");

        this.title = title;

        Random random = new Random();
        this.id = random.Next(10000, 100000);

        this.playCount = "0";
    }

    public void IncreasePlayCount(int count)
    {

        Debug.Assert(count <= 10000000, "Precondition gagal: Input penambahan maksimal 10.000.000.");

        try
        {
            int currentCount = int.Parse(this.playCount);

            checked
            {
                currentCount += count;
            }

            this.playCount = currentCount.ToString();
        }
        catch (OverflowException)
        {
            Console.WriteLine($"Gagal menambah {count} ke play count. Telah melebihi batas maksimum integer (Overflow).");
        }
    }

    public void PrintTrackDetails()
    {
        Console.WriteLine($"ID: {id} | Title: {title} | Play Count: {playCount}");
    }
}



class Program
{
    static void Main(string[] args)
    {

        SayaMusicTrack track1 = new SayaMusicTrack("Bohemian Rhapsody");
        track1.PrintTrackDetails();



        for (int i = 1; i <= 216; i++)
        {
            track1.IncreasePlayCount(10000000);

            if (i == 214 || i == 215 || i == 216)
            {
                Console.Write($"Iterasi ke-{i}: ");
                track1.PrintTrackDetails();
            }
        }


    }
}