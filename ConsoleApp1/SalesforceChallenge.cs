using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace HackerRankSolutions
{
    class SalesforceChallenge
    {
        
    }

    [Serializable]
    public class Directory
    {
        public Directory Parent { get; set; }
        public Dictionary<string, Directory> Children { get; set; }

        public ICollection<string> Files { get; set; }

        public Directory(Directory parent)
        {
            Parent = parent;
            Children = new Dictionary<string, Directory>();
            Files = new List<string>();
        }

        public Directory Up()
        {
            if (Parent != null)
            {
                return Parent;
            }
            throw new Exception("Cannot go up from root");
        }

        public string Ls()
        {
            string result = "";
            foreach (var dir in Children)
            {
                result += dir.Key;
            }
            return result;
        }

        public Directory Cd(string key)
        {
            if (key == "..")
            {
                return Up();
            }

            Directory result;
            if (Children.TryGetValue(key, out result))
            {
                return result;
            }
            throw new Exception($"The directory {key} does not exist");
        }

        public void Mkdir(string key)
        {
            if (Children.ContainsKey(key))
            {
                throw new Exception($"Directory {key} already exist");
            }

            var dir = new Directory(this);
            Children.Add(key, dir);
        }

        public void Touch(string key)
        {
            if (Files.Contains(key))
            {
                throw new Exception($"File {key} already exists");
            }
            Files.Add(key);
        }
    }


    public interface Command
    {
        void Execute(Directory directory);
    }

    public class QuitCommand : Command
    {
        public void Execute(Directory directory)
        {
        }
    }
}
