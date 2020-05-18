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

namespace Wpf01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //InitializeComponent();
            //Grid grid = new Grid();
            //this.Content = grid;
            //Button btn = new Button();
            //btn.Width = 100;
            //btn.Height = 100;
            //btn.FontSize = 26;

            //WrapPanel wrapPanel = new WrapPanel();
            //TextBlock txt = new TextBlock();
            //txt.Text = "Multi";
            //txt.Foreground = Brushes.Blue;
            //wrapPanel.Children.Add(txt);

            //txt = new TextBlock();
            //txt.Text = "Color";
            //txt.Foreground = Brushes.Red;
            //wrapPanel.Children.Add(txt);

            //txt = new TextBlock();
            //txt.Text = "Button";
            //txt.Foreground = Brushes.White;
            //wrapPanel.Children.Add(txt);


            //btn.Content = wrapPanel;
            //grid.Children.Add(btn);


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thanks for the Click");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thanks for the Click-Direct Event");
        }
        //this is a bubbling event 
        private void Button_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Mouse button up/ was released- Bubbling event (Went up visual tree)");
        }

        private void Button_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Mouse button up/ was released-tunneling event (Goes down visual tree)");
        }

        private void Button_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(" Left mouse button down -tunneling event (Goes down visual tree)");

        }

        private void Button_PreviewMouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Right mouse button up/ was released-tunneling event (Goes down visual tree)");

        }
    }
}
