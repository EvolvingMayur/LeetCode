public partial class Solution {
    public string TruncateSentence(string s, int k)
    {
        var lastIndex = s.Length;
        var sLength = s.Length;
        for (int i = 1; i < sLength && k > 0 ; i++)
        {
            if (s[i] == ' ')
            {
                k--;
                lastIndex = i;
            }
        }
        if (k == 1)
        {
            return s;
        }
        return s[..lastIndex];
    }
}