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
using HMMotionTester.ViewModels;
using System.Text.RegularExpressions;
using System.IO;
using System.Net.NetworkInformation;

namespace HMMotionTester.Views
{
    /// <summary>
    /// Interaction logic for View1.xaml
    /// </summary>
    public partial class MainView : UserControl
    {

        public string WmxOptionIniPath = "C:\\Users\\pxban\\Desktop\\HM-MotionTester\\HMMotionTester\\Views\\Resources\\AxisName.txt";
        //MotorList motorLIst = new MotorList();
        
        public MainView()
        {
            InitializeComponent();
            //string path = @"C:\경로\WmxOption.ini";
            MotorList.Instance.LoadAxisNames(WmxOptionIniPath);
            this.DataContext = MotorList.Instance;


            foreach (var child in MotionPanel.Children)
            {
                if (child is Button btn)
                {
                    btn.Click += MotionButton_Click;
                }
            }
        }
        //===============================================================================
        public void LoadAxisName(MotorList motorList, int i)
        {
            // 모터 이름 가져오기
            foreach (string line in File.ReadAllLines(WmxOptionIniPath))
            {
                var match = Regex.Match(line, @"AxisName\((\d+)\)=(.+)");
                if (match.ToString().Contains("AxisName(" + i + ")"))
                {
                    int k = match.Value.LastIndexOf('=') + 1;
                    motorList.Motors[i].AxisName = i + ": " + match.ToString().Substring(k, match.Value.Length - k);
                    Moving_Axis.Items.Add(i);
                }
            }
        }
        //===============================================================================================
        private void MotionButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                string motionName = btn.Content.ToString();
                switch (motionName)
                {
                    case "MovePosition":
                        MotionContentControl.Content = new MovePosition();
                        CoordinatesGrid.Visibility = Visibility.Collapsed;
                        MotionContentControl.Margin = new Thickness(0, -20, 0, 0);
                        break;
                    case "MoveVelocity":
                        MotionContentControl.Content = new MoveVelocity();
                        CoordinatesGrid.Visibility = Visibility.Collapsed;
                        MotionContentControl.Margin = new Thickness(0, -20, 0, 0);
                        break;
                    case "DSM":
                        MotionContentControl.Content = new DSM();
                        CoordinatesGrid.Visibility = Visibility.Collapsed;
                        MotionContentControl.Margin = new Thickness(0, -20, 0, 0);
                        break;
                    case "SLM":
                        MotionContentControl.Content = new SLM();
                        CoordinatesGrid.Visibility = Visibility.Collapsed;
                        MotionContentControl.Margin = new Thickness(0, -20, 0, 0);
                        break;
                    case "MoveVibration":
                        MotionContentControl.Content = new MoveVibration();
                        CoordinatesGrid.Visibility = Visibility.Collapsed;
                        MotionContentControl.Margin = new Thickness(0, -20, 0, 0);
                        break;
                    case "MoveLinearInterp":
                        MotionContentControl.Content = new MoveLinearInterp();
                        CoordinatesGrid.Visibility = Visibility.Visible;
                        MotionContentControl.Margin = new Thickness(0, 5, 0, 0);
                        break;
                    case "MovePnP":
                        MotionContentControl.Content = new MovePnP();
                        CoordinatesGrid.Visibility = Visibility.Visible;
                        MotionContentControl.Margin = new Thickness(0, 5, 0, 0);
                        break;
                    case "FlipperUp":
                        MotionContentControl.Content = new FlipperUp();
                        CoordinatesGrid.Visibility = Visibility.Visible;
                        MotionContentControl.Margin = new Thickness(0, 5, 0, 0);
                        break;
                    case "FlipperDown":
                        MotionContentControl.Content = new FlipperDown();
                        CoordinatesGrid.Visibility = Visibility.Visible;
                        MotionContentControl.Margin = new Thickness(0, 5, 0, 0);
                        break;
                    case "PathInterpDirectControl":
                        MotionContentControl.Content = new PathInterpDirectControl();
                        CoordinatesGrid.Visibility = Visibility.Visible;
                        MotionContentControl.Margin = new Thickness(0, 5, 0, 0);
                        break;
                    case "PathInterpFileInterface":
                        MotionContentControl.Content = new PathInterpFileInterface();
                        CoordinatesGrid.Visibility = Visibility.Visible;
                        MotionContentControl.Margin = new Thickness(0, 5, 0, 0);
                        break;
                    case "Circular~":
                        MotionContentControl.Content = new Circular();
                        CoordinatesGrid.Visibility = Visibility.Visible;
                        MotionContentControl.Margin = new Thickness(0, 5, 0, 0);
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
        //===============================================================================
        private void StopButton_Click(object sender, RoutedEventArgs e)
        {

        }
        //===============================================================================
        private void ReStartButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
