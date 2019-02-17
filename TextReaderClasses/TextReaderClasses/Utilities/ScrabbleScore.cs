using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextReaderClasses.Utilities
{
    public class ScrabbleScore
    {
        //SortedDictionary to hold scrabble scores for letters
        public SortedDictionary<char, int> LetterScores;

        public ScrabbleScore()
        {
            //Add all scores into SortedDictionary
            LetterScores = new SortedDictionary<char, int>();

            LetterScores.Add('a', 1);
            LetterScores.Add('b', 3);
            LetterScores.Add('c', 3);
            LetterScores.Add('d', 2);
            LetterScores.Add('e', 1);
            LetterScores.Add('f', 4);
            LetterScores.Add('g', 2);
            LetterScores.Add('h', 4);
            LetterScores.Add('i', 1);
            LetterScores.Add('j', 8);
            LetterScores.Add('k', 5);
            LetterScores.Add('l', 1);
            LetterScores.Add('m', 3);
            LetterScores.Add('n', 1);
            LetterScores.Add('o', 1);
            LetterScores.Add('p', 3);
            LetterScores.Add('q', 10);
            LetterScores.Add('r', 1);
            LetterScores.Add('s', 1);
            LetterScores.Add('t', 1);
            LetterScores.Add('u', 4);
            LetterScores.Add('v', 4);
            LetterScores.Add('w', 4);
            LetterScores.Add('x', 8);
            LetterScores.Add('y', 4);
            LetterScores.Add('z', 10);
        }

        public int CalculateScore(string word)
        {

            var score = 0;

            //Convert word to lowercase, just in "case"
            word = word.ToLower();

            //loop all char in word
            foreach(char letter in word)
            {
                //get score for letter
                score += LetterScores.Where(x => x.Key == letter).FirstOrDefault().Value;
            }
            return score;
        }
    }
}
