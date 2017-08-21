using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using B1993.WebCommon;
using B1993.Core;

namespace B1993.BLL
{

    /// <summary>
    /// 【】
    /// </summary>
    public class Hander
    {
        #region 搜索

        /// <summary>
        /// 根据商品名字进行商品信息搜索
        /// </summary>
        /// <param name="stateid">商品状态（1正常，2下架）</param>
        /// <param name="PageSize">每页显示记录数</param>
        /// <param name="PageNo">当前页码</param>
        public string Bamboo_search(int stateid, string name, int PageSize, int PageNo)
        {
            string strJson = "";

            #region 响应类
            B1993.Entity.DataResponse_Productinfo Response = new Entity.DataResponse_Productinfo();
            #endregion

            #region 业务逻辑类
            B1993.BLL.product_info info = new B1993.BLL.product_info();
            #endregion

            try
            {
                List<B1993.Entity.DataList_Productinfo> Plist = new List<B1993.Entity.DataList_Productinfo>();
                List<B1993.Entity.product_info> mylist = info.GetAllList(stateid, name);
                foreach (B1993.Entity.product_info model in mylist)
                {
                    B1993.Entity.DataList_Productinfo data = new Entity.DataList_Productinfo();
                    data.ProductId = model.ProductId;
                    data.ProductName = model.ProductName;
                    data.ProductImage = model.MainImgUrl;
                    data.ProductPrice = model.ProductPrice;
                    Plist.Add(data);
                }
                //分页，把最后生成的list列表分页
                PagingUtil<B1993.Entity.DataList_Productinfo> myPage = new PagingUtil<B1993.Entity.DataList_Productinfo>(Plist, PageSize, PageNo);

                Response.mylist = myPage;
                Response.pageCount = myPage.PageCount;
                Response.recordCount = Plist.Count;
                Response.Msg = "";
                Response.Result = true;
            }
            catch
            {
                Response.Msg = "数据异常！";
                Response.Result = false;
            }

            strJson = JSONUtility<B1993.Entity.product_info>.Serialize(Response);
            return strJson;
        }
        #endregion

        #region 通过商品代码得到详细商品信息
        /// <summary>
        /// 根据商品编码调出商品详细信息搜索
        /// </summary>
        /// <returns></returns> 
        public string Bamboo_getProductInfoByCode(string productCode)
        {
            //响应类
            B1993.Entity.DataResponse_info Response = new Entity.DataResponse_info();
            //业务逻辑类
            B1993.BLL.product_info info = new product_info();
            try
            {
                B1993.Entity.product_info eninfo = new Entity.product_info();
                eninfo = info.GetOneInfo(productCode);
                Response.ProductId = eninfo.ProductId;
                Response.ProductName = eninfo.ProductName;
                Response.ProductPrice = eninfo.ProductPrice;
                Response.Specifications = eninfo.Specifications;
                Response.ProductWeight = eninfo.ProductWeight;
                Response.ProductDetail = eninfo.ProductDetail;
                Response.MadeFactor = eninfo.MadeFactor;
                Response.MadeHome = eninfo.MadeHome;
                Response.SalesNum = eninfo.SalesNum;
                Response.StateId = eninfo.StateId;
                Response.StoreNum = eninfo.StoreNum;
                Response.TypeId = eninfo.TypeId;
                Response.MainImgUrl = eninfo.MainImgUrl;
                Response.RefreshDate = eninfo.RefreshDate;
                Response.Msg = "";
                Response.Result = true;
            }
            catch
            {
                Response.Msg = "数据错误！";
                Response.Result = false;
            }
            string jsonstr = JSONUtility<B1993.Entity.product_info>.Serialize(Response);
            return jsonstr;
        }
        #endregion

