public class SpaceAge
{
    private double earthYears;
    public SpaceAge(int seconds)
    {
        this.earthYears = seconds / 31557600.0;
    }

    public double OnEarth()
    {
        return earthYears;
    }

    public double OnMercury()
    {
        return this.earthYears/0.2408467;
    }

    public double OnVenus()
    {
        return this.earthYears/0.61519726;
    }

    public double OnMars()
    {
        return this.earthYears/1.8808158;
    }

    public double OnJupiter()
    {
        return this.earthYears/11.862615;
    }

    public double OnSaturn()
    {
        return this.earthYears/29.447498;
    }

    public double OnUranus()
    {
        return this.earthYears/84.016846;
    }

    public double OnNeptune()
    {
        return this.earthYears/164.79132;
    }
}