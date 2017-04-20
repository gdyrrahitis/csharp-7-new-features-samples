namespace CSharpSeven.PatternMatching.Types
{
    public class TypesWithIsOperator
    {
        public bool IsCustomReferenceType(object obj)
        {
            if (obj is CustomReferenceType t)
            {
                return t.True;
            }

            return false;
        }

        public bool IsNullableIntGreaterThanTen(int? value)
        {
            if (value is int v)
            {
                return v > 10;
            }

            return false;
        }
    }

    public class CustomReferenceType
    {
        public bool True => true;
    }
}
