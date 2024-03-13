using DesignPatterns.Builder.Builders;
using DesignPatterns.Builder.Directors;

namespace DesignPatterns.Builder
{
    public static class Builder
    {
        public static void GetResult() { 

            HouseDirector director = new HouseDirector();

            IHouse basicHouse = new BasicHouse();
            IHouse premiumHouse = new PremiumHouse();

            director.BuildHouse(basicHouse);
            director.BuildHouse(premiumHouse);

            director.GetHouses();
        
        }
    }
}
