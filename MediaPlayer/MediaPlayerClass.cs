using System;
using System.Collections.Generic;
using System.Text;

namespace MediaPlayer
{
    public interface IStreamingDevice
    {
        public string DeviceName { get; set; }  //properties  prop+tab+tab
        public bool IsPlaying { get; set; }    //properties  prop+tab+tab
        public bool IsPaused { get; set; }  //properties  prop+tab+tab
        bool Play();    //methods
        void Pause();   //methods
        void Ffwd();    //methods
        void Rewind();
        bool Stop();
    }
    class MediaPlayerClass
    {
    }
    public class DVDPlayer : IStreamingDevice
    {
        public DVDPlayer()
        {
            DeviceName = "My DVD Player";
            IsPlaying = false;
            IsPaused = false;
        }
        public string DeviceName { get; set; }

        public bool IsPlaying { get; set; }
        public bool IsPaused { get; set; }

        public void Ffwd()
        {
            Console.WriteLine($"\nFfwd {DeviceName}");

        }
        public void Pause()
        {
            //throw new NotImplementedException();
            if (IsPlaying)
            {
                IsPaused = true;
                Console.WriteLine($"\n{DeviceName} paused.");
            }
            else Console.WriteLine($"\nCan't pause. {DeviceName} is not playing.");
        }
        public bool Play()
        {
            Console.WriteLine($"\nPlaying {DeviceName}");
            IsPlaying = true;
            IsPaused = false;
            return IsPlaying;
        }
        public void Rewind()
        {
            Console.WriteLine($"\nRewind {DeviceName}");
        }
        public bool Stop()
        {
          Console.WriteLine($"\n{DeviceName} is now stopped.");
            IsPlaying = false;
            return IsPlaying;
        }
    }
}
