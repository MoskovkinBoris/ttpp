using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab16
{
				public partial class Form1 : Form
				{
								public Form1()
								{
												InitializeComponent();
								}

								private void button1_Click(object sender, EventArgs e)
								{
												openFileDialog1.InitialDirectory = Application.StartupPath;
												if(openFileDialog1.ShowDialog() == DialogResult.OK)
												{
																ShowData(openFileDialog1.FileName);
												}
								}

								private void ShowData(string dataFilePath)
								{
												try
												{
																DataProvider provider = DataProvider.GetDataProvider(dataFilePath);

																dataGrid.DataSource = provider.GetFileData();
																dataGrid.ReadOnly = true;

																dataSummary.DataSource = provider.GetSummaryData();
																dataSummary.ReadOnly = true;

																withoutDebtsCount.Text = provider.WithoutDebts.ToString();
												}
												catch(Exception)
												{
																MessageBox.Show("Что-то пошло не так");
												}
								}
				}
}
