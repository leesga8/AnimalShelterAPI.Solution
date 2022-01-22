using Microsoft.EntityFrameworkCore;

namespace AnimalShelterAPI.Models
{
  public class AnimalShelterAPIContext : DbContext
  {
    public AnimalShelterAPIContext(DbContextOptions<AnimalShelterAPIContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
          .HasData(
              new Animal { AnimalId = 1, Name = "Bob", Species = "Dog", Age = 15, Gender = "Male" },
              new Animal { AnimalId = 2, Name = "Peter", Species = "Cat", Age = 10, Gender = "Male" },
              new Animal { AnimalId = 3, Name = "Jane", Species = "Cat", Age = 2, Gender = "Female" },
              new Animal { AnimalId = 4, Name = "Mary", Species = "Dog", Age = 7, Gender = "Female" },
              new Animal { AnimalId = 5, Name = "John", Species = "Duck", Age = 12, Gender = "Male" }
          );
    }
    public DbSet<Animal> Animals { get; set; }
  }
}