using System;
using System.Collections.Generic;

namespace length_of_last_word
{
    public class Program
    {
        //leet code
        static int LastWordLength(string s)
        {
            
            var stringInput=s.TrimEnd().Split(' ');
            List<string> vs = new List<string>();
            foreach (var item in stringInput)
            {
                vs.Add(item);
            }
            string result = vs[vs.Count-1];
            return result.Length;
        }
        static void Main(string[] args)
        {
            string s = "Show the message  ";
            LastWordLength(s);
            Console.WriteLine(LastWordLength(s));
        }
    }
}
