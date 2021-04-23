using System.Text;

namespace ConvertToPDF
{
    public static class ReverseShuffleMerge
    {
        public static string reverseShuffleMerge(string s)
        {
            var lettersCant = new int[27];

            foreach (var letter in s)
            {
                int index = letter - 97;
                lettersCant[index]++;
            }

            var requiredCant = new int[27];
            for (int i = 0; i < lettersCant.Length; i++)
            {
                requiredCant[i] = lettersCant[i] / 2;
            }

            for (int i = s.Length - 1; i >= 0; i--)
            {

            }
            var builder = new StringBuilder();

            for (int i = 0; i < lettersCant.Length; i++)
            {
                builder.Append(new string((char)(i + 97), lettersCant[i] / 2));
            }
            return builder.ToString();
        }

    }
}
