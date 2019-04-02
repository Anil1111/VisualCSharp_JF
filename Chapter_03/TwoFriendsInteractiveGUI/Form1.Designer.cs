namespace TwoFriendsInteractiveGUI
{
	partial class FriendsCompare
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
			this.friend01 = new System.Windows.Forms.Label();
			this.friend01Name = new System.Windows.Forms.TextBox();
			this.friend02 = new System.Windows.Forms.Label();
			this.friend02Name = new System.Windows.Forms.TextBox();
			this.firstToSecond = new System.Windows.Forms.Label();
			this.compareNames = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// friend01
			// 
			this.friend01.AutoSize = true;
			this.friend01.Location = new System.Drawing.Point(35, 42);
			this.friend01.Name = "friend01";
			this.friend01.Size = new System.Drawing.Size(79, 17);
			this.friend01.TabIndex = 0;
			this.friend01.Text = "First Friend";
			// 
			// friend01Name
			// 
			this.friend01Name.Location = new System.Drawing.Point(169, 42);
			this.friend01Name.Name = "friend01Name";
			this.friend01Name.Size = new System.Drawing.Size(123, 22);
			this.friend01Name.TabIndex = 1;
			// 
			// friend02
			// 
			this.friend02.AutoSize = true;
			this.friend02.Location = new System.Drawing.Point(35, 85);
			this.friend02.Name = "friend02";
			this.friend02.Size = new System.Drawing.Size(100, 17);
			this.friend02.TabIndex = 2;
			this.friend02.Text = "Second Friend";
			// 
			// friend02Name
			// 
			this.friend02Name.Location = new System.Drawing.Point(169, 82);
			this.friend02Name.Name = "friend02Name";
			this.friend02Name.Size = new System.Drawing.Size(123, 22);
			this.friend02Name.TabIndex = 3;
			// 
			// firstToSecond
			// 
			this.firstToSecond.AutoSize = true;
			this.firstToSecond.Location = new System.Drawing.Point(166, 132);
			this.firstToSecond.Name = "firstToSecond";
			this.firstToSecond.Size = new System.Drawing.Size(212, 17);
			this.firstToSecond.TabIndex = 4;
			this.firstToSecond.Text = "Compare First to Second Friend ";
			// 
			// compareNames
			// 
			this.compareNames.Location = new System.Drawing.Point(35, 132);
			this.compareNames.Name = "compareNames";
			this.compareNames.Size = new System.Drawing.Size(115, 23);
			this.compareNames.TabIndex = 5;
			this.compareNames.Text = "Compare Now";
			this.compareNames.UseVisualStyleBackColor = true;
			this.compareNames.Click += new System.EventHandler(this.CompareNames_Click);
			// 
			// FriendsCompare
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(439, 208);
			this.Controls.Add(this.compareNames);
			this.Controls.Add(this.firstToSecond);
			this.Controls.Add(this.friend02Name);
			this.Controls.Add(this.friend02);
			this.Controls.Add(this.friend01Name);
			this.Controls.Add(this.friend01);
			this.Name = "FriendsCompare";
			this.Text = "Compare Friends";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label friend01;
		private System.Windows.Forms.TextBox friend01Name;
		private System.Windows.Forms.Label friend02;
		private System.Windows.Forms.TextBox friend02Name;
		private System.Windows.Forms.Label firstToSecond;
		private System.Windows.Forms.Button compareNames;
	}
}

