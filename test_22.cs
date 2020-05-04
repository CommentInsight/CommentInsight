//https://blog.csdn.net/u011127019/article/details/52538320

/// <summary>
/// 验证是否是URL链接
/// </summary>
/// <param name="str">指定字符串</param>
/// <returns></returns>
public static bool IsURL(string str)
{
    string pattern = @"^(https?|ftp|file|ws)://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?$";
    return IsMatch(pattern, str);
}


void test()
{
		
	//将相对uri转换成绝对uri 实例
	Uri uri = new Uri("http://www.gongjuji.net");
	Uri uri2 = new Uri(uri, "abc/1234.html");
	Console.WriteLine(uri2.ToString());//http://www.gongjuji.net/abc/1234.html
	Uri uri3 = new Uri(uri, "/md5/encrypt");
	Console.WriteLine(uri3.ToString());//http://www.gongjuji.net/md5/encrypt

	Regex re = new Regex(@"(?<url>http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?)");
	MatchCollection mc = re.Matches(s);
	foreach (Match m in mc)
	{
		string url = m.Result("${url}");
		Console.WriteLine(url);
	}


	string s = "例如：http://www.asd.com";
	Regex re = new Regex(@"(?<url>http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?)");
	MatchCollection mc = re.Matches(s);
	foreach (Match m in mc)
	{
		s = s.Replace(m.Result("${url}"), String.Format("<a href='{0}'>{0}</a>", m.Result("${url}")));
	}
	Console.WriteLine(s);
	
}	
