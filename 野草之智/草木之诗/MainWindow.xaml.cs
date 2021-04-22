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
            bg.Play();
        }

        private void mediaended(object sender, RoutedEventArgs e)
        {
            mediaElement.Stop();
            mediaElement.Play();
        }

        private void bgmediaended(object sender, RoutedEventArgs e)
        {
            bg.Stop();
            bg.Play();
        }

        private void IntoTouchDown(object sender, TouchEventArgs e)
        {
            bg_Into.Stop();
            bg_Into.Play();
        }

        private void backTouchDown(object sender, TouchEventArgs e)
        {
            bg_Back.Stop();
            bg_Back.Play();
        }
    }
}
