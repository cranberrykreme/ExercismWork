using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private Dictionary<int, List<string>> students = new Dictionary<int, List<string>>();
    
    public bool Add(string student, int grade)
    {
        if(students.Values.Any(x => x.Contains(student)))
        {
            return false;
        }

        var lst = students.TryGetValue(grade, out var gradeList) ? gradeList : new List<string>();
        lst.Add(student);
        students[grade] = lst;
        return true;
    }

    public IEnumerable<string> Roster() => students
                .OrderBy(x => x.Key)
                .SelectMany(x => x.Value.OrderBy(x => x));

    public IEnumerable<string> Grade(int grade) => students
                .Where(s => s.Key == grade)
                .SelectMany(s => s.Value)
                .OrderBy(s => s);
}