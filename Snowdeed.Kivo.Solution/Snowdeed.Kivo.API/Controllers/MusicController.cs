using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Snowdeed.Kivo.API.Controllers
{
    using Snowdeed.Kivo.Core;
    using Snowdeed.Kivo.Dto;
    using Snowdeed.Kivo.Services;

    [Route("api/music")]
    public class MusicController : Controller
    {
        public IConfiguration Configuration { get; }

        public MusicController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        [HttpPost]
        [Route("addgroup")]
        public int AddGroup(GroupDto value)
        {
            if (ModelState.IsValid)
            {
                using (KivoDbContext context = new KivoDbContext(Configuration.GetConnectionString("DefaultConnection")))
                {
                    return context.Group.Add(value.ConvertToGroup());
                }
            }

            return 0;
        }

        [HttpPost]
        [Route("addartist")]
        public int AddArtist(ArtistDto value)
        {
            if(ModelState.IsValid)
            {
                using (KivoDbContext context = new KivoDbContext(Configuration.GetConnectionString("DefaultConnection")))
                {
                    return context.Artist.Add(value.ConvertToArtist());
                }
            }

            return 0;
        }

        [HttpPost]
        [Route("addalbum")]
        public int AddAlbum(AlbumDto value)
        {
            if(ModelState.IsValid)
            {
                using(KivoDbContext context = new KivoDbContext(Configuration.GetConnectionString("DefaultConnection")))
                {
                    return context.Album.Add(value.ConvertToAlbum());
                }
            }

            return 0;
        }

        [HttpPost]
        [Route("addtrack")]
        public int AddTrack(TrackDto value)
        {
            if(ModelState.IsValid)
            {
                using (KivoDbContext context = new KivoDbContext(Configuration.GetConnectionString("DefaultConnection")))
                {
                    return context.Track.Add(value.ConvertToTrack());
                }
            }

            return 0;
        }
    }
}