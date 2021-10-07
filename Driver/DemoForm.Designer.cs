
namespace Driver
{
    partial class DemoForm
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
            this.btnSpeakText = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbVariants = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nmPitch = new System.Windows.Forms.NumericUpDown();
            this.nmSpeed = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTextFilePath = new System.Windows.Forms.TextBox();
            this.btnSpeakTextFile = new System.Windows.Forms.Button();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.linkGithub = new System.Windows.Forms.LinkLabel();
            this.linkSourceforge = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nmPitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSpeed)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSpeakText
            // 
            this.btnSpeakText.Enabled = false;
            this.btnSpeakText.Location = new System.Drawing.Point(205, 46);
            this.btnSpeakText.Name = "btnSpeakText";
            this.btnSpeakText.Size = new System.Drawing.Size(75, 23);
            this.btnSpeakText.TabIndex = 0;
            this.btnSpeakText.Text = "Speak";
            this.btnSpeakText.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Language";
            // 
            // txtLanguage
            // 
            this.txtLanguage.Location = new System.Drawing.Point(15, 25);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(140, 20);
            this.txtLanguage.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Variant";
            // 
            // cbVariants
            // 
            this.cbVariants.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVariants.FormattingEnabled = true;
            this.cbVariants.Location = new System.Drawing.Point(161, 24);
            this.cbVariants.Name = "cbVariants";
            this.cbVariants.Size = new System.Drawing.Size(140, 21);
            this.cbVariants.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pitch";
            // 
            // nmPitch
            // 
            this.nmPitch.Location = new System.Drawing.Point(15, 70);
            this.nmPitch.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nmPitch.Name = "nmPitch";
            this.nmPitch.Size = new System.Drawing.Size(140, 20);
            this.nmPitch.TabIndex = 6;
            this.nmPitch.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // nmSpeed
            // 
            this.nmSpeed.Location = new System.Drawing.Point(164, 70);
            this.nmSpeed.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nmSpeed.Minimum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.nmSpeed.Name = "nmSpeed";
            this.nmSpeed.Size = new System.Drawing.Size(137, 20);
            this.nmSpeed.TabIndex = 8;
            this.nmSpeed.Value = new decimal(new int[] {
            175,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Speed (WPM)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtText);
            this.groupBox1.Controls.Add(this.btnSpeakText);
            this.groupBox1.Location = new System.Drawing.Point(15, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 79);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Speak by text";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(6, 19);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(274, 20);
            this.txtText.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTextFilePath);
            this.groupBox2.Controls.Add(this.btnSpeakTextFile);
            this.groupBox2.Location = new System.Drawing.Point(15, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 79);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Speak text file content";
            // 
            // txtTextFilePath
            // 
            this.txtTextFilePath.Location = new System.Drawing.Point(6, 19);
            this.txtTextFilePath.Name = "txtTextFilePath";
            this.txtTextFilePath.ReadOnly = true;
            this.txtTextFilePath.Size = new System.Drawing.Size(199, 20);
            this.txtTextFilePath.TabIndex = 10;
            // 
            // btnSpeakTextFile
            // 
            this.btnSpeakTextFile.Enabled = false;
            this.btnSpeakTextFile.Location = new System.Drawing.Point(205, 46);
            this.btnSpeakTextFile.Name = "btnSpeakTextFile";
            this.btnSpeakTextFile.Size = new System.Drawing.Size(75, 23);
            this.btnSpeakTextFile.TabIndex = 0;
            this.btnSpeakTextFile.Text = "Speak";
            this.btnSpeakTextFile.UseVisualStyleBackColor = true;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(226, 205);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(69, 20);
            this.btnChooseFile.TabIndex = 11;
            this.btnChooseFile.Text = "Choose...";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            // 
            // linkGithub
            // 
            this.linkGithub.AutoSize = true;
            this.linkGithub.Location = new System.Drawing.Point(12, 271);
            this.linkGithub.Name = "linkGithub";
            this.linkGithub.Size = new System.Drawing.Size(103, 13);
            this.linkGithub.TabIndex = 12;
            this.linkGithub.TabStop = true;
            this.linkGithub.Text = "eSpeak.NET Github";
            // 
            // linkSourceforge
            // 
            this.linkSourceforge.AutoSize = true;
            this.linkSourceforge.Location = new System.Drawing.Point(190, 271);
            this.linkSourceforge.Name = "linkSourceforge";
            this.linkSourceforge.Size = new System.Drawing.Size(105, 13);
            this.linkSourceforge.TabIndex = 13;
            this.linkSourceforge.TabStop = true;
            this.linkSourceforge.Text = "eSpeak Sourceforge";
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 293);
            this.Controls.Add(this.linkSourceforge);
            this.Controls.Add(this.linkGithub);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nmSpeed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nmPitch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbVariants);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLanguage);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DemoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eSpeak.NET Demo";
            ((System.ComponentModel.ISupportInitialize)(this.nmPitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSpeed)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpeakText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbVariants;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmPitch;
        private System.Windows.Forms.NumericUpDown nmSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTextFilePath;
        private System.Windows.Forms.Button btnSpeakTextFile;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.LinkLabel linkGithub;
        private System.Windows.Forms.LinkLabel linkSourceforge;
    }
}

