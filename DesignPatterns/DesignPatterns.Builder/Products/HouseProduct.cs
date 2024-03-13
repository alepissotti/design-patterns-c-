using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Products
{
    public class HouseProduct
    {
        public int Doors { get; set; }
        public int Walls { get; set; }
        public bool HasGarden { get; set; }

        public string GetProduct() {
            return $"Doors: {Doors}, Walls: {Walls}, Has Garden?: {(HasGarden ? "Yes" : "No")}";
        }
    }
}
