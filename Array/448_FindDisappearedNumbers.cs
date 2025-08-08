public partial class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        var returnList = new List<int>();
        var numSet = new HashSet<int>(nums);
        var numLength = nums.Length;
        for (int i = 0; i < numLength; i++)
        {
            if (!numSet.Contains(i))
            {
                returnList.Add(i);
            }
        }
        return returnList;
    }
}