using System;
namespace MoviesAPI.DTO
{
	public class ActorDTO
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfbirth { get; set; }
        public string Biography { get; set; }
        public string Picture { get; set; }
    }
}

