namespace EggsInteractiveGUI
{
	partial class EggProduction
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
			this.egg1 = new System.Windows.Forms.TextBox();
			this.egg2 = new System.Windows.Forms.TextBox();
			this.egg3 = new System.Windows.Forms.TextBox();
			this.egg4 = new System.Windows.Forms.TextBox();
			this.egg5 = new System.Windows.Forms.TextBox();
			this.addEggs = new System.Windows.Forms.Button();
			this.totalEggs = new System.Windows.Forms.Label();
			this.totalDozen = new System.Windows.Forms.Label();
			this.singleEgg = new System.Windows.Forms.Label();
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
			// egg1
			// 
			this.egg1.Location = new System.Drawing.Point(147, 67);
			this.egg1.Name = "egg1";
			this.egg1.Size = new System.Drawing.Size(65, 22);
			this.egg1.TabIndex = 5;
			// 
			// egg2
			// 
			this.egg2.Location = new System.Drawing.Point(147, 108);
			this.egg2.Name = "egg2";
			this.egg2.Size = new System.Drawing.Size(65, 22);
			this.egg2.TabIndex = 6;
			// 
			// egg3
			// 
			this.egg3.Location = new System.Drawing.Point(147, 149);
			this.egg3.Name = "egg3";
			this.egg3.Size = new System.Drawing.Size(65, 22);
			this.egg3.TabIndex = 7;
			// 
			// egg4
			// 
			this.egg4.Location = new System.Drawing.Point(147, 190);
			this.egg4.Name = "egg4";
			this.egg4.Size = new System.Drawing.Size(65, 22);
			this.egg4.TabIndex = 8;
			// 
			// egg5
			// 
			this.egg5.Location = new System.Drawing.Point(147, 231);
			this.egg5.Name = "egg5";
			this.egg5.Size = new System.Drawing.Size(65, 22);
			this.egg5.TabIndex = 9;
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
			this.totalEggs.Location = new System.Drawing.Point(155, 279);
			this.totalEggs.Name = "totalEggs";
			this.totalEggs.Size = new System.Drawing.Size(76, 17);
			this.totalEggs.TabIndex = 11;
			this.totalEggs.Text = "Total Eggs";
			// 
			// totalDozen
			// 
			this.totalDozen.AutoSize = true;
			this.totalDozen.Location = new System.Drawing.Point(155, 313);
			this.totalDozen.Name = "totalDozen";
			this.totalDozen.Size = new System.Drawing.Size(85, 17);
			this.totalDozen.TabIndex = 12;
			this.totalDozen.Text = "Total Dozen";
			// 
			// singleEgg
			// 
			this.singleEgg.AutoSize = true;
			this.singleEgg.Location = new System.Drawing.Point(155, 347);
			this.singleEgg.Name = "singleEgg";
			this.singleEgg.Size = new System.Drawing.Size(83, 17);
			this.singleEgg.TabIndex = 13;
			this.singleEgg.Text = "Single Eggs";
			// 
			// EggProduction
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(364, 421);
			this.Controls.Add(this.singleEgg);
			this.Controls.Add(this.totalDozen);
			this.Controls.Add(this.totalEggs);
			this.Controls.Add(this.addEggs);
			this.Controls.Add(this.egg5);
			this.Controls.Add(this.egg4);
			this.Controls.Add(this.egg3);
			this.Controls.Add(this.egg2);
			this.Controls.Add(this.egg1);
			this.Controls.Add(this.chick05);
			this.Controls.Add(this.chick04);
			this.Controls.Add(this.chick03);
			this.Controls.Add(this.chick02);
			this.Controls.Add(this.chick01);
			this.Name = "EggProduction";
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
		private System.Windows.Forms.TextBox egg1;
		private System.Windows.Forms.TextBox egg2;
		private System.Windows.Forms.TextBox egg3;
		private System.Windows.Forms.TextBox egg4;
		private System.Windows.Forms.TextBox egg5;
		private System.Windows.Forms.Button addEggs;
		private System.Windows.Forms.Label totalEggs;
		private System.Windows.Forms.Label totalDozen;
		private System.Windows.Forms.Label singleEgg;
	}
}

