using ASolidDrawingApp.Widget;

internal class Program
{
    private static void Main(string[] args)
    {
        // create shapes
        List<WidgetBase> widgets = new List<WidgetBase>
        {
            new RectangleWidget(10, 10, 30, 40),
            new SquareWidget(15, 30, 35),
            new EllipseWidget(100, 150, 300, 200),
            new CircleWidget(1, 1, 300),
            new TextboxWidget(5, 5, 200, 100, "sample text")
        };


        Console.WriteLine("----------------------------------------------------------------\r\nRequested Drawing\r\n----------------------------------------------------------------");
        // draw shapes
        foreach (WidgetBase widget in widgets)
        {
            string output = widget.Draw();
            Console.WriteLine(output);
        }

        Console.WriteLine("----------------------------------------------------------------");
    }
}