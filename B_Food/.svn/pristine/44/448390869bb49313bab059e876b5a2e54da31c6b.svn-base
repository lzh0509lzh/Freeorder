using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace B1993.Web.WeChat.Wxlogin
{
    /// <summary>
    /// 微信授权（一）
    /// </summary>
    public partial class WxLoginStart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string redirect_uri = Server.UrlEncode("http://dreamtoday.top/WeChat/Wxlogin/GetCode.aspx");
            string url = "https://open.weixin.qq.com/connect/oauth2/authorize?";
            url += "appid=wxee8247c68c078628&";
            url += "redirect_uri=" + redirect_uri + "&";
            url += "response_type=code&";
            url += "scope=snsapi_userinfo&";
            url += "state=Bamboo";
            url += "#wechat_redirect";
            Response.Redirect(url);
        }
    }
}