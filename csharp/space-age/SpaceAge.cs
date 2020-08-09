using System;

public class SpaceAge
{
    private const double SecondsInEarthYear = 31557600d;

    private const double MercuryOrbitRatio = 0.2408467;
    private const double VenusOrbitRatio = 0.61519726;
    private const double MarsOrbitRatio = 1.8808158;
    private const double JupiterOrbitRatio = 11.862615;
    private const double SaturnOrbitRatio = 29.447498;
    private const double UranusOrbitRatio = 84.016846;
    private const double NeptuneOrbitRatio = 164.79132;

    private readonly int seconds;

    public SpaceAge(int seconds) => this.seconds = seconds;

    public double OnEarth() => seconds / SecondsInEarthYear;

    public double OnMercury() => OnEarth() / MercuryOrbitRatio;

    public double OnVenus() => OnEarth() / VenusOrbitRatio;

    public double OnMars() => OnEarth() / MarsOrbitRatio;

    public double OnJupiter() => OnEarth() / JupiterOrbitRatio;

    public double OnSaturn() => OnEarth() / SaturnOrbitRatio;

    public double OnUranus() => OnEarth() / UranusOrbitRatio;

    public double OnNeptune() => OnEarth() / NeptuneOrbitRatio;
}