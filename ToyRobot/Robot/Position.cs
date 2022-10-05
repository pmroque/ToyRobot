namespace ToyRobot.Robot
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Direction { get; set; }

        internal Position Clone()
        {
            return new Position()
            {
                X = this.X,
                Y = this.Y,
                Direction = this.Direction
            };
        }

        public override string ToString()
        {
            return $"Output: {this.X},{this.Y},{this.Direction}";
        }
    }
}
