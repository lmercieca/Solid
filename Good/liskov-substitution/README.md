# Liskov Substitution Principle
The Liskov Substitution principle mainly revolves around behaviour of classes.

*Functions that use pointers or references to base classes must be able to use objects of derived classes without knowing it* This means that a parent object of type X for example should be able to be replaced with a child object of type X, but the behaviour must be the same.

## liskov-substitution
Example of a simple shape drawer. The main program simple outputs what shape is being drawn.

### Example one
ShapeProcesser class violates the solid principles in that the DrawShape function is badly formed. It must know about every possible Shape class, and it must be changed whenever new shapes are created.

Square inherits from rectangle as its fair to say in all intents and purposes that a Square is a rectangle, which can lead to a subtle problem. A Square does not need the Rectangle height and width member variables and the setWidth and SetHeight methods as the width and height of a square are identical.

### Example two
In Program.cs a developer creates the method Area which takes a Rectangle sets the height and width and assumes that the result is 20. This is fine if the RectangleBase is a Rectangle but if a Square is passed to the method this is not true.

Is the programmer justified in thinking that changing the width of the rectangle will leave the height unchanged? The Liskov substitution principle highlights these issues and is mainly behaviour driven. A square can be thought of as a Rectangle but a Square is not a rectangle as it’s behaviour is not consistent with that of a Rectangle.

### To run the project
1. Right click on the *liskov-substitution* project and choose "Set as Startup Project" 
3. Press F5, a console window will display the status and the output from the shape processing
