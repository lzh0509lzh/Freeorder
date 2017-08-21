/*         
*│版权所有：Dream1993
*│创建人：Lee        
*/
using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace B1993.Entity
{
    /// <summary>
    /// useraddress：实体类
    /// </summary>
    [Serializable]
    public class useraddress
    {
        /// <summary>
        /// 地址编号
        /// </summary>		
        private int _addressid;
        public int AddressID
        {
            get { return _addressid; }
            set { _addressid = value; }
        }
        /// <summary>
        /// 用户编号
        /// </summary>		
        private string _userid;
        public string UserId
        {
            get { return _userid; }
            set { _userid = value; }
        }
        /// <summary>
        /// 收货人手机号
        /// </summary>		
        private string _permobile;
        public string PerMobile
        {
            get { return _permobile; }
            set { _permobile = value; }
        }
        /// <summary>
        /// 收货人姓名
        /// </summary>		
        private string _pername;
        public string PerName
        {
            get { return _pername; }
            set { _pername = value; }
        }
        /// <summary>
        /// 收货人地址
        /// </summary>		
        private string _address;
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        /// <summary>
        /// 地址状态（1普通，2默认）
        /// </summary>		
        private int _stateid;
        public int StateId
        {
            get { return _stateid; }
            set { _stateid = value; }
        }
        /// <summary>
        /// 创建时间
        /// </summary>		
        private string _createdate;
        public string CreateDate
        {
            get { return _createdate; }
            set { _createdate = value; }
        }
        /// <summary>
        /// 更新时间
        /// </summary>		
        private string _refreshdate;
        public string RefreshDate
        {
            get { return _refreshdate; }
            set { _refreshdate = value; }
        }

    }
}