#include "raindrops.h"
#include <string>

namespace raindrops {

// TODO: add your solution here
std::string convert(int num) {
    std::string ans{};
    bool div_num{};
    if(num%3 == 0) {
        div_num = true;
        ans += "Pling";
    }
    if(num%5 == 0) {
        div_num = true;
        ans+= "Plang";
    }
    if(num%7 == 0) {
        div_num = true;
        ans += "Plong";
    }

    if(!div_num) {
        ans = std::to_string(num);
    }

    return ans;
    
}
    
}  // namespace raindrops
