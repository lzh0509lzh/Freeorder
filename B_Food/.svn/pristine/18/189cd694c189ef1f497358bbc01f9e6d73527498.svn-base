using B1993.Core;
using B1993.Core.WeChat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B1993.BLL.Wechat
{
    public class GetToken
    {
        public void Access_token()
        {
            string url = "https://api.weixin.qq.com/cgi-bin/token";
            string Datastr = "grant_type=client_credential&appid=wxee8247c68c078628&secret=ec9ab6720ace244c3a25561bc19ce0a7";
            string strJson = RequestGP.HttpGet(url, Datastr);
            B1993.Entity.WeChat.JsonModel_token model = JSONUtility<B1993.Entity.WeChat.JsonModel_token>.DeSerialize(strJson);
            var a1 = model.access_token;
            var a2 = model.expires_in;
            var a3 = model.errcode;
            var a4 = model.invalid;

        }
    }
}
