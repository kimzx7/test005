namespace WinFormsMethod02
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
            groupBox1 = new GroupBox();
            lblResult = new Label();
            btnCicumference = new Button();
            btnCircleArea = new Button();
            txtRadius = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnArrayParamiter = new Button();
            btnOutputParameter = new Button();
            btnRefParameter = new Button();
            txtInput = new TextBox();
            txtSize = new TextBox();
            txtLetter = new TextBox();
            btnTriangle01 = new Button();
            txtOutput = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkGray;
            groupBox1.Controls.Add(lblResult);
            groupBox1.Controls.Add(btnCicumference);
            groupBox1.Controls.Add(btnCircleArea);
            groupBox1.Controls.Add(txtRadius);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(21, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(505, 189);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "รูปวงกลม";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.White;
            lblResult.Location = new Point(162, 119);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(180, 43);
            lblResult.TabIndex = 4;
            lblResult.Text = "...";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCicumference
            // 
            btnCicumference.Location = new Point(383, 37);
            btnCicumference.Name = "btnCicumference";
            btnCicumference.Size = new Size(94, 29);
            btnCicumference.TabIndex = 3;
            btnCicumference.Text = "เส้นรอบวง";
            btnCicumference.UseVisualStyleBackColor = true;
            btnCicumference.Click += btnCicumference_Click;
            // 
            // btnCircleArea
            // 
            btnCircleArea.Location = new Point(267, 37);
            btnCircleArea.Name = "btnCircleArea";
            btnCircleArea.Size = new Size(94, 29);
            btnCircleArea.TabIndex = 2;
            btnCircleArea.Text = "พื้นที่";
            btnCircleArea.UseVisualStyleBackColor = true;
            btnCircleArea.Click += btnCircleArea_Click;
            // 
            // txtRadius
            // 
            txtRadius.Anchor = AnchorStyles.Top;
            txtRadius.Location = new Point(104, 37);
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(125, 27);
            txtRadius.TabIndex = 1;
            txtRadius.Text = "1";
            txtRadius.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 40);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "รัสมีวงกลม";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.DarkGray;
            groupBox2.Controls.Add(btnArrayParamiter);
            groupBox2.Controls.Add(btnOutputParameter);
            groupBox2.Controls.Add(btnRefParameter);
            groupBox2.Controls.Add(txtInput);
            groupBox2.Controls.Add(txtSize);
            groupBox2.Controls.Add(txtLetter);
            groupBox2.Controls.Add(btnTriangle01);
            groupBox2.Controls.Add(txtOutput);
            groupBox2.Location = new Point(22, 226);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(504, 334);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "ทดสอบ funtion";
            // 
            // btnArrayParamiter
            // 
            btnArrayParamiter.Location = new Point(239, 273);
            btnArrayParamiter.Name = "btnArrayParamiter";
            btnArrayParamiter.Size = new Size(237, 29);
            btnArrayParamiter.TabIndex = 7;
            btnArrayParamiter.Text = "Paramiter แบบ Array";
            btnArrayParamiter.UseVisualStyleBackColor = true;
            btnArrayParamiter.Click += btnArrayParamiter_Click;
            // 
            // btnOutputParameter
            // 
            btnOutputParameter.Location = new Point(239, 238);
            btnOutputParameter.Name = "btnOutputParameter";
            btnOutputParameter.Size = new Size(237, 29);
            btnOutputParameter.TabIndex = 6;
            btnOutputParameter.Text = "ทดสอบ output Parameter";
            btnOutputParameter.UseVisualStyleBackColor = true;
            btnOutputParameter.Click += btnOutputParameter_Click;
            // 
            // btnRefParameter
            // 
            btnRefParameter.Location = new Point(239, 203);
            btnRefParameter.Name = "btnRefParameter";
            btnRefParameter.Size = new Size(237, 29);
            btnRefParameter.TabIndex = 5;
            btnRefParameter.Text = "ทดสอบ RefParameter";
            btnRefParameter.UseVisualStyleBackColor = true;
            btnRefParameter.Click += btnRefParameter_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(239, 159);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(237, 27);
            txtInput.TabIndex = 4;
            // 
            // txtSize
            // 
            txtSize.Location = new Point(239, 70);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(125, 27);
            txtSize.TabIndex = 3;
            txtSize.Text = "5";
            txtSize.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLetter
            // 
            txtLetter.Location = new Point(239, 26);
            txtLetter.Name = "txtLetter";
            txtLetter.Size = new Size(125, 27);
            txtLetter.TabIndex = 2;
            txtLetter.Text = "A";
            txtLetter.TextAlign = HorizontalAlignment.Center;
            // 
            // btnTriangle01
            // 
            btnTriangle01.Location = new Point(382, 26);
            btnTriangle01.Name = "btnTriangle01";
            btnTriangle01.Size = new Size(94, 29);
            btnTriangle01.TabIndex = 1;
            btnTriangle01.Text = "Triangle";
            btnTriangle01.UseVisualStyleBackColor = true;
            btnTriangle01.Click += btnTriangle01_Click;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(16, 26);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(212, 293);
            txtOutput.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(546, 567);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label lblResult;
        private Button btnCicumference;
        private Button btnCircleArea;
        private TextBox txtRadius;
        private GroupBox groupBox2;
        private TextBox txtOutput;
        private Button btnTriangle01;
        private TextBox txtSize;
        private TextBox txtLetter;
        private Button btnRefParameter;
        private TextBox txtInput;
        private Button btnOutputParameter;
        private Button btnArrayParamiter;
    }
}
