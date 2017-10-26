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

namespace Calculator_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Addition_Click(object sender, RoutedEventArgs e)
        {
            double Result;
            double number1 = double.Parse(Textbox1.Text);
            double number2 = double.Parse(Textbox2.Text);
            Result = number1 + number2;
            Textblock3.Text = Result.ToString();
            // Had to convert the double variables into a text first
            //Had to convert the answer or results into a string as well
        }

        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            double Result;
            double number1 = double.Parse(Textbox1.Text);
            double number2 = double.Parse(Textbox2.Text);
            Result = number1 - number2;
            Textblock3.Text = Result.ToString();
            // Had to convert the double variables into a text first
            //Had to convert the answer or results into a string as well
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            double Result;
            double number1 = double.Parse(Textbox1.Text);
            double number2 = double.Parse(Textbox2.Text);
            Result = number1 * number2;
            Textblock3.Text = Result.ToString();
            // Had to convert the double variables into a text first
            //Had to convert the answer or results into a string as well
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            double Result;
            double number1 = double.Parse(Textbox1.Text);
            double number2 = double.Parse(Textbox2.Text);
            Result = number1 / number2;
            Textblock3.Text = Result.ToString();
            // Had to convert the double variables into a text first
            //Had to convert the answer or results into a string as well
        }


        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Textbox1.Clear();
            Textbox2.Clear();
            Textblock3.Text = "";
            //Textblock does not have a clear function so you can just replace it with a space
        }
    }
}
