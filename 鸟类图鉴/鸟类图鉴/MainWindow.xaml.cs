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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace 鸟类图鉴
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

        int index = -1;
        private void Into(object sender, MouseButtonEventArgs e)
        {
            index = 0;
        }

        private void leftevent(object sender, MouseButtonEventArgs e)
        {
            switch (index)
            {
                case 1:
                    index--;
                    Storyboard left0;
                    left0 = (Storyboard)FindResource("Moveright6");
                    left0.Begin();
                    break;
                case 2:
                    index--;
                    Storyboard left1;
                    left1 = (Storyboard)FindResource("Moveright5");
                    left1.Begin();
                    break;
                case 3:
                    index--;
                    Storyboard left2;
                    left2 = (Storyboard)FindResource("Moveright4");
                    left2.Begin();
                    break;
                case 4:
                    index--;
                    Storyboard left3;
                    left3 = (Storyboard)FindResource("Moveright3");
                    left3.Begin();
                    break;
                case 5:
                    index--;
                    Storyboard left4;
                    left4 = (Storyboard)FindResource("Moveright2");
                    left4.Begin();
                    break;
                case 6:
                    index--;
                    Storyboard left5;
                    left5 = (Storyboard)FindResource("Moveright1");
                    left5.Begin();
                    break;
                case 7:
                    index--;
                    Storyboard left6;
                    left6 = (Storyboard)FindResource("Moveright0");
                    left6.Begin();
                    break;

            }
        }

        private void rightevent(object sender, MouseButtonEventArgs e)
        {
            switch (index)
            {
                case 0:
                    index++;
                    Storyboard right0;
                    right0 = (Storyboard)FindResource("Moveleft0");
                    right0.Begin();
                    break;
                case 1:
                    index++;
                    Storyboard right1;
                    right1 = (Storyboard)FindResource("Moveleft1");
                    right1.Begin();
                    break;
                case 2:
                    index++;
                    Storyboard right2;
                    right2 = (Storyboard)FindResource("Moveleft2");
                    right2.Begin();
                    break;
                case 3:
                    index++;
                    Storyboard right3;
                    right3 = (Storyboard)FindResource("Moveleft3");
                    right3.Begin();
                    break;
                case 4:
                    index++;
                    Storyboard right4;
                    right4 = (Storyboard)FindResource("Moveleft4");
                    right4.Begin();
                    break;
                case 5:
                    index++;
                    Storyboard right5;
                    right5 = (Storyboard)FindResource("Moveleft5");
                    right5.Begin();
                    break;
                case 6:
                    index++;
                    Storyboard right6;
                    right6 = (Storyboard)FindResource("Moveleft6");
                    right6.Begin();
                    break;

            }
        }

        int btnindex;

        private void btn1(object sender, MouseButtonEventArgs e)
        {
            btnindex = 0;
        }

        private void btn2(object sender, MouseButtonEventArgs e)
        {
            btnindex = 1;
        }

        private void btn3(object sender, MouseButtonEventArgs e)
        {
            btnindex = 2;
        }

        private void btn4(object sender, MouseButtonEventArgs e)
        {
            btnindex = 3;
        }

        private void btn5(object sender, MouseButtonEventArgs e)
        {
            btnindex = 4;
        }

        private void btn6(object sender, MouseButtonEventArgs e)
        {
            btnindex = 5;
        }

        private void btn7(object sender, MouseButtonEventArgs e)
        {
            btnindex = 6;
        }

        private void detailleftevent(object sender, MouseButtonEventArgs e)
        {
            switch (btnindex)
            {
                case 1:
                    btnindex--;
                    Storyboard left0;
                    left0 = (Storyboard)FindResource("Detail0");
                    left0.Begin();
                    break;
                case 2:
                    btnindex--;
                    Storyboard left1;
                    left1 = (Storyboard)FindResource("Detail1");
                    left1.Begin();
                    break;
                case 3:
                    btnindex--;
                    Storyboard left2;
                    left2 = (Storyboard)FindResource("Detail2");
                    left2.Begin();
                    break;
                case 4:
                    btnindex--;
                    Storyboard left3;
                    left3 = (Storyboard)FindResource("Detail3");
                    left3.Begin();
                    break;
                case 5:
                    btnindex--;
                    Storyboard left4;
                    left4 = (Storyboard)FindResource("Detail4");
                    left4.Begin();
                    break;
                case 6:
                    btnindex--;
                    Storyboard left5;
                    left5 = (Storyboard)FindResource("Detail5");
                    left5.Begin();
                    break;


            }
        }

        private void detailrightevent(object sender, MouseButtonEventArgs e)
        {
            switch (btnindex)
            {
                case 0:
                    btnindex++;
                    Storyboard right0;
                    right0 = (Storyboard)FindResource("Detail1");
                    right0.Begin();
                    break;
                case 1:
                    btnindex++;
                    Storyboard right1;
                    right1 = (Storyboard)FindResource("Detail2");
                    right1.Begin();
                    break;
                case 2:
                    btnindex++;
                    Storyboard right2;
                    right2 = (Storyboard)FindResource("Detail3");
                    right2.Begin();
                    break;
                case 3:
                    btnindex++;
                    Storyboard right3;
                    right3 = (Storyboard)FindResource("Detail4");
                    right3.Begin();
                    break;
                case 4:
                    btnindex++;
                    Storyboard right4;
                    right4 = (Storyboard)FindResource("Detail5");
                    right4.Begin();
                    break;
                case 5:
                    btnindex++;
                    Storyboard right5;
                    right5 = (Storyboard)FindResource("Detail6");
                    right5.Begin();
                    break;
            }
        }


        //touch down
        private void Into(object sender, TouchEventArgs e)
        {
            index = 0;
        }


        private void btn1(object sender, TouchEventArgs e)
        {
            btnindex = 0;
        }

        private void btn2(object sender, TouchEventArgs e)
        {
            btnindex = 1;
        }

        private void btn3(object sender, TouchEventArgs e)
        {
            btnindex = 2;
        }

        private void btn4(object sender, TouchEventArgs e)
        {
            btnindex = 3;
        }

        private void btn5(object sender, TouchEventArgs e)
        {
            btnindex = 4;
        }

        private void btn6(object sender, TouchEventArgs e)
        {
            btnindex = 5;
        }

        private void btn7(object sender, TouchEventArgs e)
        {
            btnindex = 6;
        }


        private void leftevent(object sender, TouchEventArgs e)
        {
            switch (index)
            {
                case 1:
                    index--;
                    Storyboard left0;
                    left0 = (Storyboard)FindResource("Moveright6");
                    left0.Begin();
                    break;
                case 2:
                    index--;
                    Storyboard left1;
                    left1 = (Storyboard)FindResource("Moveright5");
                    left1.Begin();
                    break;
                case 3:
                    index--;
                    Storyboard left2;
                    left2 = (Storyboard)FindResource("Moveright4");
                    left2.Begin();
                    break;
                case 4:
                    index--;
                    Storyboard left3;
                    left3 = (Storyboard)FindResource("Moveright3");
                    left3.Begin();
                    break;
                case 5:
                    index--;
                    Storyboard left4;
                    left4 = (Storyboard)FindResource("Moveright2");
                    left4.Begin();
                    break;
                case 6:
                    index--;
                    Storyboard left5;
                    left5 = (Storyboard)FindResource("Moveright1");
                    left5.Begin();
                    break;
                case 7:
                    index--;
                    Storyboard left6;
                    left6 = (Storyboard)FindResource("Moveright0");
                    left6.Begin();
                    break;

            }
        }

        private void rightevent(object sender, TouchEventArgs e)
        {
            switch (index)
            {
                case 0:
                    index++;
                    Storyboard right0;
                    right0 = (Storyboard)FindResource("Moveleft0");
                    right0.Begin();
                    break;
                case 1:
                    index++;
                    Storyboard right1;
                    right1 = (Storyboard)FindResource("Moveleft1");
                    right1.Begin();
                    break;
                case 2:
                    index++;
                    Storyboard right2;
                    right2 = (Storyboard)FindResource("Moveleft2");
                    right2.Begin();
                    break;
                case 3:
                    index++;
                    Storyboard right3;
                    right3 = (Storyboard)FindResource("Moveleft3");
                    right3.Begin();
                    break;
                case 4:
                    index++;
                    Storyboard right4;
                    right4 = (Storyboard)FindResource("Moveleft4");
                    right4.Begin();
                    break;
                case 5:
                    index++;
                    Storyboard right5;
                    right5 = (Storyboard)FindResource("Moveleft5");
                    right5.Begin();
                    break;
                case 6:
                    index++;
                    Storyboard right6;
                    right6 = (Storyboard)FindResource("Moveleft6");
                    right6.Begin();
                    break;

            }
        }

        private void detailleftevent(object sender, TouchEventArgs e)
        {
            switch (btnindex)
            {
                case 1:
                    btnindex--;
                    Storyboard left0;
                    left0 = (Storyboard)FindResource("Detail0");
                    left0.Begin();
                    break;
                case 2:
                    btnindex--;
                    Storyboard left1;
                    left1 = (Storyboard)FindResource("Detail1");
                    left1.Begin();
                    break;
                case 3:
                    btnindex--;
                    Storyboard left2;
                    left2 = (Storyboard)FindResource("Detail2");
                    left2.Begin();
                    break;
                case 4:
                    btnindex--;
                    Storyboard left3;
                    left3 = (Storyboard)FindResource("Detail3");
                    left3.Begin();
                    break;
                case 5:
                    btnindex--;
                    Storyboard left4;
                    left4 = (Storyboard)FindResource("Detail4");
                    left4.Begin();
                    break;
                case 6:
                    btnindex--;
                    Storyboard left5;
                    left5 = (Storyboard)FindResource("Detail5");
                    left5.Begin();
                    break;


            }
        }

        private void detailrightevent(object sender, TouchEventArgs e)
        {
            switch (btnindex)
            {
                case 0:
                    btnindex++;
                    Storyboard right0;
                    right0 = (Storyboard)FindResource("Detail1");
                    right0.Begin();
                    break;
                case 1:
                    btnindex++;
                    Storyboard right1;
                    right1 = (Storyboard)FindResource("Detail2");
                    right1.Begin();
                    break;
                case 2:
                    btnindex++;
                    Storyboard right2;
                    right2 = (Storyboard)FindResource("Detail3");
                    right2.Begin();
                    break;
                case 3:
                    btnindex++;
                    Storyboard right3;
                    right3 = (Storyboard)FindResource("Detail4");
                    right3.Begin();
                    break;
                case 4:
                    btnindex++;
                    Storyboard right4;
                    right4 = (Storyboard)FindResource("Detail5");
                    right4.Begin();
                    break;
                case 5:
                    btnindex++;
                    Storyboard right5;
                    right5 = (Storyboard)FindResource("Detail6");
                    right5.Begin();
                    break;
            }
        }
    }
}
