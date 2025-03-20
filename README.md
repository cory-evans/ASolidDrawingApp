# Thoughts during development

How do I "draw" widgets? - For this excercise, they'll be printed to the console but I still need to be able to unit test the output.
- Write directly to the console in the Draw method
- Return a string from the Draw method
- Pass a TextWriter to the Draw method, have some helper to write to the console during execution, but inspect the string in the unit test

Decided to keep things simple for now and return a string from the Draw method.




Widths, heights and diameters must be positive. - Do I make validation part of the base widget class? - For now just throwing an exception in the constructor per implementation.


Rendering the Widget's position is the same across all widgets.
I'm going to use a getter on the base class to return the position as a string.
And use that throughout the derived classes.


Textbox could extend the rectangle class. Maybe it should.


# Explanation & Next Steps

All widgets have a (x, y) position and are to be drawn on an imaginary page.
So it was clear that I could create a base class for all of the widgets to extend.

The `abstract string Draw()` method enforces that all widgets can be rendered to some capacity.

Using a base class means in the Main function, I just have a list of widgets and the program doesn't need to know what type of widget it is.
It can loop over and render them all in one go.

I've used `protected` property setters on my widgets so that derived classes can set the properties but they can't be set from outside the class.

I thought about an `IDrawable` interface but it provides no benefit at this stage over just using an abstract class.
It could be useful in future if there are other classes that are not widgets that need to be drawn.
As a *renderer* only cares about objects that can be drawn, not necessarily widgets that extend `WidgetBase`.


I decided to store the position as seperate x & y properties.
I could create a `Point` class that has an x & y property, and use a `Point` as a widget's position.
It could also be useful for a future Polygon widget which would be made up of a list of points.
For this exercise I saw no reason to create a `Point` class.

I could change the Textbox widget to extend the Rectangle. For now, I'm just going to keep it simple and leave as is.
If I was going to change the Textbox it would look like:
```cs
public class TextboxWidget : RectangleWidget
{
    public string Text { get; protected set; }

    public TextboxWidget(int positionX, int positionY, int width, int height, string text)
        : base(positionX, positionY, width, height)
    {
        Text = text;
    }

    public override string Draw()
    {
        return $"{base.Draw()} text=\"{Text}\"";
    }
}
```