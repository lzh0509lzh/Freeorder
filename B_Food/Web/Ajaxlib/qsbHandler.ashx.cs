using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using B1993.Web.com;//公网引用
//using B1993.Web.localhost;////本地引用

namespace B1993.Web.Ajaxlib
{
    /// <summary>
    /// qsbHandler 的摘要说明
    /// </summary>
    /// <summary>
    /// wxHandler 微信相关 create by lee
    /// </summary>
    public class qsbHandler : IHttpHandler
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
                    case "searchproduct":    //获取搜索的验证参数
                        searchproduct();
                        break;
                    case "productlist":
                        productlist();      //根据商品类型代码取到商品列表
                        break;
                    case "productinfo":
                        productinfo();      //通过商品id获取商品详情
                        break;
                    case "getchange":       //换一批
                        getchange();
                        break;
                    case "":

                        break;
                    case "q":

                        break;
                    case "qqq":

                        break;
                    case "qqqq":

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

        #region 获取搜索的验证参数
        private void searchproduct() 
        {
            int stateid = Convert.ToInt32(Context.Request["stateid"].ToString());
            string name = Context.Request["name"].ToString();
            int PageSize = Convert.ToInt32(Context.Request["PageSize"].ToString());
            int PageNo = Convert.ToInt32(Context.Request["PageNo"].ToString());
            slife.LifeUserAuthenticationValue = UserAuthentication;
            strJson = slife.search_product(stateid, name, PageSize, PageNo);
        }
        #endregion

        #region 根据商品类型代码取到商品列表
        private void productlist()
        {
            int stateid = Convert.ToInt32(Context.Request["stateid"].ToString());
            int TypeName = Convert.ToInt32(Context.Request["stateid"].ToString());
            int PageSize = Convert.ToInt32(Context.Request["PageSize"].ToString());
            int PageNo = Convert.ToInt32(Context.Request["PageNo"].ToString());
            slife.LifeUserAuthenticationValue = UserAuthentication;
            strJson = slife.product_type(stateid, TypeName, PageSize, PageNo);
        }
        #endregion

        #region 商品详情
        private void productinfo() 
        {
            string code = Context.Request["stateid"].ToString();
            slife.LifeUserAuthenticationValue = UserAuthentication;
            strJson = slife.getproductinfo(code);
        }
        #endregion

        #region 换一批
        private void getchange() 
        {
            int stateid = Convert.ToInt32(Context.Request["stateid"].ToString());
            string TypeString = Context.Request["typeString"].ToString();
            slife.LifeUserAuthenticationValue = UserAuthentication;
            strJson = slife.getChangeProduct(stateid, TypeString);
        }
        #endregion

        #region 地址信息获取
        private void getaddress()
        {
            string userId = Context.Request["userId"].ToString();
            string stateid = Context.Request["stateid"].ToString();
            slife.LifeUserAuthenticationValue = UserAuthentication;
            //strJson = slife.getAddress(userId, stateid);
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