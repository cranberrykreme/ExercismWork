public struct Coord
{
    public Coord(ushort x, ushort y)
    {
        X = x;
        Y = y;
    }

    public ushort X { get; }
    public ushort Y { get; }

    public bool Equals(Coord other)
    {
        return X == other.X && Y == other.Y;
    }
}

public struct Plot
{
    // TODO: Complete implementation of the Plot struct
    public Plot(Coord a, Coord b, Coord c, Coord d)
    {
        A = a;
        B = b;
        C = c;
        D = d;
    }

    public Coord A { get; }
    public Coord B { get; }
    public Coord C { get; }
    public Coord D { get; }

    public override int GetHashCode()
    {
        return HashCode.Combine(A, B, C, D);
    }

    public bool Equals(Plot p)
    {
        return A.Equals(p.A) && B.Equals(p.B) && C.Equals(p.C) && D.Equals(p.D);
    }
}


public class ClaimsHandler
{
    public HashSet<Plot> plotClaims = new HashSet<Plot>();
    public Plot lastAdded;
    public void StakeClaim(Plot plot)
    {
        plotClaims.Add(plot);
        lastAdded = plot;
    }

    public bool IsClaimStaked(Plot plot)
    {
        return plotClaims.Contains(plot);
    }

    public bool IsLastClaim(Plot plot)
    {
        return plot.Equals(lastAdded);
    }

    public Plot GetClaimWithLongestSide()
    {
        Plot longestSide = new Plot();
        int longestSideLength = 0;
        foreach (Plot p in plotClaims)
        {
            int[] sides = { Math.Abs(p.A.X - p.B.X), Math.Abs(p.B.Y - p.C.Y) , Math.Abs(p.C.X - p.D.X),  Math.Abs(p.D.Y - p.A.Y) };
            int largest = sides.Max();
            if(largest > longestSideLength)
            {
                longestSideLength = largest;
                longestSide = p;
            }
        }
        return longestSide;
    }
}
