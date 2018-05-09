using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace transFormat
{
    class Global
    {
        public Global()
        {
            this.ResultRule = new Rule();
            StreamReader sr = new StreamReader(Global.ORU_R01rulepath, Encoding.Default);
            String line;
            SingleRule msinglerule;
            while ((line = sr.ReadLine()) != null)
            {
                string[] rules = line.Split(',');
                msinglerule = new SingleRule();
                msinglerule.Name = rules[0];
                for(int i=1;i<rules.Count();i++)
                {
                    msinglerule.Numbers[i - 1] = float.Parse(rules[i]);
                }
                ResultRule.RuleGroup.Add(msinglerule);
            }

            foreach(SingleRule m in ResultRule.RuleGroup)
            {
                //Console.WriteLine(m.Name);
                foreach(float i in m.Numbers)
                {
                    Console.WriteLine(i.ToString());
                    if (i == 0) break;
                }
            }
        }

        public static Boolean TransFunctionEnable = false;

        public static string sharedpath = @"..\..\..\sharedfile";
        public static string dbpath = @"..\..\..\DB.sqlite"; 
        public static string rulepath = @"..\..\..\TransRules";
        public static string ORU_R01rulepath= @"..\..\..\TransRules\ORU_R01.txt";
        public static string OML_O21rulepath = @"..\..\..\TransRules\OML_O21.txt";
        public static string Seenrulepath = @"..\..\..\TransRules\Seen.txt";

        //Roche
        public static string RocheOrderPath = @"C:\ShareFile\Roche\Order";
        public static string RocheResultPath = @"C:\ShareFile\Roche\Result";
        public static string RocheSeenPath = @"C:\ShareFile\Roche\Seen";
        //LIS
        public static string LISOrderPath = @"C:\ShareFile\LIS\Order";
        public static string LISResultPath = @"C:\ShareFile\LIS\Result";
        public static string LISSeenPath = @"C:\ShareFile\LIS\Seen";

        public Rule ResultRule;
        public Rule OrderRule;
        public Rule SeenRule;
    }
}
