using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
	public class AnimalShelterAPIContext : DbContext
	{
		public AnimalShelterAPIContext(DbContextOptions<AnimalShelterAPIContext> options)
			: base(options)
			{
			}
			
			public DbSet<Animal> Animals { get; set; }
	}
}