using System;
using System.ComponentModel.DataAnnotations;

namespace Snowdeed.Kivo.Dto
{
    public class GroupDto
    {
        [Required]
        public string Group_Name { get; set; }

        public DateTime Create_At { get; set; }

        public Guid Create_By { get; set; }
    }
}
