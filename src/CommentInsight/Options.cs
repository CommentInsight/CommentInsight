using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentCleanTool
{
    public class Options
    {
        public string FileExt;
        public string DiffTool;
        public string DiffToolPath;

        public string BackupType;
        public string BackupPath;

        private IList<IDictionary<string, string>> ignoreFolder;
        private IList<IDictionary<string, string>> ignoreFile;

        public FolderJsonData folder_configData;
        public FileJsonData file_configData;

        public RegexJsonData comment_regexConfig;
        public FileJsonData  comment_findConfig;

        public bool config_inited;

        public Options()
        {
            folder_configData = new FolderJsonData();
            file_configData = new FileJsonData();
            comment_regexConfig = new RegexJsonData();
            comment_findConfig = new FileJsonData();
            
        }

        private void reset_ignore()
        {
            jsonData jdata = new jsonData(@".git", "git resp folder", "true");
            folder_configData.jsonData.Add(jdata);

            jdata = new jsonData(@"comment_backup", "default backup folder","true");
            folder_configData.jsonData.Add(jdata);


            jdata = new jsonData(@".Designer.cs", "C# Form Designer files", "true");
            file_configData.jsonData.Add(jdata);


            jdata = new jsonData(@"[^(\x00-\x7f)]", "search not-ASCII comment", "true");
            comment_regexConfig.jsonData.Add(jdata);


            jdata = new jsonData(@"comment", "search comment test", "false");
            comment_findConfig.jsonData.Add(jdata);
        }

        public void load_config()
        {
            FileExt = ConfigHelper.GetAppConfig("FileExt", "*.c;*.cpp;*.h;*.java;*.php;*.asp;*.aspx;*.cs;*.js;*.go;*txt;*.ini;*.txt;*.py");
            DiffTool = ConfigHelper.GetAppConfig("DiffTool", "0");
            DiffToolPath = ConfigHelper.GetAppConfig("DiffToolPath", "");

            BackupType = ConfigHelper.GetAppConfig("BackupType", "0");
            BackupPath = ConfigHelper.GetAppConfig("BackupPath", ".");

            string igfolder = ConfigHelper.GetAppConfig("IgnoreFolder", "");
            string igfile = ConfigHelper.GetAppConfig("IgnoreFile", "");
            string regex = ConfigHelper.GetAppConfig("Comment_Regex", "");
            string cFind = ConfigHelper.GetAppConfig("Comment_Find", "");

            try
            {

                if ((igfolder.Length == 0) && (igfile.Length == 0) && (regex.Length == 0))
                {
                    config_inited = true;
                    reset_ignore();
                }
                else
                {
                    config_inited = true;
                }
                    

                if (igfolder.Length > 0)
                    folder_configData = COptionsHelper.getFolderOptions(igfolder);

                if (igfile.Length > 0)
                    file_configData = COptionsHelper.getFileOptions(igfile);

                if (regex.Length > 0)
                    comment_regexConfig = COptionsHelper.getRegexOptions(regex);

                if (cFind.Length > 0)
                    comment_findConfig = COptionsHelper.getFileOptions(cFind);

                int dindex = Convert.ToInt32(DiffTool);
                if ((dindex < 0) || (dindex > 3))
                    dindex = 0;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void save_config()
        {
            ConfigHelper.UpdateAppConfig("FileExt", FileExt);
            ConfigHelper.UpdateAppConfig("DiffTool", DiffTool);
            ConfigHelper.UpdateAppConfig("DiffToolPath", DiffToolPath);

            ConfigHelper.UpdateAppConfig("BackupType", BackupType);
            ConfigHelper.UpdateAppConfig("BackupPath", BackupPath);


            if (folder_configData.jsonData.Count() > 0)
            {
                string ig = COptionsHelper.getFolderOptionsString(folder_configData);
                ConfigHelper.UpdateAppConfig("IgnoreFolder", ig);
            }

            if (file_configData.jsonData.Count() > 0)
            {
                string ig = COptionsHelper.getFileOptionsString(file_configData);
                ConfigHelper.UpdateAppConfig("IgnoreFile", ig);
            }

            if (comment_regexConfig.jsonData.Count() > 0)
            {
                string ig = COptionsHelper.getRegexOptionsString(comment_regexConfig);
                ConfigHelper.UpdateAppConfig("Comment_Regex", ig);
            }

            if (comment_findConfig.jsonData.Count() > 0)
            {
                string ig = COptionsHelper.getFileOptionsString(comment_findConfig);
                ConfigHelper.UpdateAppConfig("Comment_Find", ig);
            }
        }
    }
    
}

