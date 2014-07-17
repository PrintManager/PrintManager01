using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace PrintManagerSystem.View
{
    public class StaticControl
    {
        private static System.Windows.Window mainWindows = null;
        /// <summary>
        /// 主窗体
        /// </summary>
        public static System.Windows.Window MainWindows
        {
            get { return StaticControl.mainWindows; }
            set { StaticControl.mainWindows = value; }
        }

        private static DevExpress.Wpf.NavBar.NavBarControl mainNavBarControl = null;
        /// <summary>
        /// 主抽屉控件
        /// </summary>
        public static DevExpress.Wpf.NavBar.NavBarControl MainNavBarControl
        {
            get { return StaticControl.mainNavBarControl; }
            set { StaticControl.mainNavBarControl = value; }
        }

        private static Border topBod = null;
        /// <summary>
        /// 头部边框
        /// </summary>
        public static Border TopBod
        {
            get { return StaticControl.topBod; }
            set { StaticControl.topBod = value; }
        }


    }
}
