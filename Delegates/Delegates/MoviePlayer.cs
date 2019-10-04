using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    class MoviePlayer
    {
        public string CurrentMovie { get; set; }

        public delegate void MovieFinishedHandler();

        public event MovieFinishedHandler MovieFinished;

        public void PlayMovie()
        {
            Console.WriteLine($"Playing movie {CurrentMovie}");

            Thread.Sleep(3000);


            MovieFinished();
        }
    }
}
