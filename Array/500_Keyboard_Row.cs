public partial class Solution
{
    public string[] FindWords(string[] words)
    {
        var firstRow = new HashSet<char>("qwertyuiop");
        var secondRow = new HashSet<char>("asdfghjkl");
        var thirdRow = new HashSet<char>("zxcvbnm");

        var result = new List<string>();

        foreach (var word in words)
        {
            var lowerWord = word.ToLower();

            HashSet<char> targetRow = firstRow.Contains(lowerWord[0]) ? firstRow :
                                      secondRow.Contains(lowerWord[0]) ? secondRow :
                                      thirdRow;

            bool sameRow = true;
            for (int i = 1; i < lowerWord.Length; i++)
            {
                if (!targetRow.Contains(lowerWord[i]))
                {
                    sameRow = false;
                    break;
                }
            }

            if (sameRow)
            {
                result.Add(word); // Keep original casing
            }
        }
        return [.. result];
    }
}