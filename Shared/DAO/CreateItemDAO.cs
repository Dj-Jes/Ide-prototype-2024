using Data.Entities;

namespace Shared.DAO;

public record CreateItemDAO
{
    public int ItemId { get; set; }
    public decimal Weight { get; set; }
    public SorteringCategory SoteringCategory { get; set; }
    public string Type { get; set; }
    public bool IsTaken { get; set; }
    
}