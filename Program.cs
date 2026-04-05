using TP_MODUL6_103022400044;

class Program
{
    static void Main(string[] args)
    {
        SayaMusicTrack track = new SayaMusicTrack("Lagu Uji");

        for (int i = 0; i < 100; i++)
        {
            track.IncreasePlayCount(10000000);
        }

        track.PrintTrackDetails();
    }
}