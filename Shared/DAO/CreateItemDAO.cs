using Data.Entities;

namespace Shared.DAO;

public record CreateItemDAO
{
    public Units Unit { get; set; }
    public decimal Weight { get; set; }
    public SorteringCategory SoteringCategory { get; set; }
    public string Type { get; set; }

}