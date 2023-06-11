using System;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using MoviesAPI.Entities;
using MoviesAPI.Services;

namespace MoviesAPI.Controllers
{
	[Route("api/genres")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class GenresController : ControllerBase
	{
		private readonly IRepository repository;
        private readonly ILogger<GenresController> logger;
		public GenresController(IRepository repository, ILogger<GenresController> logger)
		{
			this.repository = repository;
            this.logger = logger;
		}


		[HttpGet] // api/genres
        [HttpGet("list")] // api/genres/list
        [HttpGet("/allgenres")] // allgenres
        [ResponseCache(Duration = 60)]
		public async Task<ActionResult<List<Genre>>> Get()
		{
            logger.LogInformation("Getting all the genres");
			return await repository.GetAllGenres();
		}

        [HttpGet("{Id:int}")] // api/genres/example
        public ActionResult<Genre> Get(int id, [BindNever] string param2)
        {
            logger.LogDebug("get by Id method executing...");
            var genre = repository.GetGenreById(id);
            if (genre == null)
            {
                logger.LogWarning($"Genre with Id {id} not found");
                logger.LogError("this is an error");
                return NotFound();
            }

            return genre;
        }

        [HttpPost]
		public ActionResult Post([FromBody] Genre genre)
		{
            repository.AddGenre(genre);

            return NoContent();
		}

        [HttpPost]
        public ActionResult Put([FromBody] Genre genre)
        {
            return NoContent();
        }

        [HttpDelete]
        public ActionResult Delete()
        {
            return NoContent();
        }
    }
}

