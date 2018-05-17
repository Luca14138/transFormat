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
            iniResultRule();
            iniOrderRule();
            iniSeenRule();
        }

        public static Boolean TransFunctionEnable = false;

        public static string sharedpath = @"..\..\..\sharedfile";
        public static string dbpath = @"..\..\..\DB.sqlite"; 
        public static string rulepath = @"..\..\..\TransRules";
        public static string rulebackpath = @"..\..\..\TransRules\back";
        public static string ORU_R01rulepath= @"..\..\..\TransRules\ORU_R01.txt";
        public static string ORM_O01rulepath = @"..\..\..\TransRules\ORM_O01.txt";
        public static string SSU_U03rulepath = @"..\..\..\TransRules\SSU_U03.txt";

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

        /// <summary>
        /// 初始化ResultRule
        /// </summary>
        private void iniResultRule()
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
                for (int i = 1; i < rules.Count(); i++)
                {
                    msinglerule.Numbers[i - 1] = float.Parse(rules[i]);
                }
                ResultRule.RuleGroup.Add(msinglerule);
            }
        }

        /// <summary>
        /// 初始化OrderRule
        /// </summary>
        private void iniOrderRule()
        {
            this.OrderRule = new Rule();
            StreamReader sr = new StreamReader(Global.ORM_O01rulepath, Encoding.Default);
            String line;
            SingleRule msinglerule;
            while ((line = sr.ReadLine()) != null)
            {
                string[] rules = line.Split(',');
                msinglerule = new SingleRule();
                msinglerule.Name = rules[0];
                for (int i = 1; i < rules.Count(); i++)
                {
                    msinglerule.Numbers[i - 1] = float.Parse(rules[i]);
                }
                OrderRule.RuleGroup.Add(msinglerule);
            }

            foreach (SingleRule m in OrderRule.RuleGroup)
            {
                //Console.WriteLine(m.Name);
                foreach (float i in m.Numbers)
                {
                    if (i == 0) break;
                    Console.WriteLine(i.ToString());                    
                }
            }
        }

        /// <summary>
        /// 初始化SeenRule
        /// </summary>
        private void iniSeenRule()
        {
            this.SeenRule = new Rule();
            StreamReader sr = new StreamReader(Global.SSU_U03rulepath, Encoding.Default);
            String line;
            SingleRule msinglerule;
            while ((line = sr.ReadLine()) != null)
            {
                string[] rules = line.Split(',');
                msinglerule = new SingleRule();
                msinglerule.Name = rules[0];
                for (int i = 1; i < rules.Count(); i++)
                {
                    msinglerule.Numbers[i - 1] = float.Parse(rules[i]);
                }
                SeenRule.RuleGroup.Add(msinglerule);
            }

            foreach (SingleRule m in SeenRule.RuleGroup)
            {
                Console.WriteLine(m.Name);
                for (int i = 0; m.Numbers[i]!=0; i++)
                {
                    Console.WriteLine(m.Numbers[i]);
                }
            }
        }
    }
}
