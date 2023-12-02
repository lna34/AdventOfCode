﻿using System.Text.RegularExpressions;

namespace AdventOfCode.AdventOfCodeDayOne
{
    public class Decoder
    {
        private readonly (string NumberString, string Number)[] StringToNumberMap = new (string, string)[] {
            ("one", "1"),
            ("two", "2"),
            ("three", "3"),
            ("four", "4"),
            ("five", "5"),
            ("six", "6"),
            ("seven", "7"),
            ("eight", "8"),
            ("nine", "9")
        };

        private string[] _linesToBeDecoded;

        public Decoder(string[] linesToBeDecoded)
        {
            _linesToBeDecoded = linesToBeDecoded;
        }

        public int ResolvePuzzle1()
        {
            return _linesToBeDecoded
                .Select(line => new string(line.Where(c => char.IsDigit(c)).ToArray()))
                .Where(line => !string.IsNullOrEmpty(line))
                .Select(line => Convert.ToInt32($"{line.First()}{line.Last()}"))
                .Sum();
        }

        public int ResolvePuzzle2()
        {
            FindFirstAndLastDigits("");
            return 1;
        }

        private (int FirstDigit, int LastDigit) FindFirstAndLastDigits(string input)
        {
            string pattern = @"\d|one|two|three|four|five|six|seven|eight|nine";
            var matchFirstDigit = Regex.Match(input, pattern).Value;
            var matchLastDigit = Regex.Match(input, pattern, RegexOptions.RightToLeft).Value;
            
            return (1, 1);
        }
    }
}