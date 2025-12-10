#include "pangram.h"
#include <string>
#include <cctype>

namespace pangram {

// TODO: add your solution here
bool is_pangram(std::string sentence) {
    std::unordered_set<char> letters;
    if(sentence.length() < 26) {
        return false;
    } 
    for(unsigned long long i{}; i < sentence.length(); i++) {
        char letter = static_cast<char>(tolower(sentence[i]));
        if(std::islower(letter)) {
            letters.insert(letter);
        }
    }

    if(letters.size() < 26) {
        return false;
    }
    return true;
}
}  // namespace pangram
