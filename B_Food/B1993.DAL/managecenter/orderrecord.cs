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

namespace B1993.DAL{
	/// <summary>
    /// orderrecord数据访问层类
    /// </summary>
	public partial class orderrecord
	{ 
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(DbHelperMySQL myHelperMySQL ,B1993.Entity.orderrecord model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into orderrecord(");			
            strSql.Append("UserId,UserName,PerName,Address,Mobile,ProductAmount,PostAmount,Stateid,Amount");
			strSql.Append(") values (");
            strSql.Append("@UserId,@UserName,@PerName,@Address,@Mobile,@ProductAmount,@PostAmount,@Stateid,@Amount");            
            strSql.Append(") ");            
            	
			MySqlParameter[] parameters = {
                                    new MySqlParameter("@UserId", model.UserId)  ,
                                    new MySqlParameter("@UserName", model.UserName)  ,
                                    new MySqlParameter("@PerName", model.PerName)  ,
                                    new MySqlParameter("@Address", model.Address)  ,
                                    new MySqlParameter("@Mobile", model.Mobile)  ,
                                    new MySqlParameter("@ProductAmount", model.ProductAmount)  ,
                                    new MySqlParameter("@PostAmount", model.PostAmount)  ,
                                    new MySqlParameter("@Stateid", model.Stateid)  ,
                                    new MySqlParameter("@Amount", model.Amount)              
            };
            
            myHelperMySQL.ExecuteNonQuery(strSql.ToString(),parameters);		
		}
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public int Update(DbHelperMySQL myHelperMySQL ,B1993.Entity.orderrecord model, string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update orderrecord set ");                                   
            strSql.Append(" UserId = @UserId , ");                                    
            strSql.Append(" UserName = @UserName , ");                                    
            strSql.Append(" PerName = @PerName , ");                                    
            strSql.Append(" Address = @Address , ");                                    
            strSql.Append(" Mobile = @Mobile , ");                                    
            strSql.Append(" ProductAmount = @ProductAmount , ");                                    
            strSql.Append(" PostAmount = @PostAmount , ");                                    
            strSql.Append(" Stateid = @Stateid , ");                                    
            strSql.Append(" Amount = @Amount  ");                        			
			MySqlParameter[] parameters = {
                                    new MySqlParameter("@UserId", model.UserId)  ,
                                    new MySqlParameter("@UserName", model.UserName)  ,
                                    new MySqlParameter("@PerName", model.PerName)  ,
                                    new MySqlParameter("@Address", model.Address)  ,
                                    new MySqlParameter("@Mobile", model.Mobile)  ,
                                    new MySqlParameter("@ProductAmount", model.ProductAmount)  ,
                                    new MySqlParameter("@PostAmount", model.PostAmount)  ,
                                    new MySqlParameter("@Stateid", model.Stateid)  ,
                                    new MySqlParameter("@Amount", model.Amount)               
            };
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            int rows=myHelperMySQL.ExecuteNonQuery(strSql.ToString(),parameters);

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
		public int Delete(DbHelperMySQL myHelperMySQL ,string strWhere, MySqlParameter[] parameters)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from orderrecord ");
			
			if (strWhere.Trim() != "")
            {
                strSql.Append(" WHERE " + strWhere);
            }

			int rows=myHelperMySQL.ExecuteNonQuery(strSql.ToString(),parameters);
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
			strSql.Append("  FROM orderrecord  ");
			
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            List<B1993.Entity.orderrecord> myList = new List<B1993.Entity.orderrecord>();
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
		public List<B1993.Entity.orderrecord> GetList(DbHelperMySQL myHelperMySQL ,int Top, string strWhere, string filedOrder, MySqlParameter[] parameters)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if (Top > 0)
            {
                strSql.Append(" TOP " + Top.ToString());
            }
			strSql.Append(" a.OrderId, a.UserId, a.UserName, a.PerName, a.Address, a.Mobile, a.ProductAmount, a.PostAmount, a.Stateid, a.Amount  ");			
			strSql.Append("  FROM orderrecord a ");
			
			if (strWhere.Trim() != "")
            {
                strSql.Append(" WHERE " + strWhere);
            }
            if (filedOrder.Trim() != "")
            {
                strSql.Append(" ORDER BY " + filedOrder);
            }
            
            List<B1993.Entity.orderrecord> myList = new List<B1993.Entity.orderrecord>();
            using (MySqlDataReader dr = myHelperMySQL.ExecuteReader(strSql.ToString(), parameters))
            {
                while (dr.Read())
                {
                    B1993.Entity.orderrecord model = new B1993.Entity.orderrecord();
                    
                    															model.OrderId= dr["OrderId"].ToString();
																																								model.UserId= dr["UserId"].ToString();
																																								model.UserName= dr["UserName"].ToString();
																																								model.PerName= dr["PerName"].ToString();
																																								model.Address= dr["Address"].ToString();
																																								model.Mobile= dr["Mobile"].ToString();
																																			if(dr["ProductAmount"].ToString()!="")
					{
						model.ProductAmount=decimal.Parse(dr["ProductAmount"].ToString());
					}
																																								if(dr["PostAmount"].ToString()!="")
					{
						model.PostAmount=decimal.Parse(dr["PostAmount"].ToString());
					}
																																								if(dr["Stateid"].ToString()!="")
					{
						model.Stateid=int.Parse(dr["Stateid"].ToString());
					}
																																								if(dr["Amount"].ToString()!="")
					{
						model.Amount=decimal.Parse(dr["Amount"].ToString());
					}
																														
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
		public List<B1993.Entity.orderrecord> GetList(DbHelperMySQL myHelperMySQL ,int Top, string filedSelect, string strWhere, string filedOrder, MySqlParameter[] parameters)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if (Top > 0)
            {
                strSql.Append(" TOP " + Top.ToString());
            }
			//自定义字段
            strSql.Append(" " + filedSelect);
			strSql.Append("  FROM orderrecord a  ");
			
			if (strWhere.Trim() != "")
            {
                strSql.Append(" WHERE " + strWhere);
            }
            if (filedOrder.Trim() != "")
            {
                strSql.Append(" ORDER BY " + filedOrder);
            }
            
            List<B1993.Entity.orderrecord> myList = new List<B1993.Entity.orderrecord>();
            using (MySqlDataReader dr = myHelperMySQL.ExecuteReader(strSql.ToString(), parameters))
            {
                while (dr.Read())
                {
                    B1993.Entity.orderrecord model = new B1993.Entity.orderrecord();
                    
                    	                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.orderid").Count() > 0)
	                {
															model.OrderId= dr["OrderId"].ToString();
																									} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.userid").Count() > 0)
	                {
															model.UserId= dr["UserId"].ToString();
																									} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.username").Count() > 0)
	                {
															model.UserName= dr["UserName"].ToString();
																									} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.pername").Count() > 0)
	                {
															model.PerName= dr["PerName"].ToString();
																									} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.address").Count() > 0)
	                {
															model.Address= dr["Address"].ToString();
																									} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.mobile").Count() > 0)
	                {
															model.Mobile= dr["Mobile"].ToString();
																									} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.productamount").Count() > 0)
	                {
										if(dr["ProductAmount"].ToString()!="")
					{
						model.ProductAmount=decimal.Parse(dr["ProductAmount"].ToString());
					}
																														} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.postamount").Count() > 0)
	                {
										if(dr["PostAmount"].ToString()!="")
					{
						model.PostAmount=decimal.Parse(dr["PostAmount"].ToString());
					}
																														} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.stateid").Count() > 0)
	                {
										if(dr["Stateid"].ToString()!="")
					{
						model.Stateid=int.Parse(dr["Stateid"].ToString());
					}
																														} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.amount").Count() > 0)
	                {
										if(dr["Amount"].ToString()!="")
					{
						model.Amount=decimal.Parse(dr["Amount"].ToString());
					}
																														} 
					
                    myList.Add(model);
                }
                dr.Close();
            }
            return myList;
		}

	}
}