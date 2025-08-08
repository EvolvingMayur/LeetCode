public partial class Solution {
    public IList<string> FizzBuzz(int n) {
        string[] arr = new string[n];
        for (int i = 1; i <= n; i++)
        {
            var j = i - 1;
            if (i % 15 == 0)
            {
                arr[j] = "FizzBuzz";
            }
            else if (i % 5 == 0)
            {
                arr[j] = "Buzz";
            }
            else if (i % 3 == 0)
            {
                arr[j] = "Fizz";
            }
            else
            {
                arr[j] = i.ToString();
            }
        }
        return arr;
    }
}