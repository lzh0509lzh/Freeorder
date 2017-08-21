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
    /// orderlist数据访问层类
    /// </summary>
	public partial class orderlist
	{ 
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(DbHelperMySQL myHelperMySQL ,B1993.Entity.orderlist model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into orderlist(");			
            strSql.Append("OrderId,ProductId,ProductName,Num,ProductPrice,Amount");
			strSql.Append(") values (");
            strSql.Append("@OrderId,@ProductId,@ProductName,@Num,@ProductPrice,@Amount");            
            strSql.Append(") ");            
            	
			MySqlParameter[] parameters = {
			            new MySqlParameter("@OrderId", model.OrderId)  ,
                                    new MySqlParameter("@ProductId", model.ProductId)  ,
                                    new MySqlParameter("@ProductName", model.ProductName)  ,
                                    new MySqlParameter("@Num", model.Num)  ,
                                    new MySqlParameter("@ProductPrice", model.ProductPrice)  ,
                                    new MySqlParameter("@Amount", model.Amount)              
            };
            
            myHelperMySQL.ExecuteNonQuery(strSql.ToString(),parameters);		
		}
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public int Update(DbHelperMySQL myHelperMySQL ,B1993.Entity.orderlist model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update orderlist set ");
			                        
            strSql.Append(" OrderId = @OrderId , ");                                    
            strSql.Append(" ProductId = @ProductId , ");                                    
            strSql.Append(" ProductName = @ProductName , ");                                    
            strSql.Append(" Num = @Num , ");                                    
            strSql.Append(" ProductPrice = @ProductPrice , ");                                    
            strSql.Append(" Amount = @Amount  ");                        			
			MySqlParameter[] parameters = {
			            new MySqlParameter("@OrderId", model.OrderId)  ,
                                    new MySqlParameter("@ProductId", model.ProductId)  ,
                                    new MySqlParameter("@ProductName", model.ProductName)  ,
                                    new MySqlParameter("@Num", model.Num)  ,
                                    new MySqlParameter("@ProductPrice", model.ProductPrice)  ,
                                    new MySqlParameter("@Amount", model.Amount)               
            };
            
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
			strSql.Append("delete from orderlist ");
			
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
			strSql.Append("  FROM orderlist  ");
			
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            List<B1993.Entity.orderlist> myList = new List<B1993.Entity.orderlist>();
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
		public List<B1993.Entity.orderlist> GetList(DbHelperMySQL myHelperMySQL ,int Top, string strWhere, string filedOrder, MySqlParameter[] parameters)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if (Top > 0)
            {
                strSql.Append(" TOP " + Top.ToString());
            }
			strSql.Append(" a.OrderId, a.ProductId, a.ProductName, a.Num, a.ProductPrice, a.Amount  ");			
			strSql.Append("  FROM orderlist a ");
			
			if (strWhere.Trim() != "")
            {
                strSql.Append(" WHERE " + strWhere);
            }
            if (filedOrder.Trim() != "")
            {
                strSql.Append(" ORDER BY " + filedOrder);
            }
            
            List<B1993.Entity.orderlist> myList = new List<B1993.Entity.orderlist>();
            using (MySqlDataReader dr = myHelperMySQL.ExecuteReader(strSql.ToString(), parameters))
            {
                while (dr.Read())
                {
                    B1993.Entity.orderlist model = new B1993.Entity.orderlist();
                    
                    															model.OrderId= dr["OrderId"].ToString();
																																								model.ProductId= dr["ProductId"].ToString();
																																								model.ProductName= dr["ProductName"].ToString();
																																			if(dr["Num"].ToString()!="")
					{
						model.Num=int.Parse(dr["Num"].ToString());
					}
																																								if(dr["ProductPrice"].ToString()!="")
					{
						model.ProductPrice=decimal.Parse(dr["ProductPrice"].ToString());
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
		public List<B1993.Entity.orderlist> GetList(DbHelperMySQL myHelperMySQL ,int Top, string filedSelect, string strWhere, string filedOrder, MySqlParameter[] parameters)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if (Top > 0)
            {
                strSql.Append(" TOP " + Top.ToString());
            }
			//自定义字段
            strSql.Append(" " + filedSelect);
			strSql.Append("  FROM orderlist a  ");
			
			if (strWhere.Trim() != "")
            {
                strSql.Append(" WHERE " + strWhere);
            }
            if (filedOrder.Trim() != "")
            {
                strSql.Append(" ORDER BY " + filedOrder);
            }
            
            List<B1993.Entity.orderlist> myList = new List<B1993.Entity.orderlist>();
            using (MySqlDataReader dr = myHelperMySQL.ExecuteReader(strSql.ToString(), parameters))
            {
                while (dr.Read())
                {
                    B1993.Entity.orderlist model = new B1993.Entity.orderlist();
                    
                    	                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.orderid").Count() > 0)
	                {
															model.OrderId= dr["OrderId"].ToString();
																									} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.productid").Count() > 0)
	                {
															model.ProductId= dr["ProductId"].ToString();
																									} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.productname").Count() > 0)
	                {
															model.ProductName= dr["ProductName"].ToString();
																									} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.num").Count() > 0)
	                {
										if(dr["Num"].ToString()!="")
					{
						model.Num=int.Parse(dr["Num"].ToString());
					}
																														} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.productprice").Count() > 0)
	                {
										if(dr["ProductPrice"].ToString()!="")
					{
						model.ProductPrice=decimal.Parse(dr["ProductPrice"].ToString());
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