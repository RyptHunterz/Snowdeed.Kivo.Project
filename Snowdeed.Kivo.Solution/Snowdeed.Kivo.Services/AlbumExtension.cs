namespace Snowdeed.Kivo.Services
{
    using System;
    using Snowdeed.Kivo.Data.Musics;
    using Snowdeed.Kivo.Dto;

    public static class AlbumExtension
    {
        public static AlbumDto ConvertToAlbumDto(this Album entity)
        {
            if (entity == null)
                return null;

            var albumDto = new AlbumDto()
            {
                Album_Title = entity.Album_Title,
                Album_Studio = entity.Album_Studio
            };

            return albumDto;
        }

        public static Album ConvertToAlbum(this AlbumDto dto)
        {
            if (dto == null)
                return null;

            var album = new Album()
            {
                ID = Guid.NewGuid(),
                Album_Title = dto.Album_Title,
                Album_Studio = dto.Album_Studio
            };

            return album;
        }
    }
}