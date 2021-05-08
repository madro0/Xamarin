using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyCal
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            picker.Items.Add("Suma");
            picker.Items.Add("Resta");
            picker.Items.Add("Multiplicación");
            picker.Items.Add("División");
        }

        private void pickerSelectIndex(object seder, EventArgs e)
        {
            String pi = picker.SelectedIndex.ToString();
            int n1 = Int32.Parse(number1.Text);
            int n2 = Int32.Parse(number2.Text);
            double res = 0;

            
            switch (pi)
            {
                case "0":
                    res = n1 + n2;
                    break;
                case "1":
                    res =  n1 - n2;
                    break;
                case "2":
                    res = n1 * n2;
                    break;
                case "3":
                    res = n1 / n2;
                    break;
                default:
                    break;
            }

            txtResultado.Text = ""+res;

        }
    }
}
