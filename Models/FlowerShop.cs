using System.Collections.Generic;

namespace FlowerShop
{
    public class FlowerShop
    {
        public string ShopName { get; set; }
        public string OpeningTime { get; set; }
        public string ClosingTime { get; set; }

        public List<Rose> Roses { get; set; } = new List<Rose>();
        public List<Tulip> Tulips { get; set; } = new List<Tulip>();
        public List<DragonsBreath> DragonsBreaths { get; set; } = new List<DragonsBreath>();
        public List<Chrysanthemum> Chrysanthemums { get; set; } = new List<Chrysanthemum>();

        public List<IMothersDay> MakeMothersDayArrangement () {
            List<IMothersDay> arrangement = new List<IMothersDay>() {
                new Tulip() { Size = 2 },
                new Tulip() { Size = 2 },
                new Tulip() { Size = 2 },
                new DragonsBreath() { Size = 4 },
                new DragonsBreath() { Size = 4 },
            };

            return arrangement;
        }

        public List<IBirthday> MakeBirthdayArrangement () {
            List<IBirthday> arrangement = new List<IBirthday>() {
                new Rose() { },
                new Rose() { },
                new Rose() { },
                new Chrysanthemum() { },
                new Chrysanthemum() { },
            };

            return arrangement;
        }
    }
}