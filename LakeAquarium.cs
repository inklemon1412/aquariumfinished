using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    internal class LakeAquarium
    {
       
        
        public List<LakeFish> _fishes { get; private set; }
        public LakeFish fishes;
        public enum FishTypes
        {
            Tigerbarb,
            Tilapia,
            Gatorgar,
            Giantstingray

        }
        public FishTypes fishtypes;

        public LakeAquarium()
        {
            _fishes = new List<LakeFish>()
            {
                new LakeFish("Tiger barb", "A common freshwater fish known for its black stripes.", "Golden"),
                new LakeFish("Tilapia", "A common freshwater fish. Makes for a good meal",  "Green"),
                new LakeFish("Gator gar", "This fish has a long, narrow mouth", "Bronze"),
                new LakeFish("Giant stingray", "A legendary freshwater fish. It’s massive, but it has no bones. The whole body is supported by flexible cartilage.", "Blue"),
            };
        }
        public void goTo()
        {
            while (true)
            {
                Console.WriteLine("Welcome to the lake aquarium! Please look below for the types of fish, and write it's number to get more info!");
                Console.WriteLine($"1 {FishTypes.Tigerbarb}");
                Console.WriteLine($"2 {FishTypes.Tilapia}");
                Console.WriteLine($"3 {FishTypes.Gatorgar}");
                Console.WriteLine($"4 {FishTypes.Giantstingray}");
                var fishMenu = Console.ReadLine();
                if (fishMenu == "1")
                {
                   fishtypes = FishTypes.Tigerbarb;
                    fishes = GetFish("Tiger barb");
                }
                if (fishMenu == "2")
                {
                    fishtypes = FishTypes.Tilapia;
                   fishes = GetFish("Tilapia");

                }
                if (fishMenu == "3")
                {
                    fishtypes = FishTypes.Gatorgar;
                  fishes =  GetFish("Gator gar");
                }
                if (fishMenu == "4")
                {
                    fishtypes = FishTypes.Giantstingray;
                 fishes =  GetFish("Giant stingray");
                   
                }
                seeFish(fishes);
            }
        }
        public void seeFish(LakeFish _fishes)
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
        public LakeFish GetFish(string name)
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