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
    /// log：实体类
    /// </summary>
	[Serializable]
	public class log
	{   
      	/// <summary>
		/// id
        /// </summary>		
		private int _id;
        public int id
        {
            get{ return _id; }
            set{ _id = value; }
        }        
		/// <summary>
		/// 作者
        /// </summary>		
		private string _writer;
        public string Writer
        {
            get{ return _writer; }
            set{ _writer = value; }
        }        
		/// <summary>
		/// 内容
        /// </summary>		
		private string _content;
        public string Content
        {
            get{ return _content; }
            set{ _content = value; }
        }        
		/// <summary>
		/// 时间
        /// </summary>		
		private string _createtime;
        public string CreateTime
        {
            get{ return _createtime; }
            set{ _createtime = value; }
        }        
		   
	}
}