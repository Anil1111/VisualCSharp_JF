namespace OrderReceiptGUI
{
	partial class OrderReceipt
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
			this.nameLabel = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.addressLabel = new System.Windows.Forms.Label();
			this.addressTextBox = new System.Windows.Forms.TextBox();
			this.cityLabel = new System.Windows.Forms.Label();
			this.cityTextBox = new System.Windows.Forms.TextBox();
			this.stateLabel = new System.Windows.Forms.Label();
			this.stateTextBox = new System.Windows.Forms.TextBox();
			this.zipCodeLabel = new System.Windows.Forms.Label();
			this.zipCodeTextBox = new System.Windows.Forms.TextBox();
			this.blendersLabel = new System.Windows.Forms.Label();
			this.blendersTextBox = new System.Windows.Forms.TextBox();
			this.orderButton = new System.Windows.Forms.Button();
			this.nameShowLabel = new System.Windows.Forms.Label();
			this.addressShowLabel = new System.Windows.Forms.Label();
			this.cityShowLabel = new System.Windows.Forms.Label();
			this.stateShowLabel = new System.Windows.Forms.Label();
			this.zipShowLabel = new System.Windows.Forms.Label();
			this.orderShowLabel = new System.Windows.Forms.Label();
			this.orderTotalShowLabel = new System.Windows.Forms.Label();
			this.salesTaxShowLabel = new System.Windows.Forms.Label();
			this.totalShowLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(16, 18);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(45, 17);
			this.nameLabel.TabIndex = 0;
			this.nameLabel.Text = "Name";
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(105, 13);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(310, 22);
			this.nameTextBox.TabIndex = 1;
			// 
			// addressLabel
			// 
			this.addressLabel.AutoSize = true;
			this.addressLabel.Location = new System.Drawing.Point(16, 46);
			this.addressLabel.Name = "addressLabel";
			this.addressLabel.Size = new System.Drawing.Size(60, 17);
			this.addressLabel.TabIndex = 2;
			this.addressLabel.Text = "Address";
			// 
			// addressTextBox
			// 
			this.addressTextBox.Location = new System.Drawing.Point(105, 41);
			this.addressTextBox.Name = "addressTextBox";
			this.addressTextBox.Size = new System.Drawing.Size(310, 22);
			this.addressTextBox.TabIndex = 3;
			// 
			// cityLabel
			// 
			this.cityLabel.AutoSize = true;
			this.cityLabel.Location = new System.Drawing.Point(16, 69);
			this.cityLabel.Name = "cityLabel";
			this.cityLabel.Size = new System.Drawing.Size(31, 17);
			this.cityLabel.TabIndex = 4;
			this.cityLabel.Text = "City";
			// 
			// cityTextBox
			// 
			this.cityTextBox.Location = new System.Drawing.Point(105, 69);
			this.cityTextBox.Name = "cityTextBox";
			this.cityTextBox.Size = new System.Drawing.Size(310, 22);
			this.cityTextBox.TabIndex = 5;
			// 
			// stateLabel
			// 
			this.stateLabel.AutoSize = true;
			this.stateLabel.Location = new System.Drawing.Point(16, 102);
			this.stateLabel.Name = "stateLabel";
			this.stateLabel.Size = new System.Drawing.Size(41, 17);
			this.stateLabel.TabIndex = 6;
			this.stateLabel.Text = "State";
			// 
			// stateTextBox
			// 
			this.stateTextBox.Location = new System.Drawing.Point(105, 102);
			this.stateTextBox.Name = "stateTextBox";
			this.stateTextBox.Size = new System.Drawing.Size(103, 22);
			this.stateTextBox.TabIndex = 7;
			// 
			// zipCodeLabel
			// 
			this.zipCodeLabel.AutoSize = true;
			this.zipCodeLabel.Location = new System.Drawing.Point(226, 107);
			this.zipCodeLabel.Name = "zipCodeLabel";
			this.zipCodeLabel.Size = new System.Drawing.Size(65, 17);
			this.zipCodeLabel.TabIndex = 8;
			this.zipCodeLabel.Text = "Zip Code";
			// 
			// zipCodeTextBox
			// 
			this.zipCodeTextBox.Location = new System.Drawing.Point(315, 107);
			this.zipCodeTextBox.Name = "zipCodeTextBox";
			this.zipCodeTextBox.Size = new System.Drawing.Size(100, 22);
			this.zipCodeTextBox.TabIndex = 9;
			// 
			// blendersLabel
			// 
			this.blendersLabel.AutoSize = true;
			this.blendersLabel.Location = new System.Drawing.Point(16, 135);
			this.blendersLabel.Name = "blendersLabel";
			this.blendersLabel.Size = new System.Drawing.Size(64, 17);
			this.blendersLabel.TabIndex = 10;
			this.blendersLabel.Text = "Blenders";
			// 
			// blendersTextBox
			// 
			this.blendersTextBox.Location = new System.Drawing.Point(105, 135);
			this.blendersTextBox.Name = "blendersTextBox";
			this.blendersTextBox.Size = new System.Drawing.Size(100, 22);
			this.blendersTextBox.TabIndex = 11;
			// 
			// orderButton
			// 
			this.orderButton.Location = new System.Drawing.Point(19, 180);
			this.orderButton.Name = "orderButton";
			this.orderButton.Size = new System.Drawing.Size(115, 23);
			this.orderButton.TabIndex = 12;
			this.orderButton.Text = "Place Order";
			this.orderButton.UseVisualStyleBackColor = true;
			this.orderButton.Click += new System.EventHandler(this.OrderButton_Click);
			// 
			// nameShowLabel
			// 
			this.nameShowLabel.AutoSize = true;
			this.nameShowLabel.Location = new System.Drawing.Point(19, 227);
			this.nameShowLabel.Name = "nameShowLabel";
			this.nameShowLabel.Size = new System.Drawing.Size(45, 17);
			this.nameShowLabel.TabIndex = 13;
			this.nameShowLabel.Text = "Name";
			// 
			// addressShowLabel
			// 
			this.addressShowLabel.AutoSize = true;
			this.addressShowLabel.Location = new System.Drawing.Point(19, 253);
			this.addressShowLabel.Name = "addressShowLabel";
			this.addressShowLabel.Size = new System.Drawing.Size(60, 17);
			this.addressShowLabel.TabIndex = 14;
			this.addressShowLabel.Text = "Address";
			// 
			// cityShowLabel
			// 
			this.cityShowLabel.AutoSize = true;
			this.cityShowLabel.Location = new System.Drawing.Point(19, 282);
			this.cityShowLabel.Name = "cityShowLabel";
			this.cityShowLabel.Size = new System.Drawing.Size(31, 17);
			this.cityShowLabel.TabIndex = 15;
			this.cityShowLabel.Text = "City";
			// 
			// stateShowLabel
			// 
			this.stateShowLabel.AutoSize = true;
			this.stateShowLabel.Location = new System.Drawing.Point(19, 309);
			this.stateShowLabel.Name = "stateShowLabel";
			this.stateShowLabel.Size = new System.Drawing.Size(41, 17);
			this.stateShowLabel.TabIndex = 16;
			this.stateShowLabel.Text = "State";
			// 
			// zipShowLabel
			// 
			this.zipShowLabel.AutoSize = true;
			this.zipShowLabel.Location = new System.Drawing.Point(143, 309);
			this.zipShowLabel.Name = "zipShowLabel";
			this.zipShowLabel.Size = new System.Drawing.Size(65, 17);
			this.zipShowLabel.TabIndex = 17;
			this.zipShowLabel.Text = "Zip Code";
			// 
			// orderShowLabel
			// 
			this.orderShowLabel.AutoSize = true;
			this.orderShowLabel.Location = new System.Drawing.Point(19, 343);
			this.orderShowLabel.Name = "orderShowLabel";
			this.orderShowLabel.Size = new System.Drawing.Size(121, 17);
			this.orderShowLabel.TabIndex = 18;
			this.orderShowLabel.Text = "Blenders Ordered";
			// 
			// orderTotalShowLabel
			// 
			this.orderTotalShowLabel.AutoSize = true;
			this.orderTotalShowLabel.Location = new System.Drawing.Point(19, 375);
			this.orderTotalShowLabel.Name = "orderTotalShowLabel";
			this.orderTotalShowLabel.Size = new System.Drawing.Size(81, 17);
			this.orderTotalShowLabel.TabIndex = 19;
			this.orderTotalShowLabel.Text = "Order Total";
			// 
			// salesTaxShowLabel
			// 
			this.salesTaxShowLabel.AutoSize = true;
			this.salesTaxShowLabel.Location = new System.Drawing.Point(19, 403);
			this.salesTaxShowLabel.Name = "salesTaxShowLabel";
			this.salesTaxShowLabel.Size = new System.Drawing.Size(70, 17);
			this.salesTaxShowLabel.TabIndex = 20;
			this.salesTaxShowLabel.Text = "Sales Tax";
			// 
			// totalShowLabel
			// 
			this.totalShowLabel.AutoSize = true;
			this.totalShowLabel.Location = new System.Drawing.Point(19, 435);
			this.totalShowLabel.Name = "totalShowLabel";
			this.totalShowLabel.Size = new System.Drawing.Size(81, 17);
			this.totalShowLabel.TabIndex = 21;
			this.totalShowLabel.Text = "Order Total";
			// 
			// OrderReceipt
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(435, 463);
			this.Controls.Add(this.totalShowLabel);
			this.Controls.Add(this.salesTaxShowLabel);
			this.Controls.Add(this.orderTotalShowLabel);
			this.Controls.Add(this.orderShowLabel);
			this.Controls.Add(this.zipShowLabel);
			this.Controls.Add(this.stateShowLabel);
			this.Controls.Add(this.cityShowLabel);
			this.Controls.Add(this.addressShowLabel);
			this.Controls.Add(this.nameShowLabel);
			this.Controls.Add(this.orderButton);
			this.Controls.Add(this.blendersTextBox);
			this.Controls.Add(this.blendersLabel);
			this.Controls.Add(this.zipCodeTextBox);
			this.Controls.Add(this.zipCodeLabel);
			this.Controls.Add(this.stateTextBox);
			this.Controls.Add(this.stateLabel);
			this.Controls.Add(this.cityTextBox);
			this.Controls.Add(this.cityLabel);
			this.Controls.Add(this.addressTextBox);
			this.Controls.Add(this.addressLabel);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.nameLabel);
			this.Name = "OrderReceipt";
			this.Text = "Order Receipt";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Label addressLabel;
		private System.Windows.Forms.TextBox addressTextBox;
		private System.Windows.Forms.Label cityLabel;
		private System.Windows.Forms.TextBox cityTextBox;
		private System.Windows.Forms.Label stateLabel;
		private System.Windows.Forms.TextBox stateTextBox;
		private System.Windows.Forms.Label zipCodeLabel;
		private System.Windows.Forms.TextBox zipCodeTextBox;
		private System.Windows.Forms.Label blendersLabel;
		private System.Windows.Forms.TextBox blendersTextBox;
		private System.Windows.Forms.Button orderButton;
		private System.Windows.Forms.Label nameShowLabel;
		private System.Windows.Forms.Label addressShowLabel;
		private System.Windows.Forms.Label cityShowLabel;
		private System.Windows.Forms.Label stateShowLabel;
		private System.Windows.Forms.Label zipShowLabel;
		private System.Windows.Forms.Label orderShowLabel;
		private System.Windows.Forms.Label orderTotalShowLabel;
		private System.Windows.Forms.Label salesTaxShowLabel;
		private System.Windows.Forms.Label totalShowLabel;
	}
}

