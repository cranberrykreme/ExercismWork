#include <string>

namespace log_line {
std::string message(std::string line) {
    int start_loc = line.find(":") + 2;
    std::string log_message=line.substr(start_loc);
    return log_message;
}

std::string log_level(std::string line) {
    int level_len = line.find("]") - 1;
    std::string log_level=line.substr(1, level_len);
    return log_level;
}

std::string reformat(std::string line) {
    std::string log_message = log_line::message(line);
    std::string log_level = log_line::log_level(line);
    std::string full_message = log_message + " (" + log_level + ")";
    return full_message;
}
}  // namespace log_line
