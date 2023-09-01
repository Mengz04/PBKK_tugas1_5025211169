
namespace WindowsFormsApp1
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.Add = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.Subtract = new System.Windows.Forms.Button();
			this.Multiply = new System.Windows.Forms.Button();
			this.Divide = new System.Windows.Forms.Button();
			this.Clear = new System.Windows.Forms.Button();
			this.Modulo = new System.Windows.Forms.Button();
			this.Power = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(149, 52);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(255, 22);
			this.textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(149, 93);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(255, 22);
			this.textBox2.TabIndex = 1;
			// 
			// Add
			// 
			this.Add.Location = new System.Drawing.Point(90, 199);
			this.Add.Name = "Add";
			this.Add.Size = new System.Drawing.Size(73, 100);
			this.Add.TabIndex = 2;
			this.Add.Text = "+";
			this.Add.UseVisualStyleBackColor = true;
			this.Add.Click += new System.EventHandler(this.Add_Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(149, 141);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(255, 22);
			this.textBox3.TabIndex = 3;
			this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(89, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "Nilai 1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(89, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Nilai 2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(97, 144);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 17);
			this.label3.TabIndex = 6;
			this.label3.Text = "Hasil";
			// 
			// Subtract
			// 
			this.Subtract.Location = new System.Drawing.Point(169, 199);
			this.Subtract.Name = "Subtract";
			this.Subtract.Size = new System.Drawing.Size(73, 100);
			this.Subtract.TabIndex = 7;
			this.Subtract.Text = "-";
			this.Subtract.UseVisualStyleBackColor = true;
			this.Subtract.Click += new System.EventHandler(this.Subtract_Click);
			// 
			// Multiply
			// 
			this.Multiply.Location = new System.Drawing.Point(90, 305);
			this.Multiply.Name = "Multiply";
			this.Multiply.Size = new System.Drawing.Size(73, 100);
			this.Multiply.TabIndex = 8;
			this.Multiply.Text = "*";
			this.Multiply.UseVisualStyleBackColor = true;
			this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
			// 
			// Divide
			// 
			this.Divide.Location = new System.Drawing.Point(169, 305);
			this.Divide.Name = "Divide";
			this.Divide.Size = new System.Drawing.Size(73, 100);
			this.Divide.TabIndex = 9;
			this.Divide.Text = "/";
			this.Divide.UseVisualStyleBackColor = true;
			this.Divide.Click += new System.EventHandler(this.Divide_Click);
			// 
			// Clear
			// 
			this.Clear.Location = new System.Drawing.Point(327, 199);
			this.Clear.Name = "Clear";
			this.Clear.Size = new System.Drawing.Size(72, 206);
			this.Clear.TabIndex = 10;
			this.Clear.Text = "clear";
			this.Clear.UseVisualStyleBackColor = true;
			this.Clear.Click += new System.EventHandler(this.Clear_Click);
			// 
			// Modulo
			// 
			this.Modulo.Location = new System.Drawing.Point(248, 199);
			this.Modulo.Name = "Modulo";
			this.Modulo.Size = new System.Drawing.Size(73, 100);
			this.Modulo.TabIndex = 11;
			this.Modulo.Text = "%";
			this.Modulo.UseVisualStyleBackColor = true;
			this.Modulo.Click += new System.EventHandler(this.Modulo_Click);
			// 
			// Power
			// 
			this.Power.Location = new System.Drawing.Point(248, 305);
			this.Power.Name = "Power";
			this.Power.Size = new System.Drawing.Size(73, 100);
			this.Power.TabIndex = 12;
			this.Power.Text = "pow";
			this.Power.UseVisualStyleBackColor = true;
			this.Power.Click += new System.EventHandler(this.Power_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(501, 450);
			this.Controls.Add(this.Power);
			this.Controls.Add(this.Modulo);
			this.Controls.Add(this.Clear);
			this.Controls.Add(this.Divide);
			this.Controls.Add(this.Multiply);
			this.Controls.Add(this.Subtract);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.Add);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button Add;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button Subtract;
		private System.Windows.Forms.Button Multiply;
		private System.Windows.Forms.Button Divide;
		private System.Windows.Forms.Button Clear;
		private System.Windows.Forms.Button Modulo;
		private System.Windows.Forms.Button Power;
	}
}

