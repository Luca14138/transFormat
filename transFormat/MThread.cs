
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
                    ProcessRoche_Result();
                    ProcessRoche_Seen();
                   // ProcessLIS_Order();

                Thread.Sleep(3000);
            } 
        }
        
        ///<summary>
        ///监控Roche_Result中的文件,ORU_R01
        /// </summary>
        private void ProcessRoche_Result()
        {
            string tMessage = null;
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
                            if(hl7.Substring(0,2) == "\r\n")
                            {
                                hl7 = hl7.Remove(0,2);
                            }
                            if (hl7.Substring(0, 1) == "\v")
                            {
                                hl7 = hl7.Remove(0, 1);
                            }
                            IMessage hl7Message = ParesHL7String(hl7);
                            if(hl7Message.GetType() == typeof(NHapi.Model.V25.Message.ORU_R01))
                            {                                                              
                                //第一步转换消息
                                 tMessage = TransRoche_Result(hl7Message,"2.5");

                                //第二步保存消息
                                saveORU_R01(hl7Message, hl7, "2.5",tMessage);
                            }
                            else if(hl7Message.GetType() == typeof(NHapi.Model.V23.Message.ORU_R01))
                            {                               
                                //第一步转换消息
                                tMessage = TransRoche_Result(hl7Message, "2.3");

                                //第二步保存消息
                                saveORU_R01(hl7Message, hl7, "2.3",tMessage);
                            }                         
                        }
                        //第三步删除消息
                        File.Delete(f);

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
            string tMessage = null;
            var hl7Files = Directory.EnumerateFiles(Global.RocheSeenPath, "*.hl7");
            if (hl7Files.Count() != 0)
            {
                foreach (var f in hl7Files)
                {
                    try
                    {
                        using (StreamReader sr = new StreamReader(f.ToString()))
                        {
                            String hl7 = sr.ReadToEnd();
                            if (hl7.Substring(0, 2) == "\r\n")
                            {
                                hl7 = hl7.Remove(0, 2);
                            }
                            if (hl7.Substring(0, 1) == "\v")
                            {
                                hl7 = hl7.Remove(0, 1);
                            }
                            IMessage hl7Message = ParesHL7String(hl7);
                            Console.WriteLine(hl7Message.GetType());
                            if (hl7Message.GetType() == typeof(NHapi.Model.V24.Message.SSU_U03))
                            {
                                //第一步转换消息
                                tMessage = TransRoche_Seen(hl7Message);

                                //第二步保存消息                              
                                saveSSU_U03(hl7Message, hl7,tMessage);
                            }
                        }
                        //第三步删除消息
                        File.Delete(f);

                    }
                    catch (Exception err)
                    {
                        Console.WriteLine(err.Message);
                    }
                }
            }
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
        private string TransRoche_Result(IMessage HL7Message, string version)
        {       
            string tMessage = null;           
            bool exitLine = false;
            string path = null;
            switch (version)
            {
                case "2.5":
                    NHapi.Model.V25.Message.ORU_R01 mORU_R01_25 = (NHapi.Model.V25.Message.ORU_R01)HL7Message;
                    P_ORU_R01_25 pORU_R01_25 = new P_ORU_R01_25(mORU_R01_25);

                    foreach (SingleRule m in Global.ResultRule.RuleGroup)
                    {
                        switch (m.Name)
                        {
                            case "MSH":
                                if (exitLine == true)
                                {
                                    tMessage += "\r\n";
                                }
                                tMessage += pORU_R01_25.getMSH(m.Numbers);
                                exitLine = true;
                                break;
                            case "PID":
                                if (exitLine == true)
                                {
                                    tMessage += "\r\n";
                                }
                                tMessage += pORU_R01_25.getPID(m.Numbers);
                                exitLine = true;
                                break;
                            case "PV1":
                                if (exitLine == true)
                                {
                                    tMessage += "\r\n";
                                }
                                tMessage += pORU_R01_25.getPV1(m.Numbers);
                                exitLine = true;
                                break;
                            case "ORC":
                                if (exitLine == true)
                                {
                                    tMessage += "\r\n";
                                }
                                tMessage += pORU_R01_25.getORC(m.Numbers);
                                exitLine = true;
                                break;
                            case "OBR":
                                if (exitLine == true)
                                {
                                    tMessage += "\r\n";
                                }
                                tMessage += pORU_R01_25.getOBR(m.Numbers);
                                exitLine = true;
                                break;
                            case "OBX":
                                if (exitLine == true)
                                {
                                    tMessage += "\r\n";
                                }
                                tMessage += pORU_R01_25.getOBX(m.Numbers);
                                exitLine = true;
                                break;
                        }
                    }
                    path = Global.LISResultPath + "\\" + mORU_R01_25.MSH.MessageControlID.Value + ".txt";

                    break;
                case "2.3":
                    NHapi.Model.V23.Message.ORU_R01 mORU_R01_23 = (NHapi.Model.V23.Message.ORU_R01)HL7Message;
                    P_ORU_R01_23 pORU_R01_23 = new P_ORU_R01_23(mORU_R01_23);

                    foreach (SingleRule m in Global.ResultRule.RuleGroup)
                    {
                        switch (m.Name)
                        {
                            case "MSH":
                                if (exitLine == true)
                                {
                                    tMessage += "\r\n";
                                }
                                tMessage += pORU_R01_23.getMSH(m.Numbers);
                                exitLine = true;
                                break;
                            case "PID":
                                if (exitLine == true)
                                {
                                    tMessage += "\r\n";
                                }
                                tMessage += pORU_R01_23.getPID(m.Numbers);
                                exitLine = true;
                                break;
                            case "PV1":
                                if (exitLine == true)
                                {
                                    tMessage += "\r\n";
                                }
                                tMessage += pORU_R01_23.getPV1(m.Numbers);
                                exitLine = true;
                                break;
                            case "ORC":
                                if (exitLine == true)
                                {
                                    tMessage += "\r\n";
                                }
                                tMessage += pORU_R01_23.getORC(m.Numbers);
                                exitLine = true;
                                break;
                            case "OBR":
                                if (exitLine == true)
                                {
                                    tMessage += "\r\n";
                                }
                                tMessage += pORU_R01_23.getOBR(m.Numbers);
                                exitLine = true;
                                break;
                            case "OBX":
                                if (exitLine == true)
                                {
                                    tMessage += "\r\n";
                                }
                                tMessage += pORU_R01_23.getOBX(m.Numbers);
                                exitLine = true;
                                break;
                        }
                    }
                    path = Global.LISResultPath + "\\" + mORU_R01_23.MSH.MessageControlID.Value + ".txt";
                    break;
            }
            

           
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
            string tMessage = null;
            bool exitLine = false;

            NHapi.Model.V23.Message.ORM_O01 mORM_O01 = (NHapi.Model.V23.Message.ORM_O01)HL7Message;
            P_ORM_O01 pORM_O01 = new P_ORM_O01(mORM_O01);

            foreach (SingleRule m in Global.ResultRule.RuleGroup)
            {
                switch (m.Name)
                {
                    case "MSH":
                        if (exitLine == true)
                        {
                            tMessage += "\r\n";
                        }
                        tMessage += pORM_O01.getMSH( m.Numbers);
                        exitLine = true;
                        break;
                    case "PID":
                        if (exitLine == true)
                        {
                            tMessage += "\r\n";
                        }
                        tMessage += pORM_O01.getPID(m.Numbers);
                        exitLine = true;
                        break;
                    case "ORC":
                        if (exitLine == true)
                        {
                            tMessage += "\r\n";
                        }
                        tMessage += pORM_O01.getORC(m.Numbers);
                        exitLine = true;
                        break;
                    case "OBR":
                        if (exitLine == true)
                        {
                            tMessage += "\r\n";
                        }
                        tMessage += pORM_O01.getOBR(m.Numbers);
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

        /// <summary>
        /// 读取预设格式文件
        /// 将Roche_Result中的HL7文件转换为指定格式
        /// </summary>
        private string TransRoche_Seen(IMessage HL7Message)
        {
            string tMessage = null;
            bool exitLine = false;

            NHapi.Model.V24.Message.SSU_U03 mSSU_U03 = (NHapi.Model.V24.Message.SSU_U03)HL7Message;
            P_SSU_U03 pSSU_U03 = new P_SSU_U03(mSSU_U03);

            foreach (SingleRule m in Global.SeenRule.RuleGroup)
            {
                for(int i =0;i<m.Numbers.Count();i++)
                {
                    Console.WriteLine(m.Numbers[i]);
                }
                switch (m.Name)
                {
                    case "MSH":
                        if (exitLine == true)
                        {
                            tMessage += "\r\n";
                        }
                        tMessage += pSSU_U03.getMSH(m.Numbers);
                        exitLine = true;
                        break;
                    case "EQU":
                        if (exitLine == true)
                        {
                            tMessage += "\r\n";
                        }
                        tMessage += pSSU_U03.getEQU(m.Numbers);
                        exitLine = true;
                        break;
                    case "SAC":
                        if (exitLine == true)
                        {
                            tMessage += "\r\n";
                        }
                        tMessage += pSSU_U03.getSAC(m.Numbers);
                        exitLine = true;
                        break;                    
                }
            }

            string path = Global.LISSeenPath + "\\" + mSSU_U03.MSH.MessageControlID.Value + ".txt";
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
        ///保存Result
        /// </summary>
        private void saveORU_R01(IMessage hl7M, string hl7,string version,string tMessage)
        {
            string CtrID = null;
            string sampleID = null;//样本ID
            string mesDescription = null; //消息名称OrderRequest/SampleResult/SampleSeen
            string PID = null;//病人ID
            string PName = null; //病人姓名
            string text = null; //文本内容
            string SEX = null;

            string mString = null;

            switch (version)
            {
                case "2.5":
                    NHapi.Model.V25.Message.ORU_R01 mORU_R01_25 = (NHapi.Model.V25.Message.ORU_R01)hl7M;
                    P_ORU_R01_25 pORU_R01_25 = new P_ORU_R01_25(mORU_R01_25);
                    mString = pORU_R01_25.getMSHField(10);

                    CtrID = mString.Substring(mString.Length - 7);
                    sampleID = pORU_R01_25.getORCField(2);
                    mesDescription = "SampleResult";
                    PID = pORU_R01_25.getPIDField(3);  
                    text = hl7;

                    PName = pORU_R01_25.getPIDField(5);
                    SEX = pORU_R01_25.getPIDField(8);
                    break;
                case "2.3":
                    NHapi.Model.V23.Message.ORU_R01 mORU_R01_23 = (NHapi.Model.V23.Message.ORU_R01)hl7M;
                    P_ORU_R01_23 pORU_R01_23 = new P_ORU_R01_23(mORU_R01_23);
                    mString = pORU_R01_23.getMSHField(10);

                    CtrID = mString.Substring(mString.Length - 7);
                    sampleID = pORU_R01_23.getORCField(2);
                    mesDescription = "SampleResult";
                    PID = pORU_R01_23.getPIDField(3);
                    text = hl7;

                    PName = pORU_R01_23.getPIDField(5);
                    SEX = pORU_R01_23.getPIDField(8);
                    break;
            }
            

            saveOMessage(CtrID, sampleID, mesDescription, PID, text);
            savePATIENT(PID,PName,SEX);
            saveTMessage(CtrID, sampleID, mesDescription, PID, tMessage);
        }

        ///<summary>
        ///保存Seen
        /// </summary>
        private void saveSSU_U03(IMessage hl7M, string hl7,string tMessage)
        {
            string CtrID = null;
            string sampleID = null;//样本ID
            string mesDescription = null; //消息名称OrderRequest/SampleResult/SampleSeen
            string PID = "null";//病人ID
            string text = null; //文本内容

            NHapi.Model.V24.Message.SSU_U03 mSSU_U03 = (NHapi.Model.V24.Message.SSU_U03)hl7M;
            P_SSU_U03 pSSU_U03 = new P_SSU_U03(mSSU_U03);

            CtrID = pSSU_U03.getMSHField(10);
            sampleID = pSSU_U03.getSACField(4);
            mesDescription = "SampleSeen";
            PID = "0";
            text = hl7;

            saveOMessage(CtrID, sampleID, mesDescription, PID, text);
            saveTMessage(CtrID, sampleID, mesDescription, PID, tMessage);
        }

        ///<summary>
        ///保存OMessage表
        /// </summary>
        private void saveOMessage(string ctrid, string sampleid,string mesdescription,string pid,string text)
        {
            string sql = "insert into OMessage(CtrID,SampleID,MesDescription,PID,TEXT) values (@CtrID,@SampleID,@MesDescription,@PID,@TEXT)";
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("CtrID", ctrid);
            param.Add("SampleID", sampleid);
            param.Add("MesDescription", mesdescription);
            param.Add("PID", pid);
            param.Add("TEXT", text);

            if (ctrid != null)
            {
                msqlite.query(sql, param);
            }
        }

        ///<summary>
        ///保存Patient表
        /// </summary>
        private void savePATIENT(string PID, string NAME, string SEX)
        {
            string sql = "insert into Patient(PID,NAME,SEX) values (@PID,@NAME,@SEX)";
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("PID", PID);
            param.Add("NAME", NAME);
            param.Add("SEX", SEX);

            if (PID != null)
            {
                msqlite.query(sql, param);
            }
        }

        ///<summary>
        ///保存TMessage表
        /// </summary>
        private void saveTMessage(string ctrid, string sampleid, string mesdescription, string pid, string text)
        {
            string sql = "insert into TMessage(CtrID,SampleID,MesDescription,PID,TEXT) values (@CtrID,@SampleID,@MesDescription,@PID,@TEXT)";
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("CtrID", ctrid);
            param.Add("SampleID", sampleid);
            param.Add("MesDescription", mesdescription);
            param.Add("PID", pid);
            param.Add("TEXT", text);

            if (ctrid != null)
            {
                msqlite.query(sql, param);
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
                if(File.Exists(Global.ORM_O01rulepath))
                {
                    if(File.Exists(Global.SSU_U03rulepath))
                    {
                        Global.TransFunctionEnable = true;
                        return true;
                    }
                }
            }
            return false;               
        }
                                    
    }
}

