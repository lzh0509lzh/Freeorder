using B1993.BLL;
using B1993.Core;
using B1993.Core.DEncrypt;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web;

namespace B1993.Web.Web
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //this.TextBox1.Text = DESEncrypt.Encrypt("server=180.76.171.127;");
            //this.TextBox2.Text = DESEncrypt.Encrypt("database=managecenter;");
            //this.TextBox3.Text = DESEncrypt.Encrypt("uid=lee;");
            //this.TextBox4.Text = DESEncrypt.Encrypt("pwd=lee2688");
            ////string strJson1 = "{\"openid\": \"oJaTBwQTw - jg73VF00WnJ9DEAD80\",\"nickname\": \"雨晨\",\"sex\": 1,\"language\": \"zh_CN\",\"city\": \"太原\",\"province\": \"山西\",\"country\": \"中国\",\"headimgurl\":\"http://wx.qlogo.cn/mmopen/GuU1UMXokXjiaa3k59UmJjydREiatms42grrLic7ULPYvTbrbr3zd3ic2KveEDJUsLn5OnPiaAjWW2DhgLaFicYsjNfZx001AKlzoC/0\",\"privilege\": []}";
            ////B1993.Entity.WeChat.JsonModel_WxuserIngo UserInfo = JSONUtility<B1993.Entity.WeChat.JsonModel_WxuserIngo>.DeSerialize(strJson1);
            //B1993.Entity.userinfo usermodel = new B1993.Entity.userinfo();

            //B1993.BLL.userinfo userBll = new B1993.BLL.userinfo();
            //List<B1993.Entity.userinfo> userlist = new List<B1993.Entity.userinfo>();
            ////userlist = userBll.GetListCustomByOpenid("oJaTBwQTw-jg73VF00WnJ9DEAD80");
            //int count = userBll.GetListNumByOpenid("oJaTBwQTw-jg73VF00WnJ9DEAD80");//查询是否已有账户
            //#region 存入Cookie
            //HttpContext.Current.Response.Cookies["Bam:IsLogin"].Value = "1";
            //HttpContext.Current.Response.Cookies["Bam:UserId"].Value = userlist[0].UserId;
            //HttpContext.Current.Response.Cookies["Bam:UserName"].Value = userlist[0].UserName;
            //HttpContext.Current.Response.Cookies["Bam:GroupClass"].Value = userlist[0].GroupClass.ToString().Trim();
            //#endregion
        }
    }
}