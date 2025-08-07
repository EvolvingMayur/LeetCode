public partial class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        Array.Sort(g);
        Array.Sort(s);
        int child = 0;
        for (int cookie = 0; cookie < s.Length && child < g.Length; cookie++)
        {
            if (s[cookie] >= g[child])
            {
                child++;
            }
        }

        return child;
    }
}