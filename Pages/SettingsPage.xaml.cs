using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace EpicGamesLauncher.Pages
{
    /// <summary>
    /// Interaction logic for SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow != null)
                ((MainWindow) Application.Current.MainWindow).MainFrame.GoBack();
        }

        private void Hyperlink_OnRequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            if (((Hyperlink) e.Source).Inlines.FirstOrDefault() is Run run && !run.Text.Contains("Logs"))
                Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            else
            {
                Process.Start(new ProcessStartInfo(
                    $@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\EpicGamesLauncher\Saved\Logs"));
            }

            e.Handled = true;
        }
    }
}