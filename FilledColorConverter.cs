using System;
using System.Globalization;

namespace fmr.NovaUI.Converters;

/// <summary>
/// Converter used to color the Filled text
/// </summary>
public sealed class FilledColorConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        string txtValue = value?.ToString();
        ResourceDictionary resources = Application.Current?.Resources;
        Color defaultTextColor = Color.FromArgb("#FFECECEC");
        if (txtValue.Length > 0)
        {
            string[] splits = txtValue.Split('/');
            if (splits.Length > 0)
            {
                if (splits[0] == "0")
                {
                    return resources?.TryGetValue("FilledText"),out object textColorResource) == true
                        ? textColorResource as Color
                        : defaultTextColor;
                }
            }
        }
        return defaultTextColor;
    }
    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}