using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommentCleanTool
{
    class Sources
    {

        private bool search_SubFolder;

        private Options App_Config;

        public Sources(Options appConfig, bool subFolder)
        {
            App_Config = appConfig;
            search_SubFolder = subFolder;
        }

        private bool isValidFolder(DirectoryInfo NextFolder)   
        {
            bool fvalid = true;

            List<jsonData> IgData = App_Config.folder_configData .jsonData;

            for (int i = 0; i < IgData.Count; i++)
            {
                jsonData fdata = IgData[i];

                if (fdata.cEnabled.ToLower() == "false")
                    continue;

                
                
                
                
                
                

                if (NextFolder.Name.ToLower() == fdata.cName.ToLower())
                {
                    fvalid = false;
                    break;
                }

                if (NextFolder.FullName.IndexOf(@"\"+fdata.cName + @"\") >= 0)
                {
                    fvalid = false;
                    break;
                }
            }

            return fvalid;
        }

        private bool isValidSource(FileInfo NextFile)
        {
            bool fvalid = true;

            List<jsonData> fileIgData = App_Config.file_configData.jsonData;

            for (int i = 0; i < fileIgData.Count; i++)
            {
                jsonData fdata = fileIgData[i];

                if (fdata.cEnabled.ToLower() == "false")
                    continue;

                //".Designer.cs"
                if (NextFile.Name.IndexOf(fdata.cName) >= 0)
                {
                    fvalid = false;
                    break;
                }
            }

            return fvalid;
        }

        private void addFilesItem(string spath, string ext,FileInfo[] thefileInfo, ref List<Dictionary<string, string>> fileList, ref List<String> list)
        {
            foreach (FileInfo NextFile in thefileInfo)
            {
                if (NextFile.Extension.Length < 1)
                    continue;

                if (ext.IndexOf(NextFile.Extension.ToLower()) < 0)
                    continue;

                if (NextFile.Length == 0)
                    continue;

                //skip backup dir's file
                //todo: confirm defalut backup dir
                //if (NextFile.FullName.IndexOf(App_Config.BackupPath) == 0)
                //    continue;

                //if (NextFile.Name.IndexOf(".Designer.cs") >= 0)
                if (isValidSource(NextFile) == false)
                    continue;

                Dictionary<string, string> dict = new Dictionary<string, string>();

                if (search_SubFolder)
                    dict["name"] = get_relative_path(spath, NextFile.FullName);
                else
                    dict["name"] = NextFile.Name;

                dict["size"] = NextFile.Length.ToString();
                dict["type"] = SFileType.File_item.ToString();
                dict["lastModified"] = NextFile.LastAccessTime.ToString();
                dict["FullName"] = NextFile.FullName;

                fileList.Add(dict);
                list.Add(NextFile.FullName);
            }

        }
        /*
        public List<Dictionary<string, string>> queryFilelists(string path, string ext)
        {
            if ((path[path.Length - 1] != '\\') & (path[path.Length - 1] != '/'))
                path = path + "\\";

            List<Dictionary<string, string>> fileList = new List<Dictionary<string, string>>();
            //ArrayList fileList = new ArrayList();

            List<String> list = new List<string>();
            DirectoryInfo theFolder = new DirectoryInfo(path);
            FileInfo[] thefileInfo = theFolder.GetFiles("*.*", SearchOption.TopDirectoryOnly);


            if (comboBox_FilePath.Text.Length > 3)
            {
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict["name"] = "..";

                dict["size"] = "";
                dict["type"] = Folder.ToString();
                dict["lastModified"] = "";

                fileList.Add(dict);
                list.Add("..");
            }

            foreach (FileInfo NextFile in thefileInfo)
            {
                if (NextFile.Extension.Length < 1)
                    continue;

                if (ext.IndexOf(NextFile.Extension.ToLower()) < 0)
                    continue;

                if (NextFile.Length == 0)
                    continue;


                Dictionary<string, string> dict = new Dictionary<string, string>();

                if (checkBox1_SubFolder.Checked)
                    dict["name"] = get_relative_path(comboBox_FilePath.Text, NextFile.FullName);
                else
                    dict["name"] = NextFile.Name;

                dict["size"] = NextFile.Length.ToString();
                dict["type"] = File.ToString();
                dict["lastModified"] = NextFile.LastAccessTime.ToString();

                fileList.Add(dict);
                list.Add(NextFile.FullName);
            }

            DirectoryInfo[] dirInfo = theFolder.GetDirectories();
            foreach (DirectoryInfo NextFolder in dirInfo)
            {

                list.Add(NextFolder.ToString());

                Dictionary<string, string> dict1 = new Dictionary<string, string>();

                dict1["name"] = NextFolder.Name;
                dict1["size"] = "";
                dict1["type"] = Folder.ToString(); //0 folder, 1 file
                dict1["lastModified"] = NextFolder.LastAccessTime.ToString();

                fileList.Add(dict1);


                if (checkBox1_SubFolder.Checked == false)
                {
                    continue;
                }


                FileInfo[] fileInfo = NextFolder.GetFiles("*.*", SearchOption.AllDirectories);
                foreach (FileInfo NextFile in fileInfo)
                {
                    if (NextFile.Extension.Length < 1)
                        continue;

                    if (ext.IndexOf(NextFile.Extension.ToLower()) < 0)
                        continue;

                    if (NextFile.Length == 0)
                        continue;

                    //skip backup dir's file
                    if (NextFile.FullName.IndexOf(BackupPath) == 0)
                        continue;

                    if (NextFile.Name.IndexOf(".Designer.cs") >= 0)
                        continue;


                    Dictionary<string, string> dict = new Dictionary<string, string>();

                    if (checkBox1_SubFolder.Checked)
                        dict["name"] = get_relative_path(comboBox_FilePath.Text, NextFile.FullName);
                    else
                        dict["name"] = NextFile.Name;

                    dict["size"] = NextFile.Length.ToString();
                    dict["type"] = File.ToString(); //0 folder, 1 file
                    dict["lastModified"] = NextFile.LastAccessTime.ToString();

                    fileList.Add(dict);
                    list.Add(NextFile.FullName);
                }
            }

            return fileList;
        }
        */

        public List<Dictionary<string, string>> queryFilelists(string spath, string ext)
        {
            if ((spath[spath.Length - 1] != '\\') & (spath[spath.Length - 1] != '/'))
                spath = spath + "\\";

            List<Dictionary<string, string>> fileList = new List<Dictionary<string, string>>();
            //ArrayList fileList = new ArrayList();

            List<String> list = new List<string>();
            DirectoryInfo theFolder = new DirectoryInfo(spath);
            FileInfo[] thefileInfo = theFolder.GetFiles("*.*", SearchOption.TopDirectoryOnly);


            if (spath.Length > 3)
            {
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict["name"] = "..";

                dict["size"] = "";
                dict["type"] = SFileType.Folder_item.ToString();
                dict["lastModified"] = "";

                fileList.Add(dict);
                list.Add("..");
            }

            addFilesItem(spath, ext, thefileInfo,ref fileList,ref list);

            DirectoryInfo[] dirInfo = { } ;

            try
            {
                if (search_SubFolder)
                {
                    dirInfo = theFolder.GetDirectories("*.*", SearchOption.AllDirectories);
                }
                else
                    dirInfo = theFolder.GetDirectories("*.*", SearchOption.TopDirectoryOnly);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            foreach (DirectoryInfo NextFolder in dirInfo)
            {

                //ignore .git
                //if (NextFolder.FullName.IndexOf(@"\.git\") >= 0)
                //{
                //    continue;//bypass .git
                //}
                if (isValidFolder(NextFolder) == false)
                {
                    continue;
                }

                //FileInfo[] fileInfo = NextFolder.GetFiles("*.*", SearchOption.AllDirectories);

                FileInfo[] fileInfo = { };
                try
                {
                    fileInfo = NextFolder.GetFiles("*.*", SearchOption.TopDirectoryOnly);
                }
                catch (Exception)
                {

                }
                
                if (fileInfo.Count() == 0)
                {
                    continue;//bypass empty folder
                }

                List<Dictionary<string, string>> fileListSubDir = new List<Dictionary<string, string>>();
                //foreach (FileInfo NextFile in fileInfo)
                //{
                //    if (NextFile.Extension.Length < 1)
                //        continue;

                //    if (ext.IndexOf(NextFile.Extension.ToLower()) < 0)
                //        continue;

                //    if (NextFile.Length == 0)
                //        continue;

                //    //skip backup dir's file
                //    if (NextFile.FullName.IndexOf(App_Config.BackupPath) == 0)
                //        continue;

                //    if (NextFile.Name.IndexOf(".Designer.cs") >= 0)
                //        continue;


                //    Dictionary<string, string> dict = new Dictionary<string, string>();

                //    if (search_SubFolder)
                //        dict["name"] = get_relative_path(spath, NextFile.FullName);
                //    else
                //        dict["name"] = NextFile.Name;

                //    dict["size"] = NextFile.Length.ToString();
                //    dict["type"] = SFileType.File_item.ToString(); //0 folder, 1 file
                //    dict["lastModified"] = NextFile.LastAccessTime.ToString();
                //    dict["FullName"] = NextFile.FullName;

                //    fileListSubDir.Add(dict);
                //}

                addFilesItem(spath, ext, fileInfo, ref fileListSubDir, ref list);

                if (fileListSubDir.Count() > 0)
                {
                    Dictionary<string, string> dict1 = new Dictionary<string, string>();

                    //dict1["name"] = NextFolder.Name;
                    dict1["name"] = get_relative_path(spath, NextFolder.FullName);
                    dict1["size"] = "";
                    dict1["type"] = SFileType.Folder_item.ToString(); //0 folder, 1 file
                    dict1["lastModified"] = NextFolder.LastAccessTime.ToString();

                    fileList.Add(dict1);
                    list.Add(NextFolder.ToString());
                }


                if (search_SubFolder == false)
                {
                    continue;
                }

                foreach (Dictionary<string, string> dict12 in fileListSubDir)
                {
                    fileList.Add(dict12);
                    list.Add(dict12["FullName"]);
                }
            }

            return fileList;
        }

        private string get_relative_path(string baseDir, string filePath)
        {
            if ((baseDir[baseDir.Length - 1] != '\\') & (baseDir[baseDir.Length - 1] != '/'))
                baseDir = baseDir + "\\";

            System.Uri uri1 = new Uri(filePath);
            System.Uri uri2 = new Uri(baseDir);

            Uri relativeUri = uri2.MakeRelativeUri(uri1);

            string rel_path = relativeUri.ToString().Replace("/", "\\").Replace("%20", " ");


            return rel_path;
        }
    }
}
