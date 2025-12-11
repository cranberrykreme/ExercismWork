#include "grade_school.h"
#include <algorithm>

namespace grade_school {

map<int, vector<string>> school::roster() const {
    return grades;
}
void school::add(string name, int grade) {
    grades[grade].push_back(name);
    sort(grades[grade].begin(), grades[grade].end());
}
vector<string> school::grade(int year) const {
    if(!grades.count(year)) {
        return {};
    }
    return grades.at(year);
}

}  // namespace grade_school
