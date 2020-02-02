using System;

public static class Darts
{
    public static int Score(double x, double y)
    {
        double distanceFromCenter = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

        return
          distanceFromCenter <= 1 ? 10 :
          distanceFromCenter <= 5 ? 5 :
          distanceFromCenter <= 10 ? 1 :
          0;
    }
}
