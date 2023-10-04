internal class Solution
{
    internal int FindCenter(List<Vector> edges)
    {
        var zero = edges[0];
        var one = edges[1];
        return zero.Vertical.Equals(one.Vertical) || zero.Vertical.Equals(one.Horizontal)
            ? zero.Vertical
            : one.Vertical;
    }
}