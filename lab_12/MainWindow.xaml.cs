using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab_12
{
				/// <summary>
				/// Логика взаимодействия для MainWindow.xaml
				/// </summary>
				public partial class MainWindow : Window
				{
								public MainWindow()
								{
												InitializeComponent();
								}

								private void Calc()
								{
												try
												{
																int w = 0;
																int f = 0;
																int e = 0;
																bool canW = int.TryParse(wTextBox.Text, out w);
																bool canF = int.TryParse(fTextBox.Text, out f);
																bool canE = int.TryParse(eTextBox.Text, out e);

																if(!canW || !canF || !canW) throw new Exception("Cannot parse to int");

																Point mousePosition = Mouse.GetPosition(this);
																int y = (int) mousePosition.Y;

																double sqrtFEW = Math.Sqrt(Math.Abs((f - e) / w));
																double sinEW2 = Math.Pow(Math.Sin(e / w), 2);
																double cosY = Math.Cos(y);

																double U = sqrtFEW + Math.Abs(sinEW2 + cosY);

																Title = $"{U}";
												}
												catch
												{
																Title = "ERROR";
												}
								}

								private void Button_Click(object sender, RoutedEventArgs e)
								{
												Calc();
								}

        private void fTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
