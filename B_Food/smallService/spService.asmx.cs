using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace smallService
{
    /// <summary>
    /// 小程序webservice接口
    /// </summary>
    [WebService(Namespace = "http://dreamtoday.top/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class spService : System.Web.Services.WebService
    {
        #region 声明Soap头实例
        //静态验证头
        //public B1993.BusinessRules.LifeUserAuthentication myHeaderUserAuth = new B1993.BusinessRules.LifeUserAuthentication();
        //动态验证头
        // B1993.BusinessRules.LifeUserAuthenticationDy myHeaderUserAuthDy = new B1993.BusinessRules.LifeUserAuthenticationDy();
        #endregion

        //#region 示例

        ///// <summary>
        ///// 动态头
        ///// </summary>
        ///// <returns>
        ///// 返回数据JSON格式
        ///// {
        ///// 
        ///// }
        ///// </returns>
        //[WebMethod]
        //[SoapHeader("myHeaderUserAuthDy")]
        //public string HelloWorld()
        //{
        //    string Msg = "";
        //    if (!myHeaderUserAuthDy.IsValid(out Msg))
        //    {
        //        return "{\"MemberEncryption\":null,\"Result\":false,\"Msg\":\"非法连接.\"}";
        //    }
        //    string strJson = "Hello World";
        //    return strJson;
        //}

        ///// <summary>
        ///// 静态头
        ///// </summary>
        ///// <returns></returns>
        //[WebMethod]
        //[SoapHeader("myHeaderUserAuth")]
        //public string HelloWorld2()
        //{
        //    string Msg = "";
        //    if (!myHeaderUserAuth.IsValid(out Msg))
        //    {
        //        return "{\"MemberEncryption\":null,\"Result\":false,\"Msg\":\"非法连接.\"}";
        //    }
        //    string strJson = "Hello World";
        //    return strJson;
        //}

        //#endregion
    }
}
