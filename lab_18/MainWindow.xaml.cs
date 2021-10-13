using System;
using System.Windows;

namespace lab18 {
				/// <summary>
				/// Логика взаимодействия для MainWindow.xaml
				/// </summary>
				public partial class MainWindow : Window {
								public MainWindow() {
												InitializeComponent();
								}

								private void button_Click(object sender, RoutedEventArgs e) {
												try {
																double x = Convert.ToDouble(xInput.Text);
																double y = Convert.ToDouble(yInput.Text);
																double f = Convert.ToDouble(fInput.Text);
																int n = Convert.ToInt32(nInput.Text);
																int k = Convert.ToInt32(kInput.Text);

																double z = 0;
																for(int i = 1; i < n; i++) 
																{
																				for(int j = 1; j < k; j++) {
																								z += Calc(x, y, f, i, j);
																				}
																}
																zLabel.Content = $"{z}";
												}
												catch(Exception) {
																zLabel.Content = "Error";
												}
								}

								private double Calc(double x, double y, double f, int i, int j)
								{
												double upper = Math.Sin(x) * Math.Pow(x, i) + Math.Pow(f, j) * Math.Pow(y, j);
												int lower = i * j;
												return upper / lower;
								}
				}
}
