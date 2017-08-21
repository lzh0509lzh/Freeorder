using System;
using System.Collections.Generic;
using System.Web;
using B1993.Core.WeChat;
using B1993.Core;
using B1993.BLL;

namespace B1993.Web.WeChat.Wxlogin
{
    /// <summary>
    /// 微信授权（二）
    /// </summary>
    public partial class GetCode : System.Web.UI.Page
    {
        public static string Openid = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            Myfunc.WriteLog("wxlogin", "start");//日志
            string appid = WxConfig.AppID;
            string secret = WxConfig.AppSecret;
            string code = Request.Params["code"].ToString().Trim();
            string state = Request.Params["state"].ToString().Trim();

            #region 通过code换取网页授权access_token和openid等

            string url = "https://api.weixin.qq.com/sns/oauth2/access_token?";
            url += "appid="+ appid + "&secret="+ secret + "&code="+ code;
            url += "&grant_type=authorization_code";
            string strJson = RequestGP.HttpGet(url);//通过code换取网页授权access_token和openid等
            B1993.Entity.WeChat.JsonModel_code model = JSONUtility<B1993.Entity.WeChat.JsonModel_code>.DeSerialize(strJson);

            Myfunc.WriteLog("wxlogin", "strJson=" + strJson);//日志
            #endregion

            if (model.errcode == null)
            {
                Myfunc.WriteLog("wxlogin", "errcode=" + model.errcode);//日志

                #region 通过access_token和openid拉取用户信息
                string url1 = "https://api.weixin.qq.com/sns/userinfo?";
                url1 += "access_token=" + model.access_token + "&openid=" + model.openid + "&lang=zh_CN";

                Myfunc.WriteLog("wxlogin", "url1=" + url1);//日志

                string strJson1 = RequestGP.HttpGet(url1);//通过access_token和openid拉取用户信息

                Myfunc.WriteLog("wxlogin", "strJson1=" + strJson1);//日志

                B1993.Entity.WeChat.JsonModel_WxuserIngo UserInfo = JSONUtility<B1993.Entity.WeChat.JsonModel_WxuserIngo>.DeSerialize(strJson1);
                Myfunc.WriteLog("wxlogin", "UserInfo-strJson1=" + UserInfo.sex);//日志
                #endregion

                #region 保存微信用户信息并登陆
                try
                {
                    if (UserInfo.errcode == null)
                    {
                        Openid = UserInfo.openid;
                        Myfunc.WriteLog("Openid", Openid);//日志

                        B1993.BLL.userinfo userBll = new B1993.BLL.userinfo();
                        int count = userBll.GetListNumByOpenid(Openid);//查询是否已有账户
                        if (count <= 0)//没有账户
                        {
                            #region 保存微信用户信息
                            Entity.wechatuserinfo winfo = new Entity.wechatuserinfo();
                            winfo.openid = UserInfo.openid;
                            winfo.nickname = UserInfo.nickname;
                            winfo.headimgurl = UserInfo.headimgurl;
                            winfo.sex = Convert.ToInt32(UserInfo.sex);
                            winfo.province = UserInfo.openid;
                            winfo.city = UserInfo.city;
                            winfo.country = UserInfo.country;
                            winfo.CreateDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss").Trim();
                            winfo.privilege = "";
                            winfo.unionid = "";
                            wechatuserinfo Wxbll = new wechatuserinfo();

                            Wxbll.ADD(winfo);//存微信用户信息
                            #endregion

                            Myfunc.WriteLog("保存", Openid);//日志
                            

                            #region 注册 
                            B1993.Entity.userinfo usermodel = new B1993.Entity.userinfo();
                            usermodel.UserId = GetTimeID.MakeUserid();
                            usermodel.headimgurl = winfo.headimgurl;
                            usermodel.UserName = winfo.nickname;
                            usermodel.Openid = winfo.openid;
                            usermodel.Pwd = winfo.openid;
                            usermodel.Mobile = "";
                            usermodel.Operator = "lee";
                            usermodel.GroupClass = 6;
                            usermodel.StateId = 1;
                            usermodel.RefreshDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss").Trim();
                            usermodel.CreateDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss").Trim();
                            userinfo bll = new userinfo();
                            bll.ADD(usermodel);
                            #endregion

                            Myfunc.WriteLog("注册", Openid);//日志
                        }

                        Myfunc.WriteLog("登录", Openid);//日志

                        #region 登录并存入Cookie

                        List<B1993.Entity.userinfo> userlist = new List<B1993.Entity.userinfo>();
                        userlist = userBll.GetListCustomByOpenid(Openid);
                        if (userlist.Count > 0)
                        {
                            Myfunc.WriteLog("存入Cookie", Openid);//日志

                            #region 存入Cookie
                            HttpContext.Current.Response.Cookies["Bam:IsLogin"].Value = "1";
                            HttpContext.Current.Response.Cookies["Bam:UserId"].Value = userlist[0].UserId;
                            HttpContext.Current.Response.Cookies["Bam:UserHeadImg"].Value = userlist[0].headimgurl;
                            HttpContext.Current.Response.Cookies["Bam:UserName"].Value = userlist[0].UserName;
                            HttpContext.Current.Response.Cookies["Bam:GroupClass"].Value = userlist[0].GroupClass.ToString().Trim();
                            #endregion

                            Myfunc.WriteLog("准备跳转", Openid);//日志

                        }
                        else
                        {
                            //登录失败
                        }
                        #endregion

                    }
                    else
                    {
                        Response.Write("获取用户信息出错：" + UserInfo.errmsg);
                    }
                }
                catch(Exception ex)
                {
                    Response.Write(ex.ToString().Trim());
                    Myfunc.WriteLog("wxlogin", "[Exception]-" + ex.ToString().Trim());//日志
                }

                #endregion

            }
            else
            {
                Response.Write("获取Openid出错：" + model.errmsg);
            }

            Response.Redirect("../../index.html");

            Myfunc.WriteLog("wxlogin", "stop");//日志
        }
    }
}