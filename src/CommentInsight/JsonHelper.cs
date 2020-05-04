using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;


namespace CommentCleanTool
{
    class JsonHelper
    {
        
        public static string ObjectToJson(object obj)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
            MemoryStream stream = new MemoryStream();
            serializer.WriteObject(stream, obj);
            byte[] dataBytes = new byte[stream.Length];
            stream.Position = 0;
            stream.Read(dataBytes, 0, (int)stream.Length);
            return Encoding.UTF8.GetString(dataBytes);
        }
        
        public static object JsonToObject(string jsonString, object obj)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
            MemoryStream mStream = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
            return serializer.ReadObject(mStream);
        }


    }

    class COptionsHelper
    {
        public static string getFolderOptionsString(FolderJsonData jsonData)
        {
            string ls =   JsonHelper.ObjectToJson(jsonData);

            ls = Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(ls));

            
            

            return ls;
        }

        public static FolderJsonData getFolderOptions(string opstr)
        {
            
            
            

            byte[] bdata = Convert.FromBase64String(opstr);
            string str = System.Text.Encoding.Default.GetString(bdata);

            FolderJsonData jsdata = new FolderJsonData();
            jsdata = (FolderJsonData)JsonHelper.JsonToObject(str, (object)jsdata);

            return jsdata;
        }

        public static string getFileOptionsString(FileJsonData jsonData)
        {
            string ls = JsonHelper.ObjectToJson(jsonData);

            ls = Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(ls));


            return ls;
        }

        public static FileJsonData getFileOptions(string opstr)
        {
            byte[] bdata = Convert.FromBase64String(opstr);
            string str = System.Text.Encoding.Default.GetString(bdata);

            FileJsonData jsdata = new FileJsonData();
            jsdata = (FileJsonData)JsonHelper.JsonToObject(str, (object)jsdata);

            return jsdata;
        }

        public static string getRegexOptionsString(RegexJsonData jsonData)
        {
            string ls = JsonHelper.ObjectToJson(jsonData);

            ls = Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(ls));


            return ls;
        }

        public static RegexJsonData getRegexOptions(string opstr)
        {
            byte[] bdata = Convert.FromBase64String(opstr);
            string str = System.Text.Encoding.Default.GetString(bdata);

            RegexJsonData jsdata = new RegexJsonData();
            jsdata = (RegexJsonData)JsonHelper.JsonToObject(str, (object)jsdata);

            return jsdata;
        }
    }
    [DataContract]
    public class jsonData
    {
        [DataMember]
        public String cName;
        [DataMember]
        public String cDesc;
        [DataMember]
        public String cEnabled;
        public jsonData(String c_name, String c_Desc, string c_Enabled)
        {
            this.cName = c_name;
            this.cDesc = c_Desc;
            this.cEnabled = c_Enabled;
        }
    };
    [DataContract]
    public class FolderJsonData
    {
        [DataMember]
        public List<jsonData> jsonData;

        public FolderJsonData()
        {
            this.jsonData = new List<jsonData>();
        }
    }
    [DataContract]
    public class FileJsonData
    {
        [DataMember]
        public List<jsonData> jsonData;

        public FileJsonData()
        {
            this.jsonData = new List<jsonData>();
        }
    }

    [DataContract]
    public class RegexJsonData
    {
        [DataMember]
        public List<jsonData> jsonData;

        public RegexJsonData()
        {
            this.jsonData = new List<jsonData>();
        }
    }

}
