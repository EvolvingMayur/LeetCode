public partial class Solution {
    public int LengthOfLastWord(string s) {
        //100_23.48_40.1
        s = s.TrimEnd();
        var length = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == ' ')
            {
                return length;
            }
            length++;
        }
        return length;
    }
}