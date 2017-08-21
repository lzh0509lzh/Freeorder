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
    public partial class useraddress
    {
        private readonly B1993.DAL.useraddress dal = new B1993.DAL.useraddress();

        #region GetListCustomByXxx 方法，根据Xxx取出  信息(自定义字段)
        /// <summary>
        /// 获得useraddress数据列表(独立连接)
        /// <param name="Xxx"></param>
        /// </summary>
        public List<B1993.Entity.useraddress> GetListCustomByXxx(string Xxx)
        {
            List<B1993.Entity.useraddress> myList = new List<B1993.Entity.useraddress>();
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
                    "地址：" + HttpContext.Current.Request.ServerVariables.Get("LOCAL_ADDR").ToString() + ((char)13).ToString() +
                    ((char)10).ToString() +
                    "时间：" + DateTime.Now.ToString("yyyy-MM-dd") + ((char)13).ToString() + ((char)10).ToString() +
                    "内容：" + errorStr.ToString() + ((char)13).ToString() + ((char)10).ToString() + " ";

                //-------------------------------------------------------------------------------
                #endregion
            }
            return myList;
        }
        /// <summary>
        /// 获得useraddress数据列表，(方法外传入连接对象，需要人工关闭连接)
        /// <param name="myHelperMySQL">自定义数据连接对象实例</param>
        /// <param name="Xxx"></param>
        /// </summary>
        public List<B1993.Entity.useraddress> GetListCustomByXxx(DbHelperMySQL myHelperMySQL, string Xxx)
        {
            List<B1993.Entity.useraddress> myList = new List<B1993.Entity.useraddress>();

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
        /// 获得useraddress数据列表记录数(独立连接)
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
                    "地址：" + HttpContext.Current.Request.ServerVariables.Get("LOCAL_ADDR").ToString() + ((char)13).ToString() +
                    ((char)10).ToString() +
                    "时间：" + DateTime.Now.ToString("yyyy-MM-dd") + ((char)13).ToString() + ((char)10).ToString() +
                    "内容：" + errorStr.ToString() + ((char)13).ToString() + ((char)10).ToString() + " ";

                //-------------------------------------------------------------------------------
                #endregion
            }
            return Num;
        }
        /// <summary>
        /// 获得useraddress数据列表记录数，(方法外传入连接对象，需要人工关闭连接)
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
        /// 更新useraddress指定字段(独立连接)
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
                    "地址：" + HttpContext.Current.Request.ServerVariables.Get("LOCAL_ADDR").ToString() + ((char)13).ToString() +
                    ((char)10).ToString() +
                    "时间：" + DateTime.Now.ToString("yyyy-MM-dd") + ((char)13).ToString() + ((char)10).ToString() +
                    "内容：" + errorStr.ToString() + ((char)13).ToString() + ((char)10).ToString() + " ";

                //-------------------------------------------------------------------------------
                #endregion
            }
            return iNum;
        }
        /// <summary>
        /// 更新useraddress指定字段，(方法外传入连接对象，需要人工关闭连接)
        /// </summary>
        /// <param name="myDbHelperC">自定义数据连接对象实例</param>
        /// <param name="Xxx">条件</param>
        /// <param name="Vvv1">值1</param>
        /// <param name="Vvv2">值2</param>
        /// <returns>生效记录数</returns>
        public int UpdateCustom(DbHelperMySQL myHelperMySQL, string Xxx, string Vvv1, string Vvv2)
        {
            int iNum = 0;
            List<B1993.Entity.useraddress> myList = new List<B1993.Entity.useraddress>();

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
        /// 删除useraddress指定条件记录(独立连接)
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
                    "地址：" + HttpContext.Current.Request.ServerVariables.Get("LOCAL_ADDR").ToString() + ((char)13).ToString() +
                    ((char)10).ToString() +
                    "时间：" + DateTime.Now.ToString("yyyy-MM-dd") + ((char)13).ToString() + ((char)10).ToString() +
                    "内容：" + errorStr.ToString() + ((char)13).ToString() + ((char)10).ToString() + " ";

                //-------------------------------------------------------------------------------
                #endregion
            }
            return iNum;
        }
        /// <summary>
        /// 删除useraddress指定条件记录，(方法外传入连接对象，需要人工关闭连接)
        /// </summary>
        /// <param name="myHelperMySQL">自定义数据连接对象实例</param>
        /// <param name="Xxx">条件</param>
        /// <returns>生效记录数</returns>
        public int DeleteByXxx(DbHelperMySQL myHelperMySQL, string Xxx)
        {
            int iNum = 0;
            List<B1993.Entity.useraddress> myList = new List<B1993.Entity.useraddress>();

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

        #region 根据用户标号和状态码拿到对应的收货地址信息
        /// <summary>
        /// 根据用户标号和状态码拿到对应的收货地址信息
        /// </summary>
        /// <param name="userId">用户编号</param>
        /// <param name="satstateId">地址信息状态码（1普通，2默认）</param>
        /// <returns></returns>
        public List<B1993.Entity.useraddress> GetListCustomByUserId(string userId, string satstateId)
        {
            List<B1993.Entity.useraddress> myList = new List<B1993.Entity.useraddress>();
            DbHelperMySQL myHelperMySQL = new DbHelperMySQL();
            myHelperMySQL.BusinessDbConnection = ConfigB1993.ConnStringCenter;
            try
            {
                myList = this.GetListCustomById(myHelperMySQL, userId, satstateId);
            }
            catch (Exception errorStr)
            {
                #region 出错打印日志
                //打印日志-----------------------------------------------------------------

                string MailContent = "服务器出现错误!" + ((char)13).ToString() + ((char)10).ToString() +
                    "地址：" + HttpContext.Current.Request.ServerVariables.Get("LOCAL_ADDR").ToString() + ((char)13).ToString() +
                    ((char)10).ToString() +
                    "时间：" + DateTime.Now.ToString("yyyy-MM-dd") + ((char)13).ToString() + ((char)10).ToString() +
                    "内容：" + errorStr.ToString() + ((char)13).ToString() + ((char)10).ToString() + " ";

                //-------------------------------------------------------------------------------
                #endregion
            }
            return myList;
        }

        private List<Entity.useraddress> GetListCustomById(DbHelperMySQL myHelperMySQL, string userId, string satstateId)
        {
            List<B1993.Entity.useraddress> myList = new List<B1993.Entity.useraddress>();

            //字段
            string fieldSelect = "AddressID,PerMobile,PerName,Address";
            //条件
            string strWhere = "UserId=@UserId and StateId=@satstateId";
            //排序
            string fieldOrder = "RefreshDate desc";
            //参数
            MySqlParameter[] parms =
            {
                new MySqlParameter("UserId", userId),
                new MySqlParameter("satstateId", satstateId)
            };

            myList = dal.GetList(myHelperMySQL, 4, fieldSelect, strWhere, fieldOrder, parms);

            return myList;
        }
        #endregion

        #region 根据地址编号更新地址
        /// <summary>
        /// 根据地址编号更新地址
        /// </summary>
        /// <param name="id">地址编号</param>
        /// <param name="address">封装的address对象</param>
        /// <returns></returns>
        public int UpdateAddress(string id,B1993.Entity.useraddress address) 
        {
            int iNum = 0;
            DbHelperMySQL myHelperMySQL = new DbHelperMySQL();
            myHelperMySQL.BusinessDbConnection = ConfigB1993.ConnStringCenter;
            try
            {
                iNum = this.UpdateAddressDal(myHelperMySQL, address, id);
            }
            catch (Exception errorStr)
            {
                #region 出错打印日志
                //打印日志-----------------------------------------------------------------

                string MailContent = "服务器出现错误!" + ((char)13).ToString() + ((char)10).ToString() +
                    "地址：" + HttpContext.Current.Request.ServerVariables.Get("LOCAL_ADDR").ToString() + ((char)13).ToString() +
                    ((char)10).ToString() +
                    "时间：" + DateTime.Now.ToString("yyyy-MM-dd") + ((char)13).ToString() + ((char)10).ToString() +
                    "内容：" + errorStr.ToString() + ((char)13).ToString() + ((char)10).ToString() + " ";

                //-------------------------------------------------------------------------------
                #endregion
            }
            return iNum;
        }
        /// <summary>
        /// 根据地址编号更新地址工具方法
        /// </summary>
        /// <param name="myHelperMySQL"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        private int UpdateAddressDal(DbHelperMySQL myHelperMySQL, Entity.useraddress address,string id)
        {
            int num = 0;
            num = dal.Update(myHelperMySQL, address, id);
            return num;
        }
        #endregion

        #region 添加一条地址
        public void AddAddress(B1993.Entity.useraddress address) 
        {
            DbHelperMySQL myHelperMySQL = new DbHelperMySQL();
            myHelperMySQL.BusinessDbConnection = ConfigB1993.ConnStringCenter;
            try
            {
                dal.Add(myHelperMySQL, address);
            }
            catch (Exception errorStr)
            {
                #region 出错打印日志
                //打印日志-----------------------------------------------------------------

                string MailContent = "服务器出现错误!" + ((char)13).ToString() + ((char)10).ToString() +
                    "地址：" + HttpContext.Current.Request.ServerVariables.Get("LOCAL_ADDR").ToString() + ((char)13).ToString() +
                    ((char)10).ToString() +
                    "时间：" + DateTime.Now.ToString("yyyy-MM-dd") + ((char)13).ToString() + ((char)10).ToString() +
                    "内容：" + errorStr.ToString() + ((char)13).ToString() + ((char)10).ToString() + " ";

                //-------------------------------------------------------------------------------
                #endregion
            }
        }
        #endregion

        #region 通过地址编号删除一条地址
        /// <summary>
        /// 通过地址编号删除一条地址
        /// </summary>
        /// <param name="addressid">地址编号</param>
        /// <returns></returns>
        public int DeleteAddressById(string addressid) 
        {
            int iNum = 0;
            DbHelperMySQL myHelperMySQL = new DbHelperMySQL();
            myHelperMySQL.BusinessDbConnection = ConfigB1993.ConnStringCenter;
            try
            {
                iNum = this.DeleteAddressDal(myHelperMySQL, addressid);
            }
            catch (Exception errorStr)
            {
                #region 出错打印日志
                //打印日志-----------------------------------------------------------------

                string MailContent = "服务器出现错误!" + ((char)13).ToString() + ((char)10).ToString() +
                    "地址：" + HttpContext.Current.Request.ServerVariables.Get("LOCAL_ADDR").ToString() + ((char)13).ToString() +
                    ((char)10).ToString() +
                    "时间：" + DateTime.Now.ToString("yyyy-MM-dd") + ((char)13).ToString() + ((char)10).ToString() +
                    "内容：" + errorStr.ToString() + ((char)13).ToString() + ((char)10).ToString() + " ";

                //-------------------------------------------------------------------------------
                #endregion
            }
            return iNum;
        }
        /// <summary>
        /// 通过地址编号删除一条地址工具方法
        /// </summary>
        /// <param name="myHelperMySQL">链接工具对象</param>
        /// <param name="addressid">地址编号</param>
        /// <returns></returns>
        private int DeleteAddressDal(DbHelperMySQL myHelperMySQL, string addressid)
        {
            string strWhere = "AddressID=@addressid";
            //参数
            MySqlParameter[] parms =
            {
                new MySqlParameter("addressid", addressid)
            };
            int num = dal.Delete(myHelperMySQL, strWhere, parms);
            return num;
        }
        #endregion

    }
}