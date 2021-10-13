using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab17 {
				public partial class Form1 : Form {
								private Point location = new Point(50, 50);
								private int Radius = 100;
								private static int center = 100;
								private static int step = 75;
								Boolean isDropStarted = false;

								private Figure xAxis;
								private Figure yAxis;

								private Figure ellipse;
								private Figure lineDiagonal;
								private Figure lineSide;
								private Figure lineUpper;

								Rectangle boundings = new Rectangle(new Point(center, center), new Size(step * 2, step * 2));
								Figure pie = new Figure();


								public Form1() {
												InitializeComponent();
												Paint += Form1_Paint;
												MouseDown += Form1_MouseDown;
												MouseUp += RedrawElips;
												MouseMove += RedrawElips;
												MouseUp += Form1_MouseUp;
								}

								private void Form1_MouseUp(object sender, MouseEventArgs e) {
												isDropStarted = false;
								}

								private void RedrawElips(object sender, MouseEventArgs e) {
												if (isDropStarted) {
																location.X = e.X + Radius / 2;
																location.Y = e.Y + Radius / 2;
																Invalidate();
												}
												Refresh();
								}

								private void Form1_MouseDown(object sender, MouseEventArgs e) {
												int currentX = e.X;
												int currentY = e.Y;
												Boolean isInX = (currentX >= location.X - Radius && currentX <= location.X + Radius);
												Boolean isInY = (currentY >= location.Y - Radius && currentY <= location.Y + Radius);

												if (isInX && isInY) {
																isDropStarted = true;
												}
								}

								private void Form1_Paint(object sender, PaintEventArgs eventArgs) {
												Graphics graphics = eventArgs.Graphics;
												Pen filling = new Pen(Color.Black, 2);
												Pen axisFilling = new Pen(Color.Gray, 2);
												
												ellipse = new Figure();
												ellipse.Path.AddEllipse(new Rectangle(center, center, step * 2, step * 2));
												lineDiagonal = new Figure();
												RectangleF ellipseBoundings = ellipse.Path.GetBounds();
												lineDiagonal.Path.AddLine(center + step * 2, ellipseBoundings.Location.Y, ellipseBoundings.Location.X, center + step * 2);
												lineUpper = new Figure();
												lineUpper.Path.AddLine(center, ellipseBoundings.Top, center + step * 2 + 20, ellipseBoundings.Left);
												lineSide = new Figure();
												lineSide.Path.AddLine(ellipseBoundings.Right, ellipseBoundings.Top - 20, ellipseBoundings.Right, ellipseBoundings.Bottom);

												int start = 20;
												float length = (float) (step * 4.5);
												int centerPoint = center + step;
												graphics.DrawLine(axisFilling, start, centerPoint, length, centerPoint);
												graphics.DrawLine(axisFilling, centerPoint, start, centerPoint, length);
												graphics.DrawEllipse(filling, center, center, step * 2, step * 2);
												graphics.DrawLine(filling, center + step * 2, ellipseBoundings.Location.Y, ellipseBoundings.Location.X, center + step * 2);
												graphics.DrawLine(filling, center, ellipseBoundings.Top, center + step * 2 + 20, ellipseBoundings.Left);
												graphics.DrawLine(filling, ellipseBoundings.Right, ellipseBoundings.Top - 20, ellipseBoundings.Right, ellipseBoundings.Bottom);

												
												pie.Path.AddPie(boundings, 90, 45);
												Point pos = PointToClient(Cursor.Position);	
												bool isMouseIn = pie.Path.IsVisible(pos);


												graphics.FillPie(new SolidBrush(isMouseIn ? Color.Green : Color.Blue), boundings, 90, 45);
								}

								class Figure {
												public GraphicsPath Path = new GraphicsPath();

												public PointF Center {
																get {
																				var rect = Path.GetBounds();
																				return new PointF(rect.X + rect.Width / 2, rect.Y + rect.Height / 2);
																}
												}

												public Region Region {
																get { return new Region(Path); }
												}
								}
				}
}
