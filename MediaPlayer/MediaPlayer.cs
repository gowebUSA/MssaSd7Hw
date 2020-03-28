using System;
using MediaPlayer;

namespace MediaPlayer
{
    class MediaPlayer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Media Player Demo!");

            var mediaPlayer = new DVDPlayer();

            Console.WriteLine($"\tStreaming from: {mediaPlayer.DeviceName}.");

            while (true)
            {
                Console.WriteLine("\tPush Up-Arrow to Play");
                Console.WriteLine("\tPush [Spacebar] to Stop");
                Console.WriteLine("\tPush  F  to Ffwd");
                Console.WriteLine("\tPush  R  to Rewind");
                Console.WriteLine("\tPush  P  to Pause");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.RightArrow:
                        mediaPlayer.Ffwd();
                        break;
                    case ConsoleKey.LeftArrow:
                        mediaPlayer.Rewind();
                        break;
                    case ConsoleKey.Spacebar:
                        mediaPlayer.Stop();
                        break;
                    case ConsoleKey.DownArrow:
                        mediaPlayer.Pause();
                        break;
                    case ConsoleKey.UpArrow:
                        mediaPlayer.Play();
                        break;

                }
            }

        }
    }
}
