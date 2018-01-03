using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NHapi.Model.V25.Datatype;
using NHapi.Model.V25.Message;
using NHapi.Model.V25.Group;
using NHapi.Model.V25.Segment;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;

namespace transFormat.ParseMessage
{
    class P_ORU_R01
    {
        private string ORU_R01_Message;

        /// <summary>
        /// 构造函数
        /// </summary>
        public P_ORU_R01(string hl7Message)
        {
            this.ORU_R01_Message = hl7Message;
        }

        /// <summary>
        /// 解析ORU_R01的所有字段
        /// </summary>
        public void ParseORU_R01()
        {
            var parse = new PipeParser();
            var mORU_R01 = new ORU_R01();
            mORU_R01 = (ORU_R01)parse.Parse(ORU_R01_Message);
            parseMSH(mORU_R01);//解析MSH字段
            Console.WriteLine("\n");
            parsePID(mORU_R01);//解析PID字段
            parsePV1(mORU_R01);//解析PV1字段
        }

        ///<summary>
        ///解析MSH字段
        /// </summary>
        private void parseMSH(ORU_R01 mORU_R01)
        {
            ///<li>MSH-1: Field Separator (ST)</li>
            ///<li>MSH-2: Encoding Characters (ST)</li>
            ///<li>MSH-3: Sending Application (HD)</li>
            ///<li>MSH-4: Sending Facility (HD)</li>
            ///<li>MSH-5: Receiving Application (HD)</li>
            ///<li>MSH-6: Receiving Facility (HD)</li>
            ///<li>MSH-7: Date/Time Of Message (TS)</li>
            ///<li>MSH-8: Security (ST)</li>
            ///<li>MSH-9: Message Type (MSG)</li>
            ///<li>MSH-10: Message Control ID (ST)</li>
            ///<li>MSH-11: Processing ID (PT)</li>
            ///<li>MSH-12: Version ID (VID)</li>
            ///<li>MSH-13: Sequence Number (NM)</li>
            ///<li>MSH-14: Continuation Pointer (ST)</li>
            ///<li>MSH-15: Accept Acknowledgment Type (ID)</li>
            ///<li>MSH-16: Application Acknowledgment Type (ID)</li>
            ///17之后的字段罗氏没有用到？
            
            //MSH-1
            Console.WriteLine("MSH-1\t" + mORU_R01.MSH.FieldSeparator.ToString());
            //MSH-2
            Console.WriteLine("MSH-2\t" + mORU_R01.MSH.EncodingCharacters.ToString());
            //MSH-3
            Console.WriteLine("MSH-3\t" + mORU_R01.MSH.SendingApplication.NamespaceID);
            //MSH-4
            Console.WriteLine("MSH-4\t" + mORU_R01.MSH.SendingFacility.NamespaceID);
            //MSH-5
            Console.WriteLine("MSH-5\t" + mORU_R01.MSH.ReceivingApplication.NamespaceID);
            //MSH-6
            Console.WriteLine("MSH-6\t" + mORU_R01.MSH.ReceivingFacility.NamespaceID);
            //MSH-7
            Console.WriteLine("MSH-7\t" + mORU_R01.MSH.DateTimeOfMessage.Time);
            //MSH-8
            Console.WriteLine("MSH-8\t" + mORU_R01.MSH.Security.Value);
            //MSH-9
            Console.WriteLine("MSH-9\t" + mORU_R01.MSH.MessageType.MessageStructure);
            //MSH-10
            Console.WriteLine("MSH-10\t" + mORU_R01.MSH.MessageControlID.Value);
            //MSH-11
            Console.WriteLine("MSH-11\t" + mORU_R01.MSH.ProcessingID.ProcessingID);
            //MSH-12
            Console.WriteLine("MSH-12\t" + mORU_R01.MSH.VersionID.VersionID);
            //MSH-13
            Console.WriteLine("MSH-13\t" + mORU_R01.MSH.SequenceNumber.Value);
            //MSH-14
            Console.WriteLine("MSH-14\t" + mORU_R01.MSH.ContinuationPointer.Value);
            //MSH-15
            Console.WriteLine("MSH-15\t" + mORU_R01.MSH.AcceptAcknowledgmentType.Value);
            //MSH-16
            Console.WriteLine("MSH-16\t" + mORU_R01.MSH.ApplicationAcknowledgmentType.Value);
            
        }

        ///<summary>
        ///解析PID字段
        /// </summary>
        private void parsePID(ORU_R01 mORU_R01)
        {
            ///PID Segment 只用了8个字段
            ///<li>PID-1: Set ID - PID (SI)</li>
            ///<li>PID-2: Patient ID (CX)</li>
            ///<li>PID-3: Patient Identifier List (CX)</li>
            ///<li>PID-4: Alternate Patient ID - PID (CX)</li>
            ///<li>PID-5: Patient Name (XPN)</li>
            ///<li>PID-6: Mother's Maiden Name (XPN)</li>
            ///<li>PID-7: Date/Time of Birth (TS)</li>
            ///<li>PID-8: Administrative Sex (IS)</li>
            //PID-1
            Console.WriteLine("PID-1\t" + mORU_R01.GetPATIENT_RESULT().PATIENT.PID.SetIDPID);
            //PID-2
            Console.WriteLine("PID-2\t" + mORU_R01.GetPATIENT_RESULT().PATIENT.PID.PatientID.IDNumber);
            //PID-3
            Console.WriteLine("PID-3\t" + mORU_R01.GetPATIENT_RESULT().PATIENT.PID.GetPatientIdentifierList(0).IDNumber);
            //PID-4
            Console.WriteLine("PID-4\t" + mORU_R01.GetPATIENT_RESULT().PATIENT.PID.GetAlternatePatientIDPID(0).IDNumber);
            //PID-5 名字，中文显示乱码
            Console.WriteLine("PID-5\t" + mORU_R01.GetPATIENT_RESULT().PATIENT.PID.GetPatientName(0).GivenName.Value.ToString());
            //PID-6
            Console.WriteLine("PID-6\t" + mORU_R01.GetPATIENT_RESULT().PATIENT.PID.GetMotherSMaidenName(0).GivenName.Value );
            //PID-7
            Console.WriteLine("PID-7\t" + mORU_R01.GetPATIENT_RESULT().PATIENT.PID.DateTimeOfBirth.Time);
            //PID-8
            Console.WriteLine("PID-8\t" + mORU_R01.GetPATIENT_RESULT().PATIENT.PID.AdministrativeSex.Value);
        }

        ///<summary>
        ///解析PV1字段
        /// </summary>
        private void parsePV1(ORU_R01 mORU_R01)
        {
            //PV1-1
            Console.WriteLine("PV1-1\t" + mORU_R01.GetStructure("PV1"));
            

        }
    }
}
