public partial class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        int[] counts = new int[26];
        foreach (char c in magazine)
        {
            counts[c - 'a']++;
        }
        foreach (char c in ransomNote)
        {
            if (--counts[c - 'a'] < 0)
            {
                return false;
            }
        }
        return true;
        //Bad Solution 12.48_8.43_50.6
        // var magazineDictionary = magazine.GroupBy(c => c).ToDictionary(k => k.Key, v => v.ToArray().Length);
        // var ransomNoteDictionary = ransomNote.GroupBy(c => c).ToDictionary(k => k.Key, v => v.ToArray().Length);

        // foreach (var data in ransomNoteDictionary)
        // {
        //     if (!magazineDictionary.TryGetValue(data.Key, out var count) || data.Value != count)
        //     {
        //         return false;
        //     }
        // }
        // return true;
    }
}