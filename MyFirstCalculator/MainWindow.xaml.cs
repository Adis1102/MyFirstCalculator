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
using System.Xaml;

namespace MyFirstCalculator
{
  
    public partial class MainWindow : Window
    {
        double numb1 = 0;
        double numb2 = 0;
        double result =0;
        string operation = "";          




        public MainWindow()
        {       
            InitializeComponent();
            txtbox_output.Text = numb1.ToString();




        }




        //Operator-Buttons
        #region
    private void plus_Click(object sender, RoutedEventArgs e)
    {
        operation = "+";

        if (!(result == 0))
        {
           numb1 = result;
           result = 0;
        }
    }

    private void minus_Click(object sender, RoutedEventArgs e)
    {
        operation = "-";

        if (!(result == 0))
        {
            numb1 = result;
            result = 0;
        }



    }

    private void multi_Click(object sender, RoutedEventArgs e)
    {
        operation = "x";

        if (!(result == 0))
        {
            numb1 = result;
            result = 0;
        }
    }

    private void divide_Click(object sender, RoutedEventArgs e)
    {
        operation = "/";

        if (!(result == 0))
        {
            numb1 = result;
            result = 0;
        }

    }

    private void equals_Click(object sender, RoutedEventArgs e)
    {

        switch (operation)
        {
            case "+":
                result = numb1 + numb2;
                txtbox_output.Text = result.ToString();
                operation = "";
                numb1 = numb2 = 0;
                break;

            case "-":
                result = numb1 - numb2;
                txtbox_output.Text = result.ToString();
                operation = "";
                numb1 = numb2 = 0;
                break;

            case "x":
                result = numb1 * numb2;
                txtbox_output.Text = result.ToString();
                operation = "";
                numb1 = numb2 = 0;
                break;

            case "/":
                result = numb1 / numb2;
                txtbox_output.Text = result.ToString();
                operation = "";
                numb1 = numb2 = 0;
                break;


        }
    }

    private void AC_Click(object sender, RoutedEventArgs e)
    {
        operation = "";
        numb1 = numb2 = result= 0;
        txtbox_output.Text = 0.ToString();
    }

    private void plusMinus_Click(object sender, RoutedEventArgs e)
    {
            if (operation == "" && result == 0)
            {
                numb1 *= -1;
                txtbox_output.Text = numb1.ToString();
            }
            else if (!(result == 0))
            {
                result *= -1;
                txtbox_output.Text = result.ToString();
            }

            else
            {
                numb2 *= -1;
                txtbox_output.Text = numb2.ToString();
            }
        }

        private void backSpace_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "" && result == 0)
            {
                numb1 /=10;
                txtbox_output.Text = numb1.ToString();
            }
            else if (!(result == 0))
            {
                result /=10;
                txtbox_output.Text = result.ToString();
            }

            else
            {
                numb2 /=10;
                txtbox_output.Text = numb2.ToString();
            }
        }

        private void comma_Click(object sender, RoutedEventArgs e)
        {
            

            //if (operation == "" && result == 0)
            //{
            //    txtbox_output.Text = numb1.ToString("C");
            //}
            
        }


        #endregion


        //Number-Buttons
        #region




        private void one_Click(object sender, RoutedEventArgs e)
    {
        if (operation == "")
        {
            numb1 = (numb1 * 10) + 1;
            txtbox_output.Text = numb1.ToString("N");
        }
        else
        {
            numb2 = (numb2 * 10) + 1;
            txtbox_output.Text = numb2.ToString();
        }
    }

    private void two_Click(object sender, RoutedEventArgs e)
    {
        if (operation == "")
        {
            numb1 = (numb1 * 10) + 2;
            txtbox_output.Text = numb1.ToString();
        }
        else
        {
            numb2 = (numb2 * 10) + 2;
            txtbox_output.Text = numb2.ToString();
        }

    }


    private void three_Click(object sender, RoutedEventArgs e)
    {
        if (operation == "")
        {
            numb1 = (numb1 * 10) + 3;
            txtbox_output.Text = numb1.ToString();
        }
        else
        {
            numb2 = (numb2 * 10) + 3;
            txtbox_output.Text = numb2.ToString();
        }
    }

    private void four_Click(object sender, RoutedEventArgs e)
    {
        if (operation == "")
        {
            numb1 = (numb1 * 10) + 4;
            txtbox_output.Text = numb1.ToString();
        }
        else
        {
            numb2 = (numb2 * 10) + 4;
            txtbox_output.Text = numb2.ToString();
        }
    }

    private void five_Click(object sender, RoutedEventArgs e)
    {
        if (operation == "")
        {
            numb1 = (numb1 * 10) + 5;
            txtbox_output.Text = numb1.ToString();
        }
        else
        {
            numb2 = (numb2 * 10) + 5;
            txtbox_output.Text = numb2.ToString();
        }
    }

    private void six_Click(object sender, RoutedEventArgs e)
    {
        if (operation == "")
        {
            numb1 = (numb1 * 10) + 6;
            txtbox_output.Text = numb1.ToString();
        }
        else
        {
            numb2 = (numb2 * 10) + 6;
            txtbox_output.Text = numb2.ToString();
        }
    }

    private void seven_Click(object sender, RoutedEventArgs e)
    {
        if (operation == "")
        {
            numb1 = (numb1 * 10) + 7;
            txtbox_output.Text = numb1.ToString();
        }
        else
        {
            numb2 = (numb2 * 10) + 7;
            txtbox_output.Text = numb2.ToString();
        }
    }

    private void eight_Click(object sender, RoutedEventArgs e)
    {
        if (operation == "")
        {
            numb1 = (numb1 * 10) + 8;
            txtbox_output.Text = numb1.ToString();
        }
        else
        {
            numb2 = (numb2 * 10) + 8;
            txtbox_output.Text = numb2.ToString();
        }
    }

    private void nine_Click(object sender, RoutedEventArgs e)
    {
        if (operation == "")
        {
            numb1 = (numb1 * 10) + 9;
            txtbox_output.Text = numb1.ToString();
        }
        else
        {
            numb2 = (numb2 * 10) + 9;
            txtbox_output.Text = numb2.ToString();
        }
    }


        

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                numb1 = (numb1 * 10);
                txtbox_output.Text = numb1.ToString();
            }
            else
            {
                numb2 = (numb2 * 10);
                txtbox_output.Text = numb2.ToString();
            }

        }

        #endregion

        
    }
}
