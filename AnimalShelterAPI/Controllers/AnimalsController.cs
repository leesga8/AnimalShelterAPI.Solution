using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelterAPI.Models;

namespace AnimalShelterAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private readonly AnimalShelterAPIContext _db;

    public AnimalsController(AnimalShelterAPIContext db)
    {
      _db = db;
    }
    
    // GET api/animals
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Animal>>> Get()
    {
      return await _db.Animals.ToListAsync();
    }

    // POST api/animals
    [HttpPost]
    public async Task<ActionResult<Animal>> Post(Animal animal)
    {
      _db.Animals.Add(animal);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetAnimal), new { id = animal.AnimalId }, animal);
    }

    // GET: api/Animals/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Animal>> GetAnimal(int id)
    {
      var animal = await _db.Animals.FindAsync(id);

      if (animal == null)
      {
        return NotFound();
      }

      return animal;
    }
  }
}