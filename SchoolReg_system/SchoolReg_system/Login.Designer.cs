namespace SchoolReg_system
{
    partial class Login
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
            label1 = new Label();
            panel1 = new Panel();
            checkBox1 = new CheckBox();
            linkLabel1 = new LinkLabel();
            sign_btn = new Button();
            password = new TextBox();
            label3 = new Label();
            username = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(250, 182);
            label1.Name = "label1";
            label1.Size = new Size(115, 36);
            label1.TabIndex = 0;
            label1.Text = "Sign in";
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(sign_btn);
            panel1.Controls.Add(password);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(username);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(91, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(605, 596);
            panel1.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(178, 425);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(129, 24);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Remember me";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(275, 552);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(59, 20);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign up";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // sign_btn
            // 
            sign_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sign_btn.Location = new Point(250, 481);
            sign_btn.Name = "sign_btn";
            sign_btn.Size = new Size(120, 54);
            sign_btn.TabIndex = 6;
            sign_btn.Text = "Sign in";
            sign_btn.UseVisualStyleBackColor = true;
            sign_btn.Click += sign_btn_Click;
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.Location = new Point(178, 385);
            password.Name = "password";
            password.Size = new Size(274, 34);
            password.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(253, 347);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // username
            // 
            username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.Location = new Point(178, 287);
            username.Name = "username";
            username.Size = new Size(274, 34);
            username.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(253, 259);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 2;
            label2.Text = "UserName";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.download__1_;
            pictureBox1.Location = new Point(201, -12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 191);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 676);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox password;
        private Label label3;
        private TextBox username;
        private CheckBox checkBox1;
        private LinkLabel linkLabel1;
        private Button sign_btn;
    }
}