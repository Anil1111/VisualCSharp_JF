namespace TwitterGUI
{
	partial class TwitterForm
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
			if ( disposing && ( components != null ) )
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
			this.messageLabel = new System.Windows.Forms.Label();
			this.messageTextBox = new System.Windows.Forms.TextBox();
			this.sendMessageButton = new System.Windows.Forms.Button();
			this.messageSentLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// messageLabel
			// 
			this.messageLabel.AutoSize = true;
			this.messageLabel.Location = new System.Drawing.Point(49, 57);
			this.messageLabel.Name = "messageLabel";
			this.messageLabel.Size = new System.Drawing.Size(103, 17);
			this.messageLabel.TabIndex = 0;
			this.messageLabel.Text = "Enter Message";
			// 
			// messageTextBox
			// 
			this.messageTextBox.Location = new System.Drawing.Point(207, 57);
			this.messageTextBox.Name = "messageTextBox";
			this.messageTextBox.Size = new System.Drawing.Size(411, 22);
			this.messageTextBox.TabIndex = 1;
			// 
			// sendMessageButton
			// 
			this.sendMessageButton.Location = new System.Drawing.Point(52, 105);
			this.sendMessageButton.Name = "sendMessageButton";
			this.sendMessageButton.Size = new System.Drawing.Size(124, 27);
			this.sendMessageButton.TabIndex = 2;
			this.sendMessageButton.Text = "Send Message";
			this.sendMessageButton.UseVisualStyleBackColor = true;
			this.sendMessageButton.Click += new System.EventHandler(this.SendMessageButton_Click);
			// 
			// messageSentLabel
			// 
			this.messageSentLabel.AutoSize = true;
			this.messageSentLabel.Location = new System.Drawing.Point(49, 159);
			this.messageSentLabel.Name = "messageSentLabel";
			this.messageSentLabel.Size = new System.Drawing.Size(109, 17);
			this.messageSentLabel.TabIndex = 3;
			this.messageSentLabel.Text = "Message Status";
			// 
			// TwitterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(737, 248);
			this.Controls.Add(this.messageSentLabel);
			this.Controls.Add(this.sendMessageButton);
			this.Controls.Add(this.messageTextBox);
			this.Controls.Add(this.messageLabel);
			this.Name = "TwitterForm";
			this.Text = "Send Message";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label messageLabel;
		private System.Windows.Forms.TextBox messageTextBox;
		private System.Windows.Forms.Button sendMessageButton;
		private System.Windows.Forms.Label messageSentLabel;
	}
}

