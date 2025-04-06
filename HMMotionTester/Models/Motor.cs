using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMMotionTester.Models
{
    public class Motor : INotifyPropertyChanged
    {
        private int nAxisNum;
        private string sAxisName;
        private bool _isSelectable = true;

        public int AxisNum
        {
            get => nAxisNum;
            set
            {
                nAxisNum = value;
                OnPropertyChanged(nameof(AxisNum));
            }
        }

        public string AxisName
        {
            get => sAxisName;
            set
            {
                sAxisName = value;
                OnPropertyChanged(nameof(AxisName));
            }
        }
        
        public bool IsSelectable
        {
            get => _isSelectable;
            set
            {
                _isSelectable = value;
                OnPropertyChanged(nameof(IsSelectable));
            }
        }
        //===============================================================================
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
