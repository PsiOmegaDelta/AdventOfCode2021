namespace AdventOfCode.Shared
{
    public static class InputParsers
    {
        public static char[][] ToCharArrays(this IEnumerable<string> input)
        {
            return input.Select(x => x.ToArray()).ToArray();
        }

        public static int[][] ToIntArrays(this IEnumerable<string> input)
        {
            return input
                .Select(x => x.Where(char.IsDigit).Select(x => (int)char.GetNumericValue(x)).ToArray())
                .ToArray();
        }
    }
}
