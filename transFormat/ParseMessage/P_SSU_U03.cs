using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHapi.Model.V24.Message;

namespace transFormat
{
    class P_SSU_U03
    {
        private SSU_U03 mSSU_U03;

        /// <summary>
        /// 构造函数
        /// </summary>
        public P_SSU_U03(SSU_U03 m)
        {
            this.mSSU_U03 = m;
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
        ///获取EQU中的字段，返回保存结果的string
        /// </summary>
        public string getEQU(float[] rule)
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
                    field = this.getEQUField(seq);
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
        ///获取SAC中的字段，返回保存结果的string
        /// </summary>
        public string getSAC(float[] rule)
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
                    field = this.getSACField(seq);
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
                    return mSSU_U03.MSH.FieldSeparator.Value;

                case 2:
                    return mSSU_U03.MSH.EncodingCharacters.Value;

                case 3:
                    return mSSU_U03.MSH.SendingApplication.NamespaceID.Value;

                case 4:
                    return mSSU_U03.MSH.SendingFacility.NamespaceID.Value;

                case 5:
                    return mSSU_U03.MSH.ReceivingApplication.NamespaceID.Value;

                case 6:
                    return mSSU_U03.MSH.ReceivingFacility.NamespaceID.Value;

                case 7:
                    return mSSU_U03.MSH.DateTimeOfMessage.TimeOfAnEvent.Value;

                case 8:
                    return mSSU_U03.MSH.Security.Value;

                case 9:
                    return mSSU_U03.MSH.MessageType.MessageType.Value+"_"+ mSSU_U03.MSH.MessageType.TriggerEvent.Value;

                case 10:
                    return mSSU_U03.MSH.MessageControlID.Value;

                case 11:
                    return mSSU_U03.MSH.ProcessingID.ProcessingID.Value;

                case 12:
                    return mSSU_U03.MSH.VersionID.VersionID.Value;

                case 13:
                    return mSSU_U03.MSH.SequenceNumber.Value;

                case 14:
                    return mSSU_U03.MSH.ContinuationPointer.Value;

                case 15:
                    return mSSU_U03.MSH.AcceptAcknowledgmentType.Value;

                case 16:
                    return mSSU_U03.MSH.ApplicationAcknowledgmentType.Value;

                case 17:
                    return mSSU_U03.MSH.CountryCode.Value;

                case 18:
                    return mSSU_U03.MSH.GetCharacterSet(0).Value;

                default:
                    return null;
            }
        }

        /// <summary>
        /// 获取EQU的每个Field
        /// </summary>
        /// <param name="number"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public string getEQUField(int number, int second = 0)
        {
            switch (number)
            {
                case 1:
                    return mSSU_U03.EQU.EquipmentInstanceIdentifier.NamespaceID.Value;

                case 2:
                    return mSSU_U03.EQU.EventDateTime.TimeOfAnEvent.Value;

                case 3:
                    return mSSU_U03.EQU.EquipmentState.Identifier.Value;

                case 4:
                    return mSSU_U03.EQU.LocalRemoteControlState.Text.Value;

                case 5:
                    return mSSU_U03.EQU.AlertLevel.Text.Value;

                default:
                    return null;
            }
        }

        /// <summary>
        /// 获取SAC的每个Field
        /// </summary>
        /// <param name="number"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public string getSACField(int number, int second = 0)
        {
            switch (number)
            {
                case 1:
                    return mSSU_U03.GetSPECIMEN_CONTAINER().SAC.ExternalAccessionIdentifier.EntityIdentifier.Value;

                case 2:
                    return mSSU_U03.GetSPECIMEN_CONTAINER().SAC.AccessionIdentifier.EntityIdentifier.Value;

                case 3:
                    return mSSU_U03.GetSPECIMEN_CONTAINER().SAC.ContainerIdentifier.EntityIdentifier.Value;

                case 4:
                    return mSSU_U03.GetSPECIMEN_CONTAINER().SAC.PrimaryParentContainerIdentifier.EntityIdentifier.Value;

                case 5:
                    return mSSU_U03.GetSPECIMEN_CONTAINER().SAC.EquipmentContainerIdentifier.EntityIdentifier.Value;

                case 6:
                    return mSSU_U03.GetSPECIMEN_CONTAINER().SAC.SpecimenSource.SpecimenRole.AlternateIdentifier.Value;

                case 7:
                    return mSSU_U03.GetSPECIMEN_CONTAINER().SAC.RegistrationDateTime.TimeOfAnEvent.Value;

                case 8:
                    return mSSU_U03.GetSPECIMEN_CONTAINER().SAC.ContainerStatus.Identifier.Value;

                case 9:
                    return mSSU_U03.GetSPECIMEN_CONTAINER().SAC.CarrierType.Identifier.Value;

                case 10:
                    return mSSU_U03.GetSPECIMEN_CONTAINER().SAC.CarrierIdentifier.EntityIdentifier.Value;

                case 11:
                    return mSSU_U03.GetSPECIMEN_CONTAINER().SAC.PositionInCarrier.Value1.Value;

                case 12:
                    return mSSU_U03.GetSPECIMEN_CONTAINER().SAC.TrayTypeSAC.Identifier.Value;

                default:
                    return null;
            }
        } 
    }
}
