using System;
using System.Collections.Generic;
using System.Text;

namespace NetCart.Core.Utilities;

public static class PriceUtility
{
    public static decimal ApplyDiscount(decimal price, decimal discountPercentage)
    {
        if (discountPercentage < 0 || discountPercentage > 100)
            throw new ArgumentOutOfRangeException(nameof(discountPercentage));

        return price - (price * discountPercentage / 100);
    }

    private static readonly string[] UnitsMap =
{ "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine",
  "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen",
  "Seventeen", "Eighteen", "Nineteen" };

    private static readonly string[] TensMap =
    { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

    public static string ToWords(this int number)
    {
        if (number == 0)
            return "Zero";

        if (number < 0)
            return "Minus " + ToWords(Math.Abs(number));

        string words = "";

        if ((number / 1000000) > 0)
        {
            words += ToWords(number / 1000000) + " Million ";
            number %= 1000000;
        }

        if ((number / 1000) > 0)
        {
            words += ToWords(number / 1000) + " Thousand ";
            number %= 1000;
        }

        if ((number / 100) > 0)
        {
            words += ToWords(number / 100) + " Hundred ";
            number %= 100;
        }

        if (number > 0)
        {
            if (words != "")
                words += "and ";

            if (number < 20)
                words += UnitsMap[number];
            else
            {
                words += TensMap[number / 10];
                if ((number % 10) > 0)
                    words += "-" + UnitsMap[number % 10];
            }
        }

        return words.Trim();
    }
    public static string FormatCurrency(decimal amount, string currencySymbol = "INR:")
    {
        return $"{currencySymbol}{amount:N2}";
    }
}

