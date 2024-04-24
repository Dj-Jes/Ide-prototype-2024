namespace Data.Entities;

public enum Units
{
    Weight,
    Peaces,
    Pallets,
    SquareMeters
}

public class GetReadableUnits
{
    public string GetReadableUnit(Units unit)
    {
        return unit switch
        {
            Units.Weight => "kg",
            Units.Peaces => "pcs",
            Units.Pallets => "pallets",
            Units.SquareMeters => "m2",
            _ => "Unknown"
        };
    }
}