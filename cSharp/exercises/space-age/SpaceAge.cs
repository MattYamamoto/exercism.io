using System;

public class SpaceAge
{

  long AgeInSeconds;
  double EarthYearInSeconds = 31557600;

  public SpaceAge(long seconds)
  {
    this.AgeInSeconds = seconds;
  }

  public double OnEarth()
  {
    return this.AgeInSeconds / this.EarthYearInSeconds;
  }

  public double OnMercury()
  {
    return this.OnEarth() / 0.2408467;
  }

  public double OnVenus()
  {
    return this.OnEarth() / 0.61519726;
  }

  public double OnMars()
  {
    return this.OnEarth() / 1.8808158;
  }

  public double OnJupiter()
  {
    return this.OnEarth() / 11.862615;
  }

  public double OnSaturn()
  {
    return this.OnEarth() / 29.447498;
  }

  public double OnUranus()
  {
    return this.OnEarth() / 84.016846;
  }

  public double OnNeptune()
  {
    return this.OnEarth() / 164.79132;
  }
}