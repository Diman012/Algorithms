public static bool IsPalindrome(string input) {
          string ans = ""; // makes an empty variable.
          for (int x = input.Length - 1; x>=0; x--) { // this goes from the back of the string to the beginning
               ans = ans + input[x]; // this will store letters from the last to the beginning of this string (if that makes sense)
          }

          return input == ans ? true : false; // makes a ternary statement and checks to see if the input is the same as the reversed string
     }
