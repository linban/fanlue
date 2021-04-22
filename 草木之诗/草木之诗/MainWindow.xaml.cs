using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace 草木之诗
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mediaElement.Play();
            Bg.Play();
        }

        private void mediaended(object sender, RoutedEventArgs e)
        {
            mediaElement.Stop();
            mediaElement.Play();
        }



        private void BgmediaEnded(object sender, RoutedEventArgs e)
        {
            Bg.Stop();
            Bg.Play();
        }



        private void BGIntoTouchDown(object sender, TouchEventArgs e)
        {
            Bg_Into.Stop();
            Bg_Into.Play();
        }

        private void BGbackTouchDown(object sender, TouchEventArgs e)
        {
            Bg_back.Stop();
            Bg_back.Play();
        }
    }
}
