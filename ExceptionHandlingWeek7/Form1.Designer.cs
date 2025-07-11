namespace ExceptionHandlingWeek7
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
            txtNumber1 = new TextBox();
            txtNumber2 = new TextBox();
            AddButton = new Button();
            buttonSubtract = new Button();
            buttonMultiply = new Button();
            buttonDivide = new Button();
            lblResult = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtNumber1
            // 
            txtNumber1.Location = new Point(409, 61);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(100, 23);
            txtNumber1.TabIndex = 0;
            // 
            // txtNumber2
            // 
            txtNumber2.Location = new Point(409, 108);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(100, 23);
            txtNumber2.TabIndex = 1;
            // 
            // AddButton
            // 
            AddButton.BackColor = SystemColors.InactiveCaption;
            AddButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddButton.Location = new Point(295, 166);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(84, 31);
            AddButton.TabIndex = 2;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // buttonSubtract
            // 
            buttonSubtract.BackColor = SystemColors.InactiveCaption;
            buttonSubtract.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSubtract.Location = new Point(409, 166);
            buttonSubtract.Name = "buttonSubtract";
            buttonSubtract.Size = new Size(102, 31);
            buttonSubtract.TabIndex = 3;
            buttonSubtract.Text = "Subtract";
            buttonSubtract.UseVisualStyleBackColor = false;
            buttonSubtract.Click += buttonSubtract_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.BackColor = SystemColors.InactiveCaption;
            buttonMultiply.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMultiply.Location = new Point(295, 212);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(97, 33);
            buttonMultiply.TabIndex = 4;
            buttonMultiply.Text = "Multiply";
            buttonMultiply.UseVisualStyleBackColor = false;
            buttonMultiply.Click += buttonMultiply_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.BackColor = SystemColors.InactiveCaption;
            buttonDivide.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDivide.Location = new Point(409, 212);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(92, 33);
            buttonDivide.TabIndex = 5;
            buttonDivide.Text = "Divide";
            buttonDivide.UseVisualStyleBackColor = false;
            buttonDivide.Click += buttonDivide_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(362, 264);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(66, 25);
            lblResult.TabIndex = 6;
            lblResult.Text = "Result";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(198, 61);
            label1.Name = "label1";
            label1.Size = new Size(181, 25);
            label1.TabIndex = 7;
            label1.Text = "Enter First Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(198, 106);
            label2.Name = "label2";
            label2.Size = new Size(209, 25);
            label2.TabIndex = 8;
            label2.Text = "Enter Second Number";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1185, 572);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblResult);
            Controls.Add(buttonDivide);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonSubtract);
            Controls.Add(AddButton);
            Controls.Add(txtNumber2);
            Controls.Add(txtNumber1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private Button AddButton;
        private Button buttonSubtract;
        private Button buttonMultiply;
        private Button buttonDivide;
        private Label lblResult;
        private Label label1;
        private Label label2;
    }
}
