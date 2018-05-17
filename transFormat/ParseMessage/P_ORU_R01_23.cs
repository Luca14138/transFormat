using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace transFormat
{
    class P_ORU_R01_23
    {
        private NHapi.Model.V23.Message.ORU_R01 mORU_R01;

        /// <summary>
        /// 构造函数
        /// </summary>
        public P_ORU_R01_23(NHapi.Model.V23.Message.ORU_R01 m)
        {
            this.mORU_R01 = m;
        }

        ///<summary>
        ///获取MSH中的字段，返回保存结果的string
        /// </summary>
        public string getMSH(float[] rule)
        {
            int seq = 0;
            string m = null;
            string field = null;
            for (int i = 0; rule[i] != 0; i++)
            {
                if (rule[i] % 1 == 0)
                {
                    seq = (int)rule[i];
                    if (i != 0)
                    {
                        m += ",";
                    }
                    field = this.getMSHField(seq);
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
        public string getPID(float[] rule)
        {
            int seq = 0;
            string m = null;
            string field = null;
            for (int i = 0; rule[i] != 0; i++)
            {
                if (rule[i] % 1 == 0)
                {
                    seq = (int)rule[i];
                    if (i != 0)
                    {
                        m += ",";
                    }
                    field = this.getPIDField(seq);
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
        public string getPV1(float[] rule)
        {
            int seq = 0;
            string m = null;
            string field = null;
            for (int i = 0; rule[i] != 0; i++)
            {
                if (rule[i] % 1 == 0)
                {
                    seq = (int)rule[i];
                    if (i != 0)
                    {
                        m += ",";
                    }
                    field = this.getPV1Field(seq);
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
        public string getORC(float[] rule)
        {
            int seq = 0;
            string m = null;
            string field = null;
            for (int i = 0; rule[i] != 0; i++)
            {
                if (rule[i] % 1 == 0)
                {
                    seq = (int)rule[i];
                    if (i != 0)
                    {
                        m += ",";
                    }
                    field = this.getORCField(seq);
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
        public string getOBR(float[] rule)
        {
            int seq = 0;
            string m = null;
            string field = null;
            int resultNumber = mORU_R01.GetRESPONSE().ORDER_OBSERVATIONRepetitionsUsed;
            for(int j=0;j<resultNumber;j++)
            {
                if (j != 0)
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
                        field = this.getOBRField(j,seq);
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

        ///<summary>
        ///获取OBX中的字段，返回保存结果的string
        /// </summary>
        public string getOBX(float[] rule)
        {
            int seq = 0;
            string m = null;
            string field = null;
            int resultNumber = mORU_R01.GetRESPONSE().ORDER_OBSERVATIONRepetitionsUsed;

            for (int j = 0; j < resultNumber; j++)
            {
                if (j != 0)
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
                        field = this.getOBXField(j, seq);
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

        /// <summary>
        /// 获取MSH的每个Field
        /// </summary>
        /// <param name="number"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public string getMSHField(int number, int second = 0)
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
                    return mORU_R01.MSH.DateTimeOfMessage.TimeOfAnEvent.Value;

                case 8:
                    return mORU_R01.MSH.Security.Value;

                case 9:
                    return mORU_R01.MSH.MessageType.MessageType.Value + "_" + mORU_R01.MSH.MessageType.TriggerEvent.Value;

                case 10:
                    return mORU_R01.MSH.MessageControlID.Value;

                case 11:
                    return mORU_R01.MSH.ProcessingID.ProcessingID.Value;

                case 12:
                    return mORU_R01.MSH.VersionID.Value;

                case 13:
                    return mORU_R01.MSH.SequenceNumber.Value;

                case 14:
                    return mORU_R01.MSH.ContinuationPointer.Value;

                case 15:
                    return mORU_R01.MSH.AcceptAcknowledgementType.Value;

                case 16:
                    return mORU_R01.MSH.ApplicationAcknowledgementType.Value;

                case 17:
                    return mORU_R01.MSH.CountryCode.Value;

                case 18:
                    return mORU_R01.MSH.CharacterSet.Value;

                case 19:
                    return mORU_R01.MSH.PrincipalLanguageOfMessage.Identifier.Value;

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
                    return mORU_R01.GetRESPONSE().PATIENT.PID.SetIDPatientID.Value;

                case 2:
                    return mORU_R01.GetRESPONSE().PATIENT.PID.PatientIDExternalID.ID.Value;

                case 3:
                    return mORU_R01.GetRESPONSE().PATIENT.PID.GetPatientIDInternalID(0).ID.Value;

                case 4:
                    return mORU_R01.GetRESPONSE().PATIENT.PID.GetAlternatePatientID(0).ID.Value;
                                               
                case 5:
                    return mORU_R01.GetRESPONSE().PATIENT.PID.GetPatientName(0).GivenName.Value;

                case 6:
                    return mORU_R01.GetRESPONSE().PATIENT.PID.MotherSMaidenName.GivenName.Value;

                case 7:
                    return mORU_R01.GetRESPONSE().PATIENT.PID.DateOfBirth.TimeOfAnEvent.Value;

                case 8:
                    return mORU_R01.GetRESPONSE().PATIENT.PID.Sex.Value;

                case 9:
                    return mORU_R01.GetRESPONSE().PATIENT.PID.GetPatientAlias(0).GivenName.Value;

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
        private string getPV1Field(int number, int second = 0)
        {
            switch (number)
            {
                //case 1:
                    //return mORU_R01.GetRESPONSE().PATIENT.VISIT.PV1;
                default:
                    return null;
            }
        }

        /// <summary>
        /// 获取ORC的每一个Field
        /// </summary>
        /// <param name="number"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public string getORCField(int number, int second = 0)
        {
            switch (number)
            {
                case 1:
                    return mORU_R01.GetRESPONSE().GetORDER_OBSERVATION().ORC.OrderControl.Value;

                case 2:
                    return mORU_R01.GetRESPONSE().GetORDER_OBSERVATION().ORC.GetPlacerOrderNumber(0).EntityIdentifier.Value;

                case 3:
                    return mORU_R01.GetRESPONSE().GetORDER_OBSERVATION().ORC.FillerOrderNumber.EntityIdentifier.Value;

                case 4:
                    return mORU_R01.GetRESPONSE().GetORDER_OBSERVATION().ORC.PlacerGroupNumber.EntityIdentifier.Value;

                case 5:
                    return mORU_R01.GetRESPONSE().GetORDER_OBSERVATION().ORC.OrderStatus.Value;

                case 6:
                    return mORU_R01.GetRESPONSE().GetORDER_OBSERVATION().ORC.ResponseFlag.Value;

                case 7:
                    return mORU_R01.GetRESPONSE().GetORDER_OBSERVATION().ORC.QuantityTiming.StartDateTime.TimeOfAnEvent.Value;

                case 8:
                    return mORU_R01.GetRESPONSE().GetORDER_OBSERVATION().ORC.Parent.ParentSFillerOrderNumber.EntityIdentifier.Value;

                case 9:
                    return mORU_R01.GetRESPONSE().GetORDER_OBSERVATION().ORC.DateTimeOfTransaction.TimeOfAnEvent.Value;

                case 10:
                    return mORU_R01.GetRESPONSE().GetORDER_OBSERVATION().ORC.EnteredBy.GivenName.Value;

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
        public string getOBRField(int i,int number, int second = 0)
        {
            switch (number)
            {
                case 1:
                    return mORU_R01.GetRESPONSE().GetORDER_OBSERVATION(i).OBR.SetIDObservationRequest.Value;

                case 2:
                    return mORU_R01.GetRESPONSE().GetORDER_OBSERVATION(i).OBR.PlacerOrderNumber.EntityIdentifier.Value;

                case 3:
                    return mORU_R01.GetRESPONSE().GetORDER_OBSERVATION(i).OBR.FillerOrderNumber.EntityIdentifier.Value;

                case 4:
                    return mORU_R01.GetRESPONSE().GetORDER_OBSERVATION(i).OBR.UniversalServiceIdentifier.Identifier.Value+"_"+ mORU_R01.GetRESPONSE().GetORDER_OBSERVATION().OBR.UniversalServiceIdentifier.Text.Value;

                case 5:
                    return mORU_R01.GetRESPONSE().GetORDER_OBSERVATION(i).OBR.Priority.Value;

                case 6:
                    return mORU_R01.GetRESPONSE().GetORDER_OBSERVATION(i).OBR.RequestedDateTime.TimeOfAnEvent.Value;

                case 7:
                    return mORU_R01.GetRESPONSE().GetORDER_OBSERVATION(i).OBR.ObservationDateTime.TimeOfAnEvent.Value;

                case 8:
                    return mORU_R01.GetRESPONSE().GetORDER_OBSERVATION(i).OBR.ObservationEndDateTime.TimeOfAnEvent.Value;

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
        public string getOBXField(int i, int number, int second = 0)
        {            
            switch (number)
            {
                case 1:
                    return mORU_R01.GetRESPONSE().GetORDER_OBSERVATION(i).GetOBSERVATION().OBX.SetIDOBX.Value;

                case 2:
                    return mORU_R01.GetRESPONSE().GetORDER_OBSERVATION(i).GetOBSERVATION().OBX.ValueType.Value;

                case 3:
                    return mORU_R01.GetRESPONSE().GetORDER_OBSERVATION(i).GetOBSERVATION().OBX.ObservationIdentifier.Identifier.Value+"_"+ mORU_R01.GetRESPONSE().GetORDER_OBSERVATION(i).GetOBSERVATION().OBX.ObservationIdentifier.Text.Value;

                case 4:
                    return mORU_R01.GetRESPONSE().GetORDER_OBSERVATION(i).GetOBSERVATION().OBX.ObservationSubID.Value;

                case 5:
                    return mORU_R01.GetRESPONSE().GetORDER_OBSERVATION(i).GetOBSERVATION().OBX.GetObservationValue(0).Data.ToString();

                case 6:
                    return mORU_R01.GetRESPONSE().GetORDER_OBSERVATION(i).GetOBSERVATION().OBX.Units.Identifier.Value;

                case 7:
                    return mORU_R01.GetRESPONSE().GetORDER_OBSERVATION(i).GetOBSERVATION().OBX.ReferencesRange.Value;

                case 8:
                    return mORU_R01.GetRESPONSE().GetORDER_OBSERVATION(i).GetOBSERVATION().OBX.GetAbnormalFlags(0).Value;

                case 9:
                    return mORU_R01.GetRESPONSE().GetORDER_OBSERVATION(i).GetOBSERVATION().OBX.Probability.Value;

                case 10:
                    return mORU_R01.GetRESPONSE().GetORDER_OBSERVATION(i).GetOBSERVATION().OBX.NatureOfAbnormalTest.Value;

                case 11:
                    return mORU_R01.GetRESPONSE().GetORDER_OBSERVATION(i).GetOBSERVATION().OBX.ObservResultStatus.Value;

                case 12:
                    return mORU_R01.GetRESPONSE().GetORDER_OBSERVATION(i).GetOBSERVATION().OBX.DateLastObsNormalValues.TimeOfAnEvent.Value;

                case 13:
                    return mORU_R01.GetRESPONSE().GetORDER_OBSERVATION(i).GetOBSERVATION().OBX.UserDefinedAccessChecks.Value;

                case 14:
                    return mORU_R01.GetRESPONSE().GetORDER_OBSERVATION(i).GetOBSERVATION().OBX.DateTimeOfTheObservation.TimeOfAnEvent.Value;

                case 15:
                    return mORU_R01.GetRESPONSE().GetORDER_OBSERVATION(i).GetOBSERVATION().OBX.ProducerSID.Identifier.Value+"_"+ mORU_R01.GetRESPONSE().GetORDER_OBSERVATION(i).GetOBSERVATION().OBX.ProducerSID.Text.Value;

                case 16:
                    return mORU_R01.GetRESPONSE().GetORDER_OBSERVATION(i).GetOBSERVATION().OBX.ResponsibleObserver.IDNumber.Value+"_"+ mORU_R01.GetRESPONSE().GetORDER_OBSERVATION(i).GetOBSERVATION().OBX.ResponsibleObserver.FamilyName.Value;

                default:
                    return null;
            }
        }
    }
}
