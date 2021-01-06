using System;

namespace Snowdeed.Kivo.Data.Musics
{
    public class Album
    {
        public Guid ID { get; set; }

        public bool Active { get; set; }

        public Guid Album_FileId { get; set; }

        public string Album_Title { get; set; }

        public string Album_Studio { get; set; }
    }
}