        #region 根据商品分类拿到此分类下的所有商品基本信息：编号、名称、图片、价格
        /// <summary>
        /// 根据商品分类信息调出商品基本信息
        /// </summary>
        ///<param name="stateid">商品状态（1正常，2下架）</param>
        ///<param name="TypeName">类型</param>
        /// <param name="PageSize">每页显示记录数</param>
        /// <param name="PageNo">当前页码</param>
        /// <returns>商品编号、名称、图片、价格</returns> 
        public string Bamboo_searchBytype(int stateid, int TypeName, int PageSize, int PageNo)
        {
            #region 响应类
            B1993.Entity.DataResponse_Productinfo Response = new Entity.DataResponse_Productinfo();
            #endregion
            #region 业务逻辑类
            B1993.BLL.product_info info = new product_info();
            #endregion
            try
            {
                List<B1993.Entity.DataList_Productinfo> Plist = new List<B1993.Entity.DataList_Productinfo>();
                List<B1993.Entity.product_info> mylist = info.GetAllListByTypeId(stateid, TypeName);
                foreach (B1993.Entity.product_info model in mylist)
                {
                    B1993.Entity.DataList_Productinfo data = new Entity.DataList_Productinfo();
                    data.ProductId = model.ProductId;
                    data.ProductName = model.ProductName;
                    data.ProductImage = model.MainImgUrl;
                    data.ProductPrice = model.ProductPrice;
                    Plist.Add(data);
                }
                //分页，把最后生成的list列表分页
                PagingUtil<B1993.Entity.DataList_Productinfo> myPage = new PagingUtil<B1993.Entity.DataList_Productinfo>(Plist, PageSize, PageNo);

                Response.mylist = myPage;
                Response.pageCount = myPage.PageCount;
                Response.recordCount = Plist.Count;
                Response.Msg = "";
                Response.Result = true;
            }
            catch
            {
                Response.Msg = "数据异常！";
                Response.Result = false;
            }
            string jsonstr = JSONUtility<B1993.Entity.product_info>.Serialize(Response);
            return jsonstr;
        }
        #endregion

        #region 换一批信息
        /// <summary>
        /// 通过类型拼接字符串拿到商品基本信息
        /// </summary>
        /// <param name="stateid">商品状态（1正常，2下架）</param>
        /// <param name="typeString">需要的类型拼接字符串（"1,3,8,9,6"）</param>
        /// <returns></returns>
        public string GetChangeProduct(int stateid, string typeString)
        {
            #region 响应类
            B1993.Entity.DataResponse_Productinfo Response = new Entity.DataResponse_Productinfo();
            #endregion
            #region 业务逻辑类
            B1993.BLL.product_info info = new product_info();
            #endregion
            try
            {
                List<B1993.Entity.DataList_Productinfo> Plist = new List<B1993.Entity.DataList_Productinfo>();
                string[] str = typeString.Split(',');
                foreach (string typeId in str)
                {
                    B1993.Entity.DataList_Productinfo data = new Entity.DataList_Productinfo();
                    B1993.Entity.product_info model = new Entity.product_info();
                    int id = Convert.ToInt32(typeId);
                    model = info.getChangeProduct(stateid, id)[0];
                    data.ProductId = model.ProductId;
                    data.ProductName = model.ProductName;
                    data.ProductPrice = model.ProductPrice;
                    data.ProductImage = model.MainImgUrl;
                    Plist.Add(data);
                }
                Response.mylist = Plist;
                Response.Msg = "";
                Response.Result = true;
            }
            catch
            {
                Response.Msg = "数据异常！";
                Response.Result = false;
            }
            string jsonstr = JSONUtility<B1993.Entity.product_info>.Serialize(Response);
            return jsonstr;
        }
        #endregion

