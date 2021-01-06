using System;
using System.ComponentModel.DataAnnotations;

namespace Snowdeed.Kivo.Dto
{
    public class AlbumDto
    {
        [Required]
        public string Album_Title { get; set; }

        public DateTime Album_ReleaseDate { get; set; }

        public int Album_RunningLength { get; set; }

        public TimeSpan Album_RunningTime { get; set; }

        [Required]
        public string Album_Studio { get; set; }

        public DateTime Create_At { get; set; }

        public Guid Create_By { get; set; }
    }
}
