#include "power_of_troy.h"

#include <string>
#include <memory>

namespace troy {
    
    void give_new_artifact(human& person, std::string& possession_name) {
        person.possession = std::make_unique<artifact>(possession_name);
    }

    void exchange_artifacts(std::unique_ptr<artifact>& art_one, std::unique_ptr<artifact>& art_two) {
        std::swap(art_one, art_two);
    }

    void manifest_power(human& person, std::string power_name) {
        person.own_power = std::make_shared<power>(power_name);
    }

    void use_power(human& attacker, human& target) {
        target.influenced_by = attacker.own_power;
    }

    int power_intensity(human& person) {
        return person.own_power.use_count();
    }
}  // namespace troy
