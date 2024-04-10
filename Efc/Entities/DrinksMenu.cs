using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities;

public class DrinksMenu
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int DrinkMenuId { get; set; }

    [Required] public string Name { get; set; }
    [Required] public bool ContainsAlcohol { get; set; }
    [Required] public DateTime AvailableFrom { get; set; }
    public List<Drink> Drinks { get; set; }
}