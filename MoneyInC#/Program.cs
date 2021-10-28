using System.Globalization;

namespace MoneyInC_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            decimal value = 10m; // m indicates that's for money

            Console.WriteLine(
                value.ToString(
                    "G",
                    CultureInfo.CreateSpecificCulture("pt-BR")
                )
            );

            // Currency
            Console.WriteLine(
                value.ToString(
                    "C",
                    CultureInfo.CreateSpecificCulture("pt-BR")
                )
            );

            // Calc
            Console.WriteLine(
                value.ToString(
                    "E04",
                    CultureInfo.CreateSpecificCulture("pt-BR")
                )
            );

            // without dot
            Console.WriteLine(
                value.ToString(
                    "F",
                    CultureInfo.CreateSpecificCulture("pt-BR")
                )
            );

            // percent
            Console.WriteLine(
                value.ToString(
                    "P",
                    CultureInfo.CreateSpecificCulture("pt-BR")
                )
            );
        }
    }
}