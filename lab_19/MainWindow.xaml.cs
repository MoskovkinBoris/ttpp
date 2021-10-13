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

namespace lab19 {
				/// <summary>
				/// Логика взаимодействия для MainWindow.xaml
				/// </summary>
				public partial class MainWindow : Window {
								private int shapesAmount = 0;

								public MainWindow() {
												InitializeComponent();
								}

								private void button_Click(object sender, RoutedEventArgs e) {
												try {
																shapesAmount = Convert.ToInt32(shapesCount.Text);
												}
												catch(Exception) {
																Title = "Should be a number";
												}
												DrawShapes();
								}

								private void DrawShapes() {
												Random rndShapeType = new Random(DateTime.Now.Millisecond);
												Random rndStyle = new Random(DateTime.Now.Second);
												Random rndPosition = new Random(DateTime.Now.Minute);
												Random rndSize = new Random(DateTime.Now.Minute);

												for(int i  = 0; i < shapesAmount; i++) {
																int shapeType = rndShapeType.Next(0, 2);

																Shape currentShape = shapeType == 0 ? (Shape) new Ellipse() : (Shape) new Rectangle();
																int shapeStyle = rndStyle.Next(0, 4) + 1;
																String styleName = $"style{shapeStyle}";
																Style currentStyle = (Style) this.FindResource(styleName);

																currentShape.Style = currentStyle;
																currentShape.Width = rndSize.Next(10, 200);
																currentShape.Height = rndSize.Next(10, 100);

																canvas.Children.Add(currentShape);
																Canvas.SetLeft(currentShape, rndPosition.Next(5, 750));
																Canvas.SetTop(currentShape, rndPosition.Next(5, 350));
												}
								}
				}
}