        #region 获取地址信息
        /// <summary>
        /// 通过用户编号拿到相应的收货地址信息
        /// </summary>
        /// <param name="uesrId">用户编号</param>
        /// <param name="stateId">地址信息状态码（1普通，2默认）</param>
        /// <returns></returns>
        public string GetAddressMessage(string uesrId, string stateId)
        {
            #region 响应类
            B1993.Entity.DataResponse_useraddress Response = new Entity.DataResponse_useraddress();
            #endregion
            #region 业务逻辑类
            B1993.BLL.useraddress address = new useraddress();
            #endregion
            try
            {
                List<B1993.Entity.DataList_useraddress> Dlist = new List<Entity.DataList_useraddress>();
                List<B1993.Entity.useraddress> Ulist = address.GetListCustomByUserId(uesrId, stateId);
                foreach(B1993.Entity.useraddress model in Ulist)
                {
                    B1993.Entity.DataList_useraddress res = new Entity.DataList_useraddress();
                    res.AddressId = model.AddressID;
                    res.Address = model.Address;
                    res.PerMobile = model.PerMobile;
                    res.PerName = model.PerName;
                    Dlist.Add(res);
                }
                Response.mylist = Dlist;
                Response.Msg = "";
                Response.Result = true;

            }
            catch 
            {
                Response.Msg = "数据异常！";
                Response.Result = false;
            }
            string jsonstr = JSONUtility<B1993.Entity.DataList_useraddress>.Serialize(Response);
            return jsonstr;
        }
        #endregion

        #region 根据地址编号修改地址信息
        /// <summary>
        /// 根据地址编号修改地址信息
        /// </summary>
        /// <param name="addressid">地址编号</param>
        /// <param name="AddressJson">地址相关的json字符串</param>
        /// <returns></returns>
        public string UpdateAddressById(string addressid,string AddressJson)
        {
            #region 响应类
            B1993.Entity.BaseDataResponse Response = new Entity.BaseDataResponse();
            #endregion
            #region 业务逻辑类
            B1993.BLL.useraddress address = new useraddress();
            #endregion
           
            try
            {
                B1993.Entity.useraddress add = JSONUtility<B1993.Entity.useraddress>.DeSerialize(AddressJson);
                int res = address.UpdateAddress(addressid, add);
                if (res == 1)
                {
                    Response.Msg = "更新成功！";
                    Response.Result = true;
                }
                else 
                {
                    Response.Msg = "更新失败！";
                    Response.Result = true;
                }

            }
            catch
            {
                Response.Msg = "数据异常！";
                Response.Result = false;
            }
            string jsonstr = JSONUtility<B1993.Entity.DataList_useraddress>.Serialize(Response);
            return jsonstr;
        }
        #endregion

        #region 添加地址
        /// <summary>
        /// 添加地址
        /// </summary>
        /// <param name="addressJson">地址信息Json字符串</param>
        /// <returns></returns>
        public string AddAddress(string addressJson) 
        {
            #region 响应类
            B1993.Entity.BaseDataResponse Response = new Entity.BaseDataResponse();
            #endregion
            #region 业务逻辑类
            B1993.BLL.useraddress address = new useraddress();
            #endregion

            try
            {
                B1993.Entity.useraddress add = JSONUtility<B1993.Entity.useraddress>.DeSerialize(addressJson);
                address.AddAddress(add);           
                Response.Msg = "添加成功！";
                Response.Result = true;
            }
            catch
            {
                Response.Msg = "数据异常！";
                Response.Result = false;
            }
            string jsonstr = JSONUtility<B1993.Entity.DataList_useraddress>.Serialize(Response);
            return jsonstr;
        }
        #endregion

        #region 删除一条地址信息
        /// <summary>
        /// 删除一条地址信息
        /// </summary>
        /// <param name="addressid">地址编号</param>
        /// <returns></returns>
        public string DeleteAddress(string addressid) 
        {
            #region 响应类
            B1993.Entity.BaseDataResponse Response = new Entity.BaseDataResponse();
            #endregion
            #region 业务逻辑类
            B1993.BLL.useraddress address = new useraddress();
            #endregion
            try
            {
                int res = address.DeleteAddressById(addressid);
                if (res == 1)
                {
                    Response.Msg = "删除成功！";
                    Response.Result = true;
                }
                else
                {
                    Response.Msg = "删除失败！";
                    Response.Result = true;
                }

            }
            catch
            {
                Response.Msg = "数据异常！";
                Response.Result = false;
            }
            string jsonstr = JSONUtility<B1993.Entity.DataList_useraddress>.Serialize(Response);
            return jsonstr;
        }
        #endregion
    }

}
