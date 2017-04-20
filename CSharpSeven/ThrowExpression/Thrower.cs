using System;

namespace CSharpSeven.ThrowExpression
{
    public class Thrower
    {
        public int GetStringLengthOrThrowIfNull(string value)
        {
            return value is null ?
                throw new NullReferenceException($"{nameof(value)} should not be null") :
                value.Length;
        }
    }
}
