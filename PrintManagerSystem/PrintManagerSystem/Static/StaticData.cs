using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace PrintManagerSystem.Static
{
    public class TreeParentStruct
    {
        private string menuName = null;
        /// </summary>
        public string MenuName
        {
            get { return menuName; }
            set { menuName = value; }
        }
        private string iconPath = null;
        /// <summary>
        /// icon路径
        /// </summary>
        public string IconPath
        {
            get { return iconPath; }
            set { iconPath = value; }
        }

        private List<TreeDataStruct> chiledTreeDataList = new List<TreeDataStruct>();
        /// <summary>
        /// 字抽屉列表
        /// </summary>
        public List<TreeDataStruct> ChiledTreeDataList
        {
            get { return chiledTreeDataList; }
            set { chiledTreeDataList = value; }
        }
    }

    /// <summary>
    /// 抽屉对象节点
    /// </summary>
    public class TreeDataStruct
    {
        private string menuName = null;
        /// <summary>
        /// 菜单名称
        /// </summary>
        public string MenuName
        {
            get { return menuName; }
            set { menuName = value; }
        }
        private string iconPath = null;
        /// <summary>
        /// icon路径
        /// </summary>
        public string IconPath
        {
            get { return iconPath; }
            set { iconPath = value; }
        }
        private string assembleName = null;
        /// <summary>
        /// ASS名称
        /// </summary>
        public string AssembleName
        {
            get { return assembleName; }
            set { assembleName = value; }
        }
        private string className = null;
        /// <summary>
        /// 类名
        /// </summary>
        public string ClassName
        {
            get { return className; }
            set { className = value; }
        }
    }

    public class StaticData
    {
        private static XmlDocument modelMenuXMlData = null;
        /// <summary>
        /// 抽屉节点菜单XML对象
        /// </summary>
        public static XmlDocument ModelMenuXMlData
        {
            get { return modelMenuXMlData; }
            set { modelMenuXMlData = value; }
        }

        private static List<TreeParentStruct> treeMenuDataList = new List<TreeParentStruct>();
        /// <summary>
        /// 抽屉数据列表
        /// </summary>
        public static List<TreeParentStruct> TreeMenuDataList
        {
            get { return treeMenuDataList; }
            set { treeMenuDataList = value; }
        }
    }
}
