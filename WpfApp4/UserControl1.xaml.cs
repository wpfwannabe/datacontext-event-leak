using System.Windows;

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void Log(string message)
        {
            MainWindow.Logger.Add($"[{GetHashCode():X8}] {message}");
        }

        private void ToggleButton_OnChecked(object sender, RoutedEventArgs e)
        {
            Log("Checked");
        }

        private void ToggleButton_OnUnchecked(object sender, RoutedEventArgs e)
        {
            Log("Unchecked");
        }

        private void UserControl1_OnLoaded(object sender, RoutedEventArgs e)
        {
            Log("Loaded");
        }

        private void UserControl1_OnUnloaded(object sender, RoutedEventArgs e)
        {
            Log("Unloaded");
        }
    }
}
