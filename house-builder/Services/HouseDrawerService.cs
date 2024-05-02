using house_builder.Enums;
using house_builder.Products;

namespace house_builder.Services
{
    public class HouseDrawerService
    {
        private PictureBox _canvas;
        private Dictionary<MaterialTypes, Brush> _materialBrushes;

        private readonly int _size;
        private readonly int _offset;
        private readonly int _sizeDiagonal;
        private readonly Point _startPoint;

        public HouseDrawerService(PictureBox canvas)
        {
            _canvas = canvas;

            _materialBrushes = new Dictionary<MaterialTypes, Brush>
            {
                [MaterialTypes.Iron] = Brushes.Gray,
                [MaterialTypes.Brick] = Brushes.Red,
                [MaterialTypes.Wood] = Brushes.Brown,
            };

            _size = 20;
            _offset = _size / 4;
            _sizeDiagonal = (int)(_size * Math.Sqrt(3));
            _startPoint = new Point(20, 0);
        }

        public void Draw(House house)
        {
            using (Graphics g = _canvas.CreateGraphics())
            {
                g.FillPolygon(_materialBrushes[house.Roof], GetRoofPoints());
                g.FillRectangle(_materialBrushes[house.Walls], GetWallsRectangle());
                g.FillRectangle(_materialBrushes[house.Fence], GetFenceRectangle());
            }
        }
        public void Clear()
        {
            using (Graphics g = _canvas.CreateGraphics())
            {
                g.Clear(_canvas.BackColor);
            }
        }

        private Point[] GetRoofPoints() 
            => [
                _startPoint,
                new Point(_startPoint.X - _size, _startPoint.Y + _sizeDiagonal),
                new Point(_startPoint.X + _size, _startPoint.Y + _sizeDiagonal)
            ];
        private Rectangle GetWallsRectangle()
            => new Rectangle(0, _sizeDiagonal + _offset, _size * 2, _size * 2);
        private Rectangle GetFenceRectangle()
            => new Rectangle(_size * 2 + _offset, _sizeDiagonal + _offset, _size * 4, _size * 2);
    }
}
