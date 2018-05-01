using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace transFormat
{
    class Global
    {
        public static string sharedpath = @"..\..\..\sharedfile";
        public static string dbpath = @"..\..\..\DB.sqlite";
        public static string rulepath= @"..\..\..\TransRules";

        //Roche
        public static string RocheOrderPath = @"C:\ShareFile\Roche\Order";
        public static string RocheResultPath = @"C:\ShareFile\Roche\Result";
        public static string RocheSeenPath = @"C:\ShareFile\Roche\Seen";
        //LIS
        public static string LISOrderPath = @"C:\ShareFile\LIS\Order";
        public static string LISResultPath = @"C:\ShareFile\LIS\Result";
        public static string LISSeenPath = @"C:\ShareFile\LIS\Seen";
    }
}
