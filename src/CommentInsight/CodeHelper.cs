using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommentCleanTool
{
    class CodeHelper
    {
        public delegate int UpdateCommentColrDelegateMethod(RichTextBox rtb,  string highlightText, int pos, Color color);

        public UpdateCommentColrDelegateMethod updateCommentColorMethod;

        private StringBuilder cb_code;
        private StringBuilder cb_comment;

        private StringBuilder cb_temp;

        private int sourceType = 0; 

        private Options app_Config;

        
        
        
        public CodeHelper(Options appConfig)
        {
            app_Config = appConfig;

            cb_code = new StringBuilder();
            cb_comment = new StringBuilder();
            cb_temp = new StringBuilder();

        }
        public int paser_comment_str(char c, ref int state)
        {

            if (sourceType == 0)
            {
                return paser_cpp_comment_str(c,ref state);
            }
            else if (sourceType == 1)
            {
                return paser_python_comment_str(c, ref state);
            }
            else if (sourceType == 2)
            {
                return paser_php_comment_str(c, ref state);
            }
            else if (sourceType ==3)
            {
                return paser_go_comment_str(c, ref state);
            }
            else if (sourceType == 4)
            {
                return paser_java_comment_str(c, ref state);
            }

            return -1;

        }
        public void prepare_sourcefile(string lsFilepath)
        {
            sourceType = 0;

            string fileExt = System.IO.Path.GetExtension(lsFilepath).ToLower()+";";

            
            string cppFileExt = "*.c;*.cpp;*.h;*.cs;";
            string pythonFileExt = "*.py;";
            string phpFileExt = "*.php;";
            string javaFileExt = "*.java;";
            string goFileExt = "*.go;";

            if (cppFileExt.IndexOf(fileExt) >= 0)
            {
                sourceType = 0;
            }
            else if (pythonFileExt.IndexOf(fileExt) >= 0)
            {
                sourceType = 1;
            }
            else if (phpFileExt.IndexOf(fileExt) >= 0)
            {
                sourceType = 2;
            }
            else if (goFileExt.IndexOf(fileExt) >= 0)
            {
                sourceType = 3;
            }
            else if (javaFileExt.IndexOf(fileExt) >= 0)
            {
                sourceType = 4;
            }
        }

        public int paser_go_comment_str(char c, ref int state)
        {
            int is_comment_str = paser_cpp_comment_str(c, ref state);

            return is_comment_str;
        }

        public int paser_php_comment_str(char c, ref int state)
        {
            int is_comment_str = 1;


            switch (state)
            {
                case 0:
                    if (c == '/')
                        state = 1;
                    else if (c == '#')
                        state = 5;
                    else if (c == '\'')
                        state = 6;
                    else if (c == '\"')
                        state = 8;
                    break;
                case 1:
                    if (c == '*')
                        state = 2;
                    else if (c == '/')
                        state = 4;
                    else
                    { 
                        state = 0;
                        cb_code.Append('/');
                    }
                    break;
                case 2:
                    if (c == '*') 
                        state = 3;
                    else 
                        state = 2;
                    break;
                case 3:
                    if (c == '/')
                        state = 0;
                    else if (c == '*')
                        state = 3;
                    else
                        state = 2;
                    break;
                case 4:
                     if (c == '\n')
                    {
                        state = 0;
                    }
                     else
                        state = 4;
                    break;
                case 5:
                    if (c == '\n')
                        state = 0;
                    else
                        state = 5;
                    break;
                case 6:
                    if (c == '\\')
                        state = 7;
                    else if (c == '\'')
                    {
                        state = 0;
                        
                    }
                    break;
                case 7:
                    state = 6;
                    break;
                case 8:
                    if (c == '\\')
                        state = 9;
                    else if (c == '\"')
                    {
                        state = 0;
                        
                    }
                    break;
                case 9:
                    state = 8;
                    break;
            }
            if (state == 6 || state == 7 || state == 8 || state == 9 ||  (state == 0 && c != '/'))
            {
                is_comment_str = 0;
            }


            return is_comment_str;
        }

        public int paser_java_comment_str(char c, ref int state)
        {
            int is_comment_str = paser_cpp_comment_str(c,ref state);

            return is_comment_str;
        }

        public int paser_python_comment_str(char c, ref int state)
        {
            int is_comment_str = 1;

            switch (state)
            {
                case 0:
                    if (c == '#')
                        state = 1;
                    else if (c == 'r')
                        state = 10;
                    else if (c == '\'')
                        state = 20;
                    else if (c == '\"')
                        state = 30;
                    break;

                case 1:
                    if (c == '\n')
                        state = 0;
                    else
                        state = 1;

                    break;

                case 10:
                    if (c == '\'')
                    {
                        state = 11;
                    }
                    if (c == '\"')
                    {
                        state = 13;
                    }
                    else
                        state = 0;
                    break;

                case 11:
                    if (c == '\'')
                    {
                        state = 0;
                    }
                    else if (c == '\\')
                    {
                        state = 12;
                    }
                    else
                        state = 11;
                    break;

                case 12:
                        state = 11;
                    break;

                case 13:
                    if (c == '\"')
                    {
                        state = 0;
                    }
                    else if (c == '\\')
                    {
                        state = 14;
                    }
                    else
                        state = 13;
                    break;

                case 14:
                    state = 13;
                    break;


                case 20:

                    if (c == '\'')
                    {
                        state = 21;
                    }
                    else
                        state = 200;
                    break;

                case 200:

                    if (c == '\'')
                    {
                        cb_code.Append(cb_temp);
                        cb_temp.Clear();
                        state = 0;
                    }
                    else
                        state = 200;
                    break;

                case 21:

                    if (c == '\'')
                    {
                        state = 22;
                    }
                    else
                    {
                        cb_code.Append(cb_temp);
                        cb_temp.Clear();

                        state = 0;
                    }
                        
                    break;

                case 22:

                    if (c == '\'')
                    {
                        state = 23;
                    }
                    else
                        state = 22;
                    break;

                case 23:

                    if (c == '\'')
                    {
                        state = 24;
                    }
                    else
                        state = 22;
                    break;

                case 24:

                    if (c == '\'')
                    {
                        state = 25;
                    }
                    else
                        state = 22;
                    break;

                case 25:
                    state = 0;
                    break;


                case 30:

                    if (c == '\"')
                    {
                        state = 31;
                    }
                    else
                        state = 300;
                    break;

                case 300:

                    if (c == '\"')
                    {
                        cb_code.Append(cb_temp);
                        cb_temp.Clear();
                        state = 0;
                    }
                    else
                        state = 300;
                    break;

                case 31:

                    if (c == '\"')
                    {
                        state = 32;
                    }
                    else
                    {
                        cb_code.Append(cb_temp);
                        cb_temp.Clear();

                        state = 0;
                    }

                    break;

                case 32:

                    if (c == '\"')
                    {
                        state = 33;
                    }
                    else
                        state = 32;
                    break;

                case 33:

                    if (c == '\"')
                    {
                        state = 34;
                    }
                    else
                        state = 32;
                    break;

                case 34:

                    if (c == '\"')
                    {
                        state = 35;
                    }
                    else
                        state = 32;
                    break;

                case 35:
                    state = 0;
                    break;


            }


            if (((state >= 10) &&(state <=14))|| ((state == 0) && (c !='#')) )
            {
                is_comment_str = 0;
            }


            return is_comment_str;
        }

        public int paser_cpp_comment_str(char c, ref int state)
        {

            int is_comment_str = 1; 


            switch (state)
            {
                case 0:
                    if (c == '/')
                        state = 1;
                    else if (c == '\'')
                        state = 6;
                    else if (c == '\"')
                        state = 8;
                    
                        
                    break;
                case 1:
                    if (c == '*')
                        state = 2;
                    else if (c == '/')
                        state = 4;
                    else
                    { 
                        
                        
                        state = 0;
                        cb_code.Append('/');
                    }
                    break;
                case 2:
                    if (c == '*') 
                        state = 3;
                    else 
                        state = 2;
                    break;
                case 3:
                    if (c == '/')
                        state = 0;
                    else if (c == '*')
                        state = 3;
                    else
                        state = 2;
                    break;
                case 4:
                    if (c == '\\')
                        state = 5;
                    else if (c == '\n')
                    {
                        state = 0;
                        
                    }
                    break;
                case 5:
                    if (c == '\\')
                        state = 5;
                    else
                        state = 4;
                    break;
                case 6:
                    if (c == '\\')
                        state = 7;
                    else if (c == '\'')
                    {
                        state = 0;
                        
                    }
                    break;
                case 7:
                    state = 6;
                    break;
                case 8:
                    if (c == '\\')
                        state = 9;
                    else if (c == '\"')
                    {
                        state = 0;
                        
                    }
                    break;
                case 9:
                    state = 8;
                    break;
            }
            if (state == 6 || state == 7 || state == 8 || state == 9 || (state == 0 && c != '/'))
            {
                is_comment_str = 0;
            }


            return is_comment_str;

        }


        private bool checkCommentConfig(string comment)
        {
            bool bret1 = false;
            bool bret2 = false;

            for (int i = 0; i < app_Config.comment_regexConfig.jsonData.Count; i++)
            {
                jsonData regex_cfg= app_Config.comment_regexConfig.jsonData[i];

                if (regex_cfg.cEnabled.ToLower() == "false")
                    continue;

                Regex regex = new Regex(regex_cfg.cName, RegexOptions.IgnoreCase);
                bret1 = regex.IsMatch(comment);

                if (bret1)
                {
                    break;
                }
            }

            for (int i = 0; i < app_Config.comment_findConfig.jsonData.Count; i++)
            {
                jsonData find_cfg = app_Config.comment_findConfig.jsonData[i];
                if (find_cfg.cEnabled.ToLower() == "false")
                    continue;

                bret2 = (comment.IndexOf(find_cfg.cName) > 0);

                if (bret2)
                {
                    break;
                }
            }


            return (bret1 ||bret2);
        }
        public bool isValidComment_Python(string comment, bool allComment)
        {
            bool bret = true;

            if (allComment == false)
            {
                
                
                

                bret = checkCommentConfig(comment);
            }

            Regex regex1 = new Regex(@"^[ \t\f]*#.*?coding[:=][ \t]*([-_.a-zA-Z0-9]+)", RegexOptions.IgnoreCase);
            bool bret1 = regex1.IsMatch(comment);
            if (bret1)
            {
                return false;
            }

            if (comment.IndexOf("#!/usr/bin/") == 0)
            {
                return false;
            }
                
            return bret;
        }

        public bool isValidComment(string comment, bool allComment)
        {
            bool bret = true;

            if (sourceType == 1)
            {
                return isValidComment_Python(comment, allComment);
            }

            if (allComment == false)
            {
                
                
                

                bret = checkCommentConfig(comment);
            }

            return bret;
        }

        private string clear_comment(RichTextBox rtb, string codeText, bool allComment, out int clearNum)
        {
            clearNum = 0;
            int charState = 0;
            int charIndex = 0;

            cb_comment.Clear();
            cb_code.Clear();
            cb_temp.Clear();


            char[] codeArr = codeText.ToCharArray();

            foreach (char c in codeArr)
            {
                int isCommentChar = paser_comment_str(c,ref charState);

                if (isCommentChar == -1)
                {
                    cb_temp.Append(c);
                    continue;
                }

                if (isCommentChar == 1)
                {
                    if(c == '\n')
                        cb_temp.Append("\r\n");
                    else
                        cb_temp.Append(c);

                    if (charIndex >= codeArr.Length -1)
                    {
                        isCommentChar = 0;
                        charState = 0;
                    }
                }

                if(isCommentChar == 0)
                {
                    if (cb_temp.Length <= 1)
                    {
                        
                        cb_code.Append(c);
                    }
                    else
                    {
                        
                        string cb_str = cb_temp.ToString();

                        bool bc = isValidComment(cb_str, allComment);

                        if (bc)
                        {
                            clearNum++;
                            cb_code.Append("\r\n");

                            

                            if (c == '\n')
                                cb_temp.Append("\n");

                            
                            if ((updateCommentColorMethod != null) && (rtb != null))
                                updateCommentColorMethod(rtb, cb_str, charIndex - cb_str.Length, Color.Red);
                        }
                        else
                        {
                            
                            if ((updateCommentColorMethod != null) && (rtb != null))
                                updateCommentColorMethod(rtb, cb_str, charIndex - cb_str.Length, Color.Blue);


                            if (c == '\n')
                                cb_temp.Append("\r\n");

                            cb_code.Append(cb_temp);
                        }
                        cb_comment.Append(cb_temp);
                    }
                    cb_temp.Clear();
                }

                charIndex++;
            }

            string code_clear = cb_code.ToString();

            return code_clear;
        }

        public string clear_RichTextbox_comment(RichTextBox rtb, bool allComment, out int clearNum)
        {
            clearNum = 0;
            return clear_comment(rtb, rtb.Text, allComment, out clearNum);
        }

        public string clear_File_comment(string lsFilePath, bool allComment, out int clearNum)
        {
            clearNum = 0;
            StreamReader streamReader = new StreamReader(lsFilePath);
            string fileText = streamReader.ReadToEnd();
            streamReader.Close();

            fileText = fileText.Replace("\r\n", "\n");
            prepare_sourcefile(lsFilePath);

            return clear_comment(null, fileText, allComment, out clearNum);
        }


        public string get_srouce_comment_lines(string lsPath, Encoding enc,out int lines, out int comments, out int comment_lines, bool bAll = true)
        {
            string cc_code = "";
            lines = 0;
            int commentCount = 0;

            string[] fileContents = File.ReadAllLines(lsPath,enc);
            lines = fileContents.Count();

            
            cc_code = clear_File_comment(lsPath, bAll, out commentCount);

            string comment_Contents = cb_comment.ToString();
            string[] clear_code_lines = comment_Contents.Split(new Char[] { '\n'}, StringSplitOptions.RemoveEmptyEntries);

            
            comments = commentCount;
            comment_lines = clear_code_lines.Count();

            
            return cc_code;
        }
    }
}
