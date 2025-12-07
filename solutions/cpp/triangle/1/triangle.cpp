#include "triangle.h"
#include <stdexcept>

namespace triangle {

// TODO: add your solution here

flavor kind(double a, double b, double c) {

    // If any side is equal to or less than zero, throw error.
    if(a <= 0 || b <= 0 || c <= 0) {
        throw std::domain_error("invalid triangle");
    }

    // If one side is longer than the other two, throw error.
    if (a + b <= c || a + c <= b || b + c <= a) {
        throw std::domain_error("invalid triangle");
    }
    
    if(a == b && b == c) {
        return triangle::flavor::equilateral;
    }

    if(a != b && b != c && a != c) {
        return triangle::flavor::scalene;
    }

    return triangle::flavor::isosceles;
}

}  // namespace triangle
