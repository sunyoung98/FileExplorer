using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace ClassLibrary1
{
    public enum PacketType
    {
        초기화 = 0,
        로그인,
        정보
    }
    public enum PacketSendERROR
    {
        정상 = 0,
        에러
    }
    [Serializable]
    public class Packet
    {
        public int Length;
        public int Type;
        public Packet()
        {
            this.Length = 0;
            this.Type = 0;
        }
        public static byte[] Serialize(Object o)
        {
            MemoryStream ms = new MemoryStream(1024 * 4);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, o);
            return ms.ToArray();
        }
        public static Object Desserialize(byte[] bt)
        {
            MemoryStream ms = new MemoryStream(1024 * 4);
            foreach (byte b in bt)
            {
                ms.WriteByte(b);
            }
            ms.Position = 0;
            BinaryFormatter bf = new BinaryFormatter();
            Object obj = bf.Deserialize(ms);
            ms.Close();
            return obj;
        }

    }
    [Serializable]
    public class Initialize : Packet
    {
        public int Data = 0;
        public string Datastring;
    }
    [Serializable]
    public class Login : Packet
    {
        public string m_strID;
        public Login()
        {
            this.m_strID = null;
        }
    }
    [Serializable]
    public class Info : Packet
    {
        public string m_strID;
        public string user_select;
        public int filesize;
        public DirectoryInfo[] m_d1;
        public FileInfo[] m_f1;
        public byte[] fileByteArray;
        public Info()
        {
            this.m_strID = null;
            this.fileByteArray = null;
            this.m_d1 = null;
            this.m_f1 = null;
            this.filesize = 0;
            this.user_select = null;
        }
    }
}
