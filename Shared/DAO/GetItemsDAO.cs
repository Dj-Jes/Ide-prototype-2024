using Data.Entities;

namespace Shared.DAO;

public class GetItemsDAO
{
    public bool? IsTaken { get; set; }
    public SorteringCategory? SorteringCategory { get; set; }
}