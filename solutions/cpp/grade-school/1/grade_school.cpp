#include "grade_school.h"
#include <algorithm>

namespace grade_school {

    void school::add(const std::string& name, int grade) {
        grades[grade].push_back(name);
        std::sort(grades[grade].begin(), grades[grade].end());
    }
    
    std::vector<std::string> school::grade(int year) const {
        if(grades.count(year) == 0) {
            return {};
        }
        return grades.at(year);
    }
    
    std::map<int, std::vector<std::string>> school::roster() const {
        return grades;
    }

}  // namespace grade_school
