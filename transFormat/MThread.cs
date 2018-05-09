﻿
using System.Linq;
using System.Text;

using System.Threading;

using NHapi.Model.V25.Datatype;
using NHapi.Model.V23.Message;
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
        //实例化Global
        Global mGlobal = new Global();

        /// <summary>
        /// 新建线程，监控共享文件夹中 的文件
        /// </summary>
        public void Monitor()
        {
            //获取共享文件夹位置。
            getSharedPath();

            //确认共享文件夹
            checksharedfile();

            //确认转换规则文件
            checkTransRule();

            

            //每4秒扫描一次Roche_Result/Roche_Seen/LIS_Order文件夹
            while (true)
            {
                var hl7Files = Directory.EnumerateFiles(Global.RocheResultPath, "*.hl7");
                //if (hl7Files.Count() ==0) Console.WriteLine("No Files!!");
                foreach (var f in hl7Files)
                {
                    ProcessRoche_Result();
                    //ProcessRoche_Seen();
                   // ProcessLIS_Order();

                }
                //Thread.Sleep(3000);
                break;
            } 
        }
        
        ///<summary>
        ///监控Roche_Result中的文件,ORU_R01
        /// </summary>
        private void ProcessRoche_Result()
        {
            var hl7Files = Directory.EnumerateFiles(Global.RocheResultPath, "*.hl7");
            if (hl7Files.Count() != 0)
            {
                foreach (var f in hl7Files)
                {
                    try
                    {
                        using (StreamReader sr = new StreamReader(f.ToString()))
                        {
                            String hl7 = sr.ReadToEnd();
                            IMessage hl7Message = ParesHL7String(hl7);
                            if(hl7Message.GetType() == typeof(NHapi.Model.V25.Message.ORU_R01))
                            {
                                Console.WriteLine(hl7Message.GetType());
                                //第一步保存消息
                                //saveMessage(hl7Message, hl7);
                                //第二步转换消息
                                 TransRoche_Result(hl7Message);                               
                            }                           
                        }
                        //第三步删除消息
                        //File.Delete(f);

                    }
                    catch(Exception err)
                    {
                        Console.WriteLine(err.Message);
                    }
                }
            }
        }
        ///<summary>
        ///监控Roche_Seen中的文件
        /// </summary>
        private void ProcessRoche_Seen()
        {

        }

        ///<summary>
        ///监控LIS_Order中的文件
        /// </summary>
        private void ProcessLIS_Order()
        {
            var hl7Files = Directory.EnumerateFiles(Global.LISOrderPath, "*.hl7");
            if (hl7Files.Count() != 0)
            {
                foreach (var f in hl7Files)
                {
                    try
                    {
                        using (StreamReader sr = new StreamReader(f.ToString()))
                        {
                            String hl7 = sr.ReadToEnd();
                            IMessage hl7Message = ParesHL7String(hl7);
                            
                            if (hl7Message.GetType() == typeof(NHapi.Model.V23.Message.ORM_O01))
                            {
                                Console.WriteLine(hl7Message.GetType());
                                //第一步保存消息
                                //saveMessage(hl7Message, hl7);
                                //第二步转换消息
                                TransLIS_Order(hl7Message);
                            }
                        }
                        //第三步删除消息
                        //File.Delete(f);

                    }
                    catch (Exception err)
                    {
                        Console.WriteLine(err.Message);
                    }
                }
            }
        }

        /// <summary>
        /// 读取预设格式文件
        /// 将Roche_Result中的HL7文件转换为指定格式
        /// </summary>
        private string TransRoche_Result(IMessage HL7Message)
        {
            NHapi.Model.V25.Message.ORU_R01 mORU_R01 = (NHapi.Model.V25.Message.ORU_R01)HL7Message;
            string tMessage = null;           
            bool exitLine = false;
            foreach (SingleRule m in mGlobal.ResultRule.RuleGroup)
            {
                switch (m.Name)
                {
                    case "MSH":
                        if(exitLine == true)
                        {
                            tMessage += "\r\n";
                        }
                        tMessage += getMSH(mORU_R01,m.Numbers);
                        exitLine = true;                    
                        break;
                    case "PID":
                        if (exitLine == true)
                        {
                            tMessage += "\r\n";
                        }
                        tMessage += getPID(mORU_R01, m.Numbers);
                        exitLine = true;
                        break;
                    case "PV1":
                        if (exitLine == true)
                        {
                            tMessage += "\r\n";
                        }
                        tMessage += getPV1(mORU_R01, m.Numbers);
                        exitLine = true;
                        break;
                    case "ORC":
                        if (exitLine == true)
                        {
                            tMessage += "\r\n";
                        }
                        tMessage += getORC(mORU_R01, m.Numbers);
                        exitLine = true;
                        break;
                    case "OBR":
                        if (exitLine == true)
                        {
                            tMessage += "\r\n";
                        }
                        tMessage += getOBR(mORU_R01, m.Numbers);
                        exitLine = true;
                        break;
                    case "OBX":
                        if (exitLine == true)
                        {
                            tMessage += "\r\n";
                        }                        
                        tMessage += getOBX(mORU_R01, m.Numbers);
                        exitLine = true;
                        break;
                }
            }

            string path = Global.LISResultPath + "\\" + mORU_R01.MSH.MessageControlID.Value + ".txt";
            FileStream f = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter sw = new StreamWriter(f);
            sw.WriteLine(tMessage);
            sw.Flush();
            sw.Close();
            f.Close();
            return tMessage;
        }

        /// <summary>
        /// 读取预设格式文件
        /// 将LIS_Order中的HL7文件转换为指定格式
        /// </summary>
        private string TransLIS_Order(IMessage HL7Message)
        {
            NHapi.Model.V23.Message.ORM_O01 mORM_O01 = (NHapi.Model.V23.Message.ORM_O01)HL7Message;
            string tMessage = null;
            bool exitLine = false;
            foreach (SingleRule m in mGlobal.ResultRule.RuleGroup)
            {
                switch (m.Name)
                {
                    case "MSH":
                        if (exitLine == true)
                        {
                            tMessage += "\r\n";
                        }
                        tMessage += getMSH(mORM_O01, m.Numbers);
                        exitLine = true;
                        break;
                    case "PID":
                        if (exitLine == true)
                        {
                            tMessage += "\r\n";
                        }
                        tMessage += getPID(mORM_O01, m.Numbers);
                        exitLine = true;
                        break;
                    case "PV1":
                        if (exitLine == true)
                        {
                            tMessage += "\r\n";
                        }
                        tMessage += getPV1(mORM_O01, m.Numbers);
                        exitLine = true;
                        break;
                    case "ORC":
                        if (exitLine == true)
                        {
                            tMessage += "\r\n";
                        }
                        tMessage += getORC(mORM_O01, m.Numbers);
                        exitLine = true;
                        break;
                    case "OBR":
                        if (exitLine == true)
                        {
                            tMessage += "\r\n";
                        }
                        tMessage += getOBR(mORM_O01, m.Numbers);
                        exitLine = true;
                        break;
                    case "OBX":
                        if (exitLine == true)
                        {
                            tMessage += "\r\n";
                        }
                        tMessage += getOBX(mORM_O01, m.Numbers);
                        exitLine = true;
                        break;
                }
            }

            string path = Global.LISResultPath + "\\" + mORM_O01.MSH.MessageControlID.Value + ".txt";
            FileStream f = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter sw = new StreamWriter(f);
            sw.WriteLine(tMessage);
            sw.Flush();
            sw.Close();
            f.Close();
            return tMessage;
        }

        ///<summary>
        ///解析HL7String返回IMessage
        /// </summary>
        private IMessage ParesHL7String(string hl7string)
        {
            PipeParser parser = new PipeParser();
            IMessage hl7Message;
            hl7Message = parser.Parse(hl7string);

            return hl7Message;
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
                var m_ORU_R01 = new NHapi.Model.V25.Message.ORU_R01();
                m_ORU_R01 = (NHapi.Model.V25.Message.ORU_R01)hl7M;

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

        ///<summary>
        ///检查转换规则文件夹
        /// </summary>
        private bool checkTransRule()
        {
            //var transrules = Directory.EnumerateFiles(Global.rulepath, "*.txt");
            if (File.Exists(Global.ORU_R01rulepath))
            {
                if(File.Exists(Global.OML_O21rulepath))
                {
                    if(File.Exists(Global.Seenrulepath))
                    {
                        Global.TransFunctionEnable = true;
                        return true;
                    }
                }
            }
            return false;               
        }

        ///<summary>
        ///获取MSH中的字段，返回保存结果的string
        /// </summary>
        private string getMSH(NHapi.Model.V25.Message.ORU_R01 mORU_R01,float[] rule)
        {
            int seq = 0;
            string m = null;
            string field = null;
            P_ORU_R01 pORU_R01 = new P_ORU_R01(mORU_R01);
            for (int i=0;rule[i] != 0;i++)
            {
                if(rule[i]%1 == 0)
                {
                    seq = (int)rule[i];
                    if(i!=0)
                    {
                        m += ",";
                    }
                    field = pORU_R01.getMSHField(seq);
                    if (field != null)
                    {
                        m += field;
                    }
                    else
                    {
                        m += "null";
                    }                    
                }
            }
            return m;
        }

        ///<summary>
        ///获取PID中的字段，返回保存结果的string
        /// </summary>
        private string getPID(NHapi.Model.V25.Message.ORU_R01 mORU_R01, float[] rule)
        {
            int seq = 0;
            string m = null;
            string field = null;
            P_ORU_R01 pORU_R01 = new P_ORU_R01(mORU_R01);
            for (int i = 0; rule[i] != 0; i++)
            {
                if (rule[i] % 1 == 0)
                {
                    seq = (int)rule[i];
                    if (i != 0)
                    {
                        m += ",";
                    }
                    field = pORU_R01.getPIDField(seq);
                    if (field != null)
                    {
                        m += field;
                    }
                    else
                    {
                        m += "null";
                    }
                }
            }

            return m;
        }

        ///<summary>
        ///获取PV1中的字段，返回保存结果的string
        /// </summary>
        private string getPV1(NHapi.Model.V25.Message.ORU_R01 mORU_R01, float[] rule)
        {
            int seq = 0;
            string m = null;
            string field = null;
            P_ORU_R01 pORU_R01 = new P_ORU_R01(mORU_R01);
            for (int i = 0; rule[i] != 0; i++)
            {
                if (rule[i] % 1 == 0)
                {
                    seq = (int)rule[i];
                    if (i != 0)
                    {
                        m += ",";
                    }
                    field = pORU_R01.getPV1Field(seq);
                    if (field != null)
                    {
                        m += field;
                    }
                    else
                    {
                        m += "null";
                    }
                }
            }
            return m;
        }

        ///<summary>
        ///获取ORC中的字段，返回保存结果的string
        /// </summary>
        private string getORC(NHapi.Model.V25.Message.ORU_R01 mORU_R01, float[] rule)
        {
            int seq = 0;
            string m = null;
            string field = null;
            P_ORU_R01 pORU_R01 = new P_ORU_R01(mORU_R01);
            for (int i = 0; rule[i] != 0; i++)
            {
                if (rule[i] % 1 == 0)
                {
                    seq = (int)rule[i];
                    if (i != 0)
                    {
                        m += ",";
                    }
                    field = pORU_R01.getORCField(seq);
                    if (field != null)
                    {
                        m += field;
                    }
                    else
                    {
                        m += "null";
                    }
                }
            }
            return m;
        }

        ///<summary>
        ///获取OBR中的字段，返回保存结果的string
        /// </summary>
        private string getOBR(NHapi.Model.V25.Message.ORU_R01 mORU_R01, float[] rule)
        {
            int seq = 0;
            string m = null;
            string field = null;
            P_ORU_R01 pORU_R01 = new P_ORU_R01(mORU_R01);
            for (int i = 0; rule[i] != 0; i++)
            {
                if (rule[i] % 1 == 0)
                {
                    seq = (int)rule[i];
                    if (i != 0)
                    {
                        m += ",";
                    }
                    field = pORU_R01.getOBRField(seq);
                    if (field != null)
                    {
                        m += field;
                    }
                    else
                    {
                        m += "null";
                    }
                }
            }
            return m;
        }

        ///<summary>
        ///获取OBX中的字段，返回保存结果的string
        /// </summary>
        private string getOBX(NHapi.Model.V25.Message.ORU_R01 mORU_R01, float[] rule)
        {
            int seq = 0;
            string m = null;
            string field = null;
            int resultNumber = 0;
            resultNumber = mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().OBSERVATIONRepetitionsUsed;

            P_ORU_R01 pORU_R01 = new P_ORU_R01(mORU_R01);
            for (int j=0;j<resultNumber;j++)
            {
                if(j!=0)
                {
                    m += "\r\n";
                }
                for (int i = 0; rule[i] != 0; i++)
                {
                    if (rule[i] % 1 == 0)
                    {
                        seq = (int)rule[i];
                        if (i != 0)
                        {
                            m += ",";
                        }
                        field = pORU_R01.getOBXField(j, seq);
                        if (field != null)
                        {
                            m += field;
                        }
                        else
                        {
                            m += "null";
                        }
                    }
                }
            }         
            return m;
        }
    }
}

