using Data.Entities;

namespace Shared.DAO;

public record CreateItemDAO
{
    public decimal Weight { get; set; }
    public SorteringCategory SoteringCategory { get; set; }
    public string Type { get; set; }

}