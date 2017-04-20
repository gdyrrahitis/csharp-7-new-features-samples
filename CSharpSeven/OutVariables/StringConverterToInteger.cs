namespace CSharpSeven.OutVariables
{
    public static class CustomConverter
    {
        public static int GetIntTimesTenOrDefault(string number)
        {
            if (int.TryParse(number, out int value)) {
                return value * 10;
            }

            // Value variable is visible to this scope, not only inside the if scope
            return value;
        }

        public static void GetIntegerFromStringWithDiscards(out int x, out int y)
        {
            int.TryParse("5", out var a);
            int.TryParse("6", out var b);

            x = a;
            y = b;
        }
    }
}
