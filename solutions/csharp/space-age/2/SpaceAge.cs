public class SpaceAge
{
    private double earthYears;
    public SpaceAge(int seconds) => this.earthYears = seconds / 31557600.0;

    public double OnEarth() => earthYears;

    public double OnMercury() => this.earthYears/0.2408467;

    public double OnVenus() => this.earthYears/0.61519726;

    public double OnMars() => this.earthYears/1.8808158;

    public double OnJupiter() => this.earthYears/11.862615;

    public double OnSaturn() => this.earthYears/29.447498;

    public double OnUranus() => this.earthYears/84.016846;

    public double OnNeptune() => this.earthYears/164.79132;
}