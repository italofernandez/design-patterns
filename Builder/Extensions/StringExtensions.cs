public static class StringExtensions
{
    public static string ConcatIfIsNotNull(this string original, string valueToConcat) 
        => string.IsNullOrEmpty(valueToConcat) ? original : original + valueToConcat;
}