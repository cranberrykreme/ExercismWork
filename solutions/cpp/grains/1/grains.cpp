#include "grains.h"
#include <cmath>

namespace grains {

// TODO: add your solution here
unsigned long long square(int square_pos) {
    return std::pow(2, square_pos-1);
}

unsigned long long total() {
    return 18446744073709551615ULL;
}

}  // namespace grains
