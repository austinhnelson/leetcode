class Solution {
public:
    bool isSubsequence(string s, string t) {
        std::string::iterator s_it = s.begin();
        for(char t_char : t){
            if (s_it == s.end()) {
                return true;
            }

            if(t_char == *s_it){
                s_it++;
            }
        }
        return s_it == s.end();
    }
};