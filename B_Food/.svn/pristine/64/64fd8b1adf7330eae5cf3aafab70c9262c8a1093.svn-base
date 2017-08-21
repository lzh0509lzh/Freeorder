/*         
*│版权所有：Dream1993
*│创建人：Lee        
*/
using System;
using System.Web;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using B1993.WebCommon;
using B1993.WebCommon.SQLHelper;

namespace B1993.BLL
{
    /// <summary>
    /// product_info业务规则类【这是工具类，但是这个工具类 你要根据需要修改】
    /// </summary>
    public partial class product_info
    {
        private readonly B1993.DAL.product_info dal = new B1993.DAL.product_info();

        #region 【方法1】 GetListCustomByXxx 方法，根据Xxx取出  信息(自定义字段)
        /// <summary>
        /// 获得product_info数据列表(独立连接)
        /// <param name="Xxx"></param>
        /// </summary>
        public List<B1993.Entity.product_info> GetListCustomByXxx(string Xxx)
        {
            List<B1993.Entity.product_info> myList = new List<B1993.Entity.product_info>();
            DbHelperMySQL myHelperMySQL = new DbHelperMySQL();
            myHelperMySQL.BusinessDbConnection = ConfigB1993.ConnStringCenter;
            try
            {
                myList = this.GetListCustomByXxx(myHelperMySQL, Xxx);
            }
            catch (Exception errorStr)
            {
                #region 出错打印日志
                //打印日志-----------------------------------------------------------------

                string MailContent = "服务器出现错误!" + ((char)13).ToString() + ((char)10).ToString() +
                    "地址：" + HttpContext.Current.Request.ServerVariables.Get("LOCAL_ADDR").ToString() + ((char)13).ToString() + ((char)10).ToString() +
                    "时间：" + DateTime.Now.ToString("yyyy-MM-dd") + ((char)13).ToString() + ((char)10).ToString() +
                    "内容：" + errorStr.ToString() + ((char)13).ToString() + ((char)10).ToString() + " ";

                //-------------------------------------------------------------------------------
                #endregion
            }
            return myList;
        }
        /// <summary>
        /// 获得product_info数据列表，(方法外传入连接对象，需要人工关闭连接)
        /// <param name="myHelperMySQL">自定义数据连接对象实例</param>
        /// <param name="Xxx"></param>
        /// </summary>
        public List<B1993.Entity.product_info> GetListCustomByXxx(DbHelperMySQL myHelperMySQL, string Xxx)
        {
            List<B1993.Entity.product_info> myList = new List<B1993.Entity.product_info>();

            //字段
            string fieldSelect = "";
            fieldSelect = "a.Xxx, a.Yyy ";

            //条件
            string strWhere = "Xxx=@Xxx";
            //排序
            string fieldOrder = "createdate desc";
            //参数
            MySqlParameter[] parms =
            {
                new MySqlParameter("Xxx", Xxx)
            };

            myList = dal.GetList(myHelperMySQL, 0, fieldSelect, strWhere, fieldOrder, parms);

            return myList;
        }
        #endregion

