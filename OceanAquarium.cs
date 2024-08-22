using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    internal class OceanAquarium 
    {
        public List<OceanFish> _fishes { get; private set; }
        public OceanFish fishes;
        public enum FishTypes
        {
            Lobster,
            Jellyfish,
            Parrotfish,
            Lionfish,
            GreatWhite

        }
        public FishTypes fishtypes;

        public OceanAquarium()
        {
            _fishes = new List<OceanFish>()
            {
                new OceanFish("Lobster","Commonly found near the pier", "Red"),
                new OceanFish("Jellyfish", "Cute, but venomous and dangerous",  "Light blue"),
                new OceanFish("Parrotfish", "It hunts during the day and sleeps at night in a self-built mucus cocoon", "blue, orange and green"),
                new OceanFish("Lionfish","It likes warm water. Commonly found in the Summer.",  "Yellow"),
                new OceanFish("Great White", "A legendary saltwater fish. The apex predator of the ocean.", "Gray"),
            };
        }
        public void goTo()
        {
            while (true)
            {
                Console.WriteLine("Welcome to the lake aquarium! Please look below for the types of fish, and write it's number to get more info!");
                Console.WriteLine($"1 {FishTypes.Lobster}");
                Console.WriteLine($"2 {FishTypes.Jellyfish}");
                Console.WriteLine($"3 {FishTypes.Parrotfish}");
                Console.WriteLine($"4 {FishTypes.Lionfish}");
                Console.WriteLine($"5 {FishTypes.GreatWhite}");
                var fishMenu = Console.ReadLine();
                if (fishMenu == "1")
                {
                    fishtypes = FishTypes.Lobster;
                    fishes = GetFish("Lobster");
                }
                if (fishMenu == "2")
                {
                    fishtypes = FishTypes.Jellyfish;
                    fishes = GetFish("Jellyfish");

                }
                if (fishMenu == "3")
                {
                    fishtypes = FishTypes.Parrotfish;
                    fishes = GetFish("Parrotfish");
                }
                if (fishMenu == "4")
                {
                    fishtypes = FishTypes.Lionfish;
                    fishes = GetFish("Lionfish");

                }
                if(fishMenu == "5")
                {
                    fishtypes = FishTypes.GreatWhite;
                    fishes = GetFish("Great White");
                }
                seeFish(fishes);
            }
        }
        public void seeFish(OceanFish _fishes)
        {
            while (true)
            {
                Console.WriteLine($"{fishtypes} swims past you");
                Console.WriteLine("Want more info? 1 for yes, 2 to get another fish");
                var input = Console.ReadLine();
                if (input == "1")
                {

                    _fishes.PrintInfo();
                    return;
                }
                else
                {
                    return;
                }
            }
        }
        public OceanFish GetFish(string name)
        {
            foreach (var fishes in _fishes)
            {
                if (fishes.Name == name)
                {
                    return fishes;
                }
            }
            return null;
        }
    }
}





