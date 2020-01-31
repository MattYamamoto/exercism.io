using System;

public static class Triangle
{
  public static bool IsValidTriangle(double side1, double side2, double side3)
  {
    if (side1 == 0 || side2 == 0 || side3 == 0) return false;

    double sum12 = side1 + side2;
    double sum13 = side1 + side3;
    double sum23 = side2 + side3;

    if (sum12 < side3 || sum13 < side2 || sum23 < side1) return false;

    return true;
  }
  public static bool IsScalene(double side1, double side2, double side3)
  {
    if (!IsValidTriangle(side1, side2, side3)) return false;

    return side1 != side2 && side1 != side3 && side2 != side3;
  }

  public static bool IsIsosceles(double side1, double side2, double side3)
  {
    if (!IsValidTriangle(side1, side2, side3)) return false;

    return !(side1 != side2 && side1 != side3 && side2 != side3);
  }

  public static bool IsEquilateral(double side1, double side2, double side3)
  {
    return side1 > 0 && side1 == side2 && side2 == side3;
  }
}