        #region GetListNumByXxx 方法，根据Xxx取出符合条件记录数量(自定义字段)
        /// <summary>
        /// 获得product_info数据列表记录数(独立连接)
        /// <param name="Xxx"></param>
        /// </summary>
        public int GetListNumByXxx(string Xxx)
        {
            int Num = 0;
            DbHelperMySQL myHelperMySQL = new DbHelperMySQL();
            myHelperMySQL.BusinessDbConnection = ConfigB1993.ConnStringCenter;
            try
            {
                Num = this.GetListNumByXxx(myHelperMySQL, Xxx);
            }
            catch (Exception errorStr)
            {
                #region 出错打印日志
                //打印日志-----------------------------------------------------------------

                string MailContent = "服务器出现错误!" + ((char)13).ToString() + ((char)10).ToString() +
                    "地址：" + HttpContext.Current.Request.ServerVariables.Get("LOCAL_ADDR").ToString() + ((char)13).ToString() + ((char)10).ToString() +
                    "时间：" + DateTime.Now.ToString("yyyy-MM-dd") + ((char)13).ToString() + ((char)10).ToString() +
                    "内容：" + errorStr.ToString() + ((char)13).ToString() + ((char)10).ToString() + " ";

                //-------------------------------------------------------------------------------
                #endregion
            }
            return Num;
        }
        /// <summary>
        /// 获得product_info数据列表记录数，(方法外传入连接对象，需要人工关闭连接)
        /// <param name="myHelperMySQL">自定义数据连接对象实例</param>
        /// <param name="Xxx"></param>
        /// </summary>
        public int GetListNumByXxx(DbHelperMySQL myHelperMySQL, string Xxx)
        {
            int Num = 0;


            //条件
            string strWhere = "Xxx=@Xxx";

            //参数
            MySqlParameter[] parms =
            {
                new MySqlParameter("Xxx", Xxx)
            };

            Num = dal.GetListNum(myHelperMySQL, strWhere, parms);

            return Num;
        }
        #endregion

        #region UpdateCustom 方法，更新指定字段
        /// <summary>
        /// 更新product_info指定字段(独立连接)
        /// </summary>
        /// <param name="Xxx">条件</param>
        /// <param name="Vvv1">值1</param>
        /// <param name="Vvv2">值2</param>
        /// <returns>生效记录数</returns>
        public int UpdateCustom(string Xxx, string Vvv1, string Vvv2)
        {
            int iNum = 0;
            DbHelperMySQL myHelperMySQL = new DbHelperMySQL();
            myHelperMySQL.BusinessDbConnection = ConfigB1993.ConnStringCenter;
            try
            {
                iNum = this.UpdateCustom(myHelperMySQL, Xxx, Vvv1, Vvv2);
            }
            catch (Exception errorStr)
            {
                #region 出错打印日志
                //打印日志-----------------------------------------------------------------

                string MailContent = "服务器出现错误!" + ((char)13).ToString() + ((char)10).ToString() +
                    "地址：" + HttpContext.Current.Request.ServerVariables.Get("LOCAL_ADDR").ToString() + ((char)13).ToString() + ((char)10).ToString() +
                    "时间：" + DateTime.Now.ToString("yyyy-MM-dd") + ((char)13).ToString() + ((char)10).ToString() +
                    "内容：" + errorStr.ToString() + ((char)13).ToString() + ((char)10).ToString() + " ";

                //-------------------------------------------------------------------------------
                #endregion
            }
            return iNum;
        }
        /// <summary>
        /// 更新product_info指定字段，(方法外传入连接对象，需要人工关闭连接)
        /// </summary>
        /// <param name="myDbHelperC">自定义数据连接对象实例</param>
        /// <param name="Xxx">条件</param>
        /// <param name="Vvv1">值1</param>
        /// <param name="Vvv2">值2</param>
        /// <returns>生效记录数</returns>
        public int UpdateCustom(DbHelperMySQL myHelperMySQL, string Xxx, string Vvv1, string Vvv2)
        {
            int iNum = 0;
            List<B1993.Entity.product_info> myList = new List<B1993.Entity.product_info>();

            //条件
            string strWhere = "Xxx=@Xxx";

            //字段
            string fieldUpdate = "Field1=@Vvv1,Field2=@Vvv2 ";
            //参数

            MySqlParameter[] parms = 
			{
                new MySqlParameter("Xxx",Xxx),
                new MySqlParameter("Field1",Vvv1),
                new MySqlParameter("Field2",Vvv2)
			};

            iNum = dal.Update(myHelperMySQL, strWhere, fieldUpdate, parms);
            return iNum;


        }
        #endregion

