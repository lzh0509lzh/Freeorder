using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using B1993.Web.com;//公网引用
//using B1993.Web.localhost;////本地引用

namespace B1993.Web.Ajaxlib
{
    /// <summary>
    /// wxHandler 微信相关 create by lee
    /// </summary>
    public class Handler : IHttpHandler
    {
        #region 公共属性

        public sWebBamboo slife = new sWebBamboo();
        /// <summary> 固定验证头
        /// </summary>
        public LifeUserAuthentication UserAuthentication = new LifeUserAuthentication();
        /// <summary> 动态验证头
        /// </summary>
        public LifeUserAuthenticationDy UserAuthenticationDy = new LifeUserAuthenticationDy();
        /// <summary> 请求上下文
        /// </summary>
        HttpContext Context = null;
        /// <summary> 响应数据，JSON格式
        /// </summary>
        string strJson = "";

        #endregion

        public void ProcessRequest(HttpContext context)
        {
            #region 初始化公共属性
            this.Context = context;
            #endregion

            #region 验证头属性
            //静态验证头属性
            UserAuthentication.UserId = "2688";
            UserAuthentication.PassWord = "268826881";

            //动态验证头属性，用户名密码写死 
            UserAuthenticationDy.UserId = "2688";
            UserAuthenticationDy.PassWord = "268826881";
            #endregion

            if (context.Request.Params["action"].Trim().ToLower() != null)
            {
                switch (context.Request.Params["action"].Trim().ToLower())
                {
                    case "jsconfig":    //获取JsSDK的验证参数
                        Jsconfig();
                        break;
                    default:
                        break;
                }
                Context.Response.Clear();
                Context.Response.ContentType = "text/html";
                Context.Response.Write(strJson);
                Context.Response.Flush();
                Context.Response.End();
            }
        }


        #region 获取JsSDK的验证参数
        public void Jsconfig()
        {
            string url = HttpUtility.UrlDecode(Context.Request["url"]).ToString();
            slife.LifeUserAuthenticationValue = UserAuthentication;
            strJson = slife.GetJSconfig(url);
        }
        #endregion


        #region 预留尾部
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
        #endregion
    }
}