namespace Aerodrom
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
            this.components = new System.ComponentModel.Container();
            this.planesListBox = new System.Windows.Forms.ListBox();
            this.destinationsListBox = new System.Windows.Forms.ListBox();
            this.planesLabel = new System.Windows.Forms.Label();
            this.destinationsLabel = new System.Windows.Forms.Label();
            this.addPlaneButton = new System.Windows.Forms.Button();
            this.deletePlaneButton = new System.Windows.Forms.Button();
            this.addDestinationButton = new System.Windows.Forms.Button();
            this.destinationsGroupBox = new System.Windows.Forms.GroupBox();
            this.averageDistanceTextBox = new System.Windows.Forms.TextBox();
            this.averageDistanceLabel = new System.Windows.Forms.Label();
            this.mostExpensiveDestinationTextBox = new System.Windows.Forms.TextBox();
            this.mostExpensiveDestinationLabel = new System.Windows.Forms.Label();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.destinationsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // planesListBox
            // 
            this.planesListBox.FormattingEnabled = true;
            this.planesListBox.Location = new System.Drawing.Point(15, 29);
            this.planesListBox.Name = "planesListBox";
            this.planesListBox.Size = new System.Drawing.Size(300, 264);
            this.planesListBox.TabIndex = 0;
            this.planesListBox.SelectedIndexChanged += new System.EventHandler(this.planesListBox_SelectedIndexChanged);
            // 
            // destinationsListBox
            // 
            this.destinationsListBox.FormattingEnabled = true;
            this.destinationsListBox.Location = new System.Drawing.Point(331, 29);
            this.destinationsListBox.Name = "destinationsListBox";
            this.destinationsListBox.Size = new System.Drawing.Size(300, 264);
            this.destinationsListBox.TabIndex = 1;
            // 
            // planesLabel
            // 
            this.planesLabel.AutoSize = true;
            this.planesLabel.Location = new System.Drawing.Point(12, 13);
            this.planesLabel.Name = "planesLabel";
            this.planesLabel.Size = new System.Drawing.Size(64, 13);
            this.planesLabel.TabIndex = 2;
            this.planesLabel.Text = "Аеродроми";
            // 
            // destinationsLabel
            // 
            this.destinationsLabel.AutoSize = true;
            this.destinationsLabel.Location = new System.Drawing.Point(328, 13);
            this.destinationsLabel.Name = "destinationsLabel";
            this.destinationsLabel.Size = new System.Drawing.Size(69, 13);
            this.destinationsLabel.TabIndex = 3;
            this.destinationsLabel.Text = "Дестинации";
            // 
            // addPlaneButton
            // 
            this.addPlaneButton.Location = new System.Drawing.Point(15, 318);
            this.addPlaneButton.Name = "addPlaneButton";
            this.addPlaneButton.Size = new System.Drawing.Size(300, 23);
            this.addPlaneButton.TabIndex = 4;
            this.addPlaneButton.Text = "Додади аеродром";
            this.addPlaneButton.UseVisualStyleBackColor = true;
            this.addPlaneButton.Click += new System.EventHandler(this.addPlaneButton_Click);
            // 
            // deletePlaneButton
            // 
            this.deletePlaneButton.Location = new System.Drawing.Point(15, 363);
            this.deletePlaneButton.Name = "deletePlaneButton";
            this.deletePlaneButton.Size = new System.Drawing.Size(300, 23);
            this.deletePlaneButton.TabIndex = 5;
            this.deletePlaneButton.Text = "Избриши аеродром";
            this.deletePlaneButton.UseVisualStyleBackColor = true;
            this.deletePlaneButton.Click += new System.EventHandler(this.deletePlaneButton_Click);
            // 
            // addDestinationButton
            // 
            this.addDestinationButton.Location = new System.Drawing.Point(15, 408);
            this.addDestinationButton.Name = "addDestinationButton";
            this.addDestinationButton.Size = new System.Drawing.Size(300, 23);
            this.addDestinationButton.TabIndex = 6;
            this.addDestinationButton.Text = "Додади дестинација";
            this.addDestinationButton.UseVisualStyleBackColor = true;
            this.addDestinationButton.Click += new System.EventHandler(this.addDestinationButton_Click);
            // 
            // destinationsGroupBox
            // 
            this.destinationsGroupBox.Controls.Add(this.averageDistanceTextBox);
            this.destinationsGroupBox.Controls.Add(this.averageDistanceLabel);
            this.destinationsGroupBox.Controls.Add(this.mostExpensiveDestinationTextBox);
            this.destinationsGroupBox.Controls.Add(this.mostExpensiveDestinationLabel);
            this.destinationsGroupBox.Location = new System.Drawing.Point(331, 318);
            this.destinationsGroupBox.Name = "destinationsGroupBox";
            this.destinationsGroupBox.Size = new System.Drawing.Size(300, 113);
            this.destinationsGroupBox.TabIndex = 7;
            this.destinationsGroupBox.TabStop = false;
            this.destinationsGroupBox.Text = "Дестинации";
            // 
            // averageDistanceTextBox
            // 
            this.averageDistanceTextBox.Location = new System.Drawing.Point(10, 76);
            this.averageDistanceTextBox.Name = "averageDistanceTextBox";
            this.averageDistanceTextBox.ReadOnly = true;
            this.averageDistanceTextBox.Size = new System.Drawing.Size(284, 20);
            this.averageDistanceTextBox.TabIndex = 9;
            // 
            // averageDistanceLabel
            // 
            this.averageDistanceLabel.AutoSize = true;
            this.averageDistanceLabel.Location = new System.Drawing.Point(7, 60);
            this.averageDistanceLabel.Name = "averageDistanceLabel";
            this.averageDistanceLabel.Size = new System.Drawing.Size(191, 13);
            this.averageDistanceLabel.TabIndex = 8;
            this.averageDistanceLabel.Text = "Просечна должина на дестинациите";
            // 
            // mostExpensiveDestinationTextBox
            // 
            this.mostExpensiveDestinationTextBox.Location = new System.Drawing.Point(10, 37);
            this.mostExpensiveDestinationTextBox.Name = "mostExpensiveDestinationTextBox";
            this.mostExpensiveDestinationTextBox.ReadOnly = true;
            this.mostExpensiveDestinationTextBox.Size = new System.Drawing.Size(284, 20);
            this.mostExpensiveDestinationTextBox.TabIndex = 1;
            // 
            // mostExpensiveDestinationLabel
            // 
            this.mostExpensiveDestinationLabel.AutoSize = true;
            this.mostExpensiveDestinationLabel.Location = new System.Drawing.Point(7, 20);
            this.mostExpensiveDestinationLabel.Name = "mostExpensiveDestinationLabel";
            this.mostExpensiveDestinationLabel.Size = new System.Drawing.Size(117, 13);
            this.mostExpensiveDestinationLabel.TabIndex = 0;
            this.mostExpensiveDestinationLabel.Text = "Најскапа дестинација";
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(Aerodrom.Program);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(Aerodrom.Form1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 457);
            this.Controls.Add(this.destinationsGroupBox);
            this.Controls.Add(this.addDestinationButton);
            this.Controls.Add(this.deletePlaneButton);
            this.Controls.Add(this.addPlaneButton);
            this.Controls.Add(this.destinationsLabel);
            this.Controls.Add(this.planesLabel);
            this.Controls.Add(this.destinationsListBox);
            this.Controls.Add(this.planesListBox);
            this.Name = "Form1";
            this.Text = "Аеродроми";
            this.destinationsGroupBox.ResumeLayout(false);
            this.destinationsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label planesLabel;
        private System.Windows.Forms.Label destinationsLabel;
        private System.Windows.Forms.Button addPlaneButton;
        private System.Windows.Forms.Button deletePlaneButton;
        private System.Windows.Forms.Button addDestinationButton;
        private System.Windows.Forms.GroupBox destinationsGroupBox;
        private System.Windows.Forms.TextBox averageDistanceTextBox;
        private System.Windows.Forms.Label averageDistanceLabel;
        private System.Windows.Forms.TextBox mostExpensiveDestinationTextBox;
        private System.Windows.Forms.Label mostExpensiveDestinationLabel;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.BindingSource programBindingSource;
        public System.Windows.Forms.ListBox planesListBox;
        public System.Windows.Forms.ListBox destinationsListBox;
    }
}

