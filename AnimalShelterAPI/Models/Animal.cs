using System.ComponentModel.DataAnnotations;

namespace AnimalShelterApi.Models
{
	public class Animal {
		public int AnimalId { get; set; }
		public string Name { get; set; }
    [Required]
    public string Species { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
	}
}