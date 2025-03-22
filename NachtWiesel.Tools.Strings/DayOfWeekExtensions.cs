namespace Nabla.Tools.Common;

public static class DayOfWeekExtensions
{
    public static string? ToRussian(this DayOfWeek week)
    {
        return week switch
        {
            DayOfWeek.Monday => "Пн",
            DayOfWeek.Tuesday => "Вт",
            DayOfWeek.Wednesday => "Ср",
            DayOfWeek.Thursday => "Чт",
            DayOfWeek.Friday => "Пт",
            DayOfWeek.Saturday => "Сб",
            DayOfWeek.Sunday => "Вс",
            _ => null
        };
    }
}
