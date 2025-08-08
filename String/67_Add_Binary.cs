using System.Text;

public partial class Solution
{
    public string AddBinary(string a, string b)
    {
        int aLength = a.Length;
        int bLength = b.Length;
        if (aLength < bLength)
        {
            return AddBinary(b, a);
        }
        char[] result = new char[aLength + 1];
        int carry = 0;

        for (int aIndex = aLength - 1, bIndex = bLength - 1; aIndex >= 0; aIndex--, bIndex--)
        {
            int aBit = a[aIndex] - '0';
            int bBit = 0;
            if (bIndex >= 0)
            {
                bBit = b[bIndex] - '0';
            }
            int sum = aBit + bBit + carry;
            result[aIndex + 1] = (char)('0' + (aBit ^ bBit ^ carry));
            carry = sum / 2;
        }
        if (carry > 0)
        {
            result[0] = '1';
            return new string(result);
        }
        else
        {
            return new string(result, 1, aLength);
        }
    }
}