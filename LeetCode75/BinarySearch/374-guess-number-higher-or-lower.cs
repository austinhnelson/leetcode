/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        int low = 1;
        int high = n;
        # This is magic to me, protects high from getting overflowed
        # the value of high will always be the highest value possible
        int numberToGuess = low + (high - low) / 2;
        int result = guess(numberToGuess);

        while(result != 0){
            if (result == 1) {
                low = numberToGuess + 1;
            } else {
                high = numberToGuess - 1;
            }
            numberToGuess = low + (high - low) / 2;
            result = guess(numberToGuess);
        }

        return numberToGuess;
    }
}