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
    /// product_info：实体类
    /// </summary>
	[Serializable]
	public class product_info
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
		/// 商品名称
        /// </summary>		
		private string _productname;
        public string ProductName
        {
            get{ return _productname; }
            set{ _productname = value; }
        }        
		/// <summary>
		/// 标价
        /// </summary>		
		private decimal _productprice;
        public decimal ProductPrice
        {
            get{ return _productprice; }
            set{ _productprice = value; }
        }        
		/// <summary>
		/// 商品图片
        /// </summary>		
		private string _mainimgurl;
        public string MainImgUrl
        {
            get{ return _mainimgurl; }
            set{ _mainimgurl = value; }
        }        
		/// <summary>
		/// 商品库存
        /// </summary>		
		private int _storenum;
        public int StoreNum
        {
            get{ return _storenum; }
            set{ _storenum = value; }
        }        
		/// <summary>
		/// 商品销量
        /// </summary>		
		private int _salesnum;
        public int SalesNum
        {
            get{ return _salesnum; }
            set{ _salesnum = value; }
        }        
		/// <summary>
		/// 商品类型Id
        /// </summary>		
		private int _typeid;
        public int TypeId
        {
            get{ return _typeid; }
            set{ _typeid = value; }
        }        
		/// <summary>
		/// 商品规格  
        /// </summary>		
		private string _specifications;
        public string Specifications
        {
            get{ return _specifications; }
            set{ _specifications = value; }
        }        
		/// <summary>
		/// 商品单位重量(kg）
        /// </summary>		
		private decimal _productweight;
        public decimal ProductWeight
        {
            get{ return _productweight; }
            set{ _productweight = value; }
        }        
		/// <summary>
		/// 商品描述
        /// </summary>		
		private string _productdetail;
        public string ProductDetail
        {
            get{ return _productdetail; }
            set{ _productdetail = value; }
        }        
		/// <summary>
		/// 所属公司
        /// </summary>		
		private string _madefactor;
        public string MadeFactor
        {
            get{ return _madefactor; }
            set{ _madefactor = value; }
        }        
		/// <summary>
		/// 商品产地
        /// </summary>		
		private string _madehome;
        public string MadeHome
        {
            get{ return _madehome; }
            set{ _madehome = value; }
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