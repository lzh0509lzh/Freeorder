/*         
*│版权所有：Dream1993
*│创建人：Lee        
*/
using System.Text;
using System.Data;
using System.Linq;
using B1993.WebCommon.SQLHelper;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace B1993.DAL
{
    /// <summary>
    /// useraddress数据访问层类
    /// </summary>
    public partial class useraddress
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(DbHelperMySQL myHelperMySQL, B1993.Entity.useraddress model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into useraddress(");
            strSql.Append("UserId,PerMobile,PerName,Address,StateId,CreateDate,RefreshDate");
            strSql.Append(") values (");
            strSql.Append("@UserId,@PerMobile,@PerName,@Address,@StateId,@CreateDate,@RefreshDate");
            strSql.Append(") ");

            MySqlParameter[] parameters = {
                                    new MySqlParameter("@UserId", model.UserId)  ,
                                    new MySqlParameter("@PerMobile", model.PerMobile)  ,
                                    new MySqlParameter("@PerName", model.PerName)  ,
                                    new MySqlParameter("@Address", model.Address)  ,
                                    new MySqlParameter("@StateId", model.StateId)  ,
                                    new MySqlParameter("@CreateDate", model.CreateDate)  ,
                                    new MySqlParameter("@RefreshDate", model.RefreshDate)
            };

            myHelperMySQL.ExecuteNonQuery(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 更新一条数据(所有字段)
        /// </summary>
        public int Update(DbHelperMySQL myHelperMySQL, B1993.Entity.useraddress model, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update useraddress set ");
            strSql.Append(" UserId = @UserId , ");
            strSql.Append(" PerMobile = @PerMobile , ");
            strSql.Append(" PerName = @PerName , ");
            strSql.Append(" Address = @Address , ");
            strSql.Append(" StateId = @StateId , ");
            strSql.Append(" CreateDate = @CreateDate , ");
            strSql.Append(" RefreshDate = @RefreshDate  ");
            MySqlParameter[] parameters = {
                                    new MySqlParameter("@UserId", model.UserId)  ,
                                    new MySqlParameter("@PerMobile", model.PerMobile)  ,
                                    new MySqlParameter("@PerName", model.PerName)  ,
                                    new MySqlParameter("@Address", model.Address)  ,
                                    new MySqlParameter("@StateId", model.StateId)  ,
                                    new MySqlParameter("@CreateDate", model.CreateDate)  ,
                                    new MySqlParameter("@RefreshDate", model.RefreshDate)
            };

            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            int rows = myHelperMySQL.ExecuteNonQuery(strSql.ToString(), parameters);

            return rows;
        }

        /// <summary>
        /// 更新一条数据，自定义条件和字段
        /// </summary>
        /// <param name="myDbHelperC">DbHelperC实例（数据访问类）.</param>
        /// <param name="strWhere">条件（重要）</param>
        /// <param name="filedUpdate">更新字段</param>
        /// <param name="parameters">参数</param>
        /// <returns></returns>
        public int Update(DbHelperMySQL myHelperMySQL, string strWhere, string filedUpdate, MySqlParameter[] parameters)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update MessageBoard set ");
            if (filedUpdate != "")
            {
                strSql.Append(filedUpdate);

                if (strWhere.Trim() != "")
                {
                    strSql.Append(" where " + strWhere);
                }
                int rows = myHelperMySQL.ExecuteNonQuery(strSql.ToString(), parameters);
                return rows;

            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public int Delete(DbHelperMySQL myHelperMySQL, string strWhere, MySqlParameter[] parameters)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from useraddress ");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" WHERE " + strWhere);
            }

            int rows = myHelperMySQL.ExecuteNonQuery(strSql.ToString(), parameters);
            return rows;
        }

        /// <summary>
        /// 得到一个对象实体(List类型)中指定条件记录数，数据连接类用DbHelperC（非静态）
        /// 表：PFWebSpecialityShop a
        ///     <param name="myHelperMySQL">myHelperMySQL实例（数据访问类）.</param>
        ///     <param name="strWhere">条件.</param>
        ///     <param name="dbParameters">参数(若条件中未使用参数可为null).</param>
        /// </summary>
        public int GetListNum(DbHelperMySQL myHelperMySQL, string strWhere, MySqlParameter[] parameters)
        {
            int Num = 0;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            strSql.Append(" count(1) as Num ");
            strSql.Append("  FROM useraddress  ");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            List<B1993.Entity.useraddress> myList = new List<B1993.Entity.useraddress>();
            using (MySqlDataReader dr = myHelperMySQL.ExecuteReader(strSql.ToString(), parameters))
            {
                while (dr.Read())
                {
                    if (dr["Num"].ToString().Trim() != "")
                    {
                        Num = int.Parse(dr["Num"].ToString().Trim());
                    }
                }
                dr.Close();
            }
            return Num;
        }
        /// <summary>
        /// 得到一个对象实体(List类型)，数据连接类用myHelperMySQL（非静态）,查询全部数据
        /// 表：MessageBoard 
        /// <param name="myHelperMySQL">myHelperMySQL实例（数据访问类）.</param>
        /// <param name="Top">记录数.</param>
        /// <param name="strWhere">条件.</param>
        /// <param name="filedOrder">排序字段.</param>
        /// <param name="parameters">参数(若条件中未使用参数可为null).</param>
        /// </summary>
        public List<B1993.Entity.useraddress> GetList(DbHelperMySQL myHelperMySQL, int Top, string strWhere, string filedOrder, MySqlParameter[] parameters)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" TOP " + Top.ToString());
            }
            strSql.Append(" a.AddressID, a.UserId, a.PerMobile, a.PerName, a.Address, a.StateId, a.CreateDate, a.RefreshDate  ");
            strSql.Append("  FROM useraddress a ");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" WHERE " + strWhere);
            }
            if (filedOrder.Trim() != "")
            {
                strSql.Append(" ORDER BY " + filedOrder);
            }

            List<B1993.Entity.useraddress> myList = new List<B1993.Entity.useraddress>();
            using (MySqlDataReader dr = myHelperMySQL.ExecuteReader(strSql.ToString(), parameters))
            {
                while (dr.Read())
                {
                    B1993.Entity.useraddress model = new B1993.Entity.useraddress();

                    if (dr["AddressID"].ToString() != "")
                    {
                        model.AddressID = int.Parse(dr["AddressID"].ToString());
                    }
                    model.UserId = dr["UserId"].ToString();
                    model.PerMobile = dr["PerMobile"].ToString();
                    model.PerName = dr["PerName"].ToString();
                    model.Address = dr["Address"].ToString();
                    if (dr["StateId"].ToString() != "")
                    {
                        model.StateId = int.Parse(dr["StateId"].ToString());
                    }
                    model.CreateDate = dr["CreateDate"].ToString();
                    model.RefreshDate = dr["RefreshDate"].ToString();

                    myList.Add(model);
                }
                dr.Close();
            }
            return myList;
        }

        /// <summary>
        /// 得到一个对象实体(List类型)，数据连接类用myHelperMySQL（非静态）
        /// 表：MessageBoard 
        /// <param name="myHelperMySQL">myHelperMySQL实例（数据访问类）.</param>
        /// <param name="Top">记录数.</param>
        /// <param name="filedSelect">自定义字段.</param> 
        /// <param name="strWhere">条件.</param>
        /// <param name="filedOrder">排序字段.</param>
        /// <param name="parameters">参数(若条件中未使用参数可为null).</param>
        /// </summary>
        public List<B1993.Entity.useraddress> GetList(DbHelperMySQL myHelperMySQL, int Top, string filedSelect, string strWhere, string filedOrder, MySqlParameter[] parameters)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" TOP " + Top.ToString());
            }
            //自定义字段
            strSql.Append(" " + filedSelect);
            strSql.Append("  FROM useraddress a  ");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" WHERE " + strWhere);
            }
            if (filedOrder.Trim() != "")
            {
                strSql.Append(" ORDER BY " + filedOrder);
            }

            List<B1993.Entity.useraddress> myList = new List<B1993.Entity.useraddress>();
            using (MySqlDataReader dr = myHelperMySQL.ExecuteReader(strSql.ToString(), parameters))
            {
                while (dr.Read())
                {
                    B1993.Entity.useraddress model = new B1993.Entity.useraddress();

                    if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.addressid").Count() > 0)
                    {
                        if (dr["AddressID"].ToString() != "")
                        {
                            model.AddressID = int.Parse(dr["AddressID"].ToString());
                        }
                    }
                    if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.userid").Count() > 0)
                    {
                        model.UserId = dr["UserId"].ToString();
                    }
                    if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.permobile").Count() > 0)
                    {
                        model.PerMobile = dr["PerMobile"].ToString();
                    }
                    if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.pername").Count() > 0)
                    {
                        model.PerName = dr["PerName"].ToString();
                    }
                    if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.address").Count() > 0)
                    {
                        model.Address = dr["Address"].ToString();
                    }
                    if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.stateid").Count() > 0)
                    {
                        if (dr["StateId"].ToString() != "")
                        {
                            model.StateId = int.Parse(dr["StateId"].ToString());
                        }
                    }
                    if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.createdate").Count() > 0)
                    {
                        model.CreateDate = dr["CreateDate"].ToString();
                    }
                    if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.refreshdate").Count() > 0)
                    {
                        model.RefreshDate = dr["RefreshDate"].ToString();
                    }

                    myList.Add(model);
                }
                dr.Close();
            }
            return myList;
        }

    }
}