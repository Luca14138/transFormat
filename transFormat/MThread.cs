using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using sqlite;
using System.Threading;

using NHapi.Base.Parser;
using NHapi.Model.V25.Datatype;
using NHapi.Model.V25.Message;
using NHapi.Model.V25.Group;
using NHapi.Model.V25.Segment;
using NHapi.Base.Model;
using Global;
using transFormat.ParseMessage;

namespace MTHread
{
    public class MThread
    {

        //新建线程时链接数据库 
        private Sqlite msqlite = new Sqlite(Global.Global.dbpath);

        /// <summary>
        /// 新建线程，监控共享文件夹中 的文件
        /// </summary>
        public void Monitor()
        {
            //确认共享文件夹
            if (!Directory.Exists(Global.Global.sharedpath))
            {
                Directory.CreateDirectory(Global.Global.sharedpath);
            }

            //每4秒扫描一次文件夹
            while (true)
            {
                var hl7Files = Directory.EnumerateFiles(Global.Global.sharedpath, "*.hl7");
                foreach (var f in hl7Files)
                {
                    transfom(f.ToString());
                    //Console.WriteLine("{0}", f);       
                }
                //Thread.Sleep(4000);
                break;
            } 
        }
        
        /// <summary>
        /// 将HL7文件转换为指定格式
        /// 并输出到目标文件中
        /// 保存HL7消息到数据库中，删除源文件 
        /// </summary>
        private void transfom(string filePath)
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(@filePath))
                {
                    //读取文件
                    String hl7text = sr.ReadToEnd();
                    Console.WriteLine(hl7text);


                    /* IMessage hl7Message = null;
                     hl7Message = parser.Parse(hl7text);
                     ORU_R01 m = hl7Message as ORU_R01;*/
                    var parser = new PipeParser();
                    var m = new ORU_R01();
                    m = (ORU_R01)parser.Parse(hl7text);
                    saveMessage(m.MSH.MessageControlID.ToString(), hl7text, 0);

                    var msgtype = new MSG(null);
                    msgtype = m.MSH.MessageType;
                    Console.WriteLine(msgtype.MessageStructure);

                    //Console.WriteLine(m.MSH.MessageType); 

                    Console.WriteLine(m.MSH.MessageControlID.ToString());

                    /* ORU_R01_PATIENT patient = m.GetPATIENT_RESULT().PATIENT;
                     PID pid = patient.PID;
                     string PatientId = pid.GetPatientIdentifierList(0).IDNumber.ToString();
                     Console.WriteLine(PatientId);*/

                    var p = new P_ORU_R01(hl7text);
                    p.ParseORU_R01();
                }
            }
            catch (Exception e)
            {
                //Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        ///<summary>
        ///将消息存储到数据库。
        ///type:0:原消息；1：转换后的消息。
        /// </summary>
        private void saveMessage(string controlID,string message, int type)
        {
            string sql = "insert into OMessage(ControlID,value) values (@controlid,@value)";
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("controlid", controlID);
            param.Add("value", message);

            msqlite.query(sql,param);
        }
    }
}
