namespace Builder.Models
{
    public class House
    {
        public Materials WallType { get; set; }
        public Materials FloorType { get; set; }
        public Materials DoorType { get; set; }
        public Materials WindowType { get; set; }

        public override string ToString()
            => $"This house has\n" +
               $"{WallType}'s walls\n" +
               $"{FloorType}'s floor\n" +
               $"{DoorType}'s doors\n" +
               $"{WindowType}'s windows";
    }

    public enum Materials
    {
        Wood,
        Stone,
        Iron
    }
}
