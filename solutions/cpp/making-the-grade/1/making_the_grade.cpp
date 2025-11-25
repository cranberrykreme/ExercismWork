#include <array>
#include <string>
#include <vector>

// Round down all provided student scores.
std::vector<int> round_down_scores(std::vector<double> student_scores) {
    // TODO: Implement round_down_scores
    std::vector<int> rounded_down { };
    for(int i{0}; i < student_scores.size(); i++) {
        rounded_down.emplace_back(static_cast<int>(student_scores[i]));
    }
    return rounded_down;
}

// Count the number of failing students out of the group provided.
int count_failed_students(std::vector<int> student_scores) {
    // TODO: Implement count_failed_students
    int num_fails{0};
    for(int i{0}; i < student_scores.size(); i++) {
        if(student_scores[i] < 41) {
            num_fails++;
        }
    }
    return num_fails;
}

// Create a list of grade thresholds based on the provided highest grade.
std::array<int, 4> letter_grades(int highest_score) {
    // TODO: Implement letter_grades
    int increment = (highest_score - 40) / 4;
    std::array<int, 4> letter_grades_arr = {41, 0, 0, 0};
    for(int i{1}; i < 4; i++) {
        letter_grades_arr[i] = letter_grades_arr[i-1] + increment;
    }
    return letter_grades_arr;
}

// Organize the student's rank, name, and grade information in ascending order.
std::vector<std::string> student_ranking(
    std::vector<int> student_scores, std::vector<std::string> student_names) {
    // TODO: Implement student_ranking
    std::vector<std::string> rankings_list = {};
    for(int i{0}; i < student_scores.size(); i++) {
        std::string curr = std::to_string(i+1) + ". " + student_names[i] + ": " + std::to_string(student_scores[i]);
        rankings_list.emplace_back(curr);
    }
    return rankings_list;
}

// Create a string that contains the name of the first student to make a perfect
// score on the exam.
std::string perfect_score(std::vector<int> student_scores,
                          std::vector<std::string> student_names) {
    // TODO: Implement perfect_score
    for(int i{0}; i < student_scores.size(); i++) {
        if(student_scores[i] == 100) {
            return student_names[i];
        }
    }
    return "";
}
