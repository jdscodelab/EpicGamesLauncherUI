using System.Windows;

namespace EpicGamesLauncher.Style
{
    partial class Window
    {
        public Window()
        {
            InitializeComponent();
        }

        private void MinimizeButton_OnClick(object sender, RoutedEventArgs e)
        {
            var window = (System.Windows.Window) ((FrameworkElement) sender).TemplatedParent;
            window.WindowState = WindowState.Minimized;
        }

        private void MaximizeRestoreButton_OnClick(object sender, RoutedEventArgs e)
        {
            var window = (System.Windows.Window) ((FrameworkElement) sender).TemplatedParent;
            window.WindowState = window.WindowState == WindowState.Normal ? WindowState.Maximized : WindowState.Normal;
        }

        private void CloseButton_OnClick(object sender, RoutedEventArgs e)
        {
            var window = (System.Windows.Window) ((FrameworkElement) sender).TemplatedParent;
            window.Close();
        }
    }
}