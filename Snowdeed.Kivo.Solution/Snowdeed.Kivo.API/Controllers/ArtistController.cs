using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Snowdeed.Kivo.API.Controllers
{
    using System.Linq;
    using Snowdeed.Kivo.Core;
    using Snowdeed.Kivo.Dto;
    using Snowdeed.Kivo.Services;

    [Route("api/[controller]")]
    public class ArtistController : Controller
    {
        public IConfiguration Configuration { get; }

        public ArtistController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        [HttpGet]
        public IEnumerable<ArtistDto> Get()
        {
            using (KivoDbContext context = new KivoDbContext(Configuration.GetConnectionString("DefaultConnection")))
            {
                return context.Artist.GetAll().Select(s => s.ConvertToArtistDto());
            }
        }

        [HttpPost]
        public int Post(ArtistDto value)
        {
            using (KivoDbContext context = new KivoDbContext(Configuration.GetConnectionString("DefaultConnection")))
            {
                return context.Artist.Add(value.ConvertToArtist());
            }
        }

        [HttpPut]
        public int Update(ArtistDto value)
        {
            using (KivoDbContext context = new KivoDbContext(Configuration.GetConnectionString("DefaultConnection")))
            {
                return context.Artist.Udpate(value.ConvertToArtist());
            }
        }
    }
}
