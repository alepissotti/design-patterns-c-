using DesignPatterns.Builder.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Directors
{
    public class HouseDirector
    {
        private readonly List<IHouse> _Houses;

        public HouseDirector()
        {
            _Houses = new List<IHouse>();
        }

        public void BuildHouse(IHouse house) {
            
            house.BuildWalls();
            house.BuildDoors();
            house.BuildGarden();

            _Houses.Add(house);
        }

        public void GetHouses()
        {
            Console.WriteLine("Houses buildeds: ");
            
            foreach (var house in _Houses) {
                Console.WriteLine(house.GetHouse());
            }
        }
    }
}
