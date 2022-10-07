
using System.Numerics;
using Shapes;
using static Shapes.Shape;

Shape[] shapes = new Shape[20];


for (int i = 0; i < shapes.Length; i++)
{
    shapes[i] = Shape.GenerateShape();
    Console.WriteLine(shapes[i]);
}
Console.WriteLine();
Shape.PrintValues();

