using System;
using Snowdeed.Kivo.Data.Musics;
using Snowdeed.Kivo.Dto;

namespace Snowdeed.Kivo.Services
{
    public static class ArtistExtension
    {
        public static ArtistDto ConvertToArtistDto(this Artist entity)
        {
            if (entity == null)
                return null;

            var artistDto = new ArtistDto()
            {
                Artist_StageName = entity.Artist_StageName,
                Artist_LastName = entity.Artist_LastName,
                Artist_FirstName = entity.Artist_FirstName,
                Artist_Birthday = entity.Artist_Birthday,
                Artist_BirthdayPlace = entity.Artist_BirthdayPlace,
                Artist_IsMan = entity.Artist_IsMan,
                //ArtistFileRowId = entity.ArtistFileRowId
            };

            return artistDto;
        }

        public static Artist ConvertToArtist(this ArtistDto dto)
        {
            if (dto == null)
                return null;

            var artist = new Artist()
            {
                ID = Guid.NewGuid(),
                Artist_StageName = dto.Artist_StageName,
                Artist_LastName = dto.Artist_LastName,
                Artist_FirstName = dto.Artist_FirstName,
                Artist_Birthday = dto.Artist_Birthday,
                Artist_BirthdayPlace = dto.Artist_BirthdayPlace,
                Artist_IsMan = dto.Artist_IsMan,
                //ArtistFileRowId = dto.ArtistFileRowId
            };

            return artist;
        }
    }
}
