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
    /// orderrecord：实体类
    /// </summary>
	[Serializable]
	public class orderrecord
	{   
      	/// <summary>
		/// 订单编号
        /// </summary>		
		private string _orderid;
        public string OrderId
        {
            get{ return _orderid; }
            set{ _orderid = value; }
        }        
		/// <summary>
		/// 用户编号
        /// </summary>		
		private string _userid;
        public string UserId
        {
            get{ return _userid; }
            set{ _userid = value; }
        }        
		/// <summary>
		/// 用户名
        /// </summary>		
		private string _username;
        public string UserName
        {
            get{ return _username; }
            set{ _username = value; }
        }        
		/// <summary>
		/// 收货人
        /// </summary>		
		private string _pername;
        public string PerName
        {
            get{ return _pername; }
            set{ _pername = value; }
        }        
		/// <summary>
		/// 收货地址
        /// </summary>		
		private string _address;
        public string Address
        {
            get{ return _address; }
            set{ _address = value; }
        }        
		/// <summary>
		/// 手机号
        /// </summary>		
		private string _mobile;
        public string Mobile
        {
            get{ return _mobile; }
            set{ _mobile = value; }
        }        
		/// <summary>
		/// 产品总额
        /// </summary>		
		private decimal _productamount;
        public decimal ProductAmount
        {
            get{ return _productamount; }
            set{ _productamount = value; }
        }        
		/// <summary>
		/// 邮费
        /// </summary>		
		private decimal _postamount;
        public decimal PostAmount
        {
            get{ return _postamount; }
            set{ _postamount = value; }
        }        
		/// <summary>
		/// 订单状态 （0未发货，1已发货，2待收货，3已收货）
        /// </summary>		
		private int _stateid;
        public int Stateid
        {
            get{ return _stateid; }
            set{ _stateid = value; }
        }        
		/// <summary>
		/// 订单总价
        /// </summary>		
		private decimal _amount;
        public decimal Amount
        {
            get{ return _amount; }
            set{ _amount = value; }
        }        
		   
	}
}