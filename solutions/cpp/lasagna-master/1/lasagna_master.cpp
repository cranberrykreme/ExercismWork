#include "lasagna_master.h"
#include <string>
#include <vector>
#include <cmath>

namespace lasagna_master {

// TODO: add your solution here
    int preparationTime(std::vector<std::string> layers, int minutes) {
        return minutes * layers.size();
    }

    lasagna_master::amount quantities(std::vector<std::string> layers) {
        lasagna_master::amount total_layers{};
        for(size_t i = 0; i < layers.size(); i++) {
            if(layers[i] == "noodles") {
                total_layers.noodles += 50;
            }
            if(layers[i] == "sauce") {
                total_layers.sauce += 0.2;
            }
        }

        return total_layers;
    }

    void addSecretIngredient(std::vector<std::string>& myList, std::string secretIngredient) {
        myList.back() = secretIngredient;
    }

    void addSecretIngredient(std::vector<std::string>& myList, const std::vector<std::string>& friendsList) {
        myList.back() = friendsList.back();
    }

    std::vector<double> scaleRecipe(const std::vector<double>& quant, int scale) {
        std::vector<double> scaled_quant{};
        scaled_quant.reserve(quant.size());
        double actual_scale = static_cast<double>(scale) / 2.0;
        for(double q : quant) {
            scaled_quant.push_back(q * actual_scale);
        }
        return scaled_quant;
    }

}  // namespace lasagna_master
