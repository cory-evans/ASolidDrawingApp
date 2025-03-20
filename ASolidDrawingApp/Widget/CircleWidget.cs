namespace ASolidDrawingApp.Widget
{
    public class CircleWidget : WidgetBase
    {
        public int Diameter { get; protected set; }
        public CircleWidget(int positionX, int positionY, int diameter) : base(positionX, positionY)
        {
            if (diameter < 0)
            {
                throw new ArgumentException("Diameter must be greater than or equal to 0");
            }

            Diameter = diameter;
        }

        public override string Draw()
        {
            return $"Circle {Position} size={Diameter}";
        }
    }
}
