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


namespace MTHread
{
    public class MThread
    {
        //private string sharedpath = @"C:\Users\Luca\Documents\sharedfile";
        private string sharedpath = @"..\..\..\sharedfile";

        /// <summary>
        /// 新建线程，监控共享文件夹中 的文件
        /// </summary>
        public void Monitor()
        {
            //确认共享文件夹
            if (!Directory.Exists(sharedpath))
            {
                Directory.CreateDirectory(sharedpath);
            }

            //新建线程时链接数据库
            //Sqlite msqlite = new Sqlite(@"C:\Users\Luca\Documents\DB.sqlite");
            
            Sqlite msqlite = new Sqlite(@"..\..\..\DB.sqlite");
            //每4秒扫描一次文件夹
            while (true)
            {
                var hl7Files = Directory.EnumerateFiles(sharedpath, "*.hl7");
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
                    // Read the stream to a string, and write the string to the console.
                    String hl7text = sr.ReadToEnd();
                    Console.WriteLine(hl7text); 

                    PipeParser parser = new PipeParser();
                    IMessage hl7Message = null;
                    hl7Message = parser.Parse(hl7text);
                    ORU_R01 m = hl7Message as ORU_R01;
                    ORU_R01_PATIENT patient = m.GetPATIENT_RESULT().PATIENT;
                    PID pid = patient.PID;
                    string PatientId = pid.GetPatientIdentifierList(0).IDNumber.ToString();
                    Console.WriteLine(PatientId);
                }
            }
            catch (Exception e)
            {
                //Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
