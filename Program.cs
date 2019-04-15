using System;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            FlowerShop GoldenrodFlower = new FlowerShop();

            GoldenrodFlower.MakeMothersDayArrangement()
                .ForEach(flower => Console.WriteLine(flower));

            GoldenrodFlower.MakeBirthdayArrangement()
                .ForEach(flower => Console.WriteLine(flower));
        }
    }
}
