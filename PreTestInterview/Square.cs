namespace PreTestInterview
{
    public static class Square
    {
        public static int SquareDigits(int n)
        {
            if (n == 0)
                return 0;

            int result = 0;
            int powerOfTen = 1;

            while (n > 0)
            {
                int digit = n % 10;
                int squaredDigit = (int)Math.Pow(digit, 2);
                result += squaredDigit * powerOfTen;
                n /= 10;
                powerOfTen *= 10;
            }

            return result;
        }

        public static string ReverseString(string input)
        {
            return string.Join(" ", input.Split(' ').Select(word => new string(word.Reverse().ToArray())));
        }

        public static bool IsValid(string s)
        {
            Dictionary<char, char> map = new Dictionary<char, char>
        {
            { '(', ')' },
            { '[', ']' },
            { '{', '}' }
        };

            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (map.ContainsKey(c))
                {
                    stack.Push(c);
                }
                else if (map.ContainsValue(c))
                {
                    if (stack.Count == 0 || map[stack.Pop()] != c)
                    {
                        return false; // Mismatched or extra closing symbol
                    }
                }
            }

            return stack.Count == 0; // Check if all opening symbols have been matched
        }

        public static string HighestScoringWord(string input)
        {
            string[] words = input.Split(' ');
            int maxScore = int.MinValue;
            string highestScoringWord = "";

            foreach (string word in words)
            {
                int score = CalculateScore(word);
                if (score > maxScore)
                {
                    maxScore = score;
                    highestScoringWord = word;
                }
            }

            return highestScoringWord;
        }

        public static int CalculateScore(string word)
        {
            int score = 0;
            foreach (char c in word.ToLower())
            {
                score += c - 'a' + 1; // Assuming input is lowercase English letters only
            }
            return score;
        }
    }
}
