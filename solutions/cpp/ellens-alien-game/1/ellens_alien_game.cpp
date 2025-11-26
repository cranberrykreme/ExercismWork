namespace targets {
    class Alien {
        public:
            int x_coordinate;
            int y_coordinate;
            Alien(int x, int y) {
                x_coordinate = x;
                y_coordinate = y;
            }
    
            int get_health() {
                return health;
            }

            bool hit() {
                if(health > 0) {
                    health--;
                }
                return true;
            }

            bool is_alive() {
                return health > 0;
            }

            bool teleport(int x, int y) {
                x_coordinate = x;
                y_coordinate = y;
                return true;
            }

            bool collision_detection(Alien other) {

                if(other.x_coordinate == x_coordinate && other.y_coordinate == y_coordinate) {
                    return true;
                }
                
                return false;
            }
        private:
            int health{3};
    };
}  // namespace targets
