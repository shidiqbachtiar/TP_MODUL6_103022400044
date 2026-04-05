using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace TP_MODUL6_103022400044
{

    public class SayaMusicTrack
    {
        private int id;
        private int playCount;
        private string title;

        public SayaMusicTrack(string title)
        {
            Debug.Assert(title != null, "Title tidak boleh null");
            Debug.Assert(title.Length <= 100, "Title maksimal 100 karakter");

            Random rand = new Random();
            this.id = rand.Next(1000000, 9999999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count <= 10000000, "Penambahan play count maksimal 10 juta");

            try
            {
                checked
                {
                    playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Terjadi overflow pada play count!");
            }
        }

        public void PrintTrackDetails()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Play Count: {playCount}");
        }
    }
}
