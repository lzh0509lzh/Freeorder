/*         
*│版权所有：Dream1993
*│创建人：Lee        
*/  
using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace B1993.Entity{
	/// <summary>
    /// product_attr：实体类
    /// </summary>
	[Serializable]
	public class product_attr
	{   
      	/// <summary>
		/// 商品编号
        /// </summary>		
		private string _productid;
        public string ProductId
        {
            get{ return _productid; }
            set{ _productid = value; }
        }        
		/// <summary>
		/// 商品属性名
        /// </summary>		
		private string _attributename;
        public string AttributeName
        {
            get{ return _attributename; }
            set{ _attributename = value; }
        }        
		/// <summary>
		/// 商品属性值
        /// </summary>		
		private string _attributevalue;
        public string AttributeValue
        {
            get{ return _attributevalue; }
            set{ _attributevalue = value; }
        }        
		/// <summary>
		/// 操作人（默认为Admin）
        /// </summary>		
		private string _operator;
        public string Operator
        {
            get{ return _operator; }
            set{ _operator = value; }
        }        
		/// <summary>
		/// 用户状态（默认为1）
        /// </summary>		
		private int _stateid;
        public int StateId
        {
            get{ return _stateid; }
            set{ _stateid = value; }
        }        
		/// <summary>
		/// 创建时间
        /// </summary>		
		private string _createdate;
        public string CreateDate
        {
            get{ return _createdate; }
            set{ _createdate = value; }
        }        
		/// <summary>
		/// 更新时间
        /// </summary>		
		private string _refreshdate;
        public string RefreshDate
        {
            get{ return _refreshdate; }
            set{ _refreshdate = value; }
        }        
		   
	}
}