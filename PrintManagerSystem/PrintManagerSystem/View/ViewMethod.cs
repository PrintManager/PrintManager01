using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace PrintManagerSystem.View
{
    public class ViewMethod
    {
        public static void StartInit()
        { 
            //初始化抽屉控件
            InitNarBarControl();
            //初始化边框
            InitBorder();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="NarBarCtc"></param>
        private static void InitNarBarControl()
        {
            //控件内容初始化
            DevExpress.Wpf.NavBar.NavBarControl NarBarCtc = View.StaticControl.MainNavBarControl;
            NarBarCtc.Groups.Clear();
            foreach (Static.TreeParentStruct structs in Static.StaticData.TreeMenuDataList)
            {
                DevExpress.Wpf.NavBar.NavBarGroup Group = new DevExpress.Wpf.NavBar.NavBarGroup();
                Group.Header = structs.MenuName;
                NarBarCtc.Groups.Add(Group);
            }
        }

        private static void InitBorder()
        { 
            //控件舒适化
            //View.StaticControl.TopBod.MouseMove += new System.Windows.Input.MouseEventHandler(TopBod_MouseMove);
        }

        static void TopBod_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //throw new NotImplementedException();
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                View.StaticControl.MainWindows.DragMove();
            }
        }

        static void TopBod_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            //throw new NotImplementedException();  
            if (e.LeftButton == MouseButtonState.Pressed) 
            {
                View.StaticControl.MainWindows.DragMove();
            }
        }
    }
}
