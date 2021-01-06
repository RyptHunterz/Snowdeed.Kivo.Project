using System;
using System.ComponentModel.DataAnnotations;

namespace Snowdeed.Kivo.Dto
{
    public class TrackDto
    {
        [Required]
        public string Tracks_Title { get; set; }

        public DateTime Create_At { get; set; }

        public Guid Create_By { get; set; }
    }
}