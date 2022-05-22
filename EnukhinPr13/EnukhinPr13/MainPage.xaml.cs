using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EnukhinPr13
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            TapGestureRecognizer tapGesture = new TapGestureRecognizer
            {
                NumberOfTapsRequired = 1
            };

            int count = 0;  // счетчик нажатий
            tapGesture.Tapped += (s, e) =>
            {
                count++;
                lablePow.Text = $"Тапов: {count}, 2 в стпепени {count}: {Math.Pow(2,count)}";
            };
            lablePow.GestureRecognizers.Add(tapGesture);
        }
        private void ButtonFactorial_Clicked(object sender, EventArgs e)
        {
            if (ulong.TryParse(entryNumber.Text, out ulong factorial))
            {
                lableFactorial.TextColor = Color.Black;
                lableFactorial.Text = $"Факториал числа {factorial}: {Factorial(factorial)}";

            }
            else
            {
                lableFactorial.TextColor = Color.Red;
                lableFactorial.Text = "Вы ввели не число";
            }
        }

        ulong Factorial(ulong number)
        {
            if (number <= 0)
                return 1;
            else
                return number * Factorial(number - 1);
        }
    }
}
