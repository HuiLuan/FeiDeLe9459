using System;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;

namespace StudentScoreManagement
{
   public  class HHWeb
    {
        /// <summary>
        ///     MD5 加密
        /// </summary>
        /// <param name="str">要加密的字符串</param>
        /// <returns>MD5加密后的字符串</returns>
        public static string GetMD5String(string str)
        {
            return FormsAuthentication.HashPasswordForStoringInConfigFile(str, "MD5");
        }

        #region 服务器信息

        /// <summary>
        ///     计算机名
        /// </summary>
        /// <returns>计算机名</returns>
        public static string GetHostName()
        {
            return "http://" + HttpContext.Current.Request.Url.Host + HttpContext.Current.Request.ApplicationPath;
        }

        /// <summary>
        ///     IP地址
        /// </summary>
        /// <returns>IP地址</returns>
        public static string GetHostIP(Page page)
        {
            return page.Request.ServerVariables["LOCAl_ADDR"];
        }

        /// <summary>
        ///     域名
        /// </summary>
        /// <param name="page">page</param>
        /// <returns>域名</returns>
        public static string GetServerName(Page page)
        {
            return page.Request.ServerVariables["SERVER_NAME"];
        }

        /// <summary>
        ///     端口
        /// </summary>
        /// <param name="page">page</param>
        /// <returns>端口</returns>
        public static string GetServerPort(Page page)
        {
            return page.Request.ServerVariables["Server_Port"];
        }

        /// <summary>
        ///     本文件所在路径
        /// </summary>
        /// <param name="page">page</param>
        /// <returns>本文件所在路径</returns>
        public static string GetPhysicalApplicationPath(Page page)
        {
            return page.Request.PhysicalApplicationPath;
        }

        /// <summary>
        ///     操作系统
        /// </summary>
        /// <returns>操作系统</returns>
        public static string GetOSVersion()
        {
            return Environment.OSVersion.ToString();
        }

        /// <summary>
        ///     操作系统所在文件夹
        /// </summary>
        /// <returns>操作系统所在文件夹</returns>
        public static string GetSystemDirectory()
        {
            return Environment.SystemDirectory;
        }

