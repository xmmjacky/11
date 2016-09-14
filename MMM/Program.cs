using Exceptionless;
using Exceptionless.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMM
{
    class Program
    {
       
        static void Main(string[] args)
        {
            #region 日期操作
            //int day = (int)DateTime.Now.DayOfWeek;
            //var start = DateTime.Now.AddDays(-day);
            //var end = DateTime.Now.AddDays(7-day-1);
            //var daystring = "";
            //var oldtime = "2016-07-23 01:55:16";
            //var datatime = DateTime.Now;
            //var data = datatime.ToShortDateString();
            //var time = datatime.ToShortTimeString();
            //var day = (Convert.ToDateTime(oldtime) - datatime).TotalDays;
            //if (day > 0 && day <= 1)
            //{
            //    daystring = "今天";
            //}
            //Console.WriteLine("值：" + "~" + day + daystring);
            //var date = DateTime.Now;
            //var day = date.Day;
            ////if(day.ToString().Contains("6"))
            //var a = date.Hour;
            //Console.WriteLine("日期" + day+a);
            //Console.ReadKey();
            #endregion

            var client = new ExceptionlessClient(c => {
                c.ApiKey = "8gkvV4tM2pYXUGAO5j6boi9Qddmc7M1r0UXtTjep";
                c.ServerUrl = "http://localhost:9006";
            });

            try
            {
                throw new Exception("test exception " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss"));
            }
            catch (Exception ex)
            {
                client.SubmitException(ex);
                //ex.ToExceptionless().Submit();
                Console.WriteLine("error send");
            }
            Console.ReadKey();
        }
       
    }

    public class DateEnmp
    {
        public static String TODAY = "今天";
        public static String YESTERDAY = "昨天";
        public static String TOMORROW = "明天";
        public static String BEFORE_YESTERDAY = "前天";
        public static String AFTER_TOMORROW = "后天";
        public static String SUNDAY = "星期日";
        public static String MONDAY = "星期一";
        public static String TUESDAY = "星期二";
        public static String WEDNESDAY = "星期三";
        public static String THURSDAY = "星期四";
        public static String FRIDAY = "星期五";
        public static String SATURDAY = "星期六";
    }

    //public class mytime
    //{
    //    public override int[] Eras
    //    {
    //        get
    //        {
    //            throw new NotImplementedException();
    //        }
    //    }

    //    //public static String getDateDetail(String date)
    //    //{
    //    //    Calendar today = new Calendar();
    //    //    Calendar target = Calendar.getInstance();

    //    //    DateFormat df = new SimpleDateFormat(Config.DATE_FORMAT);
    //    //    try
    //    //    {
    //    //        today.setTime(df.parse(getNowDateToStr()));
    //    //        today.set(Calendar.HOUR, 0);
    //    //        today.set(Calendar.MINUTE, 0);
    //    //        today.set(Calendar.SECOND, 0);
    //    //        target.setTime(df.parse(date));
    //    //        target.set(Calendar.HOUR, 0);
    //    //        target.set(Calendar.MINUTE, 0);
    //    //        target.set(Calendar.SECOND, 0);
    //    //    }
    //    //    catch (Exception ex)
    //    //    {
    //    //        return null;
    //    //    }
    //    //    long intervalMilli = target.getTimeInMillis() - today.getTimeInMillis();
    //    //    int xcts = (int)(intervalMilli / (24 * 60 * 60 * 1000));
    //    //    return showDateDetail(xcts, target);

    //    //}
    //    ///**
    //    // * 将日期差显示为日期或者星期
    //    // */
    //    //private static String showDateDetail(int xcts, Calendar target)
    //    //{
    //    //    switch (xcts)
    //    //    {
    //    //        case 0:
    //    //            return DateEnmp.TODAY;
    //    //        case 1:
    //    //            return DateEnmp.TOMORROW;
    //    //        case 2:
    //    //            return DateEnmp.AFTER_TOMORROW;
    //    //        case -1:
    //    //            return DateEnmp.YESTERDAY;
    //    //        case -2:
    //    //            return DateEnmp.BEFORE_YESTERDAY;
    //    //        default:
    //    //            int dayForWeek = 0;
    //    //            dayForWeek = target.get(Calendar.DAY_OF_WEEK);
    //    //            switch (dayForWeek)
    //    //            {
    //    //                case 1: return DateEnmp.SUNDAY;
    //    //                case 2: return DateEnmp.MONDAY;
    //    //                case 3: return DateEnmp.TUESDAY;
    //    //                case 4: return DateEnmp.WEDNESDAY;
    //    //                case 5: return DateEnmp.THURSDAY;
    //    //                case 6: return DateEnmp.FRIDAY;
    //    //                case 7: return DateEnmp.SATURDAY;
    //    //                default: return null;
    //    //            }

    //    //    }
    //    //}
    //}
}
