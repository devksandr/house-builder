using house_builder.Products;

namespace house_builder.Bulders
{
    public abstract class HouseBuilderAbstract
    {
        protected House _house = new House();

        public abstract void BuildRoof();
        public abstract void BuildWalls();
        public abstract void BuildFence();
        public House GetResult() => _house;
    }
}
