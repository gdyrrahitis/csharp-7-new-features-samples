namespace CSharpSeven.OutVariables
{
    public class StringConverterToInteger
    {
        public static int GetIntegerFromString(string number)
        {
            int.TryParse(number, out int value);
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
