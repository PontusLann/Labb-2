
using System.Numerics;
using Shapes;
using static Shapes.Shape;

Shape[] shapes = new Shape[20];


for (int i = 0; i < shapes.Length; i++)
{
    shapes[i] = Shape.GenerateShape();
    Console.WriteLine(shapes[i]);

}
Enum.GetNames(typeof(AllShapes)).OrderBy(x => x);
Console.WriteLine();
Shape.PrintValues();

//Triangle Triangle = new Triangle(new Vector2(2.4f, 4.2f), new Vector2(1.7f, 7.4f), new Vector2(3.1f, 4.8f));
//
//Console.WriteLine(Triangle);


//Shape.GenerateShape(new Vector3(2.0f, 3.0f, 2.2f));

//for (int i = 0; i < shapes.Length; i++)
//{
//    shapes[i] = Shape.GenerateShape(new Vector3(3.0f, 2.4f, 6.0f));
//    Console.WriteLine(shapes[i]);
//}