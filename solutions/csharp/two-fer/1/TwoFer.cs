public static class TwoFer
{
    // In order to get the tests running, first you need to make sure the Speak method 
    // can be called both without any arguments and also by passing one string argument.
    public static string Speak(string name = "you")
    {
        string sentence = "One for {0}, one for me.";
        return String.Format(sentence, name);
    }
}
