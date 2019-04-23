namespace Aerodrom
{
    partial class AddDestination
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
            this.components = new System.ComponentModel.Container();
            this.destinationGroupBox = new System.Windows.Forms.GroupBox();
            this.discardDestinationButton = new System.Windows.Forms.Button();
            this.addDestinationButton = new System.Windows.Forms.Button();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pathNumbericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.pathLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.destinationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pathNumbericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            this.SuspendLayout();
            // 
            // destinationGroupBox
            // 
            this.destinationGroupBox.Controls.Add(this.discardDestinationButton);
            this.destinationGroupBox.Controls.Add(this.addDestinationButton);
            this.destinationGroupBox.Controls.Add(this.priceNumericUpDown);
            this.destinationGroupBox.Controls.Add(this.pathNumbericUpDown);
            this.destinationGroupBox.Controls.Add(this.nameTextBox);
            this.destinationGroupBox.Controls.Add(this.priceLabel);
            this.destinationGroupBox.Controls.Add(this.pathLabel);
            this.destinationGroupBox.Controls.Add(this.nameLabel);
            this.destinationGroupBox.Location = new System.Drawing.Point(13, 13);
            this.destinationGroupBox.Name = "destinationGroupBox";
            this.destinationGroupBox.Size = new System.Drawing.Size(275, 181);
            this.destinationGroupBox.TabIndex = 0;
            this.destinationGroupBox.TabStop = false;
            this.destinationGroupBox.Text = "Додади дестинација";
            // 
            // discardDestinationButton
            // 
            this.discardDestinationButton.Location = new System.Drawing.Point(146, 140);
            this.discardDestinationButton.Name = "discardDestinationButton";
            this.discardDestinationButton.Size = new System.Drawing.Size(117, 23);
            this.discardDestinationButton.TabIndex = 8;
            this.discardDestinationButton.Text = "Откажи";
            this.discardDestinationButton.UseVisualStyleBackColor = true;
            this.discardDestinationButton.Click += new System.EventHandler(this.discardDestinationButton_Click);
            // 
            // addDestinationButton
            // 
            this.addDestinationButton.Location = new System.Drawing.Point(13, 140);
            this.addDestinationButton.Name = "addDestinationButton";
            this.addDestinationButton.Size = new System.Drawing.Size(117, 23);
            this.addDestinationButton.TabIndex = 7;
            this.addDestinationButton.Text = "Додади";
            this.addDestinationButton.UseVisualStyleBackColor = true;
            this.addDestinationButton.Click += new System.EventHandler(this.addDestinationButton_Click);
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.priceNumericUpDown.Location = new System.Drawing.Point(10, 114);
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.priceNumericUpDown.TabIndex = 6;
            // 
            // pathNumbericUpDown
            // 
            this.pathNumbericUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.pathNumbericUpDown.Location = new System.Drawing.Point(10, 75);
            this.pathNumbericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.pathNumbericUpDown.Name = "pathNumbericUpDown";
            this.pathNumbericUpDown.Size = new System.Drawing.Size(120, 20);
            this.pathNumbericUpDown.TabIndex = 5;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(10, 36);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(243, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(10, 98);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(33, 13);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Цена";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(10, 59);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(54, 13);
            this.pathLabel.TabIndex = 1;
            this.pathLabel.Text = "Должина";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(10, 20);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(29, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Име";
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // AddDestination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 206);
            this.Controls.Add(this.destinationGroupBox);
            this.Name = "AddDestination";
            this.Text = "AddDestination";
            this.destinationGroupBox.ResumeLayout(false);
            this.destinationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pathNumbericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox destinationGroupBox;
        private System.Windows.Forms.Button discardDestinationButton;
        private System.Windows.Forms.Button addDestinationButton;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.NumericUpDown pathNumbericUpDown;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ErrorProvider errorProviderName;
    }
}