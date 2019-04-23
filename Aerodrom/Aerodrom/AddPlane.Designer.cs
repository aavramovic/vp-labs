namespace Aerodrom
{
    partial class AddPlane
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
            this.addPlaneGroupBox = new System.Windows.Forms.GroupBox();
            this.discardPlaneButton = new System.Windows.Forms.Button();
            this.savePlaneButton = new System.Windows.Forms.Button();
            this.abbriviationTextBox = new System.Windows.Forms.TextBox();
            this.abbriviationLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.wrongInfoErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.addPlaneGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wrongInfoErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // addPlaneGroupBox
            // 
            this.addPlaneGroupBox.Controls.Add(this.discardPlaneButton);
            this.addPlaneGroupBox.Controls.Add(this.savePlaneButton);
            this.addPlaneGroupBox.Controls.Add(this.abbriviationTextBox);
            this.addPlaneGroupBox.Controls.Add(this.abbriviationLabel);
            this.addPlaneGroupBox.Controls.Add(this.nameTextBox);
            this.addPlaneGroupBox.Controls.Add(this.nameLabel);
            this.addPlaneGroupBox.Controls.Add(this.cityTextBox);
            this.addPlaneGroupBox.Controls.Add(this.cityLabel);
            this.addPlaneGroupBox.Location = new System.Drawing.Point(13, 13);
            this.addPlaneGroupBox.Name = "addPlaneGroupBox";
            this.addPlaneGroupBox.Size = new System.Drawing.Size(301, 208);
            this.addPlaneGroupBox.TabIndex = 0;
            this.addPlaneGroupBox.TabStop = false;
            this.addPlaneGroupBox.Text = "Додади аеродром";
            // 
            // discardPlaneButton
            // 
            this.discardPlaneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.discardPlaneButton.Location = new System.Drawing.Point(167, 172);
            this.discardPlaneButton.Name = "discardPlaneButton";
            this.discardPlaneButton.Size = new System.Drawing.Size(109, 23);
            this.discardPlaneButton.TabIndex = 7;
            this.discardPlaneButton.Text = "Откажи";
            this.discardPlaneButton.UseVisualStyleBackColor = true;
            this.discardPlaneButton.Click += new System.EventHandler(this.discardPlaneButton_Click);
            // 
            // savePlaneButton
            // 
            this.savePlaneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.savePlaneButton.Location = new System.Drawing.Point(22, 172);
            this.savePlaneButton.Name = "savePlaneButton";
            this.savePlaneButton.Size = new System.Drawing.Size(109, 23);
            this.savePlaneButton.TabIndex = 6;
            this.savePlaneButton.Text = "Зачувај";
            this.savePlaneButton.UseVisualStyleBackColor = true;
            this.savePlaneButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.savePlaneButton_MouseClick);
            // 
            // abbriviationTextBox
            // 
            this.abbriviationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.abbriviationTextBox.Location = new System.Drawing.Point(10, 129);
            this.abbriviationTextBox.Name = "abbriviationTextBox";
            this.abbriviationTextBox.Size = new System.Drawing.Size(100, 21);
            this.abbriviationTextBox.TabIndex = 5;
            // 
            // abbriviationLabel
            // 
            this.abbriviationLabel.AutoSize = true;
            this.abbriviationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.abbriviationLabel.Location = new System.Drawing.Point(7, 112);
            this.abbriviationLabel.Name = "abbriviationLabel";
            this.abbriviationLabel.Size = new System.Drawing.Size(63, 15);
            this.abbriviationLabel.TabIndex = 4;
            this.abbriviationLabel.Text = "Кратенка";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.nameTextBox.Location = new System.Drawing.Point(10, 77);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(247, 21);
            this.nameTextBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.nameLabel.Location = new System.Drawing.Point(7, 60);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(32, 15);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Име";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cityTextBox.Location = new System.Drawing.Point(10, 37);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(247, 21);
            this.cityTextBox.TabIndex = 1;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cityLabel.Location = new System.Drawing.Point(7, 20);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(35, 15);
            this.cityLabel.TabIndex = 0;
            this.cityLabel.Text = "Град";
            // 
            // wrongInfoErrorProvider
            // 
            this.wrongInfoErrorProvider.ContainerControl = this;
            // 
            // AddPlane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 233);
            this.Controls.Add(this.addPlaneGroupBox);
            this.Name = "AddPlane";
            this.Text = "Нов аеродром";
            this.addPlaneGroupBox.ResumeLayout(false);
            this.addPlaneGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wrongInfoErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addPlaneGroupBox;
        private System.Windows.Forms.Button discardPlaneButton;
        private System.Windows.Forms.Button savePlaneButton;
        private System.Windows.Forms.TextBox abbriviationTextBox;
        private System.Windows.Forms.Label abbriviationLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.ErrorProvider wrongInfoErrorProvider;
    }
}