public partial class Solution {
    public int IslandPerimeter(int[][] grid)
    {
        var perimeter = 0;
        var length = grid.Length;
        var width = grid[0].Length;
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (grid[i][j] == 1)
                {

                    if (j == 0 || grid[i][j - 1] == 0)
                    {
                        perimeter++;
                    }
                    if (i == 0 || grid[i - 1][j] == 0)
                    {
                        perimeter++;
                    }
                    if (j == width - 1 || grid[i][j + 1] == 0)
                    {
                        perimeter++;
                    }
                    if (i == length - 1 || grid[i + 1][j] == 0)
                    {
                        perimeter++;
                    }
                }
            }
        }
        return perimeter;
    }
}