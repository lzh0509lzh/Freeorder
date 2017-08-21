using B1993.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B1993.BLL.Base
{
    public class WeChat
    {
        #region JS-SDK使用权限签名
        public string JSconfig(string url)
        {
            string strJson = "";
            try
            {
                wx_requestdata bll = new wx_requestdata();
                List<Entity.wx_requestdata> mylist = new List<Entity.wx_requestdata>();
                mylist = bll.GetListCustomByDataKey("jsapi_ticket");
                string jsapi_ticket = mylist[0].DataValue.Trim();

                string noncestr = GetTimeID.GetRandomStr(16);
                string timestamp = GetTimeID.GetTimeStamp();
                string signature = "";

                #region 签名算法
                Dictionary<string, string> dics = new Dictionary<string, string>();
                dics.Add("jsapi_ticket", jsapi_ticket);
                dics.Add("noncestr", noncestr);
                dics.Add("timestamp", timestamp);
                dics.Add("url", url);
                string string1 = getParamSrc(dics).ToString().Trim();
                signature = WxSHA1.SHA1(string1);
                #endregion

                strJson = "{\"signature\":\"" + signature + "\",\"noncestr\":\"" + noncestr + "\",\"timestamp\":" + timestamp + "}";
                
            }
            catch(Exception ex)
            {
                ex.ToString();
            }
            return strJson;
        }
        #endregion

        #region 字典序
        public static String getParamSrc(Dictionary<string, string> paramsMap)
        {
            var vDic = (from objDic in paramsMap orderby objDic.Key ascending select objDic);
            StringBuilder str = new StringBuilder();
            foreach (KeyValuePair<string, string> kv in vDic)
            {
                string pkey = kv.Key;
                string pvalue = kv.Value;
                str.Append(pkey + "=" + pvalue + "&");
            }

            String result = str.ToString().Substring(0, str.ToString().Length - 1);
            return result;
        }
        #endregion
    }
}
