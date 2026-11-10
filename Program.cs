using static System.Net.Mime.MediaTypeNames;

namespace Week12Assignment12._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part 1");

            string ransomNote = "aa";
            string magazine = "aab";
            Console.WriteLine($"Ransom Note: {ransomNote} - Magazine: {magazine}");
            Console.WriteLine(RansomNote(ransomNote, magazine));

            Console.WriteLine("\nPart 2");
            LL list = new LL();
            list.AddFirst(1);
            list.AddLast(2);
            list.AddLast(2);
            list.AddLast(1);

            LL list2 = new LL();
            list2.AddFirst(1);
            list2.AddLast(2);

            Console.WriteLine("\nList 1:");
            list.Display();
            Console.WriteLine($"\nIs palindrome: {list.IsPalindrome()}");

            Console.WriteLine("\nList 2:");
            list2.Display();
            Console.WriteLine($"\nIs palindrome: {list2.IsPalindrome()}");

        }
        static bool RansomNote(string note, string magazine)
        {
            Dictionary<char, int> count = new Dictionary<char, int>();

            // Count occurrences of each character
            foreach (char c in magazine)
            {
                if (count.ContainsKey(c))
                {
                    count[c]++;
                }
                else
                {
                    count[c] = 1;
                }
            }

            foreach (char c in note)
            {
                if (!count.ContainsKey(c) || count[c] == 0)
                {
                    return false;
                }
                count[c]--;
            }
            return true;
        }
    }
}
