// ERROR: FILE CORRUPTED. Please supply valid C++ Code.

#include "doctor_data.h"
heaven::Vessel::Vessel(std::string name, int generation, star_map::System current_system) {
    this->name = name;
    this->generation = generation;
    this->current_system = current_system;
}

heaven::Vessel heaven::Vessel::replicate(std::string name) {
    return heaven::Vessel(name, this->generation+1, this->current_system);
}

void heaven::Vessel::make_buster() {
    this->busters = 1;
}

bool heaven::Vessel::shoot_buster() {
    if(this->busters < 1) {
        return false;
    }
    this->busters--;
    return true;
}

std::string heaven::get_older_bob(heaven::Vessel ves_one, heaven::Vessel ves_two) {
    if(ves_one.generation > ves_two.generation) {
        return ves_two.name;
    }
    return ves_one.name;
}

bool heaven::in_the_same_system(heaven::Vessel ves_one, heaven::Vessel ves_two) {
    return ves_one.current_system == ves_two.current_system;
}
