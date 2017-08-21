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
    /// product_img：实体类
    /// </summary>
	[Serializable]
	public class product_img
	{   
      	/// <summary>
		/// ProductId
        /// </summary>		
		private string _productid;
        public string ProductId
        {
            get{ return _productid; }
            set{ _productid = value; }
        }        
		/// <summary>
		/// PhotoUrl
        /// </summary>		
		private string _photourl;
        public string PhotoUrl
        {
            get{ return _photourl; }
            set{ _photourl = value; }
        }        
		   
	}
}