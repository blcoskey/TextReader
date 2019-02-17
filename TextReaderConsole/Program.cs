using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextReaderClasses.Utilities;

namespace TextReaderConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please enter file path");
            }
            else
            {
                var lines = "";
                try
                {
                    lines = File.ReadAllText(args[0]).ToString();
                }
                catch (System.IO.FileNotFoundException e)
                {
                    try
                    {
                        using (StreamWriter w = File.AppendText(@"ErrorLog\ErrorLog.log"))
                        {
                            Log(e.Message, w);
                        }
                    }
                    catch (Exception e2)
                    {
                        Console.WriteLine("Exception: " + e2.Message);
                    }

                    Console.WriteLine(e.Message);
#if DEBUG
                    Console.WriteLine("Press enter to close...");
                    Console.ReadLine();
#endif
                    Environment.Exit(0);
                }

                TextReaderClasses.Utilities.TextReader reader = new TextReaderClasses.Utilities.TextReader(new ScrabbleScore());

                var words = reader.GetWords(lines);

                var output = reader.CalculateOutput(words);

                Console.WriteLine(
                    "Most Frequent Word: " +
                    output.MostFrequentWord.Text +
                    "\n\t occured: " + output.MostFrequentWord.Count +
                    "\n\t length: " + output.MostFrequentWord.Length +
                    "\n\t score: " + output.MostFrequentWord.Score
                    );

                Console.WriteLine(
                    "Most Frequent 7 letter Word: " +
                    output.MostFrequent7LetterWord.Text +
                    "\n\t occured: " + output.MostFrequent7LetterWord.Count +
                    "\n\t length: " + output.MostFrequent7LetterWord.Length +
                    "\n\t score: " + output.MostFrequent7LetterWord.Score
                    );

                Console.WriteLine(
                    "Highest scoring word: " +
                    output.HighestScoredWord.Text +
                    "\n\t occured: " + output.HighestScoredWord.Count +
                    "\n\t length: " + output.HighestScoredWord.Length +
                    "\n\t score: " + output.HighestScoredWord.Score
                    );

#if DEBUG
                Console.WriteLine("Press enter to close...");
                Console.ReadLine();
#endif
            }
        }

        public static void Log(string logMessage, TextWriter w)
        {
            w.Write("\r\nLog Entry : ");
            w.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
            w.WriteLine("  :");
            w.WriteLine($"  :{logMessage}");
            w.WriteLine("-------------------------------");
        }
    }
}
