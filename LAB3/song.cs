using System;
using System.Collections.Generic;
using System.Text;

namespace LAB3
{
    internal class song
    {
        //data: what a song knows
        public string Title{ get; set; } = "";
        public string Artist { get; set; } = "";
        public int Duration { get; set; }

        bool IsExplicit { get; set; } = true;

        //behaviour: what it can do
        public string GetFormattedDuration()
        {
            int minutes = Duration / 60;
            int seconds = Duration % 60;
            return $"{minutes}:{seconds:D2}";
        }
    }
}
