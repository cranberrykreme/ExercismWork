#include "space_age.h"

namespace space_age {

// TODO: add your solution here
    space_age::space_age(long seconds) : 
        total_seconds_(seconds), 
        earth_years_(seconds / 31557600.0) {}
    
    double space_age::seconds() const {
        return total_seconds_;
    }
    double space_age::on_earth() const {
        return earth_years_;
    }
    double space_age::on_mercury() const {
        return earth_years_/0.2408467;
    }
    double space_age::on_venus() const {
        return earth_years_/0.61519726;
    }
    double space_age::on_mars() const {
        return earth_years_/1.8808158;
    }
    double space_age::on_jupiter() const {
        return earth_years_/11.862615;
    }
    double space_age::on_saturn() const {
        return earth_years_/29.447498;
    }
    double space_age::on_uranus() const {
        return earth_years_/84.016846;
    }
    double space_age::on_neptune() const {
        return earth_years_/164.79132;
    }

}  // namespace space_age
