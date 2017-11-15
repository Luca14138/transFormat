using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using sqlite;
using System.Threading;

namespace MTHread
{
    public class MThread
    {
        private string sharedpath = @"C:\Users\Luca\Documents\sharedfile";

        /// <summary>
        /// 新建线程，监控共享文件夹中的文件
        /// </summary>
        public void Monitor()
        {
            if (!Directory.Exists(sharedpath))
            {
                Directory.CreateDirectory(sharedpath);
            }
            while (true)
            {
                var hl7Files = Directory.EnumerateFiles(sharedpath, "*.hl7");
                foreach (var f in hl7Files)
                {
                    transfom(f.ToString());
                    //Console.WriteLine("{0}", f);
                    Sqlite msqlite = new Sqlite(@"C: \Users\Luca\Documents\DB.sqlite");

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
                    //Console.WriteLine(line);   
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
