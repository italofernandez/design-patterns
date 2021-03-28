namespace Builder.Models.Home.Builders
{
    public class Director
    {
        public IHouseBuilder Builder { get; }
        public Director(IHouseBuilder builder)
        {
            Builder = builder;
        }

        public House BuildCastle()
        {
            Builder.Reset();
            return Builder.BuildDoors(Materials.Iron)
                .BuildFloors(Materials.Stone)
                .BuildWalls(Materials.Stone)
                .BuildWindows(Materials.Iron)
                .Build();
        }
    }
}
