using house_builder.Bulders;

namespace house_builder.Directors
{
    public class HouseDirector
    {
        HouseBuilderAbstract _houseBuilder;

        public HouseDirector(HouseBuilderAbstract houseBuilder)
        {
            _houseBuilder = houseBuilder;
        }

        public void Construct()
        {
            _houseBuilder.BuildWalls();
            _houseBuilder.BuildRoof();
            _houseBuilder.BuildFence();
        }
    }
}
