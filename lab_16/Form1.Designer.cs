namespace lab16
{
				partial class Form1
				{
								/// <summary>
								/// Обязательная переменная конструктора.
								/// </summary>
								private System.ComponentModel.IContainer components = null;

								/// <summary>
								/// Освободить все используемые ресурсы.
								/// </summary>
								/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
								protected override void Dispose(bool disposing)
								{
												if(disposing && (components != null))
												{
																components.Dispose();
												}
												base.Dispose(disposing);
								}

								#region Код, автоматически созданный конструктором форм Windows

								/// <summary>
								/// Требуемый метод для поддержки конструктора — не изменяйте 
								/// содержимое этого метода с помощью редактора кода.
								/// </summary>
								private void InitializeComponent()
								{
												this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
												this.button1 = new System.Windows.Forms.Button();
												this.dataGrid = new System.Windows.Forms.DataGridView();
												this.dataSummary = new System.Windows.Forms.DataGridView();
												this.label1 = new System.Windows.Forms.Label();
												this.withoutDebtsCount = new System.Windows.Forms.Label();
												((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
												((System.ComponentModel.ISupportInitialize)(this.dataSummary)).BeginInit();
												this.SuspendLayout();
												// 
												// openFileDialog1
												// 
												this.openFileDialog1.FileName = "openFileDialog1";
												// 
												// button1
												// 
												this.button1.Location = new System.Drawing.Point(40, 376);
												this.button1.Name = "button1";
												this.button1.Size = new System.Drawing.Size(146, 23);
												this.button1.TabIndex = 0;
												this.button1.Text = "Загрузить данные";
												this.button1.UseVisualStyleBackColor = true;
												this.button1.Click += new System.EventHandler(this.button1_Click);
												// 
												// dataGrid
												// 
												this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
												this.dataGrid.Location = new System.Drawing.Point(40, 12);
												this.dataGrid.Name = "dataGrid";
												this.dataGrid.Size = new System.Drawing.Size(385, 336);
												this.dataGrid.TabIndex = 1;
												// 
												// dataSummary
												// 
												this.dataSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
												this.dataSummary.Location = new System.Drawing.Point(431, 12);
												this.dataSummary.Name = "dataSummary";
												this.dataSummary.Size = new System.Drawing.Size(357, 282);
												this.dataSummary.TabIndex = 2;
												// 
												// label1
												// 
												this.label1.AutoSize = true;
												this.label1.Location = new System.Drawing.Point(432, 316);
												this.label1.Name = "label1";
												this.label1.Size = new System.Drawing.Size(204, 13);
												this.label1.TabIndex = 3;
												this.label1.Text = "Кол-во студентов без задолженностей";
												// 
												// withoutDebtsCount
												// 
												this.withoutDebtsCount.AutoSize = true;
												this.withoutDebtsCount.Location = new System.Drawing.Point(643, 315);
												this.withoutDebtsCount.Name = "withoutDebtsCount";
												this.withoutDebtsCount.Size = new System.Drawing.Size(0, 13);
												this.withoutDebtsCount.TabIndex = 4;
												// 
												// Form1
												// 
												this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
												this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
												this.ClientSize = new System.Drawing.Size(800, 411);
												this.Controls.Add(this.withoutDebtsCount);
												this.Controls.Add(this.label1);
												this.Controls.Add(this.dataSummary);
												this.Controls.Add(this.dataGrid);
												this.Controls.Add(this.button1);
												this.Name = "Form1";
												this.Text = "Form1";
												((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
												((System.ComponentModel.ISupportInitialize)(this.dataSummary)).EndInit();
												this.ResumeLayout(false);
												this.PerformLayout();

								}

								#endregion

								private System.Windows.Forms.OpenFileDialog openFileDialog1;
								private System.Windows.Forms.Button button1;
								private System.Windows.Forms.DataGridView dataGrid;
								private System.Windows.Forms.DataGridView dataSummary;
								private System.Windows.Forms.Label label1;
								private System.Windows.Forms.Label withoutDebtsCount;
				}
}

