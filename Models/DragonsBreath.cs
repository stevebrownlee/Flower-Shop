namespace FlowerShop {
    public class DragonsBreath : IMothersDay {
        public string Color { get; set; }
        public int PetalCount { get; set; }
        public string Species { get; set; }
        public int SeedCount { get; set; }
        public int Size { get ; set; }

        public override string ToString () {
            return "A ferocious dragonsbreath";
        }

    }
}