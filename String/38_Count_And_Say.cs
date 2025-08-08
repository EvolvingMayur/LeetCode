using System.Text;

public partial class Solution
{
    public string CountAndSay(int n)
    {
        string result = "1";

        for (int round = 1; round < n; round++)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int count = 1;
            char prev = result[0];

            for (int i = 1; i < result.Length; i++)
            {
                if (result[i] == prev)
                {
                    count++;
                }
                else
                {
                    stringBuilder.Append(count);
                    stringBuilder.Append(prev);
                    prev = result[i];
                    count = 1;
                }
            }
            stringBuilder.Append(count);
            stringBuilder.Append(prev);
            result = stringBuilder.ToString();
        }
        return result;
        // 79.87_64.15_42.5
        // string result = "1";

        // while (n > 1)
        // {
        //     StringBuilder stringBuilder = new StringBuilder();
        //     int count = 1;
        //     char prev = result[0];
        //     for (int i = 1; i < result.Length; i++)
        //     {
        //         if (result[i] == prev)
        //         {
        //             count++;
        //         }
        //         else
        //         {
        //             stringBuilder.Append(count);
        //             stringBuilder.Append(prev);
        //             prev = result[i];
        //             count = 1;
        //         }
        //     }
        //     stringBuilder.Append(count);
        //     stringBuilder.Append(prev);

        //     result = stringBuilder.ToString();
        //     n--;
        // }
        // return result;
    }
}