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
    /// product_info数据访问层类
    /// </summary>
	public partial class product_info
	{ 
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(DbHelperMySQL myHelperMySQL ,B1993.Entity.product_info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into product_info(");			
            strSql.Append("ProductName,ProductPrice,MainImgUrl,StoreNum,SalesNum,TypeId,Specifications,ProductWeight,ProductDetail,MadeFactor,MadeHome,Operator,StateId,CreateDate,RefreshDate");
			strSql.Append(") values (");
            strSql.Append("@ProductName,@ProductPrice,@MainImgUrl,@StoreNum,@SalesNum,@TypeId,@Specifications,@ProductWeight,@ProductDetail,@MadeFactor,@MadeHome,@Operator,@StateId,@CreateDate,@RefreshDate");            
            strSql.Append(") ");            
            	
			MySqlParameter[] parameters = {
                                    new MySqlParameter("@ProductName", model.ProductName)  ,
                                    new MySqlParameter("@ProductPrice", model.ProductPrice)  ,
                                    new MySqlParameter("@MainImgUrl", model.MainImgUrl)  ,
                                    new MySqlParameter("@StoreNum", model.StoreNum)  ,
                                    new MySqlParameter("@SalesNum", model.SalesNum)  ,
                                    new MySqlParameter("@TypeId", model.TypeId)  ,
                                    new MySqlParameter("@Specifications", model.Specifications)  ,
                                    new MySqlParameter("@ProductWeight", model.ProductWeight)  ,
                                    new MySqlParameter("@ProductDetail", model.ProductDetail)  ,
                                    new MySqlParameter("@MadeFactor", model.MadeFactor)  ,
                                    new MySqlParameter("@MadeHome", model.MadeHome)  ,
                                    new MySqlParameter("@Operator", model.Operator)  ,
                                    new MySqlParameter("@StateId", model.StateId)  ,
                                    new MySqlParameter("@CreateDate", model.CreateDate)  ,
                                    new MySqlParameter("@RefreshDate", model.RefreshDate)              
            };
            
            myHelperMySQL.ExecuteNonQuery(strSql.ToString(),parameters);		
		}
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public int Update(DbHelperMySQL myHelperMySQL ,B1993.Entity.product_info model, string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update product_info set ");                               
            strSql.Append(" ProductName = @ProductName , ");                                    
            strSql.Append(" ProductPrice = @ProductPrice , ");                                    
            strSql.Append(" MainImgUrl = @MainImgUrl , ");                                    
            strSql.Append(" StoreNum = @StoreNum , ");                                    
            strSql.Append(" SalesNum = @SalesNum , ");                                    
            strSql.Append(" TypeId = @TypeId , ");                                    
            strSql.Append(" Specifications = @Specifications , ");                                    
            strSql.Append(" ProductWeight = @ProductWeight , ");                                    
            strSql.Append(" ProductDetail = @ProductDetail , ");                                    
            strSql.Append(" MadeFactor = @MadeFactor , ");                                    
            strSql.Append(" MadeHome = @MadeHome , ");                                    
            strSql.Append(" Operator = @Operator , ");                                    
            strSql.Append(" StateId = @StateId , ");                                    
            strSql.Append(" CreateDate = @CreateDate , ");                                    
            strSql.Append(" RefreshDate = @RefreshDate  ");                        			
			MySqlParameter[] parameters = {
                                    new MySqlParameter("@ProductName", model.ProductName)  ,
                                    new MySqlParameter("@ProductPrice", model.ProductPrice)  ,
                                    new MySqlParameter("@MainImgUrl", model.MainImgUrl)  ,
                                    new MySqlParameter("@StoreNum", model.StoreNum)  ,
                                    new MySqlParameter("@SalesNum", model.SalesNum)  ,
                                    new MySqlParameter("@TypeId", model.TypeId)  ,
                                    new MySqlParameter("@Specifications", model.Specifications)  ,
                                    new MySqlParameter("@ProductWeight", model.ProductWeight)  ,
                                    new MySqlParameter("@ProductDetail", model.ProductDetail)  ,
                                    new MySqlParameter("@MadeFactor", model.MadeFactor)  ,
                                    new MySqlParameter("@MadeHome", model.MadeHome)  ,
                                    new MySqlParameter("@Operator", model.Operator)  ,
                                    new MySqlParameter("@StateId", model.StateId)  ,
                                    new MySqlParameter("@CreateDate", model.CreateDate)  ,
                                    new MySqlParameter("@RefreshDate", model.RefreshDate)               
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
			strSql.Append("delete from product_info ");
			
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
			strSql.Append("  FROM product_info  ");
			
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            List<B1993.Entity.product_info> myList = new List<B1993.Entity.product_info>();
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
		public List<B1993.Entity.product_info> GetList(DbHelperMySQL myHelperMySQL ,int Top, string strWhere, string filedOrder, MySqlParameter[] parameters)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if (Top > 0)
            {
                strSql.Append(" TOP " + Top.ToString());
            }
			strSql.Append(" a.ProductId, a.ProductName, a.ProductPrice, a.MainImgUrl, a.StoreNum, a.SalesNum, a.TypeId, a.Specifications, a.ProductWeight, a.ProductDetail, a.MadeFactor, a.MadeHome, a.Operator, a.StateId, a.CreateDate, a.RefreshDate  ");			
			strSql.Append("  FROM product_info a ");
			
			if (strWhere.Trim() != "")
            {
                strSql.Append(" WHERE " + strWhere);
            }
            if (filedOrder.Trim() != "")
            {
                strSql.Append(" ORDER BY " + filedOrder);
            }
            
            List<B1993.Entity.product_info> myList = new List<B1993.Entity.product_info>();
            using (MySqlDataReader dr = myHelperMySQL.ExecuteReader(strSql.ToString(), parameters))
            {
                while (dr.Read())
                {
                    B1993.Entity.product_info model = new B1993.Entity.product_info();
                    
                    															model.ProductId= dr["ProductId"].ToString();
																																								model.ProductName= dr["ProductName"].ToString();
																																			if(dr["ProductPrice"].ToString()!="")
					{
						model.ProductPrice=decimal.Parse(dr["ProductPrice"].ToString());
					}
																																													model.MainImgUrl= dr["MainImgUrl"].ToString();
																																			if(dr["StoreNum"].ToString()!="")
					{
						model.StoreNum=int.Parse(dr["StoreNum"].ToString());
					}
																																								if(dr["SalesNum"].ToString()!="")
					{
						model.SalesNum=int.Parse(dr["SalesNum"].ToString());
					}
																																								if(dr["TypeId"].ToString()!="")
					{
						model.TypeId=int.Parse(dr["TypeId"].ToString());
					}
																																													model.Specifications= dr["Specifications"].ToString();
																																			if(dr["ProductWeight"].ToString()!="")
					{
						model.ProductWeight=decimal.Parse(dr["ProductWeight"].ToString());
					}
																																													model.ProductDetail= dr["ProductDetail"].ToString();
																																								model.MadeFactor= dr["MadeFactor"].ToString();
																																								model.MadeHome= dr["MadeHome"].ToString();
																																								model.Operator= dr["Operator"].ToString();
																																			if(dr["StateId"].ToString()!="")
					{
						model.StateId=int.Parse(dr["StateId"].ToString());
					}
																																													model.CreateDate= dr["CreateDate"].ToString();
																																								model.RefreshDate= dr["RefreshDate"].ToString();
																									
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
		public List<B1993.Entity.product_info> GetList(DbHelperMySQL myHelperMySQL ,int Top, string filedSelect, string strWhere, string filedOrder, MySqlParameter[] parameters)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if (Top > 0)
            {
                strSql.Append(" TOP " + Top.ToString());
            }
			//自定义字段
            strSql.Append(" " + filedSelect);
			strSql.Append("  FROM product_info a  ");
			
			if (strWhere.Trim() != "")
            {
                strSql.Append(" WHERE " + strWhere);
            }
            if (filedOrder.Trim() != "")
            {
                strSql.Append(" ORDER BY " + filedOrder);
            }
            
            List<B1993.Entity.product_info> myList = new List<B1993.Entity.product_info>();
            using (MySqlDataReader dr = myHelperMySQL.ExecuteReader(strSql.ToString(), parameters))
            {
                while (dr.Read())
                {
                    B1993.Entity.product_info model = new B1993.Entity.product_info();
                    
                    	                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.productid").Count() > 0)
	                {
															model.ProductId= dr["ProductId"].ToString();
																									} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.productname").Count() > 0)
	                {
															model.ProductName= dr["ProductName"].ToString();
																									} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.productprice").Count() > 0)
	                {
										if(dr["ProductPrice"].ToString()!="")
					{
						model.ProductPrice=decimal.Parse(dr["ProductPrice"].ToString());
					}
																														} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.mainimgurl").Count() > 0)
	                {
															model.MainImgUrl= dr["MainImgUrl"].ToString();
																									} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.storenum").Count() > 0)
	                {
										if(dr["StoreNum"].ToString()!="")
					{
						model.StoreNum=int.Parse(dr["StoreNum"].ToString());
					}
																														} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.salesnum").Count() > 0)
	                {
										if(dr["SalesNum"].ToString()!="")
					{
						model.SalesNum=int.Parse(dr["SalesNum"].ToString());
					}
																														} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.typeid").Count() > 0)
	                {
										if(dr["TypeId"].ToString()!="")
					{
						model.TypeId=int.Parse(dr["TypeId"].ToString());
					}
																														} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.specifications").Count() > 0)
	                {
															model.Specifications= dr["Specifications"].ToString();
																									} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.productweight").Count() > 0)
	                {
										if(dr["ProductWeight"].ToString()!="")
					{
						model.ProductWeight=decimal.Parse(dr["ProductWeight"].ToString());
					}
																														} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.productdetail").Count() > 0)
	                {
															model.ProductDetail= dr["ProductDetail"].ToString();
																									} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.madefactor").Count() > 0)
	                {
															model.MadeFactor= dr["MadeFactor"].ToString();
																									} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.madehome").Count() > 0)
	                {
															model.MadeHome= dr["MadeHome"].ToString();
																									} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.operator").Count() > 0)
	                {
															model.Operator= dr["Operator"].ToString();
																									} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.stateid").Count() > 0)
	                {
										if(dr["StateId"].ToString()!="")
					{
						model.StateId=int.Parse(dr["StateId"].ToString());
					}
																														} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.createdate").Count() > 0)
	                {
															model.CreateDate= dr["CreateDate"].ToString();
																									} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.refreshdate").Count() > 0)
	                {
															model.RefreshDate= dr["RefreshDate"].ToString();
																									} 
					
                    myList.Add(model);
                }
                dr.Close();
            }
            return myList;
		}

	}
}