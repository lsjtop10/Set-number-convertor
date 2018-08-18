using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace 세트_개수_변환기
{
    class DataSet : INotifyPropertyChanged
    {
        private string m_CurrnetRawVal;
        private string m_CurrentSetOffSet = 64;
        private string m_CurrentRestVal;
        private string m_CurrentSettesVal;

        /// <summary>
        /// 1세트의 기준이 되는 갯수
        /// </summary>
        public string CurrentSetOffSet
        {
            get
            {
                return m_CurrentSetOffSet;
            }
            set
            {
                m_CurrentSetOffSet = value;
                OnPropertyChanged("currnetSetOffset");
            }
        }

        /// <summary>
        /// 입력된 혹은 계산된 세트의 갯수
        /// </summary>
        public string CurrentSettesVal
        {
            get
            {
                return m_CurrentSettesVal;
            }
            set
            {
                m_CurrentSettesVal = value;
                OnPropertyChanged("CurrentSettesVal");
            }
        }

        /// <summary>
        /// 입력된 혹은 계산된 세트의 나머지
        /// </summary>
        public string currentRestVal
        {
            get
            {
                return m_CurrentRestVal;
            }
            set
            {
                m_CurrentRestVal = value;
                OnPropertyChanged("currentRestVal");

            }
        }

        /// <summary>
        /// 입력된 혹은 계산된 총 개수 (세트의 수 * 세트 오프셋 + 나머지)
        /// </summary>
       public string CurrentRawVal
       {
            get
            {
                return m_CurrnetRawVal;
            }
            set
            {
                m_CurrnetRawVal = value;
                OnPropertyChanged("CurrnetRawVal");
            }
       }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string PropertyName)
        {
            PropertyChangedEventArgs args = new PropertyChangedEventArgs(PropertyName);
            if (PropertyChanged != null)
            {
                PropertyChanged(this, args);
            }
        }

    }
}
