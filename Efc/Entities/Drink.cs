using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities;

public class Drink
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int DrinkId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public double Price { get; set; }
    [Required]
    public double AlcoholPrecentage { get; set; }
    [Required]
    public bool IncludeUmbrella { get; set; }
    
}