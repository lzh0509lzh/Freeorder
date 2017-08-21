using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B1993.BLL
{
    public class Myfunc
    {

        #region 打印日志
        public static void WriteLog(string content)
        {
            WriteLog("lee",content);
        }
        public static void WriteLog(string writer,string content)
        {
            #region TXT格式
            //FileStream fs = new FileStream(@"c:\MessageService.txt", FileMode.OpenOrCreate, FileAccess.Write);
            //StreamWriter m_streamWriter = new StreamWriter(fs);
            //m_streamWriter.BaseStream.Seek(0, SeekOrigin.End);
            //StringBuilder sb = new StringBuilder();
            //sb.Append("MessageService: ");
            //sb.Append(content);
            //sb.Append(" " + DateTime.Now.ToString() + "\n");
            //m_streamWriter.WriteLine(sb.ToString());
            //m_streamWriter.Flush();
            //m_streamWriter.Close();
            //fs.Close();
            #endregion

            #region SQL格式
            string datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            B1993.Entity.log model = new B1993.Entity.log();
            model.Writer = writer;
            model.Content = content;
            model.CreateTime = datetime;
            B1993.BLL.log bll = new B1993.BLL.log();
            bll.Add(model);
            #endregion
        }
        #endregion

    }
}
