public class Solution {
    public int[] PlusOne(int[] digits)
    {
        var lastIndex = digits.Length - 1;
        do
        {
            digits[lastIndex] = digits[lastIndex] == 9 ?  0 : ++digits[lastIndex];
            lastIndex--;
        } while (digits[lastIndex + 1] == 0 && lastIndex >= 0);
        if (digits[0] == 0)
        {
            digits = [1, ..digits];
        }
        return digits;
    }
}