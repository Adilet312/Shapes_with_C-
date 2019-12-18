using System;

namespace Shapes.Models
{
    public class MainClass
    {
        public static void Main()
        {
          Circle circleInstance = new Circle(2,4);
          Sphere sphereInstance = new Sphere(circleInstance);
          Console.WriteLine(circleInstance.Print());
          Console.WriteLine(circleInstance.GetRadius());
          Console.WriteLine(sphereInstance.GetSurfaceArea());
          Console.WriteLine(sphereInstance.GetVolume());
        }
    }
}
