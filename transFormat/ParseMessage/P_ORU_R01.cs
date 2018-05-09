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

namespace transFormat
{
    class P_ORU_R01
    {
        private ORU_R01 mORU_R01;

        /// <summary>
        /// 构造函数
        /// </summary>
        public P_ORU_R01(ORU_R01 m)
        {
            this.mORU_R01 = m;
        }

        /// <summary>
        /// 解析ORU_R01的所有字段
        /// </summary>
        public void ParseORU_R01()
        {
            parseMSH(mORU_R01);//解析MSH字段
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

        /// <summary>
        /// 获取MSH的每个Field
        /// </summary>
        /// <param name="number"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public string getMSHField(int number,int second=0)
        {
            switch (number)
            {
                case 1:
                    return mORU_R01.MSH.FieldSeparator.ToString();
                    
                case 2:
                    return mORU_R01.MSH.EncodingCharacters.ToString();
                    
                case 3:
                    return mORU_R01.MSH.SendingApplication.NamespaceID.Value;
                    
                case 4:
                    return mORU_R01.MSH.SendingFacility.NamespaceID.Value;
                    
                case 5:
                    return mORU_R01.MSH.ReceivingApplication.NamespaceID.Value;
                    
                case 6:
                    return mORU_R01.MSH.ReceivingFacility.NamespaceID.Value;
                    
                case 7:
                    return mORU_R01.MSH.DateTimeOfMessage.Time.Value;
                    
                case 8:
                    return mORU_R01.MSH.Security.Value;
                    
                case 9:
                    return mORU_R01.MSH.MessageType.MessageStructure.Value;
                    
                case 10:
                    return mORU_R01.MSH.MessageControlID.Value;
                    
                case 11:
                    return mORU_R01.MSH.ProcessingID.ProcessingID.Value;
                    
                case 12:
                    return mORU_R01.MSH.VersionID.VersionID.Value;
                    
                case 13:
                    return mORU_R01.MSH.SequenceNumber.Value;
                    
                case 14:
                    return mORU_R01.MSH.ContinuationPointer.Value;
                    
                case 15:
                    return mORU_R01.MSH.AcceptAcknowledgmentType.Value;
                    
                case 16:
                    return mORU_R01.MSH.ApplicationAcknowledgmentType.Value;
                    
                default:
                    return null;
            }            
        }

        /// <summary>
        /// 获取PID段的每个Field
        /// </summary>
        /// <param name="number"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public string getPIDField(int number, int second = 0)
        {
            switch (number)
            {
                case 1:
                    return mORU_R01.GetPATIENT_RESULT().PATIENT.PID.SetIDPID.Value;
                    
                case 2:
                    return mORU_R01.GetPATIENT_RESULT().PATIENT.PID.PatientID.IDNumber.Value;
                    
                case 3:
                    return mORU_R01.GetPATIENT_RESULT().PATIENT.PID.GetPatientIdentifierList(0).IDNumber.Value;
                    
                case 4:
                    return mORU_R01.GetPATIENT_RESULT().PATIENT.PID.GetAlternatePatientIDPID(0).IDNumber.Value;
                    
                case 5:
                    return mORU_R01.GetPATIENT_RESULT().PATIENT.PID.GetPatientName(0).GivenName.Value.ToString();
                    
                case 6:
                    return mORU_R01.GetPATIENT_RESULT().PATIENT.PID.GetMotherSMaidenName(0).GivenName.Value;
                    
                case 7:
                    return mORU_R01.GetPATIENT_RESULT().PATIENT.PID.DateTimeOfBirth.Time.Value;
                    
                case 8:
                    return mORU_R01.GetPATIENT_RESULT().PATIENT.PID.AdministrativeSex.Value;
                    
                default:
                    return null;
            }
        }

        /// <summary>
        /// 获取PV1的每一个Field
        /// </summary>
        /// <param name="number"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public string getPV1Field(int number, int second = 0)
        {
            switch (number)
            {
                case 1:
                    return mORU_R01.GetPATIENT_RESULT().PATIENT.VISIT.PV1.SetIDPV1.Value;
                    
                case 2:
                    return mORU_R01.GetPATIENT_RESULT().PATIENT.VISIT.PV1.PatientClass.Value;
                    
                case 3:
                    return mORU_R01.GetPATIENT_RESULT().PATIENT.VISIT.PV1.AssignedPatientLocation.LocationDescription.Value;
                    
                case 4:
                    return mORU_R01.GetPATIENT_RESULT().PATIENT.VISIT.PV1.AdmissionType.Value;
                    
                case 5:
                    return mORU_R01.GetPATIENT_RESULT().PATIENT.VISIT.PV1.PreadmitNumber.IDNumber.Value;
                    
                case 6:
                    return mORU_R01.GetPATIENT_RESULT().PATIENT.VISIT.PV1.PriorPatientLocation.LocationDescription.Value;
                    
                case 7:
                    return mORU_R01.GetPATIENT_RESULT().PATIENT.VISIT.PV1.GetAttendingDoctor(0).GivenName.Value;
                    
                case 8:
                    return mORU_R01.GetPATIENT_RESULT().PATIENT.VISIT.PV1.GetReferringDoctor(0).GivenName.Value;
                    
                case 9:
                    return mORU_R01.GetPATIENT_RESULT().PATIENT.VISIT.PV1.GetConsultingDoctor(0).GivenName.Value;
                    
                case 10:
                    return mORU_R01.GetPATIENT_RESULT().PATIENT.VISIT.PV1.HospitalService.Value;
                    
                case 11:
                    return mORU_R01.GetPATIENT_RESULT().PATIENT.VISIT.PV1.TemporaryLocation.LocationDescription.Value;
                    
                case 12:
                    return mORU_R01.GetPATIENT_RESULT().PATIENT.VISIT.PV1.PreadmitTestIndicator.Value;
                    
                case 13:
                    return mORU_R01.GetPATIENT_RESULT().PATIENT.VISIT.PV1.ReAdmissionIndicator.Value;
                    
                case 14:
                    return mORU_R01.GetPATIENT_RESULT().PATIENT.VISIT.PV1.AdmitSource.Value;
                    
                case 15:
                    return mORU_R01.GetPATIENT_RESULT().PATIENT.VISIT.PV1.GetAmbulatoryStatus(0).Value;
                    
                case 16:
                    return mORU_R01.GetPATIENT_RESULT().PATIENT.VISIT.PV1.VIPIndicator.Value;
                    
                case 17:
                    return mORU_R01.GetPATIENT_RESULT().PATIENT.VISIT.PV1.GetAdmittingDoctor(0).GivenName.Value;
                    
                case 18:
                    return mORU_R01.GetPATIENT_RESULT().PATIENT.VISIT.PV1.PatientType.Value;
                    
                case 19:
                    return mORU_R01.GetPATIENT_RESULT().PATIENT.VISIT.PV1.VisitNumber.AssigningAuthority.NamespaceID.Value;
                                    
                default:
                    return null;
            }
        }

        /// <summary>
        /// 获取PV1的每一个Field
        /// </summary>
        /// <param name="number"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public string getORCField(int number, int second = 0)
        {
            switch (number)
            {
                case 1:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().ORC.OrderControl.Value;
                    
                case 2:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().ORC.PlacerOrderNumber.EntityIdentifier.Value;
                    
                case 3:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().ORC.FillerOrderNumber.EntityIdentifier.Value;
                    
                case 4:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().ORC.PlacerGroupNumber.EntityIdentifier.Value;
                    
                case 5:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().ORC.OrderStatus.Value;
                    
                case 6:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().ORC.ResponseFlag.Value;
                    
                case 7:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().ORC.GetQuantityTiming(0).Text.Value;
                    
                case 8:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().ORC.Parent.FillerAssignedIdentifier.EntityIdentifier.Value;
                    
                case 9:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().ORC.DateTimeOfTransaction.Time.Value;
                                    
                default:
                    return null;
            }
        }

        /// <summary>
        /// 获取PV1的每一个Field
        /// </summary>
        /// <param name="number"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public string getOBRField(int number, int second = 0)
        {
            switch (number)
            {
                case 1:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().OBR.SetIDOBR.Value;
                    
                case 2:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().OBR.PlacerOrderNumber.EntityIdentifier.Value;
                    
                case 3:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().OBR.FillerOrderNumber.EntityIdentifier.Value;
                    
                case 4:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().OBR.UniversalServiceIdentifier.Text.Value;
                    
                case 5:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().OBR.PriorityOBR.Value;
                    
                case 6:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().OBR.RequestedDateTime.Time.Value;
                    
                case 7:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().OBR.ObservationDateTime.Time.Value + "/" + mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().OBR.ObservationDateTime.DegreeOfPrecision.Value;
                    
                case 8:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().OBR.ObservationEndDateTime.Time.Value;
                    
                case 9:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().OBR.CollectionVolume.Quantity.Value;
                    
                case 10:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().OBR.GetCollectorIdentifier(0).GivenName.Value;
                    
                case 11:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().OBR.SpecimenActionCode.Value;
                    
                case 12:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().OBR.DangerCode.Text.Value;
                    
                case 13:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().OBR.RelevantClinicalInformation.Value;
                    
                case 14:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().OBR.SpecimenReceivedDateTime.Time.Value;
                    
                case 15:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().OBR.SpecimenSource.SpecimenSourceNameOrCode.Text.Value;
                    
                case 16:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().OBR.GetOrderingProvider(0).GivenName.Value;
                    
                case 17:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().OBR.GetOrderCallbackPhoneNumber(0).TelephoneNumber.Value;
                    
                case 18:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().OBR.PlacerField1.Value;
                    
                case 19:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().OBR.PlacerField2.Value;
                    
                case 20:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().OBR.FillerField1.Value;
                    
                case 21:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().OBR.FillerField2.Value;
                    
                case 22:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().OBR.ResultsRptStatusChngDateTime.Time.Value;
                    
                case 23:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().OBR.ChargeToPractice.ChargeCode.Text.Value;
                    
                case 24:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().OBR.DiagnosticServSectID.Value;
                    
                case 25:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().OBR.ResultStatus.Value;
                    

                default:
                    return null;
            }
        }

        /// <summary>
        /// 获取OBX的每一个Field
        /// </summary>
        /// <param name="number"></param>
        /// <param name="second"></param>
        /// <param name="i">第几个结果</param>
        /// <returns></returns>
        public string getOBXField(int i,int number, int second = 0)
        {
            Console.WriteLine(mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().OBSERVATIONRepetitionsUsed);
            switch (number)
            {
                case 1:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().GetOBSERVATION(i).OBX.SetIDOBX.Value;
                    
                case 2:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().GetOBSERVATION(i).OBX.ValueType.Value;
                    
                case 3:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().GetOBSERVATION(i).OBX.ObservationIdentifier.Identifier.Value+"/"+ mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().GetOBSERVATION().OBX.ObservationIdentifier.Text.Value;
                    
                case 4:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().GetOBSERVATION(i).OBX.ObservationSubID.Value;
                    
                case 5:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().GetOBSERVATION(i).OBX.GetObservationValue(0).Data.ToString();
                    
                case 6:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().GetOBSERVATION(i).OBX.Units.Text.Value;
                    
                case 7:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().GetOBSERVATION(i).OBX.ReferencesRange.Value;
                    
                case 8:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().GetOBSERVATION(i).OBX.GetAbnormalFlags(0).Value;
                    
                case 9:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().GetOBSERVATION(i).OBX.Probability.Value;
                    
                case 10:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().GetOBSERVATION(i).OBX.GetNatureOfAbnormalTest(0).Value;
                    
                case 11:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().GetOBSERVATION(i).OBX.ObservationResultStatus.Value;
                    
                case 12:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().GetOBSERVATION(i).OBX.EffectiveDateOfReferenceRange.Time.Value;
                    
                case 13:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().GetOBSERVATION(i).OBX.UserDefinedAccessChecks.Value;
                    
                case 14:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().GetOBSERVATION(i).OBX.DateTimeOfTheObservation.Time.Value;
                    
                case 15:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().GetOBSERVATION(i).OBX.ProducerSID.Text.Value+"/"+ mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().GetOBSERVATION().OBX.ProducerSID.NameOfCodingSystem.Value;
                    
                case 16:
                    return mORU_R01.GetPATIENT_RESULT().GetORDER_OBSERVATION().GetOBSERVATION(i).OBX.GetResponsibleObserver(0).FamilyName.Surname.Value;
                                        
                default:
                    return null;
            }
        }
    }
}
