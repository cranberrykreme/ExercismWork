using System.Text.RegularExpressions;

public class LogParser
{
    public bool IsValidLine(string text)
    {
        var pat = @"^\[([A-Z]{3})\]*";
        return Regex.IsMatch(text, pat);
    }

    public string[] SplitLogLine(string text)
    {
        var pat = @"<[-^*=]+>";
        return Regex.Split(text, pat);
    }

    public int CountQuotedPasswords(string lines)
    {
        var pat = @"""[^""]*password[^""]*""";
        return Regex.Count(lines, pat, RegexOptions.IgnoreCase);
    }

    public string RemoveEndOfLineText(string line)
    {
        var pat = @"end-of-line[0-9]*";
        return Regex.Replace(line, pat, "");
    }

    public string[] ListLinesWithPasswords(string[] lines)
    {
        var pat = @"password\w+";
        for(int i = 0; i < lines.Length; i++) 
        {
            Match m = Regex.Match(lines[i], pat, RegexOptions.IgnoreCase);
            if (m == Match.Empty)
                lines[i] = $"--------: {lines[i]}";
            else 
                lines[i] = $"{m.Value}: {lines[i]}";
        }
        return lines;
    }
}
