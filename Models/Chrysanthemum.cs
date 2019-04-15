namespace FlowerShop
{
    public class Chrysanthemum : IBirthday
    {
        public string Color { get; set; }
        public int PetalCount { get; set; }
        public string Species { get; set; }
        public int FloweredStems { get; set; }

        public override string ToString()
        {
            return "A bountiful chrysanthemum.";
        }

    }
}