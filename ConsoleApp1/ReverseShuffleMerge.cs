using System;
using System.Text;

namespace HackerRankSolutions
{
    public static class ReverseShuffleMerge
    {
        //INCOMPLETE SOLUTION - STILL FAILS
        public static string reverseShuffleMerge(string s)
        {
            var lettersCant = new int[26];
            var smallest = int.MaxValue;

            foreach (var letter in s)
            {
                int index = letter - 97;
                lettersCant[index]++;
            }

            var requiredCant = new int[26];
            for (int i = 0; i < lettersCant.Length; i++)
            {
                requiredCant[i] = lettersCant[i] / 2;
            }

            var builder = new StringBuilder();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                var index = s[i] - 97;
                if (requiredCant[index] >= lettersCant[index] && lettersCant[index] > 0)
                {
                    if (s[i] < smallest)
                    {
                        builder.Append(s[i]);
                        lettersCant[i]--;
                    }
                    else
                    {
                        builder.Append((char)smallest);
                        builder.Append(s[i]);
                        lettersCant[smallest - 97]--;
                        lettersCant[i]--;
                        if (lettersCant[smallest - 97] == 0)
                        {
                            smallest = int.MaxValue;
                        }
                    }
                }
                else
                {
                    lettersCant[index]--;
                    smallest = Math.Min(smallest, index + 97);
                }
            }
            return builder.ToString();
        }

    }
}
