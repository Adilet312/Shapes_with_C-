using System;

namespace Shapes.Models
{
    public class Circle
    {
        private int x;
        private int y;

      public Circle (int h, int k)
      {
        this.x = h;
        this.y = k;
      }

      public int GetX()
      {
        return this.x;
      }

      public void SetX(int new_x)
      {
        // if(!IsInteger(new_x))
        // {
        //   throw new ArgumentException("Data type is invalid.");
        // }
        this.x = new_x;

      }

      public int GetY()
      {
        return this.y;
      }

      public void SetY(int new_y)
      {
        // if(!IsInteger(new_y))
        // {
        //   throw new ArgumentException("Data type is invalid.");
        // }
        this.y = new_y;
      }

      public double GetRadius()
      {
        double radius = Math.Sqrt(this.x * this.x + this.y * this.y);
        return Math.Round(radius, 2);
      }

      public double GetCircumference()
      {
        double circumference = Math.PI * 2 * GetRadius();
        return circumference;
      }

      public double GetArea()
      {
        double area = Math.PI * (GetRadius() * GetRadius());
        return area;
      }

      public string Print()
      {
        string output = "(" + this.x + "," + this.y + ")";
        return output;
      }
    }
}
