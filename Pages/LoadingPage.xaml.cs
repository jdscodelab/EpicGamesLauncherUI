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
using System.Windows.Threading;

namespace EpicGamesLauncher.Pages
{
    /// <summary>
    /// Interaction logic for LoadingPage.xaml
    /// </summary>
    public partial class LoadingPage : Page
    {
        readonly DispatcherTimer _dispatcherTimer = new DispatcherTimer();
        public LoadingPage()
        {
            InitializeComponent();
            _dispatcherTimer.Tick += _dispatcherTimer_Tick;
            _dispatcherTimer.Interval = new TimeSpan(0, 0, 5);
            _dispatcherTimer.Start();
        }

        private void _dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (Application.Current.MainWindow != null)
                ((MainWindow) Application.Current.MainWindow).MainFrame.Navigate(new Uri("Pages/SignInPage.xaml",
                    UriKind.RelativeOrAbsolute));
            _dispatcherTimer.Stop();
        }
    }
}