        #region DeleteByXxx 方法，删除指定条件记录
        /// <summary>
        /// 删除product_info指定条件记录(独立连接)
        /// </summary>
        /// <param name="Xxx">条件</param>
        /// <returns>生效记录数</returns>
        public int DeleteByXxx(string Xxx)
        {
            int iNum = 0;
            DbHelperMySQL myHelperMySQL = new DbHelperMySQL();
            myHelperMySQL.BusinessDbConnection = ConfigB1993.ConnStringCenter;
            try
            {
                iNum = this.DeleteByXxx(myHelperMySQL, Xxx);
            }
            catch (Exception errorStr)
            {
                #region 出错打印日志
                //打印日志-----------------------------------------------------------------

                string MailContent = "服务器出现错误!" + ((char)13).ToString() + ((char)10).ToString() +
                    "地址：" + HttpContext.Current.Request.ServerVariables.Get("LOCAL_ADDR").ToString() + ((char)13).ToString() + ((char)10).ToString() +
                    "时间：" + DateTime.Now.ToString("yyyy-MM-dd") + ((char)13).ToString() + ((char)10).ToString() +
                    "内容：" + errorStr.ToString() + ((char)13).ToString() + ((char)10).ToString() + " ";

                //-------------------------------------------------------------------------------
                #endregion
            }
            return iNum;
        }
        /// <summary>
        /// 删除product_info指定条件记录，(方法外传入连接对象，需要人工关闭连接)
        /// </summary>
        /// <param name="myHelperMySQL">自定义数据连接对象实例</param>
        /// <param name="Xxx">条件</param>
        /// <returns>生效记录数</returns>
        public int DeleteByXxx(DbHelperMySQL myHelperMySQL, string Xxx)
        {
            int iNum = 0;
            List<B1993.Entity.product_info> myList = new List<B1993.Entity.product_info>();

            //条件
            string strWhere = "Xxx=@Xxx";

            //参数
            MySqlParameter[] parms =
            {
                new MySqlParameter("Xxx", Xxx)
            };

            iNum = dal.Delete(myHelperMySQL, strWhere, parms);
            return iNum;


        }
        #endregion

        #region GetAllList 方法，根据stateid取出 商品名称,图片，价格，商品编号  对比 【方法1】
        /// <summary>
        /// 获得product_info数据列表(独立连接)
        /// <param name="Xxx"></param>
        /// </summary>
        public List<B1993.Entity.product_info> GetAllList(int stateid, string name)
        {
            List<B1993.Entity.product_info> myList = new List<B1993.Entity.product_info>();
            DbHelperMySQL myHelperMySQL = new DbHelperMySQL();
            myHelperMySQL.BusinessDbConnection = ConfigB1993.ConnStringCenter;
            try
            {
                myList = this.GetAllList(myHelperMySQL, stateid, name);
            }
            catch (Exception errorStr)
            {
                #region 出错打印日志
                //打印日志-----------------------------------------------------------------

                string MailContent = "服务器出现错误!" + ((char)13).ToString() + ((char)10).ToString() +
                    "地址：" + HttpContext.Current.Request.ServerVariables.Get("LOCAL_ADDR").ToString() + ((char)13).ToString() + ((char)10).ToString() +
                    "时间：" + DateTime.Now.ToString("yyyy-MM-dd") + ((char)13).ToString() + ((char)10).ToString() +
                    "内容：" + errorStr.ToString() + ((char)13).ToString() + ((char)10).ToString() + " ";

                //-------------------------------------------------------------------------------
                #endregion
            }
            return myList;
        }
        /// <summary>
        /// 获得product_info数据列表，(方法外传入连接对象，需要人工关闭连接)
        /// <param name="myHelperMySQL">自定义数据连接对象实例</param>
        /// <param name="Xxx"></param>
        /// </summary>
        public List<B1993.Entity.product_info> GetAllList(DbHelperMySQL myHelperMySQL, int stateid, string name)
        {
            List<B1993.Entity.product_info> myList = new List<B1993.Entity.product_info>();

            //字段
            string fieldSelect = "";
            fieldSelect = "Productid, ProductName,ProductPrice,MainImgUrl ";

            //条件
            //string strWhere = "ProductName like'" + stateid+"'";
            string strWhere = "ProductName like '%" + name + "%'and stateld =" + stateid;
            //排序
            string fieldOrder = "createdate desc";
            //参数
            MySqlParameter[] parms =
            {
                new MySqlParameter("stateid", stateid)
            };

            myList = dal.GetList(myHelperMySQL, 10, fieldSelect, strWhere, fieldOrder, parms);

            return myList;
        }
        #endregion



