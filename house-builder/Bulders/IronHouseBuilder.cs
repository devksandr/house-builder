using house_builder.Enums;

namespace house_builder.Bulders
{
    public class IronHouseBuilder : HouseBuilderAbstract
    {
        public override void BuildFence() => _house.Fence = MaterialTypes.Iron;
        public override void BuildRoof() => _house.Roof = MaterialTypes.Iron;
        public override void BuildWalls() => _house.Walls = MaterialTypes.Iron;
    }
}
