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

namespace 세트_개수_변환기
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetOffset.Text = 64.ToString();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int settes;
                if (!int.TryParse(CurrentSettes.Text, out settes))
                {
                    settes = 0;
                }

                int offSet;
                if (!int.TryParse(SetOffset.Text, out offSet))
                {
                    offSet = 0;
                }

                int RestVal;
                if(!int.TryParse(CurrentRest.Text, out RestVal))
                {
                    RestVal = 0;
                }


                CurrentRaw.Text = ((settes * offSet) + RestVal).ToString();
            }
            catch { };

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            try
            {
                int rawVal;
                if(!int.TryParse(CurrentRaw.Text, out rawVal))
                {
                    rawVal = 0;
                }

                int offSet;
                if(!int.TryParse(SetOffset.Text, out offSet))
                {
                    offSet = 0;
                }

                CurrentSettes.Text = (rawVal / offSet).ToString();
                CurrentRest.Text = (rawVal % offSet).ToString();
            }
            catch { };


        }
    }
}
