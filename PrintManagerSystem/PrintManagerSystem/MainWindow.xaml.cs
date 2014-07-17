using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PrintManagerSystem
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //全局初始化配置文件
            Static.StaticDataMethod.StartInit();
            //初始化静态控件
            InitStaticControl();
            //可视化控件初始化
            View.ViewMethod.StartInit();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            
        }

        private void InitStaticControl()
        {
            View.StaticControl.MainNavBarControl = this.ModelMenuNVC;
            View.StaticControl.TopBod = this.TopBorder;
            View.StaticControl.MainWindows = this;
        }

        private void image1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            BottonMenu.Visibility = Visibility.Visible;
        }
    }
}
