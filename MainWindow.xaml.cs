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

namespace HMMotionTester
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double MaxTabScrollOffset;
        private double tabWidth = 130;          // 탭의 너비
        private int visibleTabCount = 6;        // 화면에 동시에 보이는 탭의 개수

        public MainWindow()
        {
            InitializeComponent();
            MaxTabScrollOffset = (TabControl.Items.Count - visibleTabCount) * tabWidth; // 탭 개수에 따라 최대 오프셋 설정
        }

        private void LeftArrowButton_Click(object sender, RoutedEventArgs e)
        {
            if (TabTranslateTransform.X < 0)
            {
                TabTranslateTransform.X += tabWidth;
            }
        }

        private void RightArrowButton_Click(object sender, RoutedEventArgs e)
        {
            if (TabTranslateTransform.X > -MaxTabScrollOffset)
            {
                TabTranslateTransform.X -= tabWidth;
            }
        }
    }
}