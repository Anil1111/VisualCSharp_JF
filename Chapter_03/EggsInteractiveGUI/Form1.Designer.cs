namespace EggsInteractiveGUI
{
	partial class eggProduction
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose ( );
			}
			base.Dispose (disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ( )
		{
			this.chick01 = new System.Windows.Forms.Label();
			this.chick02 = new System.Windows.Forms.Label();
			this.chick03 = new System.Windows.Forms.Label();
			this.chick04 = new System.Windows.Forms.Label();
			this.chick05 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.addEggs = new System.Windows.Forms.Button();
			this.totalEggs = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// chick01
			// 
			this.chick01.AutoSize = true;
			this.chick01.Location = new System.Drawing.Point(51, 67);
			this.chick01.Name = "chick01";
			this.chick01.Size = new System.Drawing.Size(70, 17);
			this.chick01.TabIndex = 0;
			this.chick01.Text = "Chicken 1";
			// 
			// chick02
			// 
			this.chick02.AutoSize = true;
			this.chick02.Location = new System.Drawing.Point(51, 108);
			this.chick02.Name = "chick02";
			this.chick02.Size = new System.Drawing.Size(70, 17);
			this.chick02.TabIndex = 1;
			this.chick02.Text = "Chicken 2";
			// 
			// chick03
			// 
			this.chick03.AutoSize = true;
			this.chick03.Location = new System.Drawing.Point(51, 149);
			this.chick03.Name = "chick03";
			this.chick03.Size = new System.Drawing.Size(70, 17);
			this.chick03.TabIndex = 2;
			this.chick03.Text = "Chicken 3";
			// 
			// chick04
			// 
			this.chick04.AutoSize = true;
			this.chick04.Location = new System.Drawing.Point(51, 190);
			this.chick04.Name = "chick04";
			this.chick04.Size = new System.Drawing.Size(70, 17);
			this.chick04.TabIndex = 3;
			this.chick04.Text = "Chicken 4";
			// 
			// chick05
			// 
			this.chick05.AutoSize = true;
			this.chick05.Location = new System.Drawing.Point(51, 231);
			this.chick05.Name = "chick05";
			this.chick05.Size = new System.Drawing.Size(70, 17);
			this.chick05.TabIndex = 4;
			this.chick05.Text = "Chicken 5";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(147, 67);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(65, 22);
			this.textBox1.TabIndex = 5;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(147, 108);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(65, 22);
			this.textBox2.TabIndex = 6;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(147, 149);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(65, 22);
			this.textBox3.TabIndex = 7;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(147, 190);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(65, 22);
			this.textBox4.TabIndex = 8;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(147, 231);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(65, 22);
			this.textBox5.TabIndex = 9;
			// 
			// addEggs
			// 
			this.addEggs.Location = new System.Drawing.Point(39, 279);
			this.addEggs.Name = "addEggs";
			this.addEggs.Size = new System.Drawing.Size(81, 28);
			this.addEggs.TabIndex = 10;
			this.addEggs.Text = "Add Eggs";
			this.addEggs.UseVisualStyleBackColor = true;
			this.addEggs.Click += new System.EventHandler(this.Button1_Click);
			// 
			// totalEggs
			// 
			this.totalEggs.AutoSize = true;
			this.totalEggs.Location = new System.Drawing.Point(147, 279);
			this.totalEggs.Name = "totalEggs";
			this.totalEggs.Size = new System.Drawing.Size(76, 17);
			this.totalEggs.TabIndex = 11;
			this.totalEggs.Text = "Total Eggs";
			// 
			// eggProduction
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(364, 421);
			this.Controls.Add(this.totalEggs);
			this.Controls.Add(this.addEggs);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.chick05);
			this.Controls.Add(this.chick04);
			this.Controls.Add(this.chick03);
			this.Controls.Add(this.chick02);
			this.Controls.Add(this.chick01);
			this.Name = "eggProduction";
			this.Text = "Eggs Gathered";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label chick01;
		private System.Windows.Forms.Label chick02;
		private System.Windows.Forms.Label chick03;
		private System.Windows.Forms.Label chick04;
		private System.Windows.Forms.Label chick05;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Button addEggs;
		private System.Windows.Forms.Label totalEggs;
	}
}

