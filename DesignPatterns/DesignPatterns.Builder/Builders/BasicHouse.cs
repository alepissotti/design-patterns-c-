using DesignPatterns.Builder.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Builders
{
    public class BasicHouse : IHouse
    {
        private readonly HouseProduct _HouseProduct;

        public BasicHouse()
        {
            _HouseProduct = new HouseProduct();
        }

        public void BuildDoors()
        {
            _HouseProduct.Doors = 2;
        }

        public void BuildGarden()
        {
            _HouseProduct.HasGarden = false;
        }

        public void BuildWalls()
        {
            _HouseProduct.Walls = 4;
        }

        public string GetHouse()
        {
            return _HouseProduct.GetProduct();
        }
    }
}
