namespace GUI_POLYCAFE
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            butthoat = new Button();
            button5 = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            label1 = new Label();
            checkBox1 = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1020, 13);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(245, 305);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(522, 340);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(324, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(320, 166);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(601, 430);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // butthoat
            // 
            butthoat.Location = new Point(335, 340);
            butthoat.Name = "butthoat";
            butthoat.Size = new Size(89, 46);
            butthoat.TabIndex = 6;
            butthoat.Text = "Thoát";
            butthoat.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(137, 340);
            button5.Name = "button5";
            button5.Size = new Size(88, 46);
            button5.TabIndex = 7;
            button5.Text = "Đăng nhập";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(103, 104);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(396, 23);
            txtUsername.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(103, 235);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(396, 23);
            txtPassword.TabIndex = 9;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(7, 450);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(640, 10);
            progressBar1.TabIndex = 10;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(1, 438);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(648, 18);
            progressBar2.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(215, 20);
            label1.Name = "label1";
            label1.Size = new Size(156, 37);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(103, 264);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(104, 19);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Hiện mật khẩu";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 86);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 13;
            label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 217);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 14;
            label3.Text = "Mật khẩu";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            contextMenuStrip1.Opening += this.contextMenuStrip1_Opening;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(button5);
            Controls.Add(butthoat);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private Button butthoat;
        private Button button5;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private Label label1;
        private CheckBox checkBox1;
        private Label label2;
        private Label label3;
        private ContextMenuStrip contextMenuStrip1;
    }
}
