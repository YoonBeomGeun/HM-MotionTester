using DevExpress.Xpf.Docking.VisualElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using HMMotionTester.Views.Motion;
using HMMotionTester.Interface;

namespace HMMotionTester.Views
{
    /// <summary>
    /// Interaction logic for View1.xaml
    /// </summary>
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();

            foreach (var child in MotionPanel.Children)
            {
                if (child is Button btn)
                {
                    btn.Click += MotionButton_Click;
                }
            }
        }
        //===============================================================================
        private void MotionButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                string motionName = btn.Content.ToString();

                // 모션 이름에 따라 해당하는 UserControl을 로드
                switch (motionName)
                {
                    case "MovePosition":
                        MotionContentControl.Content = new MovePosition();
                        break;
                }
            }
        }
        //===============================================================================
        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            if (MotionContentControl.Content is IMotionControl motionControl)
            {
                string motionName = motionControl.GetMotionData();
                MessageBox.Show($"현재 입력된 값: {motionName}");
                motionControl.RunMotion();
            }
            else
            {
                MessageBox.Show("현재 표시된 모션 UI에서 데이터를 찾을 수 없습니다.");
            }
        }
    }
}
