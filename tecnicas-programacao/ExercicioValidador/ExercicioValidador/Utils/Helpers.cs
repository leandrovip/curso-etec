using System.Linq;

namespace ExercicioValidador.Utils
{
    public static class Helpers
    {
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        public static string OnlyNumbers(this string value)
        {
            return value.Trim().IsNullOrEmpty()
                ? string.Empty
                : new string(value.Where(char.IsDigit).ToArray());
        }
    }
}