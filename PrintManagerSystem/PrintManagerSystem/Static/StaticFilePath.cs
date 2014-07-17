using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintManagerSystem.Static
{
    public class StaticFilePath
    {
        private static string treeMenuConfigXml = null;
        /// <summary>
        /// 抽屉配置文件路径（只读）
        /// </summary>
        public static string TreeMenuConfigXml
        {
            get 
            {
                if (treeMenuConfigXml == null)
                {
                    treeMenuConfigXml = AppDomain.CurrentDomain.BaseDirectory + "CONFIG\\TreeMenu.xml";
                }
                return StaticFilePath.treeMenuConfigXml; 
            }
        }
    }
}
