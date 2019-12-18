using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class SphereTests
  {

    [TestMethod]
    public void Sphere_GetSurfaceArea_AreaOfSphere()
    {
      // Arrange
      Circle newCircle = new Circle(2,4);
      Sphere newSphere = new Sphere(newCircle);
      // Act
      double result = newSphere.GetSurfaceArea();
      // Assert
      Assert.AreEqual(result, 788.81);
    }

    [TestMethod]
    public void Sphere_GetVolume_VolumeOfSphere()
    {
      // Arrange
      Circle newCircle = new Circle(2,4);
      Sphere newSphere = new Sphere(newCircle);
      // Act
      double result = newSphere.GetVolume();
      // Assert
      Assert.AreEqual(result, 374.12);
    }
  }
}
