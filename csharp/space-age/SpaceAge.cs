using System;

static class RelativeOrbitalPeriods
{
  public const int Earth = 1;
  public const double Mercury = 0.2408467;
  public const double Venus = 0.61519726;
  public const double Mars = 1.8808158;
  public const double Jupiter = 11.862615;
  public const double Saturn = 29.447498;
  public const double Uranus = 84.016846;
  public const double Neptune = 164.79132;
}

public class SpaceAge
{

  private long AgeInSeconds;
  private readonly double EarthYearInSeconds = 31557600;

  public SpaceAge(long seconds)
  {
    this.AgeInSeconds = seconds;
  }

  public double OnEarth()
  {
    return this.GetAge(RelativeOrbitalPeriods.Earth);
  }

  private double GetAge(double orbitalPeriod)
  {
    return this.AgeInSeconds / this.EarthYearInSeconds / orbitalPeriod;
  }

  public double OnMercury()
  {
    return this.GetAge(RelativeOrbitalPeriods.Mercury);
  }

  public double OnVenus()
  {
    return this.GetAge(RelativeOrbitalPeriods.Venus);
  }

  public double OnMars()
  {
    return this.GetAge(RelativeOrbitalPeriods.Mars);
  }

  public double OnJupiter()
  {
    return this.GetAge(RelativeOrbitalPeriods.Jupiter);
  }

  public double OnSaturn()
  {
    return this.GetAge(RelativeOrbitalPeriods.Saturn);
  }

  public double OnUranus()
  {
    return this.GetAge(RelativeOrbitalPeriods.Uranus);
  }

  public double OnNeptune()
  {
    return this.GetAge(RelativeOrbitalPeriods.Neptune);
  }
}