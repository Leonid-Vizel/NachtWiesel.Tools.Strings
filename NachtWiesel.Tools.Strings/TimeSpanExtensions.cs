using System.Text;

namespace NachtWiesel.Tools.Strings;

public static class TimeSpanExtensions
{
    public static string ToRussian(this TimeSpan span, bool backThen = true)
    {
        int days = span.Days;
        int hours = span.Hours;
        int minutes = span.Minutes;
        int seconds = span.Seconds;
        StringBuilder builder = new StringBuilder();
        if (days > 0)
        {
            builder.Append($"{days} {days.Inflect("дней", "день", "дня")} ");
        }
        if (hours > 0)
        {
            builder.Append($"{hours} {hours.Inflect("часов", "час", "часа")} ");
        }
        if (minutes > 0)
        {
            builder.Append($"{minutes} {minutes.Inflect("минут", "минуту", "минуты")} ");
        }
        builder.Append($"{seconds} {seconds.Inflect("секунд", "секунду", "секунды")}");
        return backThen ? builder.Append(" назад").ToString() : builder.ToString();
    }
}
