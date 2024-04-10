using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Shared.DAO;

namespace Data.Entities;



public class Item
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ItemId { get; set; }
    [Required]
    public decimal Weight { get; set; }
    [Required]
    public SorteringCategory SoteringCategory { get; set; }
    [Required, Length(0,25)]
    public string Type { get; set; }
    [Required]
    public bool IsTaken { get; set; }


    
}