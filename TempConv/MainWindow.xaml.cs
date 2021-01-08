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

namespace TempConv
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

        private void inputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            textValidateandcalculate();
        }
        public void textValidateandcalculate()
        {
            string input = inputTextBox.Text;
            double inputValue;
            if (inputTextBox.Text == "")
            {
                //Do nothing
            }
            else if (!double.TryParse(input, out inputValue))
            {
                MessageBox.Show("The value should be a double", "Wrong value", MessageBoxButton.OK, MessageBoxImage.Error);                
            }
            else
            {
                findResult();                
            }
        }
        public void findResult()
        {
            double inputValue = double.Parse( inputTextBox.Text);
            
               // celcius
               if ((inputCelcius.IsChecked == true)&& (outputCelcius.IsChecked == true))
               {
                   result.Content = inputTextBox.Text+" C";
               }
               else if((inputCelcius.IsChecked == true) &&(outputFarenheit.IsChecked==true))
               {
                   result.Content = ((inputValue * 9) / 5 + 32)+" C" ;
               }
               else if(inputCelcius.IsChecked == true&&(outputKelvin.IsChecked==true))
               {
                
                   result.Content = inputValue + 273;
               }

               // farenheit
               else if ((inputFarenheit.IsChecked == true) && (outputCelcius.IsChecked == true))
               {
                //Fahrenheit to Celsius: C = (F – 32) * 5 / 9;
                    result.Content = ((inputValue - 32) * 5 / 9) + " F";
               }
            else if ((inputFarenheit.IsChecked == true) && (outputFarenheit.IsChecked == true))
               {
                result.Content = inputTextBox.Text+" F";

               }
               else if (inputFarenheit.IsChecked == true && (outputKelvin.IsChecked == true))
               {
                //273.5 + ((F - 32.0) * (5.0/9.0));
                result.Content = (273.5+((inputValue-32)*(5/9))) + " F";
            }

            // kelvin
            else if ((inputKelvin.IsChecked == true) && (outputCelcius.IsChecked == true))
               {
                result.Content = (inputValue - 273) + " K";
            }
               else if ((inputKelvin.IsChecked == true) && (outputFarenheit.IsChecked == true))
               {
                //(1K − 273.15) × 9/5 + 32
                result.Content = ((inputValue-273.15)*9/5+32) + " K";
            }
            else if (inputKelvin.IsChecked == true && (outputKelvin.IsChecked == true))
               {
                result.Content = inputTextBox.Text + " K";
               }
               
        }

        private void inputCelcius_Checked(object sender, RoutedEventArgs e)
        {
            textValidateandcalculate();
        }

        private void inputFarenheit_Checked(object sender, RoutedEventArgs e)
        {
            textValidateandcalculate();
        }

        private void inputKelvin_Checked(object sender, RoutedEventArgs e)
        {
            textValidateandcalculate();
        }

        private void outputCelcius_Checked(object sender, RoutedEventArgs e)
        {
            textValidateandcalculate();
        }

        private void outputFarenheit_Checked(object sender, RoutedEventArgs e)
        {
            textValidateandcalculate();
        }

        private void outputKelvin_Checked(object sender, RoutedEventArgs e)
        {
            textValidateandcalculate();
        }
    }
}
