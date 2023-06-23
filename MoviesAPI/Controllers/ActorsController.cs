﻿using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesAPI.DTO;

namespace MoviesAPI.Controllers
{
	[ApiController]
	public class ActorsController : ControllerBase
	{
		private readonly ApplicationDbContext context;
		private readonly IMapper mapper;

		public ActorsController(ApplicationDbContext context, IMapper mapper)
		{
			this.context = context;
			this.mapper = mapper;
		}

		[HttpGet]
		public async Task<ActionResult<List<ActorDTO>>> Get()
		{
			var actors = await context.Actors.ToListAsync();
			return mapper.Map<List<ActorDTO>>(actors);
		}

		[HttpGet("{id:int")]
        public async Task<ActionResult<ActorDTO>> Get(int id)
		{
			var actor = await context.Actors.FirstOrDefaultAsync(x => x.Id == id);

			if (actor == null)
			{
				return NotFound();
			}

			return mapper.Map<ActorDTO>(actor);
		}

		[HttpPost]
		public async Task<ActionResult> Post([FromBody] ActorCreationDTO actorCreationDTO)
		{
			throw new NotImplementedException();
		}

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] ActorCreationDTO actorCreationDTO)
        {
            throw new NotImplementedException();

        }

		[HttpDelete("{id:int")]
		public async Task<ActionResult> Delete(int id)
		{
            var actor = await context.Actors.FirstOrDefaultAsync(x => x.Id == id);

            if (actor == null)
            {
                return NotFound();
            }

			context.Remove(actor);
			await context.SaveChangesAsync();
			return NoContent();
        }
    }
}
