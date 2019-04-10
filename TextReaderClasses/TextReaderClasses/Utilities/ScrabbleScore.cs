using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextReaderClasses.Utilities
{
    public class ScrabbleScore
    {
        public ScrabbleScore()
        {
        }

        public int CalculateScore(string word)
        {
            int[] scores = { 1, 3, 3, 2, 1, 4, 2, 4, 1, 8, 5, 1, 3, 1, 1, 3, 10, 1, 1, 1, 4, 4, 4, 8, 4, 10};
            var score = 0;

            for (var x = 0; x < word.Length; x++)
            {
                var index = word[x] - 97;
                if(index < 0 || index > 25)
                {

                }
                else
                {
                    score += scores[index];
                }
            }

            return score;
        }
    }
}
