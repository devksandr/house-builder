using house_builder.Enums;

namespace house_builder.Bulders
{
    public class StandartHouseBuilder : HouseBuilderAbstract
    {
        public override void BuildFence() => _house.Fence = MaterialTypes.Iron;
        public override void BuildRoof() => _house.Roof = MaterialTypes.Wood;
        public override void BuildWalls() => _house.Walls = MaterialTypes.Brick;
    }
}
