public partial class Solution {
   public string RestoreString(string s, int[] indices)
    {
        var stringLength = s.Length;
        var charArray = new char[stringLength];
        var lengthIndex = 0;
        foreach (var index in indices)
        {
            charArray[index] = s[lengthIndex];
            lengthIndex++;
        }
        return new string(charArray);
    }
}