        #region GetOneInfo方法，根据code取出一个商品的详细信息
        /// <summary>
        /// 通过商品代码拿到商品详细信息
        /// </summary>
        /// <param name="Productid">商品代码</param>
        /// <returns></returns>
        public B1993.Entity.product_info GetOneInfo(string Productid)
        {
            B1993.Entity.product_info info = new Entity.product_info();
            DbHelperMySQL myHelperMySQL = new DbHelperMySQL();
            myHelperMySQL.BusinessDbConnection = ConfigB1993.ConnStringCenter;
            try
            {
                info = this.GetOnlyOneList(myHelperMySQL, Productid);
            }
            catch (Exception errorStr)
            {
                #region 出错打印日志
                //打印日志-----------------------------------------------------------------

                string MailContent = "服务器出现错误!" + ((char)13).ToString() + ((char)10).ToString() +
                    "地址：" + HttpContext.Current.Request.ServerVariables.Get("LOCAL_ADDR").ToString() + ((char)13).ToString() + ((char)10).ToString() +
                    "时间：" + DateTime.Now.ToString("yyyy-MM-dd") + ((char)13).ToString() + ((char)10).ToString() +
                    "内容：" + errorStr.ToString() + ((char)13).ToString() + ((char)10).ToString() + " ";

                //-------------------------------------------------------------------------------
                #endregion
            }
            return info;
        }
        public B1993.Entity.product_info GetOnlyOneList(DbHelperMySQL myHelperMySQL, string Productid)
        {
            List<B1993.Entity.product_info> oneinfolist = new List<B1993.Entity.product_info>();
            B1993.Entity.product_info oneinfo = new Entity.product_info();
            //字段
            string fieldSelect = "Productid,ProductName,ProductPrice,MainImgUrl,StoreNum,SalesNum,TypeId,ProductWeight,StateId";
            //条件
            string strWhere = "Productid = @code";
            //排序
            string fieldOrder = "";
            //参数
            MySqlParameter[] parms =
            {
                new MySqlParameter("code", Productid)
            };
            oneinfolist = dal.GetList(myHelperMySQL, 1, fieldSelect, strWhere, fieldOrder, parms);
            oneinfo = oneinfolist[0];
            return oneinfo;
        }
        #endregion

