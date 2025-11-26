#include <string>
#include <vector>

namespace election {

// The election result struct is already created for you:

struct ElectionResult {
    // Name of the candidate
    std::string name{};
    // Number of votes the candidate has
    int votes{};
};

// TODO: Task 1
// vote_count takes a reference to an `ElectionResult` as an argument and will
// return the number of votes in the `ElectionResult.
int vote_count(ElectionResult result) {
    return result.votes;
}

// TODO: Task 2
// increment_vote_count takes a reference to an `ElectionResult` as an argument
// and a number of votes (int), and will increment the `ElectionResult` by that
// number of votes.
void increment_vote_count(ElectionResult& result, int increment) {
    result.votes += increment;
}

// TODO: Task 3
// determine_result receives the reference to a final_count and returns a
// reference to the `ElectionResult` of the new president. It also changes the
// name of the winner by prefixing it with "President". The final count is given
// in the form of a `reference` to `std::vector<ElectionResult>`, a vector with
// `ElectionResults` of all the participating candidates.
// ElectionResult& determine_result(std::vector<ElectionResult> results_list) {
//     ElectionResult winner{"", 0};
//     for(int i = 0; i < results_list.size(); i++) {
//         if(results_list[i].votes > winner.votes) {
//             winner = results_list[i];
//         }
//     }
//     ElectionResult& final_winner{winner};
//     final_winner.name = "President " + final_winner.name;
//     return final_winner;
// }

ElectionResult& determine_result(std::vector<ElectionResult>& lst) {
    int winner_loc{0};
    for(int i = 1; i < lst.size(); i++) {
        if(lst[i].votes > lst[winner_loc].votes) {
            winner_loc = i;
        }
    }
    ElectionResult& res{lst[winner_loc]};
    res.name = "President " + res.name;
    return res;
}

}  // namespace election
