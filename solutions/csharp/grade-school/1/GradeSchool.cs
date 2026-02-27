using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private readonly Dictionary<int, List<string>> _grades = new(); 
    
    public bool Add(string student, int grade)
    {
        if (!_grades.ContainsKey(grade))
        {
            _grades[grade] = new List<string>();
        }

        if(_grades.Values.Any(lst => lst.Contains(student)))
        {
            return false;
        }

        _grades[grade].Add(student);
        return true;
    }

    public IEnumerable<string> Grade(int grade)
    {
        if (!_grades.ContainsKey(grade))
        {
            return Enumerable.Empty<string>();
        }

        return _grades[grade].OrderBy(n => n);
    }

    public IEnumerable<string> Roster()
    {
        return _grades
            .OrderBy(g => g.Key)
            .SelectMany(g => g.Value.OrderBy(n => n));
    }
}