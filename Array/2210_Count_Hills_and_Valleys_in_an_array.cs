public partial class Solution {
    public int CountHillValley(int[] nums) {
        if (nums.Length < 3)
        {
            return 0;
        }
        bool ascent = false;
        var followIndex = 1;
        var count = 0;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i+1])
            {
                followIndex++;
                continue;
            }
            if (nums[i] < nums[i+1])
            {
                ascent = true;
            }
            break;
        }

        for (int i = followIndex + 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[followIndex])
            {
                followIndex = i;
                continue;
            }
            if (ascent && nums[i] < nums[followIndex])
            {
                count++;
                ascent = false;

            }
            else if (!ascent && nums[i] > nums[followIndex])
            {
                count++;
                ascent = true;
            }
            followIndex = i;
        }
        return count;
    }
}