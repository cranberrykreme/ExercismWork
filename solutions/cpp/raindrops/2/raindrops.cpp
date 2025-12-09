#include "raindrops.h"
#include <string>

namespace raindrops {

// TODO: add your solution here
std::string convert(int num) {
    std::string ans{};
    if(num%3 == 0) {
        ans += "Pling";
    }
    if(num%5 == 0) {
        ans+= "Plang";
    }
    if(num%7 == 0) {
        ans += "Plong";
    }

    if(ans.empty()) {
        ans = std::to_string(num);
    }

    return ans;
    
}
    
}  // namespace raindrops
