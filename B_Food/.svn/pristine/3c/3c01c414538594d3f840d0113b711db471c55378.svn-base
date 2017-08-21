/* File Created: 六月 02, 2017 add by lee */


($.extend($, {

    /*清空文本两边的空格
    value:需要去掉空白的值
    */
    TrimBlank: function (value) {
        try {
            return String(value).replace(/^\s+|\s+$/g, "")
        } catch (e) {
            return "";
        }
    },

    /* 去掉字符串中，指定的空格
   function:cTrim(sInputString,iType) 
   description:字符串去空格的函数 
   parameters:iType：
   1=去掉字符串左边的空格 
   2=去掉字符串右边边的空格 
   0=去掉字符串左边和右边的空格 
   return value:去掉空格的字符串 
   */
    Trim: function (sInputString, iType) {
        var sTmpStr = ' ';
        var i = -1;

        if (iType == 0 || iType == 1) {
            while (sTmpStr == ' ') {
                ++i;
                sTmpStr = sInputString.substr(i, 1);
            }
            sInputString = sInputString.substring(i);
        }

        if (iType == 0 || iType == 2) {
            sTmpStr = ' ';
            i = sInputString.length;
            while (sTmpStr == ' ') {
                --i;
                sTmpStr = sInputString.substr(i, 1);
            }
            sInputString = sInputString.substring(0, i + 1);
        }
        return sInputString;
    },

    /*正则表达式验证输入的值
    value：值
    validType：类型
    （例如：email，tel，digitletterunderline，digitletterstar，digitletter，digit，letter，chineseletterdigit，ip，url,integer，positiveinteger，decimalsinteger，currency）
    */
    ValidateInputType: function (value, validType) {
        var isPass = true;
        var reg;
        if ($.trim(validType).toLowerCase() == "email") {//检查输入字符串是否是邮箱
            reg = new RegExp("^([a-zA-Z0-9]+[_|\_|\.]?)*[a-zA-Z0-9]+@([a-zA-Z0-9]+[_|\_|\.]?)*[a-zA-Z0-9]+\.[a-zA-Z]{2,3}$");
            if (!reg.test(value)) {
                isPass = false;
            }
        }
        else if ($.trim(validType).toLowerCase() == "tel") {//检查输入字符串是否是手机号码(11-12位)
            reg = new RegExp("^0?(13[0-9]|15[012356789]|18[0236789]|14[57])[0-9]{8}$");
            if (!reg.test(value)) {
                isPass = false;
            }
        }
        else if ($.trim(validType).toLowerCase() == "digitletterunderline") {//检查输入字符串是否只由英文字母和数字和下划线组成 
            reg = new RegExp("^[0-9a-zA-Z\_]+$");
            if (!reg.test(value)) {
                isPass = false;
            }
        }
        else if ($.trim(validType).toLowerCase() == "digitletterstar") {//检查输入字符串是否只由英文字母和数字和"*"组成 
            reg = new RegExp("^[0-9a-zA-Z\*]+$");
            if (!reg.test(value)) {
                isPass = false;
            }
        }
        else if ($.trim(validType).toLowerCase() == "digitletter") {//检查是否是由数字和字母组成
            reg = new RegExp("^[0-9a-zA-Z]+$");
            if (!reg.test(value)) {
                isPass = false;
            }
        }
        else if ($.trim(validType).toLowerCase() == "digit") {//检查是否包含数字部分
            reg = new RegExp("\d+");
            if (!reg.test(value)) {
                isPass = false;
            }
        }
        else if ($.trim(validType).toLowerCase() == "letter") {//检查是否包含字母部分
            reg = new RegExp("\w+");
            if (!reg.test(value)) {
                isPass = false;
            }
        }
        else if ($.trim(validType).toLowerCase() == "chineseletterdigit") {//检查是否是有中文、字母和数字组成
            reg = new RegExp("^[0-9a-zA-Z\u4e00-\u9fa5]+$");
            if (!reg.test(value)) {
                isPass = false;
            }
        }

        else if ($.trim(validType).toLowerCase() == "ip") {//检查是否是ip地址
            reg = new RegExp("^(\d+)\.(\d+)\.(\d+)\.(\d+)$", "g");
            if (reg.test(value)) {
                if (RegExp.$1 < 256 && RegExp.$2 < 256 && RegExp.$3 < 256 && RegExp.$4 < 256) {
                    isPass = true;
                }
            }
            else {
                isPass = false;
            }
        }

        else if ($.trim(validType).toLowerCase() == "integer") {//检查是否是整数
            reg = new RegExp("^[-]{0,1}[0-9]{1,}$");
            if (!reg.test(value)) {
                isPass = false;
            }
        }

        else if ($.trim(validType).toLowerCase() == "positiveinteger") {//检查是否是正整数
            reg = new RegExp("^[0-9]+$");
            if (s.search(re) != -1) {
                isPass = true;
            }
            else {
                isPass = false;
            }
        }

        else if ($.trim(validType).toLowerCase() == "decimalsinteger") {//检查输入字符串是否是带小数的数字格式,可以是负数 
            reg = new RegExp("^[-]{0,1}(\d+)[\.]+(\d+)$");
            if (reg.test(value)) {
                if (RegExp.$1 == 0 && RegExp.$2 == 0) { isPass = false; } else { isPass = true; }
            }
            else { isPass = false; }
        }
        else if ($.trim(validType).toLowerCase() == "currency") {//检查输入字符串是否符合金额格式 ,格式定义为带小数的正数，小数点后最多三位 
            reg = new RegExp("^[0-9]+[\.][0-9]{0,3}$");
            if (!reg.test(value)) {
                isPass = false;
            }
        }
        else if ($.trim(validType).toLowerCase() == "url") {//检查输入字符串是否符合url
            reg = /(http|ftp|https):\/\/[\w\-_]+(\.[\w\-_]+)+([\w\-\.,@?^=%&amp;:\/~\+#]*[\w\-\@?^=%&amp;\/~\+#])?/;
            if (!reg.test(value)) {
                isPass = false;
            }
        }
        return isPass;
    },

    /*用户验证文本框的值是否为为空，文本框的提示信息
    value：值
    validVal:文本框提示信息
    */
    IsNullOrEmpty: function (value, validVal) {
        var isPass = false;
        if (arguments.length == 1) {
            if ($.trim(value) == "" || typeof value == "object" || typeof value == "undefined") {
                isPass = true;
            }
        } else {
            if ($.trim(value) == "" || typeof value == "undefined" || $.trim(value) == $.trim(validVal)) {
                isPass = true;
            }
        }
        return isPass;
    },
    /*判断是否是空
    * @param value
    */
    IsEmpty: function (value) {
        if (value == null || value == "" || value == "undefined" || value == undefined || value == "null") {
            return true;
        }
        else {
            value = value.replace(/\s/g, "");
            if (value == "") {
                return true;
            }
            return false;
        }
    },

    /* 获取参数(例如：http://www.i2688.com/h5.html?id=2; $.QueryString("id"))
    *name:参数名称
    */
    QueryString: function (name) {
        var reg = new RegExp("(^|&)" + String(name).toLowerCase() + "=([^&]*)(&|$)");
        var r = String(decodeURI(window.location.search)).toLowerCase().substr(1).match(reg);
        if (r != null) return unescape(r[2]); return null;
    },

    /*获取 站点名+页面名+参数。
    例如:
    假设当前页完整地址是：http://www.test.com/aaa/bbb.aspx?id=5&name=kelli
    "http://"是协议名
    "www.test.com"是域名
    "aaa"是站点名
    "bbb.aspx"是页面名（文件名）
    "id=5&name=kelli"是参数
    */
    RawUrl: function () {
        //return window.location.pathname + window.location.search;
        var PathAndQuery = window.location.pathname + window.location.search;
        return String(PathAndQuery).substring(1);
    },

    /*获取所有Cookie
   * elementId：元素ID
   */
    GetDomainCookies: function (elementId) {
        var cookies = document.cookie.split(/; */);
        var strcookie;
        for (var i = 0; i < cookies.length; i++) {
            var cookie = cookies[i];
            var cks = String(cookie).split("=");
            var key = cks[0];
            var cm = $.cookie(key);
            if (!$.IsNullOrEmpty(cm)) {
                strcookie += key + ":" + cm + "</br>";
            }
        }
        $(elementId).html(strcookie).show();
    },

    /*移除指定的Cookie
    * prefix:移除“键”中包含prefix的cookie
    */
    RemoveDomainCookies: function (prefix) {
        var cookies = document.cookie.split(/; */);
        for (var i = 0; i < cookies.length; i++) {
            var cookie = cookies[i];
            var cks = String(cookie).split("=");
            var key = cks[0];
            if (key.indexOf(prefix) != -1) {
                $.cookie(key, null, { expires: -1, domain: "", path: "/", secure: false });
            }
        }
    },
    /*清除所有cookie
    */
    ClearDomainCookies: function () {
        var cookies = document.cookie.split(/; */);
        for (var i = 0; i < cookies.length; i++) {
            var cookie = cookies[i];
            var cks = String(cookie).split("=");
            var key = cks[0];
            $.cookie(key, null, { expires: -1, domain: "", path: "/", secure: false });
        }
    }

})());