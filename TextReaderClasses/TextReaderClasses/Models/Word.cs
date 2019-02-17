using System;
using System.Collections.Generic;
using System.Text;

namespace TextReaderClasses.Models
{
    public class Word
    {
        public string Text { get; set; }
        public int Length { get; set; }
        public int Score { get; set; }
        public int Count { get; set; }
    }
}
