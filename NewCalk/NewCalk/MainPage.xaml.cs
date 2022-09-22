using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NewCalk
{
    public partial class MainPage : ContentPage
    {
		int currentState = 1;
		string mathOperator;
		double firstNumber, secondNumber;
		public MainPage()
		{
			InitializeComponent();
			Clear(this, null);
		}
		void SelectNumber(object sender, EventArgs e)
		{
			Button button = (Button)sender;
			string pressed = button.Text;
            if (resultText.Text == "0" || currentState < 0)
            {
                resultText.Text = "";
                if (currentState < 0)
                    currentState *= -1;
            }
            resultText.Text += pressed;
			double number;
			if (double.TryParse(resultText.Text, out number))
			{
				if (currentState == 1)
				{
					firstNumber = number;
				}
				else
				{
					secondNumber = number;
				}
			}
		}
		void SelectOperator(object sender, EventArgs e)
		{
			currentState = -2;
			Button button = (Button)sender;
			string pressed = button.Text;
			mathOperator = pressed;
		}
		void Clear(object sender, EventArgs e)
		{
			firstNumber = 0;
			secondNumber = 0;
			currentState = 1;
			resultText.Text = "0";
		}
		void Calculate(object sender, EventArgs e)
		{
			if (currentState == 2)
			{
				var result = OperatorCalculator.Calculate(firstNumber, secondNumber, mathOperator);
				resultText.Text = result.ToString();
				firstNumber = result;
				currentState = -1;
			}
		}
	}
}