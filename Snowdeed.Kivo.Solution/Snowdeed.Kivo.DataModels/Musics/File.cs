using System;

namespace Snowdeed.Kivo.Data.Musics
{
    public class File
    {
        public Guid ID { get; set; }

        public bool Active { get; set; }

        public Guid File_RowId { get; set; }

        public int File_ServerId { get; set; }

        public string File_Copyright { get; set; }

        public string File_Name { get; set; }
    }
}