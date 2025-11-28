using System;
using System.Globalization;
using System.Runtime.InteropServices;

public enum Location
{
    NewYork,
    London,
    Paris
}

public enum AlertLevel
{
    Early,
    Standard,
    Late
}

public static class Appointment
{
    public static DateTime ShowLocalTime(DateTime dtUtc) => dtUtc.ToUniversalTime();

    public static DateTime Schedule(string appointmentDateDescription, Location location)
    {
        var timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(FindLocationZoneId(location));
        return TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse(appointmentDateDescription), timeZoneInfo);
    }

    public static DateTime GetAlertTime(DateTime appointment, AlertLevel alertLevel) => alertLevel switch
    {
            AlertLevel.Early => appointment.AddDays(-1),
            AlertLevel.Standard => appointment.AddMinutes(-105),
            AlertLevel.Late => appointment.AddMinutes(-30),
            _ => appointment
    };

    public static bool HasDaylightSavingChanged(DateTime dt, Location location)
    {
        var timeZone = TimeZoneInfo.FindSystemTimeZoneById(FindLocationZoneId(location));
        if(timeZone.IsDaylightSavingTime(dt) != timeZone.IsDaylightSavingTime(dt.AddDays(-7)))
            return true;
        return false;
    }

    public static DateTime NormalizeDateTime(string dataTimeText, Location location)
    {
        var cultureInfo = GetLocationCultureInfo(location);
        var isSuccess = DateTime.TryParse(dataTimeText, cultureInfo, DateTimeStyles.None, out var dateTime);
        return isSuccess ? dateTime : new(1, 1, 1);
    }

    /** 
        Helper methods for getting correct location id.
    */
    private static string FindLocationZoneId(Location loc)
    {
        if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            return WindowsZone(loc);
        }

        return NonWindowsZone(loc);
    }

    private static string WindowsZone(Location loc) => loc switch
    {
            Location.NewYork => "Eastern Standard Time",
            Location.Paris => "W. Europe Standard Time",
            _ => "GMT Standard Time"
    };

    private static string NonWindowsZone(Location loc) => loc switch
    {
            Location.NewYork => "America/New_York",
            Location.Paris => "Europe/Paris",
            _ => "Europe/London"
    };

    private static CultureInfo GetLocationCultureInfo(Location location)
    {
        var culture = location switch
        {
            Location.NewYork => "en-US",
            Location.London => "en-GB",
            Location.Paris => "fr-FR",
            _ => throw new ArgumentOutOfRangeException(),
        };
        return CultureInfo.GetCultureInfo(culture);
    }
        
}
