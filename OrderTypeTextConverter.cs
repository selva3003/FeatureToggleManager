using System;
using System.Globalization;

namespace fmr.NovaUI.Converters;

/// <summary>
/// Converts the order type text display
/// </summary>
public sealed class OrderTypeTextConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        string txtValue = value?.ToString();
        if (txtValue.Length > 0)
        {
            string[] arr = txtValue.Split(' ');
            string letter = string.Empty;
            string number = string.Empty;
            foreach (string item in arr)
            {
                if (decimal.TryParse(item, out decimal result))
                {
                    number = decimal.Parse(item).ToString("0.####");
                }
                else
                {
                    letter = letter + item + " ";
                }
            }
            return char.ToUpper(letter[0]) + letter.Substring(1) + number;
        }
        return value;
    }
    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}