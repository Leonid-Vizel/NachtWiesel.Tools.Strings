namespace Nabla.Tools.Common;

public static class BooleanExtensions
{
    public static string? ToYesNoString(this bool? flag, string? nullValue = "Не указано", string yesValue = "Да", string noValue = "Нет")
    {
        return flag switch
        {
            true => yesValue,
            false => noValue,
            _ => nullValue,
        };
    }
    public static string? ToYesNoString(this bool flag, string? nullValue = "Не указано", string yesValue = "Да", string noValue = "Нет")
        => ToYesNoString(flag as bool?, nullValue, yesValue, noValue);
}
