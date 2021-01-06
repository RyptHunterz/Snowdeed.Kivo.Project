using System;

namespace Snowdeed.Kivo.Dto
{
    public class ArtistDto
    {
        public string Artist_StageName { get; set; }

        public string Artist_LastName { get; set; }

        public string Artist_FirstName { get; set; }

        public DateTime? Artist_Birthday { get; set; }

        public string Artist_BirthdayPlace { get; set; }

        public bool Artist_IsMan { get; set; }

        public DateTime Create_At { get; set; }

        public Guid Create_By { get; set; }
    }
}