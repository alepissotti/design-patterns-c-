using DesignPatterns.Builder.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Builders
{
    public class PremiumHouse : IHouse
    {
        private readonly HouseProduct _HouseProduct;
        public PremiumHouse()
        {
            _HouseProduct = new HouseProduct();
        }

        public void BuildDoors()
        {
            _HouseProduct.Doors = 8;
        }

        public void BuildGarden()
        {
            _HouseProduct.HasGarden = true;
        }

        public void BuildWalls()
        {
            _HouseProduct.Walls = 64;
        }

        public string GetHouse()
        {
            return _HouseProduct.GetProduct();
        }
    }
}
