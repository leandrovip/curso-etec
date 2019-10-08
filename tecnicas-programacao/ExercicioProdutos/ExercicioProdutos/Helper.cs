namespace ExercicioProdutos
{
    public static class Helper
    {
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static decimal ToDecimal(this string value)
        {
            decimal.TryParse(value, out var result);
            return result;
        }
    }
}