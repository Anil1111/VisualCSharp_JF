using System;

namespace TestsInteractiveGUI
{
	partial class testAverages
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
			this.test1 = new System.Windows.Forms.Label();
			this.test2 = new System.Windows.Forms.Label();
			this.test3 = new System.Windows.Forms.Label();
			this.test4 = new System.Windows.Forms.Label();
			this.test5 = new System.Windows.Forms.Label();
			this.test01 = new System.Windows.Forms.TextBox();
			this.test02 = new System.Windows.Forms.TextBox();
			this.test03 = new System.Windows.Forms.TextBox();
			this.test04 = new System.Windows.Forms.TextBox();
			this.test05 = new System.Windows.Forms.TextBox();
			this.averageTests = new System.Windows.Forms.Button();
			this.avgScore = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// test1
			// 
			this.test1.AutoSize = true;
			this.test1.Location = new System.Drawing.Point(35, 36);
			this.test1.Name = "test1";
			this.test1.Size = new System.Drawing.Size(56, 17);
			this.test1.TabIndex = 0;
			this.test1.Text = "Test 01";
			this.test1.Click += new System.EventHandler(this.Label1_Click);
			// 
			// test2
			// 
			this.test2.AutoSize = true;
			this.test2.Location = new System.Drawing.Point(35, 77);
			this.test2.Name = "test2";
			this.test2.Size = new System.Drawing.Size(56, 17);
			this.test2.TabIndex = 1;
			this.test2.Text = "Test 02";
			// 
			// test3
			// 
			this.test3.AutoSize = true;
			this.test3.Location = new System.Drawing.Point(35, 118);
			this.test3.Name = "test3";
			this.test3.Size = new System.Drawing.Size(56, 17);
			this.test3.TabIndex = 2;
			this.test3.Text = "Test 03";
			// 
			// test4
			// 
			this.test4.AutoSize = true;
			this.test4.Location = new System.Drawing.Point(35, 159);
			this.test4.Name = "test4";
			this.test4.Size = new System.Drawing.Size(56, 17);
			this.test4.TabIndex = 3;
			this.test4.Text = "Test 04";
			// 
			// test5
			// 
			this.test5.AutoSize = true;
			this.test5.Location = new System.Drawing.Point(35, 200);
			this.test5.Name = "test5";
			this.test5.Size = new System.Drawing.Size(56, 17);
			this.test5.TabIndex = 4;
			this.test5.Text = "Test 05";
			// 
			// test01
			// 
			this.test01.Location = new System.Drawing.Point(106, 36);
			this.test01.Name = "test01";
			this.test01.Size = new System.Drawing.Size(43, 22);
			this.test01.TabIndex = 5;
			// 
			// test02
			// 
			this.test02.Location = new System.Drawing.Point(106, 77);
			this.test02.Name = "test02";
			this.test02.Size = new System.Drawing.Size(43, 22);
			this.test02.TabIndex = 6;
			// 
			// test03
			// 
			this.test03.Location = new System.Drawing.Point(106, 118);
			this.test03.Name = "test03";
			this.test03.Size = new System.Drawing.Size(43, 22);
			this.test03.TabIndex = 7;
			// 
			// test04
			// 
			this.test04.Location = new System.Drawing.Point(106, 159);
			this.test04.Name = "test04";
			this.test04.Size = new System.Drawing.Size(43, 22);
			this.test04.TabIndex = 8;
			// 
			// test05
			// 
			this.test05.Location = new System.Drawing.Point(106, 200);
			this.test05.Name = "test05";
			this.test05.Size = new System.Drawing.Size(43, 22);
			this.test05.TabIndex = 9;
			// 
			// averageTests
			// 
			this.averageTests.Location = new System.Drawing.Point(23, 241);
			this.averageTests.Name = "averageTests";
			this.averageTests.Size = new System.Drawing.Size(83, 29);
			this.averageTests.TabIndex = 10;
			this.averageTests.Text = "Average";
			this.averageTests.UseVisualStyleBackColor = true;
			this.averageTests.Click += new System.EventHandler(this.Button1_Click);
			// 
			// avgScore
			// 
			this.avgScore.AutoSize = true;
			this.avgScore.Location = new System.Drawing.Point(128, 241);
			this.avgScore.Name = "avgScore";
			this.avgScore.Size = new System.Drawing.Size(102, 17);
			this.avgScore.TabIndex = 11;
			this.avgScore.Text = "Average Score";
			// 
			// testAverages
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(308, 309);
			this.Controls.Add(this.avgScore);
			this.Controls.Add(this.averageTests);
			this.Controls.Add(this.test05);
			this.Controls.Add(this.test04);
			this.Controls.Add(this.test03);
			this.Controls.Add(this.test02);
			this.Controls.Add(this.test01);
			this.Controls.Add(this.test5);
			this.Controls.Add(this.test4);
			this.Controls.Add(this.test3);
			this.Controls.Add(this.test2);
			this.Controls.Add(this.test1);
			this.Name = "testAverages";
			this.Text = "Test Scores Average";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private void Label1_Click (object sender, EventArgs e)
		{
			throw new NotImplementedException ( );
		}

		#endregion

		private System.Windows.Forms.Label test1;
		private System.Windows.Forms.Label test2;
		private System.Windows.Forms.Label test3;
		private System.Windows.Forms.Label test4;
		private System.Windows.Forms.Label test5;
		private System.Windows.Forms.TextBox test01;
		private System.Windows.Forms.TextBox test02;
		private System.Windows.Forms.TextBox test03;
		private System.Windows.Forms.TextBox test04;
		private System.Windows.Forms.TextBox test05;
		private System.Windows.Forms.Button averageTests;
		private System.Windows.Forms.Label avgScore;
	}
}

