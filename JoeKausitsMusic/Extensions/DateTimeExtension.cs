using Humanizer;

namespace JoeKausitsMusic.Extensions
{
    public static class DateTimeExtension
    {
        public static string FormatDateRange(this DateTime startAt, DateTime endAt)
        {
            if (startAt.Date == endAt.Date)
            {
                //return $"{startAt:MMMM d} from {startAt:h:mm tt}-{endAt:h:mm tt}";
                return $"{startAt.FormatDate()}<br/>{startAt:h:mm}-{endAt:h:mm tt}";
            }

            return $"{startAt.FormatDate()} {startAt:h:mm tt} -<br/>{endAt.FormatDate()} {endAt:h:mm tt}";
        }

        public static string FormatDate(this DateTime date)
        {
            var month = date.ToString("MMMM");
            var dateString = date.Day.Ordinalize();

            return $"{month} {dateString}";
        }
    }
}
