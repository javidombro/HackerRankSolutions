using System;

namespace HackerRankSolutions
{
    public static class PostDateFormatter
    {
        public static string Format(DateTime date, DateTime current)
        {
            var output = "(s) ago";

            var difference = current - date;
            if (difference.Minutes == 0)
            {
                return "now";
            }
            if (difference.Days > 0 && difference.Days <= 7)
            {
                return $"{difference.Days} day{output}";
            }
            if (difference.Days > 7)
            {
                return date.ToString("yyyy-");
            }

            return difference.Hours > 0 ? $"{difference.Hours} hour{output}" : $"{difference.Minutes} minute{output}";
        }

        public static int solution(int N)
        {
            string number = N.ToString();
            string result = number;
            bool positive = true;
            for (int i = 0; i < number.Length; i++)
            {
                if (!int.TryParse(number[i].ToString(), out int aux))
                {
                    positive = false;
                    continue;
                }
                if (positive && aux >= 5)
                {
                    continue;
                }
                if (!positive && aux <= 5)
                {
                    continue;
                }
                result = number.Insert(i, "5");
                break;
            }
            if (result == number)
            {
                result += "5";
            }
            return int.Parse(result);
        }
    }
}
