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
    /// wechatuserinfo：实体类
    /// </summary>
	[Serializable]
	public class wechatuserinfo
	{   
      	/// <summary>
		/// 用户的唯一标识
        /// </summary>		
		private string _openid;
        public string openid
        {
            get{ return _openid; }
            set{ _openid = value; }
        }        
		/// <summary>
		/// 用户昵称
        /// </summary>		
		private string _nickname;
        public string nickname
        {
            get{ return _nickname; }
            set{ _nickname = value; }
        }        
		/// <summary>
		/// 用户的性别，值为1时是男性，值为2时是女性，值为0时是未知
        /// </summary>		
		private int _sex;
        public int sex
        {
            get{ return _sex; }
            set{ _sex = value; }
        }        
		/// <summary>
		/// 用户个人资料填写的省份
        /// </summary>		
		private string _province;
        public string province
        {
            get{ return _province; }
            set{ _province = value; }
        }        
		/// <summary>
		/// 普通用户个人资料填写的城市
        /// </summary>		
		private string _city;
        public string city
        {
            get{ return _city; }
            set{ _city = value; }
        }        
		/// <summary>
		/// 国家，如中国为CN
        /// </summary>		
		private string _country;
        public string country
        {
            get{ return _country; }
            set{ _country = value; }
        }        
		/// <summary>
		/// 用户头像，最后一个数值代表正方形头像大小（有0、46、64、96、132数值可选，0代表640*640正方形头像），用户没有头像时该项为空。若用户更换头像，原有头像URL将失效。
        /// </summary>		
		private string _headimgurl;
        public string headimgurl
        {
            get{ return _headimgurl; }
            set{ _headimgurl = value; }
        }        
		/// <summary>
		/// 用户特权信息，json 数组，如微信沃卡用户为（chinaunicom）
        /// </summary>		
		private string _privilege;
        public string privilege
        {
            get{ return _privilege; }
            set{ _privilege = value; }
        }        
		/// <summary>
		/// 只有在用户将公众号绑定到微信开放平台帐号后，才会出现该字段。
        /// </summary>		
		private string _unionid;
        public string unionid
        {
            get{ return _unionid; }
            set{ _unionid = value; }
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
		   
	}
}