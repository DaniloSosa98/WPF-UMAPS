using System.Diagnostics;
using System.Windows;
using System.Windows.Input;

namespace WPF_UMAPS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MiniBtn_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Window_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void pactware_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("\"C:\\Program Files (x86)\\PACTware Consortium\\PACTware 4.1\\APP\\PACTWARE.EXE\"");
        }

        private void meterview_Click(object sender, RoutedEventArgs e)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = @"C:\Users\Public\Desktop\MeterView XL 2.1.0.lnk";
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
            
        }

        private void simatic_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("\"C:\\Program Files (x86)\\SIEMENS\\STEP7\\S7BIN\\S7tgtopx.exe\"");
        }

        private void dim_Click(object sender, RoutedEventArgs e)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = @"C:\Users\Public\Desktop\Device Integration Manager.lnk";
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
        }
    }
}
