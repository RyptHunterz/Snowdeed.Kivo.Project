using System;

namespace Snowdeed.Kivo.Data.Musics
{
    public class Artist
    {
        public Guid ID { get; set; }

        public bool Active { get; set; }

        public string Artist_StageName { get; set; }

        public string Artist_LastName { get; set; }

        public string Artist_FirstName { get; set; }

        public DateTime? Artist_Birthday { get; set; }

        public string Artist_BirthdayPlace { get; set; }

        public bool Artist_IsMan { get; set; }

        public Guid? ArtistFileRowId { get; set; }
    }
}