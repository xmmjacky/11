using Exceptionless;
using Exceptionless.Configuration;
using Exceptionless.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
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
            #region 开源日志管理
            //var client = new ExceptionlessClient(c => {
            //    c.ApiKey = "8gkvV4tM2pYXUGAO5j6boi9Qddmc7M1r0UXtTjep";
            //    c.ServerUrl = "http://localhost:9006";
            //});
            //ExceptionlessClient.Default.Startup("8gkvV4tM2pYXUGAO5j6boi9Qddmc7M1r0UXtTjep");
            //try
            //{
            // throw new Exception("王少龙 exception " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss"));
            //}
            //catch (Exception ex)
            //{
            // client.SubmitException(ex);
            //ex.ToExceptionless().Submit();
            // ExceptionlessClient.Default.SubmitException(s);
            //Console.WriteLine("error send");
            //}
            #endregion

            #region 序列化linq
            //var m = new Persion
            //{
            //    Age = 1,
            //    Name = "测试",
            //    Sex = 1,
            //    Like = "读书"
            //};
            //var list = new List<Persion>();
            //list.Add(m);
            //var m1 = new Persion { Age = 2, Name = "辛明明", Sex = 2, Like = "打球" };
            //list.Add(m1);
            //var t1 = list.Where(p => p.Name.Any()).Select(p => p.Like).ToList();
            //Console.WriteLine(t1[0]);
            //Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(t1));
            //Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(list));
            #endregion
            //var a = 0xab;
            //var b = 0xac;
            //var random = new Random();
            //var data = RandomExtent.GetRandomString(171);
            #region 反编译后源代码
            //string str = "+TxMCVfdn8OrHu74UCy9gf1roql32/E1Hv3hu2T6fjuP3W/cXdsx7kMdbcHnUG5FCnw3vizbARiv57LBGEFGpMMbNHhfhNhQ29LvWVMlS1BGV7n+CZOtqaiL2XohoGq2FjVN80OylS1blszE09e1SdH2/QAyilTQi8LVYITqf6PD0P+okW1ym75jShdM7Fkd8qMuD1ODfAg+axhtzu3Lg7a+tBE+bYCDpOy6Ea26yKQOLjsaWMKZWeN9FULL8etB0pVse4AVsKGLsH4qWWlrPc+zOaz0caoht50ZwzjS7BMpzfKSeAFZ7f5Rg6JO5oIe5Vv9Tkce/nI=";
            //str = RandomExtent.JieMi(str, "new0ren9");
            //var str2 = "4109D-594CF-D670A-0B1CA-61ADF";
            //str2 = str2.Substring(0, 0x11);
            //var data = new Program().method_3(str, str2, "");
            //Console.WriteLine(str);
            //Console.WriteLine(str2);
            #endregion
            #region md5加密
            // var a = "{\"orderId\":\"RTDAUWBTH4CJ\",\"reasonType\":0,\"remark\":\"爱推广取消\"}";
            // var a = "{\"中国\":\"123456\"}";
            //MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            //byte[] InBytes = Encoding.GetEncoding("utf-8").GetBytes(a);
            //byte[] OutBytes = md5.ComputeHash(InBytes);
            //string OutString = "";
            //for (int i = 0; i < OutBytes.Length; i++)
            //{
            //    OutString += OutBytes[i].ToString("x2");
            //}
            // string OutString = "";
            // byte[] b = Encoding.GetEncoding("utf-8").GetBytes(a);
            // b = new MD5CryptoServiceProvider().ComputeHash(b);

            // for (int i = 0; i < b.Length; i++)
            // {
            //     OutString += b[i].ToString("x").PadLeft(2, '0');

            // }
            //OutString.PadLeft(32, '0');
            //var hexDigits = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f' }; // 用来将字节转换成 16 进制表示的字符
            //if (!string.IsNullOrEmpty(a))
            //{
            //    try
            //    {
            //        MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            //        byte[] InBytes = Encoding.GetEncoding("utf-8").GetBytes(a);
            //        byte[] OutBytes = md5.ComputeHash(InBytes);
            //        var str = new char[32];
            //        for (int i = 0, j = 0; i < 16; i++)
            //        {
            //            var temp = OutBytes[i];
            //            str[j++] = hexDigits[MoveByte(temp, 4) & 0xf];
            //            取字节中低 4 位的数字转换
            //           str[j++] = hexDigits[temp & 0xf];
            //        }
            //        OutString = new string(str);
            //    }
            //    catch (Exception ex)
            //    {
            //        throw ex;
            //    }
            //}
            // Console.WriteLine("b加密后的字符串为:{0}", OutString);
            #endregion

            #region url序列化
            //var str = "total_amount=0.01&buyer_id=2088102626120930&trade_no=2016122621001004930246855784&notify_time=2016-12-26+18%3a16%3a34&subject=%u93b5%u5b2b%u6e80%u93c0%ue219%u7caf&sign_type=RSA&buyer_logon_id=xin***%40163.com&auth_app_id=2016101002076359&charset=GBK&notify_type=trade_status_sync&invoice_amount=0.01&out_trade_no=160913164823346&trade_status=TRADE_SUCCESS&gmt_payment=2016-12-26+18%3a16%3a34&version=1.0&point_amount=0.00&sign=Kve5qwMAjPKglgbQ36GwaXwx5OIs9o1gYdW37iMvrua1uUioMbxKNztLl%2bIXHqhmkAnJKWLYZlclp6ERz7lDU1fx11NmHUV8ixQl7zf3VzWNAFbAmlO%2bwgWrzGKQ7ARpqU3iKN1hj9R9O0TMynYwrOJaZHOyveegF1QWElHP%2fss%3d&gmt_create=2016-12-26+18%3a16%3a33&buyer_pay_amount=0.01&receipt_amount=0.01&fund_bill_list=%5b%7b%22amount%22%3a%220.01%22%2c%22fundChannel%22%3a%22ALIPAYACCOUNT%22%7d%5d&app_id=2016101002076359&seller_id=2088421464422465&notify_id=85f766c03654ed48ca646131cad8fdan6e&seller_email=694530245%40qq.com ";
            //int questionMarkIndex = str.IndexOf('?');
            //var nestr = "";
            //if (questionMarkIndex == -1)
            //{
            //    nestr = str;
            //}
            //else
            //{
            //    nestr = str.Substring(0, questionMarkIndex);
            //}
            //string ps = nestr.Substring(questionMarkIndex + 1);
            //Regex re = new Regex(@"(^|&)?(\w+)=([^&]+)(&|$)?", RegexOptions.Compiled);
            //MatchCollection mc = re.Matches(ps);
            //Dictionary<String, String> paramsdicrionty = mc.Cast<Match>().ToDictionary(m => m.Result("$2").ToLower(), m => m.Result("$3"));
            //foreach(var item in paramsdicrionty)
            //{
            //    Console.WriteLine("字典的键和值{0}-------{1}", item.Key, item.Value);
            //}
            #endregion

            #region Model转换
            var m = new BookStoreDto()
            {
                Name="辛明明",
                CreateTime=DateTime.Now,
                Amount=100M,
                ID="Abc"
            };
            var model = DtoModle.Mapper<BookStoreDto,BookStore>(m);
            Console.WriteLine("返回结果:{0}", JsonConvert.SerializeObject(model));
            #endregion
            Console.ReadKey();
        }
        /// <summary>
        /// 特殊的右移位操作，补0右移，如果是负数，需要进行特殊的转换处理（右移位）java >>>
        /// </summary>
        /// <param name="value"></param>
        /// <param name="pos"></param>
        /// <returns></returns>
        public static int MoveByte(int value, int pos)
        {
            if (value < 0)
            {
                string s = Convert.ToString(value, 2);    // 转换为二进制
                for (int i = 0; i < pos; i++)
                {
                    s = "0" + s.Substring(0, 31);
                }
                return Convert.ToInt32(s, 2);            // 将二进制数字转换为数字
            }
            else
            {
                return value >> pos;
            }
        }
        private bool method_3(string string_0, string string_1, string string_2)
        {
            try
            {
                byte[] rgbHash = new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(string_1));
                RSACryptoServiceProvider key = new RSACryptoServiceProvider();
                key.FromXmlString(string_0);
                RSAPKCS1SignatureDeformatter deformatter = new RSAPKCS1SignatureDeformatter(key);
                deformatter.SetHashAlgorithm("MD5");
                byte[] rgbSignature = Convert.FromBase64String(string_2);
                return deformatter.VerifySignature(rgbHash, rgbSignature);
            }
            catch
            {
                return false;
            }
        }

    }


    public static class RandomExtent
    {
        private static byte[] byte_0;
        public static byte[] NextBytes(this Random random, int length)
        {
            var data = new byte[length];
            random.NextBytes(data);
            return data;
        }
        public static string GetRandomString(int iLength)
        {
            string buffer = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";// 随机字符中也可以为汉字（任何）  
            StringBuilder sb = new StringBuilder();
            Random r = new Random();
            int range = buffer.Length;
            for (int i = 0; i < iLength; i++)
            {
                sb.Append(buffer.Substring(r.Next(range), 1));
            }
            return sb.ToString();
        }
        public static string JieMi(string str, string ky)
        {
            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(ky);
                byte[] buffer = Convert.FromBase64String(str);
                DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
                MemoryStream stream = new MemoryStream();
                CryptoStream stream2 = new CryptoStream(stream, provider.CreateDecryptor(bytes, byte_0), CryptoStreamMode.Write);
                stream2.Write(buffer, 0, buffer.Length);
                stream2.FlushFinalBlock();
                return Encoding.UTF8.GetString(stream.ToArray());
            }
            catch
            {
                return str;
            }
        }

        public static string JiaMi(string str, string ky)
        {
            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(ky.Substring(0, 8));
                byte[] buffer = Encoding.UTF8.GetBytes(str);
                DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
                MemoryStream stream = new MemoryStream();
                CryptoStream stream2 = new CryptoStream(stream, provider.CreateEncryptor(bytes, byte_0), CryptoStreamMode.Write);
                stream2.Write(buffer, 0, buffer.Length);
                stream2.FlushFinalBlock();
                return Convert.ToBase64String(stream.ToArray());
            }
            catch
            {
                return str;
            }
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


        //checked(200000000000);
        //int a = 200000000000000;
    }
}


public class Persion
{
    public string Name { get; set; }

    public int Age { get; set; }

    public int Sex { get; set; }

    public string Like { get; set; }
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
//}
