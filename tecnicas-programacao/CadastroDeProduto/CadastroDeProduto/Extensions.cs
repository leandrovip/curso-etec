namespace CadastroDeProduto
{
    public static class Extensions
    {
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static bool IsDecimal(this string value)
        {
            decimal.TryParse(value, out var result);
            return result != 0m;
        }

        public static decimal ToDecimal(this string value)
        {
            decimal.TryParse(value, out var result);
            return result;
        }
    }
}