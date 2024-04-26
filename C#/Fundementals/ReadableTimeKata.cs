namespace Fundementals;

public class ReadableTimeKata
{

    /*
        Zadání:
            Write a function, which takes a non-negative  integer  (seconds)  as
            input and returns the time in a human-readable format (HH:MM:SS)

            HH = hours, padded to 2 digits, range: 00 - 99 MM = minutes,  padded
            to 2 digits, range: 00 - 59 SS = seconds, padded to 2 digits, range:
            00 - 59 The maximum time never exceeds 359999 (99:59:59)

            You can find some examples in the test fixtures.

        Řešení:
            We first get the hours - we divide the seconds by 3600  (one  hour).
            Then we subtract from the total seconds  the  number  of  hours  and
            divide by 60 seconds, that means we get total number of minutes.  If
            we subract both  hours  and  minutes  we  get  the  total  remaining
            seconds.
    */
    public static string GetReadableTime(int seconds)
    {
        int intHours = seconds / 3600;
        int intMinutes = (seconds - intHours * 3600) / 60;
        int intSeconds = seconds - (intHours * 3600 + intMinutes * 60);

        string hours = intHours.ToString();
        string minutes = intMinutes.ToString();
        string seconds2 = intSeconds.ToString();

        if (hours.Length == 1)
        {
            hours = "0" + hours;
        }

        if (minutes.Length == 1)
        {
            minutes = "0" + minutes;
        }

        if (seconds2.Length == 1)
        {
            seconds2 = "0" + seconds2;
        }

        return hours + ":" + minutes + ":" + seconds2;
    }
}
