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
    /// userinfo：实体类
    /// </summary>
	[Serializable]
	public class userinfo
	{   
      	/// <summary>
		/// 用户ID
        /// </summary>		
		private string _userid;
        public string UserId
        {
            get{ return _userid; }
            set{ _userid = value; }
        }        
		/// <summary>
		/// 微信用户的唯一标识
        /// </summary>		
		private string _openid;
        public string Openid
        {
            get{ return _openid; }
            set{ _openid = value; }
        }
        /// <summary>
		/// 微信用户头像
        /// </summary>		
		private string _headimgurl;
        public string headimgurl
        {
            get { return _headimgurl; }
            set { _headimgurl = value; }
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
		/// 用户密码
        /// </summary>		
		private string _pwd;
        public string Pwd
        {
            get{ return _pwd; }
            set{ _pwd = value; }
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
		/// 用户组：6普通用户，9管理员
        /// </summary>		
		private int _groupclass;
        public int GroupClass
        {
            get{ return _groupclass; }
            set{ _groupclass = value; }
        }        
		/// <summary>
		/// 操作人
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