        /// <summary>
        ///     脚本超时时间
        /// </summary>
        /// <param name="page">page</param>
        /// <returns>脚本超时时间</returns>
        public static string GetScriptTimeout(Page page)
        {
            return (page.Server.ScriptTimeout / 1000).ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        ///     系统语言
        /// </summary>
        /// <returns>系统语言</returns>
        public static string GetSystemLanguage()
        {
            return CultureInfo.InstalledUICulture.EnglishName;
        }

        /// <summary>
        ///     .NET版本
        /// </summary>
        /// <returns>.NET版本</returns>
        public static string GetNetVersion()
        {
            return Environment.Version.Major + "." + Environment.Version.Minor + "." + Environment.Version.Build + "." +
                   Environment.Version.Revision;
        }

        /// <summary>
        ///     系统已经运行时间
        /// </summary>
        /// <returns></returns>
        public static string GetSystemRunTime()
        {
            return ((Environment.TickCount / 0x3e8) / 60).ToString(CultureInfo.InvariantCulture) + "分钟";
        }

        /// <summary>
        ///     CPU数量
        /// </summary>
        /// <returns>CPU数量</returns>
        public static string GetCpuCount()
        {
            string variable = Environment.GetEnvironmentVariable("NUMBER_OF_PROCESSORS");
            if (variable != null)
                return variable;
            return "";
        }

        /// <summary>
        ///     CPU类型
        /// </summary>
        /// <returns>CPU类型</returns>
        public static string GetCpuType()
        {
            string environmentVariable = Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER");
            if (environmentVariable != null)
                return environmentVariable;
            return "";
        }

        /// <summary>
        ///     占用内存
        /// </summary>
        /// <returns>占用内存</returns>
        public static string GetTakeMemory()
        {
            return ((Double)Process.GetCurrentProcess().WorkingSet64 / 1048576).ToString("N2");
        }

        /// <summary>
        ///     占用CPU
        /// </summary>
        /// <returns>占用CPU</returns>
        public static string GetTakeCpu()
        {
            return Process.GetCurrentProcess().TotalProcessorTime.TotalSeconds.ToString("N0");
        }

        /// <summary>
        ///     当前系统用户名
        /// </summary>
        /// <returns>当前系统用户名</returns>
        public static string GetSystemUserName()
        {
            return Environment.UserName;
        }

        #endregion

        #region 浏览器 IP 系统信息

        /// <summary>
        ///     获取访问IP
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public static string GetClientIP(Page page)
        {
            return page.Request.UserHostAddress;
        }

        /// <summary>
        ///     浏览器及版本
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public static string GetBrowsInfo(Page page)
        {
            return page.Request.Browser.Browser + page.Request.Browser.Version;
        }

        //获取用户操作系统的语言
        public static string GetLanuage(Page page)
        {
            if (page.Request.UserLanguages != null) return page.Request.UserLanguages[0];
            return "";
        }

        /// <summary>
        ///     获取操作系统版本
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public static string GetOSNameByUserAgent(Page page)
        {
            string userAgent = page.Request.UserAgent ?? "无";
            string osVersion = "未知";
            if (userAgent.Contains("NT 6.1"))
            {
                osVersion = "Windows  7";
            }
            else if (userAgent.Contains("NT 6.0"))
            {
                osVersion = "Windows Vista/Server 2008";
            }
            else if (userAgent.Contains("NT 5.2"))
            {
                osVersion = "Windows Server 2003";
            }
            else if (userAgent.Contains("NT 5.1"))
            {
                osVersion = "Windows XP";
            }
            else if (userAgent.Contains("NT 5"))
            {
                osVersion = "Windows 2000";
            }
            else if (userAgent.Contains("Mac"))
            {
                osVersion = "Mac";
            }
            else if (userAgent.Contains("Unix"))
            {
                osVersion = "UNIX";
            }
            else if (userAgent.Contains("Linux"))
            {
                osVersion = "Linux";
            }
            else if (userAgent.Contains("SunOS"))
            {
                osVersion = "SunOS";
            }
            return osVersion;
        }

        #endregion

        #region Alert

        public static void AlertAndRedirect(Page page, string message, string url)
        {
            RegisterAlertScript(page, "alert('{0}');location='" + url + "'\n", message, false);
        }


        public static void Alert(Page page, string msg)
        {
            Alert(page, msg, false);
        }

        public static void Alert(Page page, string msg, bool disableResProcess)
        {
            RegisterAlertScript(page, "alert('{0}');\n", msg, disableResProcess);
        }

        private static void RegisterAlertScript(Page page, string scriptFormat, string msg, bool disableResProcess)
        {
            string script = string.Format(scriptFormat, ConvertToJSAlertString(msg, disableResProcess));

            // 尽量使alert()脚本在最晚的时候注册，使之最后执行，而不影响其他初始化脚本。
            page.PreRenderComplete += (sender, e) =>
            {
                var p = (Page)sender;
                RegisterStartupScript(p, script);
            };
        }


        public static void AlertAndClose(Page page, string msg)
        {
            AlertAndClose(page, msg, false);
        }

        public static void AlertAndClose(Page page, string msg, bool disableResProcess)
        {
            RegisterAlertScript(page, "alert('{0}');window.close();", msg, disableResProcess);
        }

        public static void Close(Page page)
        {
            RegisterStartupScript(page, "window.close();");
        }

        public static void AlertAndCloseParent(Page page, string msg)
        {
            AlertAndCloseParent(page, msg, false);
        }

        public static void AlertAndCloseParent(Page page, string msg, bool disableResProcess)
        {
            RegisterAlertScript(page, "alert('{0}');\nself.parent.close();\n", msg, disableResProcess);
        }

        public static void AlertAndBack(string msg)
        {
            string output = string.Format("<script>alert('{0}');history.go(-1);</script>", ConvertToJSAlertString(msg));
            HttpContext.Current.Response.Write(output);
            HttpContext.Current.Response.BufferOutput = false;
            HttpContext.Current.Response.End();
        }


        private static string ConvertToJSAlertString(string message, bool disableResProcess = false)
        {
            return ConvertToJSString(message);
        }

        private static void RegisterStartupScript(Page page, string script)
        {
            page.ClientScript.RegisterStartupScript(page.GetType(), Guid.NewGuid().ToString(), script, true);
        }

        private static string ConvertToJSString(string s)
        {
            if (s.IndexOfAny(new[] { '\\', '\"', '\'', '\r', '\n' }) != -1)
            {
                var sb = new StringBuilder(s);
                sb.Replace("\\", "\\\\")
                  .Replace("\"", "\\\"")
                  .Replace("'", @"\'")
                  .Replace("\r", @"\r")
                  .Replace("\n", @"\n");
                return sb.ToString();
            }
            return s;
        }

        #endregion
    }
}
