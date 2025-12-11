public enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
    private int mask;
    public Allergies(int mask)
    {
        this.mask = mask % 256;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        if((mask & (int)allergen) == (int)allergen)
            return true;
        return false;
    }

    public Allergen[] List()
    {
        List<Allergen> allergies = new List<Allergen>();
        foreach(Allergen allergy in Enum.GetValues(typeof(Allergen)))
        {
            if(IsAllergicTo(allergy))
                allergies.Add(allergy);
        }
        return allergies.ToArray();
    }
}