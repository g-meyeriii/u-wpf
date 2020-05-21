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
        //public int MyProperty 
        //{
        //    get { return (int)GetValue(myDependencyProperty); }
        //    set {SetValue(myDependencyProperty, value); }
        //}
        //public static readonly DependencyProperty myDependencyProperty =
        //    DependencyProperty.Register("MyProperty", typeof(int), typeof(MainWindow), new PropertyMetadata(0));

        //public Sum SumObject { get; set; }

        public MainWindow()
        {

            InitializeComponent();
          




            //comboBoxColors.ItemsSource = typeof(Colors).GetProperties();

            //List<Match> matches = new List<Match>();
            //matches.Add(new Match() { Team1 = "Bayern Munich  ", Team2 = "  Real Madrid", Score1 = 3, Score2 = 2, Completion = 85});
            //matches.Add(new Match() { Team1 = "PSG  ", Team2 = "  Barca", Score1 = 3, Score2 = 2, Completion = 55 });
            //matches.Add(new Match() { Team1 = "BVB Dortmund  ", Team2 = "  AS Roma", Score1 = 3, Score2 = 2, Completion = 25 });
            //matches.Add(new Match() { Team1 = "Man United  ", Team2 = "  LA Galaxy", Score1 = 1, Score2 = 1, Completion = 35 });

            //lbMatches.ItemsSource = matches;

            //SumObject = new Sum { Num1 = "1", Num2 = "3" };
            //this.DataContext = SumObject;



            //MySlider.Value = 30;
            //MyTextBox.Text = MySlider.Value.ToString();

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


            //}

            //private void Button_Click(object sender, RoutedEventArgs e)
            //{
            //    MessageBox.Show("Thanks for the Click");
            //}

            //private void Button_Click_1(object sender, RoutedEventArgs e)
            //{
            //    MessageBox.Show("Thanks for the Click-Direct Event");
            //}
            ////this is a bubbling event 
            //private void Button_MouseUp(object sender, MouseButtonEventArgs e)
            //{
            //    MessageBox.Show("Mouse button up/ was released- Bubbling event (Went up visual tree)");
            //}

            //private void Button_PreviewMouseUp(object sender, MouseButtonEventArgs e)
            //{
            //    MessageBox.Show("Mouse button up/ was released-tunneling event (Goes down visual tree)");
            //}

            //private void Button_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
            //{
            //    MessageBox.Show(" Left mouse button down -tunneling event (Goes down visual tree)");

            //}

            //private void Button_PreviewMouseRightButtonUp(object sender, MouseButtonEventArgs e)
            //{
            //    MessageBox.Show("Right mouse button up/ was released-tunneling event (Goes down visual tree)");

            //}

            //private void Button_Click_2(object sender, RoutedEventArgs e)
            //{

            //}
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Please say yes!");
        }
        private void RadioButton_Checked1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Please say yes!");
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thank you!!");
        }



        //public void cbAllCheckedChanged (object sender, RoutedEventArgs e)
        //{
        //    bool newVal = (cbAllToppings.IsChecked == true);
        //    cbPepporoni.IsChecked = newVal;
        //    cbMushroom.IsChecked = newVal;
        //    cbMozzarella.IsChecked = newVal;
        //    cbChicken.IsChecked = newVal;
        //    cbVeggie.IsChecked = newVal;
        //}

        //public void cbSingleCheckedChanged (object sender, RoutedEventArgs e)
        //{
        //    cbAllToppings.IsChecked = null;
        //    if((cbChicken.IsChecked ==true) && (cbMozzarella.IsChecked ==true)&& (cbMushroom.IsChecked == true) && (cbPepporoni.IsChecked == true)&&(cbVeggie.IsChecked==true))
        //    {
        //        cbAllToppings.IsChecked = true;
        //    }
        //    if ((cbChicken.IsChecked == false) && (cbMozzarella.IsChecked == false) && (cbMushroom.IsChecked == false) && (cbPepporoni.IsChecked == false) && (cbVeggie.IsChecked == false))
        //    {
        //        cbAllToppings.IsChecked = false;
        //    }
        //}
        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //if(lbMatches.SelectedItem != null)
        //{
        //    MessageBox.Show("Selected Match: "
        //        + (lbMatches.SelectedItem as Match).Team1 + " " +
        //         (lbMatches.SelectedItem as Match).Score1 + " " +
        //         (lbMatches.SelectedItem as Match).Score2 + " " +
        //         (lbMatches.SelectedItem as Match).Team2 
        //         );

        //}

        //}
    }


    //public class Match
    //{
    //    public int Score1 { get; set; }
    //    public int Score2 { get; set; }
    //    public string Team1 { get; set; }
    //    public string Team2 { get; set; }
    //    public int Completion { get; set; }
    //}

}
