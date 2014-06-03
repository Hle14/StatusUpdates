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

//
using System.Collections.ObjectModel;

namespace StatusUpdates
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //StatusUpdatesList _statuses = new StatusUpdatesList();

        ObservableCollection<StatusUpdate> _statuses = new ObservableCollection<StatusUpdate>();

        public MainWindow()
        {
            _statuses.Add(new StatusUpdate
            {
                Content = "first thing to say",
                timeStamp = DateTime.Now
            });
            _statuses.Add(new StatusUpdate
            {
                Content = "yup second",
                timeStamp = DateTime.Now
            });
            _statuses.Add(new StatusUpdate
            {
                Content = "YATTTAAA",
                timeStamp = DateTime.Now
            });
            InitializeComponent();
            //Loaded+=MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //_statuses.Add(new StatusUpdate(status_update.Text));
            _statuses.Add(new StatusUpdate {
                Content = "a filler line",
                timeStamp = DateTime.Now
            });

            Console.WriteLine("Hello there");
        }

        public ObservableCollection<StatusUpdate> Statuses
        { get { return _statuses; } }


        public class StatusUpdate
        {
            public string Content
            { get; set; }
            public DateTime timeStamp
            { get; set; }
            public StatusUpdate() { }
            public StatusUpdate(string input)
            {
                timeStamp = DateTime.Now;
                Content = input;
            }
        }
    }
}
