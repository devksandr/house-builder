using house_builder.Enums;

namespace house_builder.Bulders
{
    internal class BrickHouseBuilder : HouseBuilderAbstract
    {
        public override void BuildFence() => _house.Fence = MaterialTypes.Brick;
        public override void BuildRoof() => _house.Roof = MaterialTypes.Brick;
        public override void BuildWalls() => _house.Walls = MaterialTypes.Brick;
    }
}
