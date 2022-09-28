using Shapes;
using System.Numerics;


Circle newC = new Circle(new Vector2(3.0f, 4.0f), 2.0f);
Console.WriteLine(newC);
Rectangle newR = new Rectangle(new Vector2(2.0f, 1.0f), 5.0f);
Console.WriteLine(newR);
Sphere newS = new Sphere(new Vector3(4.0f, 3.0f, 5.0f), 3.5f);
Console.WriteLine(newS);
Cuboid newCu = new Cuboid(new Vector3(3.0f, 4.0f, 2.0f), new Vector3(3.0f, 3.0f, 3.0f));
Console.WriteLine(newCu);