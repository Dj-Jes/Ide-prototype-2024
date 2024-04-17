using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using Shared.DAO;

namespace Data.Entities;



public class Item
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ItemId { get; set; }
    [Required]
    public DateTime CreatedDate { get; set; }
    [Required]
    public decimal Weight { get; set; }
    [Required]
    public SorteringCategory SoteringCategory { get; set; }
    [Required, Length(0,25)]
    public string Type { get; set; }
    public DateTime TakenDate { get; set; }
    [Required]
    public bool IsTaken { get; set; }


    
}