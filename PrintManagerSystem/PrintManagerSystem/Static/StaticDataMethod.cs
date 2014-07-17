using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace PrintManagerSystem.Static
{
    public class StaticDataMethod
    {
        /// <summary>
        /// 系统启动全局初始化方法
        /// </summary>
        public static void StartInit()
        {
            InitTreeMenuData();
        }

        /// <summary>
        /// 初始化抽屉数据
        /// </summary>
        public static void InitTreeMenuData()
        {
            if (!File.Exists(StaticFilePath.TreeMenuConfigXml))
                return;
            XmlDocument TreeXmlDoc = new XmlDocument();
            TreeXmlDoc.Load(StaticFilePath.TreeMenuConfigXml);
            if (TreeXmlDoc == null) return;
            //分析节点
            XmlNode RootNode = TreeXmlDoc.SelectSingleNode("Root");
            XmlNodeList ParentMenuXml = RootNode.ChildNodes;

            foreach (XmlNode node in ParentMenuXml)
            { 
                XmlAttribute NameAtt = node.Attributes["Text"];
                if (NameAtt == null) continue;
                TreeParentStruct TreeParentData = new TreeParentStruct();
                TreeParentData.MenuName = NameAtt.Value.ToString();

                XmlAttribute IconAtt = node.Attributes["Icon"];
                if (IconAtt != null)
                {
                    TreeParentData.IconPath = IconAtt.Value.ToString();
                }

                XmlNodeList ChildNodeList = node.ChildNodes;
                if (ChildNodeList != null && ChildNodeList.Count > 0)
                {
                    foreach (XmlNode n in ChildNodeList)
                    {
                        XmlAttribute cAtt = n.Attributes["Text"];
                        if (cAtt == null) continue;
                        TreeDataStruct ChildOb = new TreeDataStruct();
                        ChildOb.MenuName = cAtt.Value.ToString();
                    }
                }

                StaticData.TreeMenuDataList.Add(TreeParentData);
            }
        }
    }
}
