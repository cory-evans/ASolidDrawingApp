using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASolidDrawingApp.Widget
{
    public class EllipseWidget : WidgetBase
    {
        public int HorizontalDiameter { get; protected set; }
        public int VerticalDiameter { get; protected set; }

        public EllipseWidget(int positionX, int positionY, int horizontalDiameter, int verticalDiameter) : base(positionX, positionY)
        {
            if (horizontalDiameter < 0 || verticalDiameter < 0)
            {
                throw new ArgumentException("Horizontal and vertical diameter must be greater than or equal to 0");
            }

            HorizontalDiameter = horizontalDiameter;
            VerticalDiameter = verticalDiameter;
        }

        public override string Draw()
        {
            return $"Ellipse {Position} diameterH={HorizontalDiameter} diameterV={VerticalDiameter}";
        }
    }
}
