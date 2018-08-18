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
        DataSet data = new DataSet();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = data;
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int settes = int.Parse(data.CurrentSettesVal);
                int offSet = int.Parse(data.CurrentSetOffSet);
                int RestVal = int.Parse(data.currentRestVal);

                data.CurrentRawVal = ((settes * offSet) + RestVal).ToString();
            }
            catch { };
           
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            try
            {
                int RawVal = int.Parse(data.CurrentRawVal);
                int offSet = int.Parse(data.CurrentSetOffSet);

                data.CurrentSettesVal = (RawVal / offSet).ToString();
                data.currentRestVal = (RawVal % offSet).ToString();
            }
            catch { };

                                
        }
    }
}
