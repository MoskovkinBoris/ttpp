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
using System.Windows.Shapes;

namespace lab15
{
				/// <summary>
				/// Логика взаимодействия для EnterNumbers.xaml
				/// </summary>
				public partial class EnterNumbers : Window
				{
								public EnterNumbers()
								{
												InitializeComponent();
								}

								public int NumbersCount
								{
												get
												{
																return  Convert.ToInt32(numbersInput.Text);
												}
								}

								public int X
								{
												get
												{
																return Convert.ToInt32(xInput.Text);
												}
								}

								private void Button_Click(object sender, RoutedEventArgs e)
								{
												DialogResult = true;
								}
				}
}
