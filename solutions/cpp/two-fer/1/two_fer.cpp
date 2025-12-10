#include "two_fer.h"

namespace two_fer {

// TODO: add your solution here
std::string two_fer(std::string name) {
    const std::string start = "One for ";
    const std::string end = ", one for me.";
    if(name == "") {
        return start + "you" + end;
    }
    return start + name + end;
}

}  // namespace two_fer
