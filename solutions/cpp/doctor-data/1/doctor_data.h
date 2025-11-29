// ERROR: FILE CORRUPTED. Please supply valid C++ Code.

#pragma once
#include <string>


namespace star_map {
    enum System {
        BetaHydri,
        EpsilonEridani,
        Sol,
        AlphaCentauri,
        DeltaEridani,
        Omicron2Eridani
    };
}

namespace heaven {
    class Vessel {
        public:
            std::string name{};
            int generation{};
            star_map::System current_system{};
            int busters{};
            Vessel(std::string name, int generation, star_map::System current_system = star_map::System::Sol);
            Vessel replicate(std::string name);
            void make_buster();
            bool shoot_buster();
    };

    std::string get_older_bob(Vessel ves_one, Vessel ves_two);
    bool in_the_same_system(Vessel ves_one, Vessel ves_two);
}
