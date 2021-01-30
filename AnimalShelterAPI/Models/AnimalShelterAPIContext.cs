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

    protected override void OnModelCreating(ModelBuilder builder)
  {
    builder.Entity<Animal>()
      .HasData(
        new Animal { AnimalId = 1, Name = "Bender", Species = "Dog", Age = 5, Gender = "Male" },
        new Animal { AnimalId = 2, Name = "Chip", Species = "Cat", Age = 3, Gender = "Male" },
        new Animal { AnimalId = 3, Name = "Emma", Species = "Cat", Age = 2, Gender = "Female" },
        new Animal { AnimalId = 4, Name = "Bella", Species = "Dog", Age = 4, Gender = "Female" },
        new Animal { AnimalId = 5, Name = "Perry", Species = "Parrot", Age = 22, Gender = "Male" }
      );
    }
	}
}