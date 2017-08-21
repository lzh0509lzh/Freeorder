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
    /// wx_requestdata：实体类
    /// </summary>
	[Serializable]
	public class wx_requestdata
	{   
      	/// <summary>
		/// 序列号
        /// </summary>		
		private int _id;
        public int id
        {
            get{ return _id; }
            set{ _id = value; }
        }        
		/// <summary>
		/// 数据名
        /// </summary>		
		private string _datakey;
        public string DataKey
        {
            get{ return _datakey; }
            set{ _datakey = value; }
        }        
		/// <summary>
		/// 数据值
        /// </summary>		
		private string _datavalue;
        public string DataValue
        {
            get{ return _datavalue; }
            set{ _datavalue = value; }
        }        
		/// <summary>
		/// 有效时间/秒
        /// </summary>		
		private string _expires_in;
        public string expires_in
        {
            get{ return _expires_in; }
            set{ _expires_in = value; }
        }        
		/// <summary>
		/// 有效时间/秒
        /// </summary>		
		private string _refreshtime;
        public string RefreshTime
        {
            get{ return _refreshtime; }
            set{ _refreshtime = value; }
        }        
		   
	}
}