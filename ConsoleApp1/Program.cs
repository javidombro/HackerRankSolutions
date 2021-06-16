using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace HackerRankSolutions
{
    class Program
    {
        static void Main(string[] args)
        {


            string s = Console.In.ReadToEnd();
            var stdin = s.Split();
            foreach (var item in stdin)
            {
                Console.WriteLine(item);
            }

            Directory current = new Directory(null);
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("SerializedObject", FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, current);
            stream.Close();

            stream = new FileStream("SerializedObject", FileMode.Open, FileAccess.Read);
            Directory directory = (Directory)formatter.Deserialize(stream);

            //var solution = PostDateFormatter.solution(-59455);
            //Console.WriteLine(solution);
            //var diff = PostDateFormatter.Format(DateTime.Now, DateTime.Now);
            //Console.WriteLine(diff);

            //var asds = JaneaSystemsCodingChallenge.countMax(new List<string> { "108 229", "1132 1237", "534 91", "3218 125", "136 222", "237 114", "235 1200" });
            //System.Console.WriteLine(asds);
            //var order = JimAndTheOrders.jimOrders(new List<List<int>>
            //{
            //    new List<int>{1,13},new List<int>{2,3}, new List<int>{2,2}, new List<int>{3,3}
            //});

            //var smallest = ReverseShuffleMerge.reverseShuffleMerge("aeiouuoiea");
            //System.Console.WriteLine(smallest);
        }
    }
}
