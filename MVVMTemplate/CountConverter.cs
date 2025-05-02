using System.Globalization;

namespace MVVMTemplate;

public class CountConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture) =>
        (int)value! switch
        {
            0 => "No clicks yet",
            1 => "Clicked once",
            2 => "Clicked twice",
            _ => $"Clicked {value} times!"
        };

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture) => null!;
}