using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace 湖泊湿地
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        

        int Chioceindex = -1;
        private void Plant0(object sender, TouchEventArgs e)
        {
            Chioceindex = 0;
            
        }

        private void Plant1(object sender, TouchEventArgs e)
        {
            Chioceindex = 1;
            
        }

        private void Plant2(object sender, TouchEventArgs e)
        {
            Chioceindex = 2;
            
        }

        private void Plant3(object sender, TouchEventArgs e)
        {

            Chioceindex = 3;
           
        }

        int MyChioce = -1;

        private void MyPlant0(object sender, TouchEventArgs e)
        {
            MyChioce = 0;
        }

        private void MyPlant1(object sender, TouchEventArgs e)
        {
            MyChioce = 1;
        }

        private void MyPlant2(object sender, TouchEventArgs e)
        {
            MyChioce = 2;
        }

        private void MyPlant3(object sender, TouchEventArgs e)
        {
            MyChioce = 3;
        }
        

        private void SubmitOption(object sender, TouchEventArgs e)
        {
            //Debug.Print("Chioceindex "+ Chioceindex + " MyChioce " + MyChioce);
            if (Chioceindex == MyChioce)
            {
                Storyboard AnwerStory;
                AnwerStory = (Storyboard)FindResource("AnwerTure");
                AnwerStory.Begin();
            }else
            {
                Storyboard AnwerStory;
                AnwerStory = (Storyboard)FindResource("AnwerFalse");
                AnwerStory.Begin();
            }
        }

        private void NextBtn(object sender, TouchEventArgs e)
        {
            switch (Chioceindex)
            {
                case 0:
                    Storyboard NextStory0;
                    NextStory0 = (Storyboard)FindResource("ReadDetail2");
                    NextStory0.Begin();
                    break;
                case 1:
                    Storyboard NextStory1;
                    NextStory1 = (Storyboard)FindResource("ReadDetail3");
                    NextStory1.Begin();
                    break;
                case 2:
                    Storyboard NextStory2;
                    NextStory2 = (Storyboard)FindResource("ReadDetail0");
                    NextStory2.Begin();
                    break;
                case 3:
                    Storyboard NextStory3;
                    NextStory3 = (Storyboard)FindResource("ReadDetail1");
                    NextStory3.Begin();
                    break;

            }
        }
        
    }
}
