public partial class Solution {
    public int StrStr(string haystack, string needle) {
        if (haystack.Length < needle.Length)
        {
            return -1;
        }
        int checkLength = haystack.Length - needle.Length;
        for (int i = 0; i <= checkLength; i++)
        {
            if (haystack[i] == needle[0])
            {
                var found = true;
                for (int j = 1; j < needle.Length; j++)
                {
                    if (haystack[i + j] != needle[j])
                    {
                        found = false;
                        break;
                    }
                }
                if (found)
                {
                    return i;
                }
            }
        }
        return -1;
    }
}