namespace SeniorProject
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
            this.HeightBox = new System.Windows.Forms.GroupBox();
            this.Height = new System.Windows.Forms.TextBox();
            this.WeightBox = new System.Windows.Forms.GroupBox();
            this.GetWeight = new System.Windows.Forms.Button();
            this.Weight = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.DPortBox = new System.Windows.Forms.GroupBox();
            this.DPort = new System.Windows.Forms.ComboBox();
            this.Error = new System.Windows.Forms.Label();
            this.ErrorM = new System.Windows.Forms.Label();
            this.HeightBox.SuspendLayout();
            this.WeightBox.SuspendLayout();
            this.DPortBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeightBox
            // 
            this.HeightBox.Controls.Add(this.Height);
            this.HeightBox.Location = new System.Drawing.Point(60, 43);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(213, 87);
            this.HeightBox.TabIndex = 0;
            this.HeightBox.TabStop = false;
            this.HeightBox.Text = "Height";
            this.HeightBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Height
            // 
            this.Height.Location = new System.Drawing.Point(34, 39);
            this.Height.MaxLength = 3;
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(161, 20);
            this.Height.TabIndex = 0;
            this.Height.Text = "Enter your height";
            this.Height.Click += new System.EventHandler(this.Height_Click);
            // 
            // WeightBox
            // 
            this.WeightBox.Controls.Add(this.GetWeight);
            this.WeightBox.Controls.Add(this.Weight);
            this.WeightBox.Location = new System.Drawing.Point(60, 146);
            this.WeightBox.Name = "WeightBox";
            this.WeightBox.Size = new System.Drawing.Size(418, 85);
            this.WeightBox.TabIndex = 1;
            this.WeightBox.TabStop = false;
            this.WeightBox.Text = "Weight";
            // 
            // GetWeight
            // 
            this.GetWeight.Location = new System.Drawing.Point(231, 34);
            this.GetWeight.Name = "GetWeight";
            this.GetWeight.Size = new System.Drawing.Size(161, 23);
            this.GetWeight.TabIndex = 2;
            this.GetWeight.Text = "Get Weight";
            this.GetWeight.UseVisualStyleBackColor = true;
            this.GetWeight.Click += new System.EventHandler(this.GetWeight_Click);
            // 
            // Weight
            // 
            this.Weight.Location = new System.Drawing.Point(34, 37);
            this.Weight.MaxLength = 3000;
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(161, 20);
            this.Weight.TabIndex = 1;
            this.Weight.Text = "Press Get Weight";
            this.Weight.Click += new System.EventHandler(this.Weight_Click);
            this.Weight.TextChanged += new System.EventHandler(this.Weight_TextChanged);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(204, 281);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(161, 23);
            this.start.TabIndex = 2;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // DPortBox
            // 
            this.DPortBox.Controls.Add(this.DPort);
            this.DPortBox.Location = new System.Drawing.Point(300, 43);
            this.DPortBox.Name = "DPortBox";
            this.DPortBox.Size = new System.Drawing.Size(178, 87);
            this.DPortBox.TabIndex = 3;
            this.DPortBox.TabStop = false;
            this.DPortBox.Text = "Device Port";
            // 
            // DPort
            // 
            this.DPort.FormattingEnabled = true;
            this.DPort.Items.AddRange(new object[] {
            "COM3"});
            this.DPort.Location = new System.Drawing.Point(20, 38);
            this.DPort.Name = "DPort";
            this.DPort.Size = new System.Drawing.Size(121, 21);
            this.DPort.TabIndex = 0;
            this.DPort.Text = "Select";
            this.DPort.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error.ForeColor = System.Drawing.Color.Red;
            this.Error.Location = new System.Drawing.Point(71, 247);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(35, 13);
            this.Error.TabIndex = 5;
            this.Error.Text = "Error:";
            this.Error.Visible = false;
            // 
            // ErrorM
            // 
            this.ErrorM.AutoSize = true;
            this.ErrorM.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorM.ForeColor = System.Drawing.Color.Red;
            this.ErrorM.Location = new System.Drawing.Point(112, 247);
            this.ErrorM.Name = "ErrorM";
            this.ErrorM.Size = new System.Drawing.Size(0, 13);
            this.ErrorM.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 340);
            this.Controls.Add(this.ErrorM);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.DPortBox);
            this.Controls.Add(this.start);
            this.Controls.Add(this.WeightBox);
            this.Controls.Add(this.HeightBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.HeightBox.ResumeLayout(false);
            this.HeightBox.PerformLayout();
            this.WeightBox.ResumeLayout(false);
            this.WeightBox.PerformLayout();
            this.DPortBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox HeightBox;
        private System.Windows.Forms.TextBox Height;
        private System.Windows.Forms.GroupBox WeightBox;
        private System.Windows.Forms.Button GetWeight;
        private System.Windows.Forms.TextBox Weight;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.GroupBox DPortBox;
        private System.Windows.Forms.ComboBox DPort;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.Label ErrorM;
    }
}

