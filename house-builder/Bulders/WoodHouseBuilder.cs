using house_builder.Enums;

namespace house_builder.Bulders
{
    internal class WoodHouseBuilder : HouseBuilderAbstract
    {
        public override void BuildFence() => _house.Fence = MaterialTypes.Wood;
        public override void BuildRoof() => _house.Roof = MaterialTypes.Wood;
        public override void BuildWalls() => _house.Walls = MaterialTypes.Wood;
    }
}
