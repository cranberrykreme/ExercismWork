#include "hamming.h"
#include <stdexcept>

namespace hamming {

int compute(string a, string b) {
    if(a.length() != b.length()) {
        throw domain_error("DNA sequences must be of equal length");
    }
    int c{};
    for(unsigned long long i{}; i < a.length(); i++) {
        if(a.at(i) != b.at(i)) {
            c++;
        }
    }
    return c;
}

}  // namespace hamming
