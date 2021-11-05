using System.Collections.ObjectModel;
using System.Windows;

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public static readonly DependencyProperty LogProperty = DependencyProperty.Register("Log", typeof(ObservableCollection<string>), typeof(MainWindow), new PropertyMetadata(default(ObservableCollection<string>)));
        public static readonly ObservableCollection<string> Logger = new ObservableCollection<string>();
        public static readonly ObservableCollection<Data> Source = new ObservableCollection<Data>
        {
            new Data
            {
                Name = "Test"
            }
        };

        public MainWindow()
        {
            InitializeComponent();
        }

        public ObservableCollection<string> Log
        {
            get { return (ObservableCollection<string>)GetValue(LogProperty); }
            set { SetValue(LogProperty, value); }
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            Log = Logger;
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            ListBox.Items.Add(new UserControl1());
        }

        private void Remove(object sender, RoutedEventArgs e)
        {
            if (ListBox.Items.Count == 0) return;
            ListBox.Items.RemoveAt(0);
        }
    }
}
