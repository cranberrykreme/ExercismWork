#pragma once
#include <string>
#include <vector>

namespace lasagna_master {

struct amount {
    int noodles;
    double sauce;
};
    int preparationTime(std::vector<std::string> layers, int minutes = 2);

    amount quantities(std::vector<std::string> layers);

    void addSecretIngredient(std::vector<std::string>& myList, const std::vector<std::string>& friendsList);

    void addSecretIngredient(std::vector<std::string>& myList, std::string secretIngredient);
    
    std::vector<double> scaleRecipe(const std::vector<double>& quant, int scale);

}  // namespace lasagna_master


