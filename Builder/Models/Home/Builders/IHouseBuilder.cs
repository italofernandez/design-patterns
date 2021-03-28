namespace Builder.Models.Home.Builders
{
    public interface IHouseBuilder : IBuilder<House>
    {
        IHouseBuilder BuildWalls(Materials material);
        IHouseBuilder BuildFloors(Materials material);
        IHouseBuilder BuildDoors(Materials material);
        IHouseBuilder BuildWindows(Materials material);
    }
}
