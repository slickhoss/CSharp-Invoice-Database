namespace InvoiceCRUD
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.invoiceDetailListBox = new System.Windows.Forms.ListBox();
            this.skuListLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.skuLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.extendedLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.skuTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.extendedTextBox = new System.Windows.Forms.TextBox();
            this.taxableCheckBox = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.legendLabel = new System.Windows.Forms.Label();
            this.detailIdLabel = new System.Windows.Forms.Label();
            this.invoiceIdTextBox = new System.Windows.Forms.TextBox();
            this.newButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // invoiceDetailListBox
            // 
            this.invoiceDetailListBox.FormattingEnabled = true;
            this.invoiceDetailListBox.ItemHeight = 20;
            this.invoiceDetailListBox.Location = new System.Drawing.Point(2, 38);
            this.invoiceDetailListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.invoiceDetailListBox.Name = "invoiceDetailListBox";
            this.invoiceDetailListBox.Size = new System.Drawing.Size(178, 304);
            this.invoiceDetailListBox.TabIndex = 0;
            this.invoiceDetailListBox.SelectedIndexChanged += new System.EventHandler(this.invoiceDetailListBox_SelectedIndexChanged);
            // 
            // skuListLabel
            // 
            this.skuListLabel.AutoSize = true;
            this.skuListLabel.Location = new System.Drawing.Point(18, 14);
            this.skuListLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skuListLabel.Name = "skuListLabel";
            this.skuListLabel.Size = new System.Drawing.Size(42, 20);
            this.skuListLabel.TabIndex = 1;
            this.skuListLabel.Text = "SKU";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(249, 86);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(80, 20);
            this.quantityLabel.TabIndex = 2;
            this.quantityLabel.Text = "Quantity : ";
            // 
            // skuLabel
            // 
            this.skuLabel.AutoSize = true;
            this.skuLabel.Location = new System.Drawing.Point(249, 131);
            this.skuLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skuLabel.Name = "skuLabel";
            this.skuLabel.Size = new System.Drawing.Size(54, 20);
            this.skuLabel.TabIndex = 3;
            this.skuLabel.Text = "SKU : ";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(249, 171);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(101, 20);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = "Description : ";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(249, 211);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(56, 20);
            this.priceLabel.TabIndex = 5;
            this.priceLabel.Text = "Price : ";
            // 
            // extendedLabel
            // 
            this.extendedLabel.AutoSize = true;
            this.extendedLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.extendedLabel.Location = new System.Drawing.Point(249, 251);
            this.extendedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.extendedLabel.Name = "extendedLabel";
            this.extendedLabel.Size = new System.Drawing.Size(89, 20);
            this.extendedLabel.TabIndex = 6;
            this.extendedLabel.Text = "Extended : ";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(362, 82);
            this.quantityTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(94, 26);
            this.quantityTextBox.TabIndex = 7;
            // 
            // skuTextBox
            // 
            this.skuTextBox.Location = new System.Drawing.Point(362, 126);
            this.skuTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.skuTextBox.Name = "skuTextBox";
            this.skuTextBox.Size = new System.Drawing.Size(192, 26);
            this.skuTextBox.TabIndex = 8;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(362, 166);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(292, 26);
            this.descriptionTextBox.TabIndex = 9;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(362, 206);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(192, 26);
            this.priceTextBox.TabIndex = 10;
            // 
            // extendedTextBox
            // 
            this.extendedTextBox.Enabled = false;
            this.extendedTextBox.Location = new System.Drawing.Point(362, 246);
            this.extendedTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.extendedTextBox.Name = "extendedTextBox";
            this.extendedTextBox.Size = new System.Drawing.Size(192, 26);
            this.extendedTextBox.TabIndex = 11;
            // 
            // taxableCheckBox
            // 
            this.taxableCheckBox.AutoSize = true;
            this.taxableCheckBox.Location = new System.Drawing.Point(362, 288);
            this.taxableCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.taxableCheckBox.Name = "taxableCheckBox";
            this.taxableCheckBox.Size = new System.Drawing.Size(90, 24);
            this.taxableCheckBox.TabIndex = 12;
            this.taxableCheckBox.Text = "Taxable";
            this.taxableCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(543, 282);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(112, 35);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(800, 38);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(18, 200);
            this.infoLabel.TabIndex = 15;
            this.infoLabel.Text = "1\r\n2\r\n3\r\n4\r\n\r\n\r\n\r\n1\r\n2\r\n3\r\n";
            // 
            // legendLabel
            // 
            this.legendLabel.AutoSize = true;
            this.legendLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.legendLabel.Location = new System.Drawing.Point(961, 38);
            this.legendLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.legendLabel.Name = "legendLabel";
            this.legendLabel.Size = new System.Drawing.Size(18, 200);
            this.legendLabel.TabIndex = 16;
            this.legendLabel.Text = "1\r\n2\r\n3\r\n4\r\n\r\n\r\n\r\n1\r\n2\r\n3\r\n";
            // 
            // detailIdLabel
            // 
            this.detailIdLabel.AutoSize = true;
            this.detailIdLabel.Location = new System.Drawing.Point(249, 38);
            this.detailIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.detailIdLabel.Name = "detailIdLabel";
            this.detailIdLabel.Size = new System.Drawing.Size(92, 20);
            this.detailIdLabel.TabIndex = 17;
            this.detailIdLabel.Text = "Invoice ID : ";
            // 
            // invoiceIdTextBox
            // 
            this.invoiceIdTextBox.Enabled = false;
            this.invoiceIdTextBox.Location = new System.Drawing.Point(362, 32);
            this.invoiceIdTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.invoiceIdTextBox.Name = "invoiceIdTextBox";
            this.invoiceIdTextBox.Size = new System.Drawing.Size(94, 26);
            this.invoiceIdTextBox.TabIndex = 18;
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(706, 282);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(112, 35);
            this.newButton.TabIndex = 19;
            this.newButton.Text = "&New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(867, 282);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(112, 35);
            this.deleteButton.TabIndex = 20;
            this.deleteButton.Text = "&Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 345);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.invoiceIdTextBox);
            this.Controls.Add(this.detailIdLabel);
            this.Controls.Add(this.legendLabel);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.taxableCheckBox);
            this.Controls.Add(this.extendedTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.skuTextBox);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.extendedLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.skuLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.skuListLabel);
            this.Controls.Add(this.invoiceDetailListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "C# -  SQL CRUD DEMO";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox invoiceDetailListBox;
        private System.Windows.Forms.Label skuListLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label skuLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label extendedLabel;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox skuTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox extendedTextBox;
        private System.Windows.Forms.CheckBox taxableCheckBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label legendLabel;
        private System.Windows.Forms.Label detailIdLabel;
        private System.Windows.Forms.TextBox invoiceIdTextBox;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button deleteButton;
    }
}
