#pragma once
#include <string>
#include <map>
#include <vector>

using namespace std;

namespace grade_school {

class school {
    private:
        map<int, vector<string>> grades{};
    public:
        map<int, vector<string>> roster() const;
        void add(string name, int grade);
        vector<string> grade(int year) const;
};

}  // namespace grade_school
