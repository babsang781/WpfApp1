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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> list = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SetBubblingTextBox()
        {
            txtBubbling.Text = string.Join(" > ", list);
            ClearList();
        }

        private async void ClearList()
        {
            await Task.Delay(500);
            list.Clear();
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            list.Add("btn");
            SetBubblingTextBox();
        }

        private void Border1_Click(object sender, RoutedEventArgs e)
        {
            list.Add("border");
            SetBubblingTextBox();
            e.Handled = false;
        }
        private void Rectangle1_Click(object sender, RoutedEventArgs e)
        {
            list.Add("rectangle");
            SetBubblingTextBox();
        }

        private void SetTunnelingTextBox()
        {
            txtTunneling.Text = string.Join(" > ", list);
            ClearList();
        }


        private void btn2_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            list.Add("btn2");
            SetTunnelingTextBox();
        }
        private void Border2_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            list.Add("border2");
            SetTunnelingTextBox();
            e.Handled = true;
        }
        private void rectangle2_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            list.Add("rectangle2");
            SetTunnelingTextBox();
        }
    }
}
