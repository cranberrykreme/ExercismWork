#include "speedywagon.h"

namespace speedywagon {

// Enter your code below:
bool connection_check(speedywagon::pillar_men_sensor* sensor) {
    if(sensor == nullptr) {
        return false;
    }
    return true;
}

int activity_counter(speedywagon::pillar_men_sensor* sensor_arr, int arr_cap) {
    int ans{};
    int index{};
    while(index < arr_cap) {
        ans += sensor_arr[index].activity;
        index++;
    }
    return ans;
}

bool alarm_control(speedywagon::pillar_men_sensor* sensor) {
    if(!connection_check(sensor) || activity_counter(sensor, 1) < 1){
        return false;
    }
    return true;
}

bool uv_alarm(pillar_men_sensor* sensor) {
    if(!connection_check(sensor) || uv_light_heuristic(&sensor->data) <= sensor->activity) {
        return false;
    }
    return true;
}

// Please don't change the interface of the uv_light_heuristic function
int uv_light_heuristic(std::vector<int>* data_array) {
    double avg{};
    for (auto element : *data_array) {
        avg += element;
    }
    avg /= data_array->size();
    int uv_index{};
    for (auto element : *data_array) {
        if (element > avg) ++uv_index;
    }
    return uv_index;
}

}  // namespace speedywagon
