using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;

namespace PC_Info
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //user
            try
            {
                UserLabelC.Content = HwFinder.GetUser();
            }
            catch
            {
                MessageBox.Show("Could not detect user.                            ", "User error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            //OS
            try
            {
                OSLabelC.Content = HwFinder.GetOS();
            }
            catch
            {
                MessageBox.Show("Could not detect operating system.                ", "OS error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            //cpu
            try
            {
                CPULabelC.Content = HwFinder.GetCpu();
            }
            catch
            {
                MessageBox.Show("Could not detect processor.                       ", "CPU error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            //gpu
            try
            {
                GPULabelC.Content = HwFinder.GetGpu();
            }
            catch
            {
                MessageBox.Show("Could not detect graphic card.                    ", "GPU error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            //ram
            try
            {
                RAMLabelC.Content = HwFinder.GetRam();
            }
            catch
            {
                MessageBox.Show("Could not detect RAM.                             ", "RAM error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            //mb
            try
            {
                MBLabelC.Content = HwFinder.GetMB();
            }
            catch
            {
                MessageBox.Show("Could not detect motherboard.                     ", "Motherboard error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            Help.ToolTip = "Hotkeys:\n----------------------------------\nESC - Close app\nS - Save all data to clipboard\nCTRL+S - Save data to desktop";
            UserLabelC.ToolTip = "Click for save to clipboard";
            OSLabelC.ToolTip = "Click for save to clipboard";
            CPULabelC.ToolTip = "Click for save to clipboard";
            GPULabelC.ToolTip = "Click for save to clipboard";
            RAMLabelC.ToolTip = "Click for save to clipboard";
            MBLabelC.ToolTip = "Click for save to clipboard";
        }


        // ********************** ICONS CLICK ********************** \\
        private void SaveDesktop_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Saver.SaveToDesktop(this);
            MessageBox.Show("Data saved to desktop...                          ");
        }

        private void SaveClipboard_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Saver.SaveToClipboard(this);
            MessageBox.Show("Data saved to clipboard...                        ");
        }


        // ********************** SHORTCUTS ********************** \\
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                this.Close();

            else if (e.Key == Key.S && Keyboard.IsKeyDown(Key.LeftCtrl))
            {
                Saver.SaveToDesktop(this);
                MessageBox.Show("Data saved to desktop...                          ");
            }

            else if (e.Key == Key.S)
            {
                Saver.SaveToClipboard(this);
                MessageBox.Show("Data saved to clipboard...                        ");
            }
        }

        // ********************** OK BUTTON ********************** \\
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // ********************* ITEM CLICK ********************** \\
        private void Item_Click(object sender, MouseButtonEventArgs e) 
        {
            if (((Label)sender).Name == "UserLabelC") 
            {
                Clipboard.SetText(Environment.UserName.ToString());
            }
            else
                Clipboard.SetText(((Label)sender).Content.ToString());
        }
    }
}