        #region 通过类型代码拿到商品基本信息：编号、名称、价格、图片
        /// <summary>
        /// 通过类型ID得到product_info列表
        /// </summary>
        /// <param name="stateid">在售状态</param>
        /// <param name="TypeId">类型ID</param>
        /// <returns>product_info基本信息列表</returns>
        public List<B1993.Entity.product_info> GetAllListByTypeId(int stateid, int TypeId)
        {
            List<B1993.Entity.product_info> myList = new List<B1993.Entity.product_info>();
            DbHelperMySQL myHelperMySQL = new DbHelperMySQL();
            myHelperMySQL.BusinessDbConnection = ConfigB1993.ConnStringCenter;
            try
            {
                myList = this.GetAllListByTypeId(myHelperMySQL, stateid, TypeId);
            }
            catch (Exception errorStr)
            {
                #region 出错打印日志
                //打印日志-----------------------------------------------------------------

                string MailContent = "服务器出现错误!" + ((char)13).ToString() + ((char)10).ToString() +
                    "地址：" + HttpContext.Current.Request.ServerVariables.Get("LOCAL_ADDR").ToString() + ((char)13).ToString() + ((char)10).ToString() +
                    "时间：" + DateTime.Now.ToString("yyyy-MM-dd") + ((char)13).ToString() + ((char)10).ToString() +
                    "内容：" + errorStr.ToString() + ((char)13).ToString() + ((char)10).ToString() + " ";

                //-------------------------------------------------------------------------------
                #endregion
            }
            return myList;
        }
        private List<Entity.product_info> GetAllListByTypeId(DbHelperMySQL myHelperMySQL, int stateid, int TypeId)
        {
            List<B1993.Entity.product_info> myList = new List<B1993.Entity.product_info>();

            //字段
            string fieldSelect = "";
            fieldSelect = "Productid, ProductName,ProductPrice,MainImgUrl ";

            //条件
            //string strWhere = "ProductName like'" + stateid+"'";
            string strWhere = "TypeId = @TypeId and StateId = @stateid";
            //排序
            string fieldOrder = "createdate desc";
            //参数
            MySqlParameter[] parms =
            {
                new MySqlParameter("TypeId", TypeId),
                new MySqlParameter("stateid", stateid)
            };

            myList = dal.GetList(myHelperMySQL, 10, fieldSelect, strWhere, fieldOrder, parms);

            return myList;
        }
        #endregion

        #region 得到换一批中的单个商品数据
        /// <summary>
        /// 得到换一批中的单个商品数据:编号、名称、图片、价格
        /// </summary>
        /// <param name="stateid"></param>
        /// <param name="TypeId"></param>
        /// <returns>返回的是包含一个product_info的list</returns>
        public List<B1993.Entity.product_info> getChangeProduct(int stateid, int TypeId) 
        {
            List<B1993.Entity.product_info> myList = new List<B1993.Entity.product_info>();
            DbHelperMySQL myHelperMySQL = new DbHelperMySQL();
            myHelperMySQL.BusinessDbConnection = ConfigB1993.ConnStringCenter;
            try
            {
                myList = this.GetChangeByTypeId(myHelperMySQL, stateid, TypeId);
            }
            catch (Exception errorStr)
            {
                #region 出错打印日志
                //打印日志-----------------------------------------------------------------

                string MailContent = "服务器出现错误!" + ((char)13).ToString() + ((char)10).ToString() +
                    "地址：" + HttpContext.Current.Request.ServerVariables.Get("LOCAL_ADDR").ToString() + ((char)13).ToString() + ((char)10).ToString() +
                    "时间：" + DateTime.Now.ToString("yyyy-MM-dd") + ((char)13).ToString() + ((char)10).ToString() +
                    "内容：" + errorStr.ToString() + ((char)13).ToString() + ((char)10).ToString() + " ";

                //-------------------------------------------------------------------------------
                #endregion
            }
            return myList;
        }
        private List<Entity.product_info> GetChangeByTypeId(DbHelperMySQL myHelperMySQL, int stateid, int TypeId)
        {
            List<B1993.Entity.product_info> myList = new List<B1993.Entity.product_info>();

            //字段
            string fieldSelect = "";
            fieldSelect = "Productid, ProductName,ProductPrice,MainImgUrl ";

            //条件
            //string strWhere = "ProductName like'" + stateid+"'";
            string strWhere = "TypeId = @TypeId and StateId = @stateid";
            //排序
            string fieldOrder = "rand() LIMIT 1";
            //参数
            MySqlParameter[] parms =
            {
                new MySqlParameter("TypeId", TypeId),
                new MySqlParameter("stateid", stateid)
            };
            myList = dal.GetList(myHelperMySQL, 1, fieldSelect, strWhere, fieldOrder, parms);

            return myList;
        }
        #endregion
    }
}