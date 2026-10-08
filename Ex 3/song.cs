using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_2
{
    internal class song
    {
        private string title = "";
        private string artist = "unknown Artist";
        private int durationSeconds = 1;

        public string Title
        {
            get { return title; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Song title cannot be blank", nameof(value));
                title = value.Trim();
            }
        }

        public string Artist
        {
            get { return artist; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    artist = "unknown Artist";
                else
                    artist = value.Trim();
            }
        }

        public int DurationSeconds
        {
            get { return durationSeconds; }
            set
            {
                if (value < 1 || value > 3600)
                    throw new ArgumentOutOfRangeException(nameof(value), "Duration must be at least 1-3600 second");
                durationSeconds = value;
            }
        }
        public bool IsExplicit { get; set; } = false;

        public song (string title, string artist, int durationSeconds, bool isExplicit)
        {
            Title = title;
            Artist = artist;
            DurationSeconds = durationSeconds;
            IsExplicit = isExplicit;
        }

        public song (string title, string artist, int durationSeconds)
            : this(title, artist, durationSeconds, false)
        {
        }

        public song(string title, int durationSeconds)
            : this(title, "unknown Artist", durationSeconds, false)
        { }


        public string GetFormattedDuration()
        {
            int minutes = DurationSeconds / 60;
            int seconds = DurationSeconds % 60;
            return $"{minutes:D2}:{seconds:D2}";
        }
    }
}
