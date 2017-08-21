using System;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;

namespace B1993.WebCommon
{
    public class JSONUtility<T> where T : class
    {
        /// <summary>
        /// json序列化
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string Serialize(object obj)
        {
            string jsonStr = new JavaScriptSerializer().Serialize(obj);
            jsonStr = Regex.Replace(jsonStr, @"\\/Date\((\d+)\)\\/", match =>
            {
                DateTime dt = new DateTime(1970, 1, 1);
                dt = dt.AddMilliseconds(long.Parse(match.Groups[1].Value));
                dt = dt.ToLocalTime();
                return dt.ToString("yyyy-MM-dd HH:mm:ss");
            });
            jsonStr = Regex.Replace(jsonStr, @"\\/Date\((-\d+)\)\\/", match =>
            {
                return "--";
            });
            return jsonStr;
        }

        /// <summary>
        /// json反序列化
        /// </summary>
        /// <param name="jsonStr"></param>
        /// <returns></returns>
        public static T DeSerialize(string jsonStr)
        {
            return new JavaScriptSerializer().Deserialize<T>(jsonStr);
        }
    }
}
