using System.Globalization;

public static class HighSchoolSweethearts
{
    public static string DisplaySingleLine(string studentA, string studentB) => $"{studentA,29} ♡ {studentB,-29}";

    public static string DisplayBanner(string studentA, string studentB)
    {
        var formatString = @"
                 ******       ******
   **      **   **      **
 **         ** **         **
**            *            **
**                         **
**     {0,5} +  {1,-5}    **
 **                       **
   **                   **
     **               **
       **           **
         **       **
           **   **
             ***
              *
            ";
        return String.Format(formatString, studentA, studentB);
    }

    public static string DisplayGermanExchangeStudents(string studentA
        , string studentB, DateTime start, float hours)
    {
        var germanCulture = new CultureInfo("de-DE");
        return String.Format(germanCulture, "{0} and {1} have been dating since {2:d} - that's {3:n2} hours", studentA, studentB, start, hours);
    }
}
