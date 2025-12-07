using System.Linq;

public class HighScores
{
    private List<int> list;
    public HighScores(List<int> list)
    {
        this.list = list;
    }

    public List<int> Scores() => this.list;

    public int Latest() => this.list[^1];

    public int PersonalBest()
    {
        var highest = 0;
        foreach(int score in this.list) 
        {
            if(score > highest)
            {
                highest = score;
            }
        }
        return highest;    
    }

    public List<int> PersonalTopThree() =>
        this.list
            .OrderByDescending(x => x)
            .Take(3)
            .ToList();
}