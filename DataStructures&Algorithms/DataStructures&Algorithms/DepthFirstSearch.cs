using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms
{
    internal class DepthFirstSearch
    {
        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            int R = image.Length;
            int C = image[0].Length;
            if (image[sr][sc] == newColor) return image;
            void dfs(int r, int c, int color)
            {
                if (r < 0 || r >= R || c < 0 || c >= C || image[r][c] != color) return;
                image[r][c] = newColor;
                dfs(r + 1, c, color);
                dfs(r - 1, c, color);
                dfs(r, c + 1, color);
                dfs(r, c - 1, color);
            }
            dfs(sr, sc, image[sr][sc]);
            return image;
        }
    }
}
