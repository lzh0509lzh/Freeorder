using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace B1993.Web.webService
{
    /// <summary>
    /// sWebBamboo 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://dreamtoday.top/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class sWebBamboo : System.Web.Services.WebService
    {
        #region 声明Soap头实例
        //静态验证头
        public B1993.BusinessRules.LifeUserAuthentication myHeaderUserAuth = new B1993.BusinessRules.LifeUserAuthentication();
        //动态验证头
        public B1993.BusinessRules.LifeUserAuthenticationDy myHeaderUserAuthDy = new B1993.BusinessRules.LifeUserAuthenticationDy();
        #endregion

        #region 示例

        /// <summary>
        /// 动态头
        /// </summary>
        /// <returns>
        /// 返回数据JSON格式
        /// {
        /// 
        /// }
        /// </returns>
        [WebMethod]
        [SoapHeader("myHeaderUserAuthDy")]
        public string HelloWorld()
        {
            string Msg = "";
            if (!myHeaderUserAuthDy.IsValid(out Msg))
            {
                return "{\"MemberEncryption\":null,\"Result\":false,\"Msg\":\"非法连接.\"}";
            }
            string strJson = "Hello World";
            return strJson;
        }

        /// <summary>
        /// 静态头
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        [SoapHeader("myHeaderUserAuth")]
        public string HelloWorld2()
        {
            string Msg = "";
            if (!myHeaderUserAuth.IsValid(out Msg))
            {
                return "{\"MemberEncryption\":null,\"Result\":false,\"Msg\":\"非法连接.\"}";
            }
            string strJson = "Hello World";
            return strJson;
        }

        #endregion

        #region 商品搜索接口
        /// <summary>
        /// 商品搜索接口
        /// </summary>
        /// <param name="stateid">在销状态码，1在销，2不在销</param>
        /// <param name="name">用户输入的商品名称</param>
        /// <param name="PageSize">每页显示记录数</param>
        /// <param name="PageNo">当前页码</param>
        /// <returns>
        /// 返回数据JSON格式
        /// {
        ///     "mylist": 
        ///     [
        ///         {
        ///             "ProductId"             商品编号
        ///             "ProductName"           商品名称
        ///             "ProductImage"          图片地址
        ///             "ProductPrice"          商品价格
        ///         },    
        ///         ...
        ///     ],
        ///     "pageCount"                     总页数
        ///     "recordCount"                   记录数
        ///     "Msg"                           提示信息
        ///     "Result"                        是否成功
        /// }
        /// </returns>
        [WebMethod]
        [SoapHeader("myHeaderUserAuth")]
        public string search_product(int stateid, string name, int PageSize, int PageNo)
        {
            string Msg = "";
            if (!myHeaderUserAuth.IsValid(out Msg))
            {
                return "{\"MemberEncryption\":null,\"Result\":false,\"Msg\":\"非法连接.\"}";
            }
            B1993.BLL.Hander hand = new BLL.Hander();
            string strJson = hand.Bamboo_search(stateid, name, PageSize, PageNo);
            return strJson;
        }
        #endregion

        #region 商品列表获取
        /// <summary>
        /// 根据商品类型代码取到商品列表
        /// </summary>
        /// <param name="stateid">在销状态码，1在销，2不在销</param>
        /// <param name="TypeName">类型代码</param>
        /// <param name="PageSize">每页显示记录数</param>
        /// <param name="PageNo">当前页码</param>
        /// <returns>
        /// 返回数据JSON格式
        /// {
        ///     "mylist": 
        ///     [
        ///         {
        ///             "ProductId"             商品编号
        ///             "ProductName"           商品名称
        ///             "ProductImage"          图片地址
        ///             "ProductPrice"          商品价格
        ///         },    
        ///         ...
        ///     ],
        ///     "pageCount"                     总页数
        ///     "recordCount"                   记录数
        ///     "Msg"                           提示信息
        ///     "Result"                        是否成功
        /// }
        /// </returns>
        [WebMethod]
        [SoapHeader("myHeaderUserAuth")]
        public string product_type(int stateid, int TypeName, int PageSize, int PageNo)
        {
            string Msg = "";
            if (!myHeaderUserAuth.IsValid(out Msg))
            {
                return "{\"MemberEncryption\":null,\"Result\":false,\"Msg\":\"非法连接.\"}";
            }
            B1993.BLL.Hander hand = new BLL.Hander();
            string strJson = hand.Bamboo_searchBytype(stateid, TypeName, PageSize, PageNo);
            return strJson;
        }
        #endregion

        #region 商品详情
        /// <summary>
        /// 根据商品编号拿到商品详细信息
        /// </summary>
        /// <param name="code">商品编号</param>
        /// <returns>
        /// 返回数据JSON格式
        /// {
        ///     "ProductId"          商品编号
        ///     "ProductName"        商品名字
        ///     "ProductPrice"       商品价格
        ///     "Specifications"     商品规格
        ///     "ProductWeight"      商品单位重量
        ///     "ProductDetail"      商品描述
        ///     "MadeFactor"         所属公司
        ///     "MadeHome"           商品产地
        ///     "SalesNum"           销售数量
        ///     "StateId"            是否在销
        ///     "StoreNum"           库存数量
        ///     "TypeId"             类型ID
        ///     "MainImgUrl"         图片地址
        ///     "RefreshDate"        更新时间
        ///     "Msg"                提示信息
        ///     "Result"             是否成功
        /// }
        /// </returns>
        [WebMethod]
        [SoapHeader("myHeaderUserAuth")]
        public string getproductinfo(string code)
        {
            string Msg = "";
            if (!myHeaderUserAuth.IsValid(out Msg))
            {
                return "{\"MemberEncryption\":null,\"Result\":false,\"Msg\":\"非法连接.\"}";
            }
            B1993.BLL.Hander hand = new BLL.Hander();
            string strJson = hand.Bamboo_getProductInfoByCode(code);
            return strJson;
        }
        #endregion

        #region 换一批
        /// <summary>
        /// 通过类型代码拼接成的字符串，拿到每个种类的一个商品基本信息
        /// </summary>
        /// <param name="stateid">商品状态码（1在售，2下架）</param>
        /// <param name="TypeString">类型代码拼接成的字符串（1,5,9,8,7）</param>
        /// <returns>/// 返回数据JSON格式
        /// {
        ///     "mylist": 
        ///     [
        ///         {
        ///             "ProductId"             商品编号
        ///             "ProductName"           商品名称
        ///             "ProductImage"          图片地址
        ///             "ProductPrice"          商品价格
        ///         },    
        ///         ...
        ///     ],
        ///     "pageCount"                     总页数
        ///     "recordCount"                   记录数
        ///     "Msg"                           提示信息
        ///     "Result"                        是否成功
        /// }
        /// </returns>
        [WebMethod]
        [SoapHeader("myHeaderUserAuth")]
        public string getChangeProduct(int stateid, string TypeString)
        {
            string Msg = "";
            if (!myHeaderUserAuth.IsValid(out Msg))
            {
                return "{\"MemberEncryption\":null,\"Result\":false,\"Msg\":\"非法连接.\"}";
            }
            B1993.BLL.Hander hand = new BLL.Hander();
            string strJson = hand.GetChangeProduct(stateid, TypeString);
            return strJson;
        }
        #endregion

        #region 地址信息获取
        /// <summary>
        /// 地址信息获取
        /// </summary>
        /// <param name="userId">用户编号</param>
        /// <param name="stateid">状态码（1正常，2默认）</param>
        /// <returns>
        /// {
        ///     "mylist":
        ///     [
        ///         {
        ///             "AddressId"            地址ID
        ///             "PerName"              收货人
        ///             "PerMobile"            手机号
        ///             "Address"              地址
        ///         }
        ///     ]
        ///     "Msg"                           提示信息
        ///     "Result"                        是否成功
        /// }
        /// </returns>
        [WebMethod]
        [SoapHeader("myHeaderUserAuth")]
        public string getAddress(string userId, string stateid) 
        {
            string Msg = "";
            if (!myHeaderUserAuthDy.IsValid(out Msg))
            {
                return "{\"MemberEncryption\":null,\"Result\":false,\"Msg\":\"非法连接.\"}";
            }
            B1993.BLL.Hander hand = new BLL.Hander();
            string strJson = hand.GetAddressMessage(userId, stateid);
            return strJson;
        }

        #endregion

        #region 更新地址信息
        /// <summary>
        /// 更新地址信息
        /// </summary>
        /// <param name="id">地址编号</param>
        /// <param name="addressJson">地址信息Json字符串
        /// {
        ///     "UserId"                       用户编号
        ///     "PerMobile"                    手机号
        ///     "PerName"                      收货人
        ///     "Address"                      收货地址
        ///     "StateId"                      地址状态码（1正常，2默认）
        ///     "CreateDate"                   创建时间
        ///     "RefreshDate"                  更新时间
        /// }
        /// 
        /// </param>
        /// <returns>
        /// {
        ///     "Msg"                           提示信息
        ///     "Result"                        是否成功
        /// }
        /// </returns>
        [WebMethod]
        [SoapHeader("myHeaderUserAuth")]
        public string updateaddress(string id, string addressJson) 
        {
            string Msg = "";
            if (!myHeaderUserAuthDy.IsValid(out Msg))
            {
                return "{\"MemberEncryption\":null,\"Result\":false,\"Msg\":\"非法连接.\"}";
            }
            B1993.BLL.Hander hand = new BLL.Hander();
            string strJson = hand.UpdateAddressById(id, addressJson);
            return strJson;
        }
        #endregion

        #region 增加一条地址信息
        /// <summary>
        /// 增加一条收货地址
        /// </summary>
        /// <param name="addressJson">地址信息Json字符串
        /// {
        ///     "UserId"                       用户编号
        ///     "PerMobile"                    手机号
        ///     "PerName"                      收货人
        ///     "Address"                      收货地址
        ///     "StateId"                      地址状态码（1正常，2默认）
        ///     "CreateDate"                   创建时间
        ///     "RefreshDate"                  更新时间
        /// }
        /// 
        /// </param>
        /// <returns>
        /// {
        ///     "Msg"                           提示信息
        ///     "Result"                        是否成功
        /// }
        /// </returns>
        /// <returns></returns>
        [WebMethod]
        [SoapHeader("myHeaderUserAuth")]
        public string addaddress(string addressJson)
        {
            string Msg = "";
            if (!myHeaderUserAuthDy.IsValid(out Msg))
            {
                return "{\"MemberEncryption\":null,\"Result\":false,\"Msg\":\"非法连接.\"}";
            }
            B1993.BLL.Hander hand = new BLL.Hander();
            string strJson = hand.AddAddress(addressJson);
            return strJson;
        }
        #endregion

        #region 删除一条地址信息
        /// <summary>
        /// 删除一条地址信息
        /// </summary>
        /// <param name="addressid">地址编号</param>
        /// <returns>
        /// {
        ///     "Msg"                           提示信息
        ///     "Result"                        是否成功
        /// }
        /// </returns>
        [WebMethod]
        [SoapHeader("myHeaderUserAuth")]
        public string deleteAddressById(string addressid) 
        {
            string Msg = "";
            if (!myHeaderUserAuthDy.IsValid(out Msg))
            {
                return "{\"MemberEncryption\":null,\"Result\":false,\"Msg\":\"非法连接.\"}";
            }
            B1993.BLL.Hander hand = new BLL.Hander();
            string strJson = hand.DeleteAddress(addressid);
            return strJson;
        }
        #endregion

        #region 微信相关

        #region 获取js-sdk签名验证相关参数
        /// <summary>
        /// 获取js-sdk签名验证相关参数
        /// </summary>
        /// <returns>
        /// 返回数据JSON格式
        /// {
        ///     signature,       签名
        ///     noncestr,        支付签名随机串，不长于 32 位
        ///     timestamp,       支付签名时间戳
        /// }
        /// </returns>
        [WebMethod]
        [SoapHeader("myHeaderUserAuth")]
        public string GetJSconfig(string url)
        {
            string Msg = "";
            if (!myHeaderUserAuth.IsValid(out Msg))
            {
                return "{\"MemberEncryption\":null,\"Result\":false,\"Msg\":\"非法连接.\"}";
            }
            BLL.Base.WeChat hander = new BLL.Base.WeChat();
            string strJson = hander.JSconfig(url);
            return strJson;
        }
        #endregion

        #endregion

        #region 购物车相关

        #region 加入购物车
        /// <summary>
        /// 加入购物车
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        [SoapHeader("myHeaderUserAuth")]
        public string addShopCart()
        {
            string Msg = "";
            if (!myHeaderUserAuth.IsValid(out Msg))
            {
                return "{\"MemberEncryption\":null,\"Result\":false,\"Msg\":\"非法连接.\"}";
            }
            string strJson = "Hello World";
            return strJson;
        }
        #endregion

        #region 删除购物车商品
        /// <summary>
        /// 加入购物车
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        [SoapHeader("myHeaderUserAuth")]
        public string deleteShopCart()
        {
            string Msg = "";
            if (!myHeaderUserAuth.IsValid(out Msg))
            {
                return "{\"MemberEncryption\":null,\"Result\":false,\"Msg\":\"非法连接.\"}";
            }
            string strJson = "Hello World";
            return strJson;
        }
        #endregion

        #region 更新购物车
        /// <summary>
        /// 加入购物车
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        [SoapHeader("myHeaderUserAuth")]
        public string shopCart()
        {
            string Msg = "";
            if (!myHeaderUserAuth.IsValid(out Msg))
            {
                return "{\"MemberEncryption\":null,\"Result\":false,\"Msg\":\"非法连接.\"}";
            }
            string strJson = "Hello World";
            return strJson;
        }
        #endregion

        #region 展示购物车
        /// <summary>
        /// 加入购物车
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        [SoapHeader("myHeaderUserAuth")]
        public string showShopCart()
        {
            string Msg = "";
            if (!myHeaderUserAuth.IsValid(out Msg))
            {
                return "{\"MemberEncryption\":null,\"Result\":false,\"Msg\":\"非法连接.\"}";
            }
            string strJson = "Hello World";
            return strJson;
        }
        #endregion

        #endregion
    }
}
