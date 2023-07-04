namespace Helper.Date;

public static class DateHelper
{
    public static DateTime GetCurrentDateTimeUtc() => DateTime.UtcNow;

    public static DateTime GetCurrentDateTimeUtc(string format)
    {
        var currentDateTimeUtc = GetCurrentDateTimeUtc();
        return DateTime.ParseExact(currentDateTimeUtc.ToString(format), format, null);
    }

    public static DateTime GetCurrentDateTime() => DateTime.Now;

    public static DateTime GetCurrentDateTime(string format)
    {
        var currentDateTime = GetCurrentDateTime();
        return DateTime.ParseExact(currentDateTime.ToString(format), format, null);
    }

    public static DateTime GetPreviousDateTimeUtc(int days) => GetCurrentDateTimeUtc().AddDays(-days);

    public static DateTime GetPreviousDateTimeUtcWithFormat(int days, string format)
    {
        var previousDateTimeUtc = GetPreviousDateTimeUtc(days);
        return DateTime.ParseExact(previousDateTimeUtc.ToString(format), format, null);
    }

    public static DateTime GetPreviousDateTime(int days) => GetCurrentDateTime().AddDays(-days);

    public static DateTime GetPreviousDateTimeWithFormat(int days, string format)
    {
        var previousDateTime = GetPreviousDateTime(days);
        return DateTime.ParseExact(previousDateTime.ToString(format), format, null);
    }

    public static DateTime GetNextDateTimeUtc(int days) => GetCurrentDateTimeUtc().AddDays(days);

    public static DateTime GetNextDateTimeUtcWithFormat(int days, string format)
    {
        var nextDateTimeUtc = GetNextDateTimeUtc(days);
        return DateTime.ParseExact(nextDateTimeUtc.ToString(format), format, null);
    }

    public static DateTime GetNextDateTime(int days) => GetCurrentDateTime().AddDays(days);

    public static DateTime GetNextDateTimeWithFormat(int days, string format)
    {
        var nextDateTime = GetNextDateTime(days);
        return DateTime.ParseExact(nextDateTime.ToString(format), format, null);
    }
}