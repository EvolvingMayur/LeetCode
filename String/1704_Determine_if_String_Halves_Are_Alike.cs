public partial class Solution
{
    public bool HalvesAreAlike(string s)
    {
        var vovels = new HashSet<char>
        {
        'a','e','i','o','u',
        'A','E','I','O','U'
        };
        // this was 40 ish _44ish _40 ish
        // char[] vovels = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'];
        int leftCount = 0;
        int rightCount = 0;
        var sLength = s.Length / 2;
        for (int i = 0; i < sLength; i++)
        {
            if (vovels.Contains(s[i]))
            {
                leftCount++;
            }
            if (vovels.Contains(s[i + sLength]))
            {
                rightCount++;
            }
        }
        return leftCount == rightCount;

    }
}