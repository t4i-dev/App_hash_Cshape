namespace lab4ATTMMT11
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textFormat = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            textData = new TextBox();
            checkMD5 = new CheckBox();
            checkSHA1 = new CheckBox();
            checkSHA2 = new CheckBox();
            textSHA2 = new TextBox();
            textSHA1 = new TextBox();
            textMD5 = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button3 = new Button();
            checkSHA3 = new CheckBox();
            textSHA3 = new TextBox();
            checkboxHex = new CheckBox();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // textFormat
            // 
            textFormat.FormattingEnabled = true;
            textFormat.Items.AddRange(new object[] { "File", "Text string" });
            textFormat.Location = new Point(12, 38);
            textFormat.Name = "textFormat";
            textFormat.Size = new Size(151, 28);
            textFormat.TabIndex = 0;
            textFormat.SelectedIndexChanged += textFormat_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 1;
            label1.Text = "Data fomat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 12);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 2;
            label2.Text = "Data";
            // 
            // textData
            // 
            textData.Location = new Point(212, 38);
            textData.Name = "textData";
            textData.Size = new Size(576, 27);
            textData.TabIndex = 3;
            textData.TextChanged += textData_TextChanged;
            // 
            // checkMD5
            // 
            checkMD5.AutoSize = true;
            checkMD5.Location = new Point(12, 125);
            checkMD5.Name = "checkMD5";
            checkMD5.Size = new Size(63, 24);
            checkMD5.TabIndex = 4;
            checkMD5.Text = "MD5";
            checkMD5.UseVisualStyleBackColor = true;
            // 
            // checkSHA1
            // 
            checkSHA1.AutoSize = true;
            checkSHA1.Location = new Point(12, 174);
            checkSHA1.Name = "checkSHA1";
            checkSHA1.Size = new Size(68, 24);
            checkSHA1.TabIndex = 5;
            checkSHA1.Text = "SHA1";
            checkSHA1.UseVisualStyleBackColor = true;
            // 
            // checkSHA2
            // 
            checkSHA2.AutoSize = true;
            checkSHA2.Location = new Point(12, 223);
            checkSHA2.Name = "checkSHA2";
            checkSHA2.Size = new Size(84, 24);
            checkSHA2.TabIndex = 6;
            checkSHA2.Text = "SHA256";
            checkSHA2.UseVisualStyleBackColor = true;
            // 
            // textSHA2
            // 
            textSHA2.Location = new Point(100, 220);
            textSHA2.Name = "textSHA2";
            textSHA2.Size = new Size(688, 27);
            textSHA2.TabIndex = 7;
            // 
            // textSHA1
            // 
            textSHA1.Location = new Point(100, 171);
            textSHA1.Name = "textSHA1";
            textSHA1.Size = new Size(688, 27);
            textSHA1.TabIndex = 8;
            // 
            // textMD5
            // 
            textMD5.Location = new Point(100, 122);
            textMD5.Name = "textMD5";
            textMD5.Size = new Size(688, 27);
            textMD5.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(12, 323);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(776, 61);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(679, 3);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Help";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(579, 3);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(479, 3);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 3;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(379, 3);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "Calculate";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Calculate_Click;
            // 
            // checkSHA3
            // 
            checkSHA3.AutoSize = true;
            checkSHA3.Location = new Point(12, 272);
            checkSHA3.Name = "checkSHA3";
            checkSHA3.Size = new Size(84, 24);
            checkSHA3.TabIndex = 11;
            checkSHA3.Text = "SHA384";
            checkSHA3.UseVisualStyleBackColor = true;
            // 
            // textSHA3
            // 
            textSHA3.Location = new Point(100, 270);
            textSHA3.Name = "textSHA3";
            textSHA3.Size = new Size(688, 27);
            textSHA3.TabIndex = 12;
            // 
            // checkboxHex
            // 
            checkboxHex.AutoSize = true;
            checkboxHex.Location = new Point(12, 83);
            checkboxHex.Name = "checkboxHex";
            checkboxHex.Size = new Size(95, 24);
            checkboxHex.TabIndex = 13;
            checkboxHex.Text = "Hex input";
            checkboxHex.UseVisualStyleBackColor = true;
            checkboxHex.CheckedChanged += checkboxHex_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 396);
            Controls.Add(checkboxHex);
            Controls.Add(textSHA3);
            Controls.Add(checkSHA3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(textMD5);
            Controls.Add(textSHA1);
            Controls.Add(textSHA2);
            Controls.Add(checkSHA2);
            Controls.Add(checkSHA1);
            Controls.Add(checkMD5);
            Controls.Add(textData);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textFormat);
            Name = "Form1";
            Text = "HashApp";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox textFormat;
        private Label label1;
        private Label label2;
        private TextBox textData;
        private CheckBox checkMD5;
        private CheckBox checkSHA1;
        private CheckBox checkSHA2;
        private TextBox textSHA2;
        private TextBox textSHA1;
        private TextBox textMD5;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private CheckBox checkSHA3;
        private TextBox textSHA3;
        private Button button4;
        private CheckBox checkboxHex;
        private CheckBox checkHex;
    }
}
