namespace lab_14_WindowsForms
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
												this.components = new System.ComponentModel.Container();
												this.toolStrip1 = new System.Windows.Forms.ToolStrip();
												this.xText = new System.Windows.Forms.ToolStripTextBox();
												this.yText = new System.Windows.Forms.ToolStripTextBox();
												this.zText = new System.Windows.Forms.ToolStripTextBox();
												this.aCombobox = new System.Windows.Forms.ToolStripComboBox();
												this.bCombobox = new System.Windows.Forms.ToolStripComboBox();
												this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
												this.xContext = new System.Windows.Forms.ToolStripTextBox();
												this.yContext = new System.Windows.Forms.ToolStripTextBox();
												this.zContext = new System.Windows.Forms.ToolStripTextBox();
												this.aContext = new System.Windows.Forms.ToolStripComboBox();
												this.bContext = new System.Windows.Forms.ToolStripComboBox();
												this.button1 = new System.Windows.Forms.Button();
												this.statusStrip1 = new System.Windows.Forms.StatusStrip();
												this.mouseFormule = new System.Windows.Forms.ToolStripDropDownButton();
												this.z = new System.Windows.Forms.ToolStripMenuItem();
												this.f = new System.Windows.Forms.ToolStripMenuItem();
												this.zSqrt = new System.Windows.Forms.ToolStripMenuItem();
												this.mouse = new System.Windows.Forms.ToolStripStatusLabel();
												this.toolStrip1.SuspendLayout();
												this.contextMenu.SuspendLayout();
												this.statusStrip1.SuspendLayout();
												this.SuspendLayout();
												// 
												// toolStrip1
												// 
												this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xText,
            this.yText,
            this.zText,
            this.aCombobox,
            this.bCombobox});
												this.toolStrip1.Location = new System.Drawing.Point(0, 0);
												this.toolStrip1.Name = "toolStrip1";
												this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
												this.toolStrip1.Size = new System.Drawing.Size(1142, 25);
												this.toolStrip1.TabIndex = 0;
												this.toolStrip1.Text = "toolStrip1";
												// 
												// xText
												// 
												this.xText.Font = new System.Drawing.Font("Segoe UI", 9F);
												this.xText.Name = "xText";
												this.xText.Size = new System.Drawing.Size(100, 25);
												// 
												// yText
												// 
												this.yText.Font = new System.Drawing.Font("Segoe UI", 9F);
												this.yText.Name = "yText";
												this.yText.Size = new System.Drawing.Size(100, 25);
												// 
												// zText
												// 
												this.zText.Font = new System.Drawing.Font("Segoe UI", 9F);
												this.zText.Name = "zText";
												this.zText.Size = new System.Drawing.Size(100, 25);
												// 
												// aCombobox
												// 
												this.aCombobox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
												this.aCombobox.Name = "aCombobox";
												this.aCombobox.Size = new System.Drawing.Size(121, 25);
												// 
												// bCombobox
												// 
												this.bCombobox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
												this.bCombobox.Name = "bCombobox";
												this.bCombobox.Size = new System.Drawing.Size(121, 25);
												// 
												// contextMenu
												// 
												this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xContext,
            this.yContext,
            this.zContext,
            this.aContext,
            this.bContext});
												this.contextMenu.Name = "contextMenu";
												this.contextMenu.Size = new System.Drawing.Size(182, 133);
												// 
												// xContext
												// 
												this.xContext.Font = new System.Drawing.Font("Segoe UI", 9F);
												this.xContext.Name = "xContext";
												this.xContext.Size = new System.Drawing.Size(100, 23);
												this.xContext.Text = "x";
												// 
												// yContext
												// 
												this.yContext.Font = new System.Drawing.Font("Segoe UI", 9F);
												this.yContext.Name = "yContext";
												this.yContext.Size = new System.Drawing.Size(100, 23);
												this.yContext.Text = "y";
												this.yContext.Click += new System.EventHandler(this.yContext_Click);
												// 
												// zContext
												// 
												this.zContext.Font = new System.Drawing.Font("Segoe UI", 9F);
												this.zContext.Name = "zContext";
												this.zContext.Size = new System.Drawing.Size(100, 23);
												this.zContext.Text = "z";
												// 
												// aContext
												// 
												this.aContext.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
												this.aContext.Name = "aContext";
												this.aContext.Size = new System.Drawing.Size(121, 23);
												this.aContext.ToolTipText = "a";
												// 
												// bContext
												// 
												this.bContext.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
												this.bContext.Name = "bContext";
												this.bContext.Size = new System.Drawing.Size(121, 23);
												this.bContext.ToolTipText = "b";
												// 
												// button1
												// 
												this.button1.Location = new System.Drawing.Point(581, 2);
												this.button1.Name = "button1";
												this.button1.Size = new System.Drawing.Size(75, 23);
												this.button1.TabIndex = 2;
												this.button1.Text = "Calculate";
												this.button1.UseVisualStyleBackColor = true;
												this.button1.Click += new System.EventHandler(this.button1_Click);
												// 
												// statusStrip1
												// 
												this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mouseFormule,
            this.mouse});
												this.statusStrip1.Location = new System.Drawing.Point(0, 428);
												this.statusStrip1.Name = "statusStrip1";
												this.statusStrip1.Size = new System.Drawing.Size(1142, 22);
												this.statusStrip1.TabIndex = 3;
												this.statusStrip1.Text = "statusStrip1";
												// 
												// mouseFormule
												// 
												this.mouseFormule.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
												this.mouseFormule.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zSqrt,
            this.f,
            this.z});
												this.mouseFormule.ImageTransparentColor = System.Drawing.Color.Magenta;
												this.mouseFormule.Name = "mouseFormule";
												this.mouseFormule.Size = new System.Drawing.Size(64, 20);
												this.mouseFormule.Text = "Formula";
												this.mouseFormule.ToolTipText = "Formula\r\n";
												// 
												// z
												// 
												this.z.Checked = true;
												this.z.CheckState = System.Windows.Forms.CheckState.Checked;
												this.z.Name = "z";
												this.z.Size = new System.Drawing.Size(186, 22);
												this.z.Text = "z = x^4";
												this.z.Click += new System.EventHandler(this.z_Click);
												// 
												// f
												// 
												this.f.Name = "f";
												this.f.Size = new System.Drawing.Size(186, 22);
												this.f.Text = "f = y^3";
												this.f.Click += new System.EventHandler(this.f_Click);
												// 
												// zSqrt
												// 
												this.zSqrt.Name = "zSqrt";
												this.zSqrt.Size = new System.Drawing.Size(186, 22);
												this.zSqrt.Text = "z = sqrt((x \\ y) + y^2)";
												this.zSqrt.Click += new System.EventHandler(this.zSqrt_Click);
												// 
												// mouse
												// 
												this.mouse.Name = "mouse";
												this.mouse.Size = new System.Drawing.Size(10, 17);
												this.mouse.Text = " ";
												// 
												// Form1
												// 
												this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
												this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
												this.ClientSize = new System.Drawing.Size(1142, 450);
												this.Controls.Add(this.statusStrip1);
												this.Controls.Add(this.button1);
												this.Controls.Add(this.toolStrip1);
												this.Name = "Form1";
												this.Text = "Form1";
												this.toolStrip1.ResumeLayout(false);
												this.toolStrip1.PerformLayout();
												this.contextMenu.ResumeLayout(false);
												this.contextMenu.PerformLayout();
												this.statusStrip1.ResumeLayout(false);
												this.statusStrip1.PerformLayout();
												this.ResumeLayout(false);
												this.PerformLayout();

								}

								#endregion

								public System.Windows.Forms.ToolStrip toolStrip1;
								public System.Windows.Forms.ToolStripTextBox xText;
								public System.Windows.Forms.ToolStripTextBox yText;
								public System.Windows.Forms.ToolStripTextBox zText;
								public System.Windows.Forms.ToolStripComboBox aCombobox;
								public System.Windows.Forms.ToolStripComboBox bCombobox;
								public System.Windows.Forms.ContextMenuStrip contextMenu;
								public System.Windows.Forms.ToolStripTextBox xContext;
								public System.Windows.Forms.ToolStripTextBox yContext;
								public System.Windows.Forms.ToolStripTextBox zContext;
								public System.Windows.Forms.ToolStripComboBox aContext;
								public System.Windows.Forms.ToolStripComboBox bContext;
								private System.Windows.Forms.Button button1;
								private System.Windows.Forms.StatusStrip statusStrip1;
								private System.Windows.Forms.ToolStripDropDownButton mouseFormule;
								private System.Windows.Forms.ToolStripMenuItem zSqrt;
								private System.Windows.Forms.ToolStripMenuItem f;
								private System.Windows.Forms.ToolStripMenuItem z;
								private System.Windows.Forms.ToolStripStatusLabel mouse;
				}
}

