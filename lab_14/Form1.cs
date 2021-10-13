using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_14_WindowsForms
{
				public partial class Form1 : Form
				{
								public Form1()
								{
												InitializeComponent();
												this.MouseMove += Form_MouseMove;
								}

								private void button1_Click(object sender, EventArgs e)
								{
												string result = String.Empty;
												try
												{

																int x = Convert.ToInt32(this.xText.Text);
																int y = Convert.ToInt32(this.yText.Text);
																int z = Convert.ToInt32(this.zText.Text);

																int a = Convert.ToInt32(this.aCombobox.SelectedItem);
																int b = Convert.ToInt32(this.bCombobox.SelectedItem);

																double res = ((a * x) / b) + (b * y / x) + Math.Sin(x);
																result = res.ToString();
												}
												catch(Exception)
												{
																result = "Error";
												}

												this.Text = result;
								}

								

								private void yContext_Click(object sender, EventArgs e)
								{

								}

								int formulaIdx = 0;

								private void Form_MouseMove(object sender, MouseEventArgs e)
								{
												double res = 0;
												try
												{
																switch(formulaIdx)
																{
																				case 0:
																								// z
																								res = Math.Pow(e.X, 4);
																								break;
																				case 1:
																								// zSqrt
																								res = Math.Sqrt(e.X / e.Y) + Math.Pow(e.Y, 2);
																								break;
																				case 2:
																								// f
																								res = Math.Pow(e.Y, 3);
																								break;
																				default:
																								break;
																}
												}
												catch(Exception)
												{
																this.mouse.Text = "Error";
												}
												this.mouse.Text = $"x: {e.X} y: {e.Y}; {res}";
								}

								private void z_Click(object sender, EventArgs e)
								{
												this.z.Checked = true;
												this.zSqrt.Checked = false;
												this.f.Checked = false;
												formulaIdx = 0;
								}

								private void zSqrt_Click(object sender, EventArgs e)
								{
												this.zSqrt.Checked = true;
												this.z.Checked = false;
												this.f.Checked = false;

												formulaIdx = 1;
								}

								private void f_Click(object sender, EventArgs e)
								{
												this.f.Checked = true;
												this.z.Checked = false;
												this.zSqrt.Checked = false;

												formulaIdx = 2;
								}
				}
}
