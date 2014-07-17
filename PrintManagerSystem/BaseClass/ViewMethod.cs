using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace BaseClass
{
    public class ViewMethod
    {

        /// <summary>
        /// 根据程序集和类名创建对象
        /// </summary>
        /// <param name="AssembleName"></param>
        /// <param name="ClassName"></param>
        /// <returns></returns>
        public static object CreateWindows(string AssembleName, string ClassName)
        {
            try
            {
                string strExePath = AppDomain.CurrentDomain.BaseDirectory;
                return Assembly.LoadFrom(strExePath + AssembleName).CreateInstance(ClassName);
            }
            catch
            { 
                return null
            }

        }
    }
}
