using DevExpress.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace HMMotionTester.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            //MovingAxisItems = new ObservableCollection<int>(Enumerable.Range(0, 65)); // 0~64
            //SelectedAxis = 0; // 초기값
        }
    }
}
