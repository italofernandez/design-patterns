namespace Builder.Models.Home.Builders
{
    public class HouseBuilder : IHouseBuilder
    {
        public House Product { get; set; }

        public HouseBuilder()
        {
            this.Reset();
        }

        public House Build() => Product;

        public IHouseBuilder BuildDoors(Materials material)
        {
            Product.DoorType = material;
            return this;
        }

        public IHouseBuilder BuildFloors(Materials material)
        {
            Product.FloorType = material;
            return this;
        }

        public IHouseBuilder BuildWalls(Materials material)
        {
            Product.WallType = material;
            return this;
        }

        public IHouseBuilder BuildWindows(Materials material)
        {
            Product.WindowType = material;
            return this;
        }

        public void Reset()
        {
            Product = new House();
        }
    }
}
