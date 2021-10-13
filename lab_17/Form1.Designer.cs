namespace lab17 {
				partial class Form1 {
								/// <summary>
								/// Обязательная переменная конструктора.
								/// </summary>
								private System.ComponentModel.IContainer components = null;

								/// <summary>
								/// Освободить все используемые ресурсы.
								/// </summary>
								/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
								protected override void Dispose(bool disposing) {
												if(disposing && (components != null)) {
																components.Dispose();
												}
												base.Dispose(disposing);
								}

								#region Код, автоматически созданный конструктором форм Windows

								/// <summary>
								/// Требуемый метод для поддержки конструктора — не изменяйте 
								/// содержимое этого метода с помощью редактора кода.
								/// </summary>
								private void InitializeComponent() {
												this.components = new System.ComponentModel.Container();
												this.toggleAnimationButton = new System.Windows.Forms.Button();
												this.colorDialog = new System.Windows.Forms.ColorDialog();
												this.chooseCOlorBtn = new System.Windows.Forms.Button();
												this.mainTImer = new System.Windows.Forms.Timer(this.components);
												this.SuspendLayout();
												// 
												// toggleAnimationButton
												// 
												this.toggleAnimationButton.Location = new System.Drawing.Point(618, 25);
												this.toggleAnimationButton.Name = "toggleAnimationButton";
												this.toggleAnimationButton.Size = new System.Drawing.Size(115, 23);
												this.toggleAnimationButton.TabIndex = 0;
												this.toggleAnimationButton.Text = "Toggle animation";
												this.toggleAnimationButton.UseVisualStyleBackColor = true;
												// 
												// chooseCOlorBtn
												// 
												this.chooseCOlorBtn.Location = new System.Drawing.Point(618, 84);
												this.chooseCOlorBtn.Name = "chooseCOlorBtn";
												this.chooseCOlorBtn.Size = new System.Drawing.Size(115, 23);
												this.chooseCOlorBtn.TabIndex = 1;
												this.chooseCOlorBtn.Text = "Choose color";
												this.chooseCOlorBtn.UseVisualStyleBackColor = true;
												// 
												// mainTImer
												// 
												this.mainTImer.Interval = 500;
												// 
												// Form1
												// 
												this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
												this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
												this.ClientSize = new System.Drawing.Size(800, 450);
												this.Controls.Add(this.chooseCOlorBtn);
												this.Controls.Add(this.toggleAnimationButton);
												this.Name = "Form1";
												this.Text = "Form1";
												this.ResumeLayout(false);

								}

								#endregion

								private System.Windows.Forms.Button toggleAnimationButton;
								private System.Windows.Forms.ColorDialog colorDialog;
								private System.Windows.Forms.Button chooseCOlorBtn;
								private System.Windows.Forms.Timer mainTImer;
				}
}

