using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TextReaderClasses.Models;

namespace TextReaderClasses.Utilities
{
    public class TextReader
    {
        public ScrabbleScore _scrabbleScore;

        public TextReader(ScrabbleScore scrabbleScore)
        {
            _scrabbleScore = scrabbleScore;
        }

        public List<Word> GetWords(string text)
        {
            MatchCollection matches = Regex.Matches(text, @"\b[\w']*\b");

            //Get all words from input
            var words = matches.Cast<Match>().Where(x => x.Value != "").Select(
                x => new Word
                {
                    Text = TrimSuffix(x.Value),
                    Length = TrimSuffix(x.Value).Length,
                    Score = _scrabbleScore.CalculateScore(TrimSuffix(x.Value)),
                    Count = 0
                }).ToList();

            //get word frequency
            var wordFrequencies = words.GroupBy(x => new { x.Text })
                .Select(g => new
                {
                    Word = g.Key.Text,
                    Count = g.Count()
                }).ToList();

            //join two result sets
            var output = words.Join(
                    wordFrequencies,
                    word => word.Text,
                    wordFrequency => wordFrequency.Word,
                    (word, wordFrequency) => new Word
                    {
                        Text = word.Text,
                        Length = word.Length,
                        Score = word.Score,
                        Count = wordFrequency.Count
                    }
                ).ToList();

            return output;
        }

        public string TrimSuffix(string word)
        {
            var apostropheLocation = word.IndexOf('\'');
            if (apostropheLocation != -1)
            {
                word = word.Substring(0, apostropheLocation);
            }

            return word;
        }

        public Output CalculateOutput(List<Word> words)
        {
            var output = new Output
            {
                HighestScoredWord = new Word(),
                MostFrequent7LetterWord = new Word(),
                MostFrequentWord = new Word(),
            };

            var mostFrequentWord = words.OrderByDescending(x => x.Count).First();
            var mostFrequent7LetterWord = words.Where(x => x.Text.Length == 7)
                .OrderByDescending(x => x.Count).First();
            var highestScoredWord = words.OrderByDescending(x => x.Score).First();

            output.MostFrequentWord.Text = mostFrequentWord.Text;
            output.MostFrequentWord.Length = mostFrequentWord.Text.Length;
            output.MostFrequentWord.Score = mostFrequentWord.Score;
            output.MostFrequentWord.Count = mostFrequentWord.Count;

            output.MostFrequent7LetterWord.Text = mostFrequent7LetterWord.Text;
            output.MostFrequent7LetterWord.Length = mostFrequent7LetterWord.Text.Length;
            output.MostFrequent7LetterWord.Score = mostFrequent7LetterWord.Score;
            output.MostFrequent7LetterWord.Count = mostFrequent7LetterWord.Count;

            output.HighestScoredWord.Text = highestScoredWord.Text;
            output.HighestScoredWord.Length = highestScoredWord.Text.Length;
            output.HighestScoredWord.Score = highestScoredWord.Score;
            output.HighestScoredWord.Count = highestScoredWord.Count;

            return output;
        }


    }
}
