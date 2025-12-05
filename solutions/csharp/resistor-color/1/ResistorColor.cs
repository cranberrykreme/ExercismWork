public static class ResistorColor
{
    private enum colours
    {
        black,
        brown,
        red,
        orange,
        yellow,
        green,
        blue,
        violet,
        grey,
        white
    };
    
    public static int ColorCode(string color)
    {
        return (int)Enum.Parse(typeof(colours), color);
    }

    public static string[] Colors()
    {
        return Enum.GetNames(typeof(colours));
    }
}