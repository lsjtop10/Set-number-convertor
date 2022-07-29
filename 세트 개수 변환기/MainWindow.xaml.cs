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
            SetUnitNum.Text = 64.ToString();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(((TextBox)sender).IsFocused)
                TextBoxUserInput(sender,e);
        }

        private void TextBoxUserInput(object sender, TextChangedEventArgs e)
        {
            int unitNumber = 0;
            int settes = 0;
            int rawVal = 0;
            int remainder = 0;

            try
            {

                if ((TextBox)sender == CurrentRaw)
                {
                    if (!int.TryParse(CurrentRaw.Text, out rawVal) && CurrentRaw.Text == "")
                    {
                        return;
                    }

                    if (!int.TryParse(SetUnitNum.Text, out unitNumber))
                    {
                        return;
                    }

                    CurrentSettes.Text = (rawVal / unitNumber).ToString();
                    CurrentRest.Text = (rawVal % unitNumber).ToString();

                }


                if ((TextBox)sender == CurrentSettes || (TextBox)sender == CurrentRest)
                {
                    if (!int.TryParse(CurrentSettes.Text, out settes) && CurrentSettes.Text == "")
                    {
                        return;

                    }


                    if (!int.TryParse(SetUnitNum.Text, out unitNumber))
                    {
                        return;
                    }


                    if (!int.TryParse(CurrentRest.Text, out remainder))
                    {
                        return;
                    }


                    CurrentRaw.Text = ((settes * unitNumber) + remainder).ToString();
                }

            }
            catch { };

        }
    }
}
