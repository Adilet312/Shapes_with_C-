using System;

namespace Shapes.Models
{
  public class Sphere
    {
        private Circle circle;

      public Sphere(Circle circle)
      {
        this.circle = circle;
      }

      public double GetVolume()
      {
        double volume = (4.0 / 3.0) * Math.PI * this.circle.GetRadius() * this.circle.GetRadius() * this.circle.GetRadius();
        return Math.Round(volume, 2);
      }

      public double GetSurfaceArea()
      {
        double surfaceArea = 4 * Math.PI * this.circle.GetArea();
        return Math.Round(surfaceArea, 2);
      }

    }
}
