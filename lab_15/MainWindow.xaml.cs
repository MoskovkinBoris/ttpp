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

namespace lab15
{
				/// <summary>
				/// Логика взаимодействия для MainWindow.xaml
				/// </summary>
				public partial class MainWindow : Window
				{
								private int NumbersCount = 0;
								private double Result = 0.0;
								private int x = 0;

								public MainWindow()
								{
												InitializeComponent();
								}

								private void Calc()
								{
												for(int i = 0; i < NumbersCount; i++)
												{
																if(i % 2 == 0)
																{
																				int devider = i * 2 + 1;
																				Result -= Math.Sin(Math.Pow(x, i * 2)) / ((i + 1) * devider);
																}
																else
																{
																				Result += (Math.Pow(x, i * 2)) / (i * (i * 2 + 1));
																}
												}

												ResultWindow resultWindow = new ResultWindow();
												resultWindow.Result = Result.ToString();
												if(resultWindow.ShowDialog() == true)
												{
																Result = 0.0;
												}
								}

								private void Button_Click(object sender, RoutedEventArgs e)
								{
												EnterNumbers enterNumbersWindow = new EnterNumbers();

												if(enterNumbersWindow.ShowDialog() == true)
												{
																NumbersCount = enterNumbersWindow.NumbersCount;
																x = enterNumbersWindow.X;
																Calc();
												}
												else
												{
																Result = 0.0;
																x = 0;
												}
								}
				}
}
