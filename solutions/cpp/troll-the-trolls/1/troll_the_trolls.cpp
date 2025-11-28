namespace hellmath {

// TODO: Task 1 - Define an `AccountStatus` enumeration to represent the four
// account types: `troll`, `guest`, `user`, and `mod`.
    enum class AccountStatus {
        troll,
        guest,
        user,
        mod
    };

// TODO: Task 1 - Define an `Action` enumeration to represent the three
// permission types: `read`, `write`, and `remove`.
    enum class Action {
        read,
        write,
        remove
    };

// TODO: Task 2 - Implement the `display_post` function, that gets two arguments
// of `AccountStatus` and returns a `bool`. The first argument is the status of
// the poster, the second one is the status of the viewer.
    bool display_post(AccountStatus acc_one, AccountStatus acc_two) {
        if(acc_one == AccountStatus::troll
            && acc_one != acc_two) {
                return false;
            }
        return true;
    }

// TODO: Task 3 - Implement the `permission_check` function, that takes an
// `Action` as a first argument and an `AccountStatus` to check against. It
// should return a `bool`.
    bool permission_check(Action action, AccountStatus acc) {
        switch(action) {
            case hellmath::Action::write:
                if(acc == AccountStatus::guest) {
                    return false;
                }
                break;
            case hellmath::Action::remove:
                if(acc != AccountStatus::mod) {
                    return false;
                }
                break;
            default: return true;
        }
        return true;
    }

// TODO: Task 4 - Implement the `valid_player_combination` function that
// checks if two players can join the same game. The function has two parameters
// of type `AccountStatus` and returns a `bool`.
    bool valid_player_combination(AccountStatus acc_one, AccountStatus acc_two) {
        if(acc_one == AccountStatus::guest || acc_two == AccountStatus::guest) {
            return false;
        }
        if((acc_one == AccountStatus::troll || acc_two == AccountStatus::troll) && acc_one != acc_two){
            return false;
        }
        
        return true;
    }

// TODO: Task 5 - Implement the `has_priority` function that takes two
// `AccountStatus` arguments and returns `true`, if and only if the first
// account has a strictly higher priority than the second.
    bool has_priority(AccountStatus acc_one, AccountStatus acc_two) {
        bool priority{false};
        switch(acc_one) {
            case hellmath::AccountStatus::guest:
                if(acc_two == hellmath::AccountStatus::troll) {
                    priority = true;
                }
                break;
            case hellmath::AccountStatus::user: 
                if(acc_two == hellmath::AccountStatus::troll || acc_two == hellmath::AccountStatus::guest) {
                    priority = true;
                }
                break;
            case hellmath::AccountStatus::mod:
                if(acc_two != AccountStatus::mod) {
                    priority = true;
                }
            default: 
                break;
        }
        return priority;
    }
}  // namespace hellmath
