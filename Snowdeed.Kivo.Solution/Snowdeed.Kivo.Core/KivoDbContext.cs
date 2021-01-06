using Snowdeed.FrameworkADO.Core.Core;

namespace Snowdeed.Kivo.Core
{
    using Snowdeed.Kivo.Data;
    using Snowdeed.Kivo.Data.Musics;

    public class KivoDbContext : DbContext
    {
        private DbSet<Album> _album;
        private DbSet<AlbumTrack> _albumTrack;
        private DbSet<Artist> _artist;
        private DbSet<ArtistAlbum> _artistAlbum;
        private DbSet<File> _file;
        private DbSet<FileRow> _fileRow;
        private DbSet<Group> _group;
        private DbSet<GroupAlbum> _groupAlbum;
        private DbSet<GroupArtist> _groupArtist;
        private DbSet<GroupArtistTrack> _groupArtistTrack;
        private DbSet<Track> _track;
        private DbSet<TrackGenre> _trackGenre;
        private DbSet<TrackGenreTrack> _trackGenreTrack;

        public KivoDbContext(string connectionString) : base(connectionString) { }

        public DbSet<Album> Album { get { return _album ?? (_album = new DbSet<Album>(_connection, _database)); } }
        public DbSet<AlbumTrack> AlbumTrack { get { return _albumTrack ?? (_albumTrack = new DbSet<AlbumTrack>(_connection, _database)); } }
        public DbSet<Artist> Artist { get { return _artist ?? (_artist = new DbSet<Artist>(_connection, _database)); } }
        public DbSet<ArtistAlbum> ArtistAlbum { get { return _artistAlbum ?? (_artistAlbum = new DbSet<ArtistAlbum>(_connection, _database)); } }
        public DbSet<File> File { get { return _file ?? (_file = new DbSet<File>(_connection, _database)); } }
        public DbSet<FileRow> FileRow { get { return _fileRow ?? (_fileRow = new DbSet<FileRow>(_connection, _database)); } }
        public DbSet<Group> Group { get { return _group ?? (_group = new DbSet<Group>(_connection, _database)); } }
        public DbSet<GroupAlbum> GroupAlbum { get { return _groupAlbum ?? (_groupAlbum = new DbSet<GroupAlbum>(_connection, _database)); } }
        public DbSet<GroupArtist> GroupArtist { get { return _groupArtist ?? (_groupArtist = new DbSet<GroupArtist>(_connection, _database)); } }
        public DbSet<GroupArtistTrack> GroupArtistTrack { get { return _groupArtistTrack ?? (_groupArtistTrack = new DbSet<GroupArtistTrack>(_connection, _database)); } }
        public DbSet<Track> Track { get { return _track ?? (_track = new DbSet<Track>(_connection, _database)); } }
        public DbSet<TrackGenre> TrackGenre { get { return _trackGenre ?? (_trackGenre = new DbSet<TrackGenre>(_connection, _database)); } }
        public DbSet<TrackGenreTrack> TrackGenreTrack { get { return _trackGenreTrack ?? (_trackGenreTrack = new DbSet<TrackGenreTrack>(_connection, _database)); } }
    }
}