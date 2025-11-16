public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }
    // TODO: implement equality and GetHashCode() methods
    public override int GetHashCode()
    {
        return HashCode.Combine(EyeColor, PhiltrumWidth);
    }

    public override bool Equals(object obj)
    {
        if(obj == null || GetType() != obj.GetType())
            return false;

        FacialFeatures other = (FacialFeatures)obj;
        return EyeColor.Equals(other.EyeColor) && PhiltrumWidth == other.PhiltrumWidth;
    }
}

public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }
    // TODO: implement equality and GetHashCode() methods
    public override int GetHashCode()
    {
        return HashCode.Combine(Email, FacialFeatures.GetHashCode());
    }

    public override bool Equals(object obj)
    {
        if(obj == null || GetType() != obj.GetType())
            return false;

        Identity other = (Identity)obj;
        return Email.Equals(other.Email) && FacialFeatures.Equals(other.FacialFeatures);
    }
}

public class Authenticator
{
    HashSet<Identity> registered = new HashSet<Identity>();
    
    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB) => 
        faceA.EyeColor.Equals(faceB.EyeColor) && faceA.PhiltrumWidth == faceB.PhiltrumWidth;

    public bool IsAdmin(Identity identity) => 
        identity.Email.Equals("admin@exerc.ism") && AreSameFace(new FacialFeatures("green", 0.9m), identity.FacialFeatures);

    public bool Register(Identity identity)
    {
        if(IsRegistered(identity))
            return false;
        registered.Add(identity);
        return true;
    }

    public bool IsRegistered(Identity identity) => registered.Contains(identity);

    public static bool AreSameObject(Identity identityA, Identity identityB)
    {
        return System.Object.ReferenceEquals(identityA, identityB);
    }
}
