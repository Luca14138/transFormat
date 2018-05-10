using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHapi.Model.V23.Message;

namespace transFormat
{
    class P_ORM_O01
    {
        private ORM_O01 mORM_O01;

        /// <summary>
        /// 构造函数
        /// </summary>
        public P_ORM_O01(ORM_O01 m)
        {
            this.mORM_O01 = m;
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
            for (int i = 0; rule[i] != 0; i++)
            {
                if (rule[i] % 1 == 0)
                {
                    seq = (int)rule[i];
                    if (i != 0)
                    {
                        m += ",";
                    }
                    field = this.getOBRField(seq);
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
        private string getMSHField(int number, int second = 0)
        {
            switch (number)
            {
                case 1:
                    return mORM_O01.MSH.FieldSeparator.Value;

                case 2:
                    return mORM_O01.MSH.EncodingCharacters.Value;

                case 3:
                    return mORM_O01.MSH.SendingApplication.NamespaceID.Value;

                case 4:
                    return mORM_O01.MSH.SendingFacility.NamespaceID.Value;

                case 5:
                    return mORM_O01.MSH.ReceivingApplication.NamespaceID.Value;

                case 6:
                    return mORM_O01.MSH.ReceivingFacility.NamespaceID.Value;

                case 7:
                    return mORM_O01.MSH.DateTimeOfMessage.TimeOfAnEvent.Value;

                case 8:
                    return mORM_O01.MSH.Security.Value;

                case 9:
                    return mORM_O01.MSH.MessageType.MessageType.Value;

                case 10:
                    return mORM_O01.MSH.MessageControlID.Value;

                case 11:
                    return mORM_O01.MSH.ProcessingID.ProcessingID.Value;

                case 12:
                    return mORM_O01.MSH.VersionID.Value;

                case 13:
                    return mORM_O01.MSH.SequenceNumber.Value;

                case 14:
                    return mORM_O01.MSH.ContinuationPointer.Value;

                case 15:
                    return mORM_O01.MSH.AcceptAcknowledgementType.Value;

                case 16:
                    return mORM_O01.MSH.ApplicationAcknowledgementType.Value;

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
        private string getPIDField(int number, int second = 0)
        {
            switch (number)
            {
                case 1:
                    return null;

                case 2:
                    return null;

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
        private string getORCField(int number, int second = 0)
        {
            switch (number)
            {
                case 1:
                    return null;

                case 2:
                    return null;

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
        private string getOBRField(int number, int second = 0)
        {
            switch (number)
            {
                case 1:
                    return null;

                case 2:
                    return null;


                default:
                    return null;
            }
        }

    }
}
