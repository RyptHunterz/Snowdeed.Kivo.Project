using System;

namespace Snowdeed.Kivo.Data.Musics
{
    public class Group
    {
        public Guid ID { get; set; }

        public bool Active { get; set; }

        public string Group_Name { get; set; }

        public Guid Groups_FileId { get; set; }
    }
}