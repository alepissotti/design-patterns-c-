using DesignPatterns.Builder.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Builders
{
    public interface IHouse
    {
        void BuildDoors();
        void BuildWalls();
        void BuildGarden();
        string GetHouse();
    }
}
