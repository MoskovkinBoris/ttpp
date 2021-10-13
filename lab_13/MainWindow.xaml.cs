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

namespace lab_13
{
				/// <summary>
				/// Логика взаимодействия для MainWindow.xaml
				/// </summary>
				public partial class MainWindow : Window
				{
								public MainWindow()
								{
												InitializeComponent();
												Equality1Radio.IsChecked = true;
								}

								private void Button_Click(object sender, RoutedEventArgs e)
								{
												double z = 0;

												try
												{
																if((bool) Equality1Radio.IsChecked)
																{
																				z = CalcEq1();
																}
																else if((bool) Equality2Radio.IsChecked)
																{
																				z = CalcEq2();
																}
																AnswerInput.Text = z.ToString();
												} catch {
																z = 0;
																AnswerInput.Text = "Error";
												}
								}

								private double CalcEq1() 
								{
												double x = Convert.ToDouble(XInput.Text);
												double y = Convert.ToDouble(YInput.Text);
												int n = Convert.ToInt32(NInput.Text);
												int divider = 2;
												double result = (y / divider) * -1;
												for(int i = 1; i < n; i++)
												{
																if((i + 1) % 2 == 0)
																{
																				result += Math.Pow(x, i) / divider;
																}
																else
																{
																				result -= Math.Pow(y, i) / divider;
																}
																divider *= 3;
												}

												return result;
								}

								private double CalcEq2()
								{
												int n = Convert.ToInt32(NInput.Text);
												int r = Convert.ToInt32(RInput.Text);
												double a = Convert.ToDouble(AInput.Text);
												double b = Convert.ToDouble(BInput.Text);
												double c = Convert.ToDouble(CInput.Text);

												double result = 0;

												for(int i = 1; i < n; i++)
												{
																double seqEl = 0;
																for(int j = 1; j < r; j++)
																{
																				seqEl = (a * i + b * j) / (c * Math.Pow(i, j));
																				result += seqEl;
																}
												}

												return result;
								}
				}
}
