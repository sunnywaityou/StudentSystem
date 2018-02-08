using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GxHelper
{
    public static class BaseHelper
    {
        /// <summary>
        /// 对象转成Json字符串
        /// </summary>
        /// <param name="obj">对象</param>
        /// <returns></returns>
        public static string ToJson(this object obj)
        {
            string json = obj.ToString();
            if(obj.GetType()!=typeof(string))
            {
                json = JsonConvert.SerializeObject(obj);
            }
            return json;
        }

        /// <summary>
        /// Json字符串转成对象
        /// </summary>
        /// <typeparam name="T">待转类型</typeparam>
        /// <param name="json">Json字符串</param>
        /// <returns></returns>
        public static T JsonToObj<T>(this string json)
        {
            Type type = typeof(T);
            return (T)json.JsonToObj(type);
        }
        /// <summary>
        /// Json字符串转成对象
        /// </summary>
        /// <param name="json">Json字符串</param>
        /// <param name="type">待转类型</param>
        /// <returns></returns>
        public static object JsonToObj(this string json, Type type)
        {
            object obj = null;
            if (type.IsValueType && type != typeof(string))
            {
                obj = JsonConvert.DeserializeObject(json, type);
            }
            else
            {
                obj = Convert.ChangeType(json, type);
            }
            return obj;
        }
    }
}
