
using System.Linq;
using System.Text;

using System.Threading;

using NHapi.Model.V25.Datatype;
using NHapi.Model.V25.Message;
using NHapi.Model.V25.Group;
using NHapi.Model.V25.Segment;
//using transFormat.ParseMessage;

namespace transFormat
{
    using NHapi.Base.Model;
    using NHapi.Base.Parser;
    using System;
    using System.IO;
    using System.Collections.Generic;
    

    public class MThread
    {

        //新建线程时链接数据库 
        private Sqlite msqlite = new Sqlite(Global.dbpath);
        
        /// <summary>
        /// 新建线程，监控共享文件夹中 的文件
        /// </summary>
        public void Monitor()
        {
            //获取共享文件夹位置。
            getSharedPath();

            //确认共享文件夹
            checksharedfile();

            //每4秒扫描一次文件夹
            while (true)
            {
                var hl7Files = Directory.EnumerateFiles(Global.sharedpath, "*.hl7");
                foreach (var f in hl7Files)
                {
                    ProcessHL7Message(f.ToString());
                    //Directory.Delete(f,true);
                    File.Delete(f);
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
        private void ProcessHL7Message(string filePath)
        {
            try
            {   
                using (StreamReader sr = new StreamReader(@filePath))
                {
                    String hl7 = sr.ReadToEnd();
                    Console.WriteLine(hl7);
                    PipeParser parser = new PipeParser();
                    IMessage hl7Message;

                    hl7Message = parser.Parse(hl7);

                    if(hl7Message != null)
                    {
                        saveMessage(hl7Message, hl7);
                    }


                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("发生错误");
            }
        }

        ///<summary>
        ///将消息存储到数据库。
        /// </summary>
        private void saveMessage(IMessage hl7M,string hl7)
        {
            string ctrlid = null;
            string type = null;
            string time = null;
            string pid = null;
            string text = hl7;
            string name = null;
            string sex = null;

            string m_type = hl7M.GetStructureName();
            if(m_type.Equals("ORU_R01"))
            {
                var m_ORU_R01 = new ORU_R01();
                m_ORU_R01 = (ORU_R01)hl7M;

                //Table OMessage
                ctrlid = m_ORU_R01.MSH.MessageControlID.Value;
                type = m_type;
                time = m_ORU_R01.MSH.DateTimeOfMessage.Time.Value;
                pid = m_ORU_R01.GetPATIENT_RESULT().PATIENT.PID.GetPatientIdentifierList(0).IDNumber.Value;

                //Table PATIENT
                //pid
                name = m_ORU_R01.GetPATIENT_RESULT().PATIENT.PID.GetPatientName(0).GivenName.Value.ToString();
                Console.WriteLine(name);
                sex = m_ORU_R01.GetPATIENT_RESULT().PATIENT.PID.AdministrativeSex.Value;
            }

            string sql1 = "insert into OMessage(CTRLID,TYPE,TIME,PID,TEXT) values (@CTRLID,@TYPE,@TIME,@PID,@TEXT)";
            Dictionary<string, object> param1 = new Dictionary<string, object>();
            param1.Add("CTRLID", ctrlid);
            param1.Add("TYPE", type);
            param1.Add("TIME", time);
            param1.Add("PID", pid);
            param1.Add("TEXT", text);

            if(ctrlid != null)
            {
                msqlite.query(sql1, param1);
            }

            string sql2 = "insert into PATIENT(PID,NAME,SEX) values (@PID,@NAME,@SEX)";
            Dictionary<string, object> param2 = new Dictionary<string, object>();
            param2.Add("PID", pid);
            param2.Add("NAME", name);
            param2.Add("SEX", sex);
            
            if (ctrlid != null)
            {
                msqlite.query(sql2, param2);
            }
        }
        /// <summary>
        /// 检查共享文件夹
        /// </summary>
        private void checksharedfile()
        {
            if (!Directory.Exists(Global.RocheOrderPath))
            {
                Directory.CreateDirectory(Global.RocheOrderPath);
            }
            if (!Directory.Exists(Global.RocheResultPath))
            {
                Directory.CreateDirectory(Global.RocheResultPath);
            }
            if (!Directory.Exists(Global.RocheSeenPath))
            {
                Directory.CreateDirectory(Global.RocheSeenPath);
            }

            if (!Directory.Exists(Global.LISOrderPath))
            {
                Directory.CreateDirectory(Global.LISOrderPath);
            }
            if (!Directory.Exists(Global.LISResultPath))
            {
                Directory.CreateDirectory(Global.LISResultPath);
            }
            if (!Directory.Exists(Global.LISSeenPath))
            {
                Directory.CreateDirectory(Global.LISSeenPath);
            }
        }

        /// <summary>
        /// 从数据库同步共享文件夹路径
        /// </summary>
        private void getSharedPath()
        {
            string sql1 = "select PATH from SharedFile where NAME = 'Roche_Order'";
            string sql2 = "select PATH from SharedFile where NAME = 'Roche_Result'";
            string sql3 = "select PATH from SharedFile where NAME = 'Roche_Seen'";

            string sql4 = "select PATH from SharedFile where NAME = 'LIS_Order'";
            string sql5 = "select PATH from SharedFile where NAME = 'LIS_Result'";
            string sql6 = "select PATH from SharedFile where NAME = 'LIS_Seen'";

            Global.RocheOrderPath = msqlite.getOne(sql1, null).ToString();
            Global.RocheResultPath = msqlite.getOne(sql2, null).ToString();
            Global.RocheSeenPath = msqlite.getOne(sql3, null).ToString();

            Global.LISOrderPath = msqlite.getOne(sql4, null).ToString();
            Global.LISResultPath = msqlite.getOne(sql5, null).ToString();
            Global.LISSeenPath = msqlite.getOne(sql6, null).ToString();
        }
    }
}
