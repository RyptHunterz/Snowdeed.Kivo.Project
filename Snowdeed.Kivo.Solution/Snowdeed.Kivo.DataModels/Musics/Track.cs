using System;

namespace Snowdeed.Kivo.Data
{
    public class Track
    {
        public Guid ID { get; set; }

        public bool Active { get; set; }

        public string Tracks_Title { get; set; }

        public Guid Tracks_FileId { get; set; }
    }
}