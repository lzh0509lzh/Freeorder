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
    /// product_type：实体类
    /// </summary>
	[Serializable]
	public class product_type
	{   
      	/// <summary>
		/// 商品类型Id（0未启用，1启用，2首页展示）
        /// </summary>		
		private int _typeid;
        public int TypeId
        {
            get{ return _typeid; }
            set{ _typeid = value; }
        }        
		/// <summary>
		/// 商品类型名
        /// </summary>		
		private string _typename;
        public string TypeName
        {
            get{ return _typename; }
            set{ _typename = value; }
        }        
		/// <summary>
		/// 类型图片地址
        /// </summary>		
		private string _typepic;
        public string TypePic
        {
            get{ return _typepic; }
            set{ _typepic = value; }
        }        
		/// <summary>
		/// 父类型Id（无父类型默认为0）
        /// </summary>		
		private int _fathertypeid;
        public int FatherTypeId
        {
            get{ return _fathertypeid; }
            set{ _fathertypeid = value; }
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