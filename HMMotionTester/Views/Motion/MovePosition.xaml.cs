using HMMotionTester.Interface;
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

namespace HMMotionTester.Views.Motion
{
    /// <summary>
    /// MovePosition.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MovePosition : UserControl, IMotionControl
    {
        public MovePosition()
        {
            InitializeComponent();
        }
        public string GetMotionData()
        {
            return RunMovePosition.Name; // TextBox 값 반환
        }
        public void RunMotion()
        {

        }
    }
}
