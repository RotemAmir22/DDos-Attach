namespace Q_2
{
    partial class DDoSAttack
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
            Start = new Button();
            Close = new Button();
            amount = new TextBox();
            path = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // Start
            // 
            Start.BackColor = SystemColors.ActiveCaption;
            Start.Location = new Point(19, 120);
            Start.Name = "Start";
            Start.Size = new Size(361, 47);
            Start.TabIndex = 0;
            Start.Text = "Start DDos Attack";
            Start.UseVisualStyleBackColor = false;
            Start.Click += button1_Click;
            // 
            // Close
            // 
            Close.BackColor = SystemColors.ButtonShadow;
            Close.Location = new Point(19, 182);
            Close.Name = "Close";
            Close.Size = new Size(361, 48);
            Close.TabIndex = 1;
            Close.Text = "Close All";
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click;
            // 
            // amount
            // 
            amount.Location = new Point(91, 41);
            amount.Name = "amount";
            amount.Size = new Size(127, 23);
            amount.TabIndex = 2;
            amount.TextChanged += textBox1_TextChanged;
            // 
            // path
            // 
            path.Location = new Point(91, 79);
            path.Name = "path";
            path.Size = new Size(289, 23);
            path.TabIndex = 3;
            path.TextChanged += path_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 44);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 4;
            label1.Text = "Attack with";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 87);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 5;
            label2.Text = "Target URL:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(249, 44);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 6;
            label3.Text = "Browsers";
            label3.Click += label3_Click;
            // 
            // DDoSAttack
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 242);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(path);
            Controls.Add(amount);
            Controls.Add(Close);
            Controls.Add(Start);
            Name = "DDoSAttack";
            Text = "MultiProcess DDoS Attack";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Start;
        private Button Close;
        private TextBox amount;
        private TextBox path;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}