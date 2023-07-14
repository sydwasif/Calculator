using System.Diagnostics;
using System.Drawing.Imaging;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using System.Data;
using System.Linq.Expressions;
using Microsoft.CodeAnalysis.FlowAnalysis;
using System.Collections.Immutable;

namespace AvaloniaApplication2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public string copyofans;
        public string a;
        DataTable dataTable = new DataTable();
        public void sevenn(object source, RoutedEventArgs args)
        {
            if (((Button)source).Content == "6")
            {

            }

            input.Text = input.Text + seven.Content.ToString();
        }
        public void eightt(object source, RoutedEventArgs args)
        {
            input.Text = input.Text + eight.Content.ToString();
        }
        public void ninee(object source, RoutedEventArgs args)
        {
            input.Text = input.Text + nine.Content.ToString();
        }

        public void fourr(object source, RoutedEventArgs args)
        {
            input.Text = input.Text + four.Content.ToString();
        }

        public void fivee(object source, RoutedEventArgs args)
        {
            input.Text = input.Text + five.Content.ToString();
        }

        public void sixx(object source, RoutedEventArgs args)
        {
            input.Text = input.Text + six.Content.ToString();
        }

        public void onee(object source, RoutedEventArgs args)
        {
            input.Text = input.Text + one.Content.ToString();
        }

        public void twoo(object source, RoutedEventArgs args)
        {
            input.Text = input.Text + two.Content.ToString();
        }

        public void threee(object source, RoutedEventArgs args)
        {
            input.Text = input.Text + three.Content.ToString();
        }


        public void zeroo(object source, RoutedEventArgs args)
        {
            input.Text = input.Text + zero.Content.ToString();
        }
        public void pointt(object source, RoutedEventArgs args)
        {
            input.Text = input.Text + point.Content.ToString();
        }

        public void pluss(object source, RoutedEventArgs args)
        {
            input.Text = input.Text + plus.Content.ToString();
        }

        public void devidee(object source, RoutedEventArgs args)
        {
            input.Text = input.Text + Devide.Content.ToString();
        }
        public void minuss(object source, RoutedEventArgs args)
        {
            input.Text = input.Text + minus.Content.ToString();
        }

        public void mull(object source, RoutedEventArgs args)
        {
            input.Text = input.Text + "*";
        }

        public void anss(object source, RoutedEventArgs args)
        {
            int a = 1;
            if (input.Text != "")
            {
                a = input.Text.Length;
                char b = input.Text[a - 1];
                if (b == '+' || b == '-' || b == '/' || b == '*')
                    input.Text = input.Text + copyofans;
            }
            else
            {
                input.Text = input.Text + copyofans;
            }


        }

        public void dell(object source, RoutedEventArgs args)
        {
            int a = input.Text.Length;
            input.Text = input.Text.Remove(a - 1);
            /*char[] phasee  = input.Text.ToCharArray();
            phasee[a - 1] = ' ';*/
            //input.Text = phasee.ToString();
        }

        public void Acc(object source, RoutedEventArgs args)
        {
            
            input.Text = "";
            outtt.Text = "";
            /*char[] phasee  = input.Text.ToCharArray();
            phasee[a - 1] = ' ';*/
            //input.Text = phasee.ToString();
        }

        public void equalss(object source, RoutedEventArgs args)
        {
            try
            {
                outtt.Text = dataTable.Compute(input.Text, "").ToString();
                copyofans = outtt.Text;
            }
            catch(Exception e)
            {
                outtt.Text = e.Message;
            }
            input.Text = "";
        }


    }
}