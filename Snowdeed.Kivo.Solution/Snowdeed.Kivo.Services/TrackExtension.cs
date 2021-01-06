using System;
using Snowdeed.Kivo.Data;
using Snowdeed.Kivo.Dto;

namespace Snowdeed.Kivo.Services
{
    public static class TrackExtension
    {
        public static TrackDto ConvertToTrackDto(this Track entity)
        {
            if (entity == null)
                return null;

            var trackDto = new TrackDto()
            {
                Tracks_Title = entity.Tracks_Title
            };

            return trackDto;
        }

        public static Track ConvertToTrack(this TrackDto dto)
        {
            if (dto == null)
                return null;

            var track = new Track()
            {
                ID = Guid.NewGuid(),
                Tracks_Title = dto.Tracks_Title
            };

            return track;
        }
    }
}
