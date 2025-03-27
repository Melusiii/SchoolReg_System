
namespace SchoolReg_system
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
            panel1 = new Panel();
            link_sign_in = new LinkLabel();
            btn_SignUp = new Button();
            chbox_remember = new CheckBox();
            txt_password2 = new TextBox();
            lbl_password2 = new Label();
            txt_password = new TextBox();
            lbl_password = new Label();
            email = new TextBox();
            lbl_email = new Label();
            logo = new PictureBox();
            gender = new ComboBox();
            datepicker = new DateTimePicker();
            lbl_Gender = new Label();
            lbl_Bday = new Label();
            last_name = new TextBox();
            lbl_2ndName = new Label();
            first_name = new TextBox();
            lbl_1stname = new Label();
            lbl_SignUp = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(link_sign_in);
            panel1.Controls.Add(btn_SignUp);
            panel1.Controls.Add(chbox_remember);
            panel1.Controls.Add(txt_password2);
            panel1.Controls.Add(lbl_password2);
            panel1.Controls.Add(txt_password);
            panel1.Controls.Add(lbl_password);
            panel1.Controls.Add(email);
            panel1.Controls.Add(lbl_email);
            panel1.Controls.Add(logo);
            panel1.Controls.Add(gender);
            panel1.Controls.Add(datepicker);
            panel1.Controls.Add(lbl_Gender);
            panel1.Controls.Add(lbl_Bday);
            panel1.Controls.Add(last_name);
            panel1.Controls.Add(lbl_2ndName);
            panel1.Controls.Add(first_name);
            panel1.Controls.Add(lbl_1stname);
            panel1.Controls.Add(lbl_SignUp);
            panel1.Location = new Point(153, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(609, 653);
            panel1.TabIndex = 0;
            // 
            // link_sign_in
            // 
            link_sign_in.AutoSize = true;
            link_sign_in.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            link_sign_in.Location = new Point(276, 625);
            link_sign_in.Name = "link_sign_in";
            link_sign_in.Size = new Size(52, 18);
            link_sign_in.TabIndex = 20;
            link_sign_in.TabStop = true;
            link_sign_in.Text = "Sign in";
            link_sign_in.LinkClicked += link_sign_in_LinkClicked;
            // 
            // btn_SignUp
            // 
            btn_SignUp.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_SignUp.Location = new Point(214, 573);
            btn_SignUp.Name = "btn_SignUp";
            btn_SignUp.Size = new Size(172, 49);
            btn_SignUp.TabIndex = 19;
            btn_SignUp.Text = "Sign Up";
            btn_SignUp.UseVisualStyleBackColor = true;
            btn_SignUp.Click += btn_SignUp_Click_1;
            // 
            // chbox_remember
            // 
            chbox_remember.AutoSize = true;
            chbox_remember.Location = new Point(370, 461);
            chbox_remember.Name = "chbox_remember";
            chbox_remember.Size = new Size(131, 24);
            chbox_remember.TabIndex = 18;
            chbox_remember.Text = "Remember_me";
            chbox_remember.UseVisualStyleBackColor = true;
            chbox_remember.CheckedChanged += chbox_remember_CheckedChanged;
            // 
            // txt_password2
            // 
            txt_password2.Location = new Point(370, 428);
            txt_password2.Name = "txt_password2";
            txt_password2.Size = new Size(211, 27);
            txt_password2.TabIndex = 17;
            // 
            // lbl_password2
            // 
            lbl_password2.AutoSize = true;
            lbl_password2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_password2.Location = new Point(370, 400);
            lbl_password2.Name = "lbl_password2";
            lbl_password2.Size = new Size(171, 25);
            lbl_password2.TabIndex = 16;
            lbl_password2.Text = "Confirm Password";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(370, 343);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(211, 27);
            txt_password.TabIndex = 15;
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_password.Location = new Point(370, 315);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(98, 25);
            lbl_password.TabIndex = 14;
            lbl_password.Text = "Password";
            // 
            // email
            // 
            email.Location = new Point(370, 271);
            email.Name = "email";
            email.Size = new Size(211, 27);
            email.TabIndex = 13;
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_email.Location = new Point(370, 243);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(60, 25);
            lbl_email.TabIndex = 12;
            lbl_email.Text = "Email";
            // 
            // logo
            // 
            logo.Image = Properties.Resources.download__1_;
            logo.Location = new Point(183, -32);
            logo.Name = "logo";
            logo.Size = new Size(224, 196);
            logo.TabIndex = 11;
            logo.TabStop = false;
            // 
            // gender
            // 
            gender.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gender.FormattingEnabled = true;
            gender.Items.AddRange(new object[] { "Male", "Female" });
            gender.Location = new Point(28, 422);
            gender.Name = "gender";
            gender.Size = new Size(211, 33);
            gender.TabIndex = 10;
            // 
            // datepicker
            // 
            datepicker.CalendarFont = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datepicker.Location = new Point(28, 498);
            datepicker.Name = "datepicker";
            datepicker.Size = new Size(248, 27);
            datepicker.TabIndex = 9;
            // 
            // lbl_Gender
            // 
            lbl_Gender.AutoSize = true;
            lbl_Gender.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Gender.Location = new Point(28, 394);
            lbl_Gender.Name = "lbl_Gender";
            lbl_Gender.Size = new Size(77, 25);
            lbl_Gender.TabIndex = 7;
            lbl_Gender.Text = "Gender";
            // 
            // lbl_Bday
            // 
            lbl_Bday.AutoSize = true;
            lbl_Bday.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Bday.Location = new Point(28, 470);
            lbl_Bday.Name = "lbl_Bday";
            lbl_Bday.Size = new Size(97, 25);
            lbl_Bday.TabIndex = 5;
            lbl_Bday.Text = "Birth Date";
            // 
            // last_name
            // 
            last_name.Location = new Point(28, 343);
            last_name.Name = "last_name";
            last_name.Size = new Size(211, 27);
            last_name.TabIndex = 4;
            // 
            // lbl_2ndName
            // 
            lbl_2ndName.AutoSize = true;
            lbl_2ndName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_2ndName.Location = new Point(28, 315);
            lbl_2ndName.Name = "lbl_2ndName";
            lbl_2ndName.Size = new Size(101, 25);
            lbl_2ndName.TabIndex = 3;
            lbl_2ndName.Text = "LastName";
            // 
            // first_name
            // 
            first_name.Location = new Point(28, 271);
            first_name.Name = "first_name";
            first_name.Size = new Size(211, 27);
            first_name.TabIndex = 2;
            // 
            // lbl_1stname
            // 
            lbl_1stname.AutoSize = true;
            lbl_1stname.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_1stname.Location = new Point(28, 243);
            lbl_1stname.Name = "lbl_1stname";
            lbl_1stname.Size = new Size(101, 25);
            lbl_1stname.TabIndex = 1;
            lbl_1stname.Text = "FirstName";
            // 
            // lbl_SignUp
            // 
            lbl_SignUp.AutoSize = true;
            lbl_SignUp.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_SignUp.Location = new Point(214, 167);
            lbl_SignUp.Name = "lbl_SignUp";
            lbl_SignUp.Size = new Size(151, 42);
            lbl_SignUp.TabIndex = 0;
            lbl_SignUp.Text = "Sign Up";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 692);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
        }

        private void chbox_remember_CheckedChanged(object sender, EventArgs e)
        {

            if (chbox_remember.Checked)
            {
                txt_password.UseSystemPasswordChar = false;
                txt_password2.UseSystemPasswordChar = false;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
                txt_password2.UseSystemPasswordChar = true;
            }
          
        }

        #endregion

        private Panel panel1;
        private Label lbl_SignUp;
        private Label lbl_1stname;
        private DateTimePicker datepicker;
        private TextBox textBox3;
        private Label lbl_Gender;
        private Label lbl_Bday;
        private TextBox last_name;
        private Label lbl_2ndName;
        private TextBox first_name;
        private ComboBox gender;
        private PictureBox logo;
        private TextBox email;
        private Label lbl_email;
        private TextBox txt_password2;
        private Label lbl_password2;
        private TextBox txt_password;
        private Label lbl_password;
        private CheckBox chbox_remember;
        private LinkLabel link_sign_in;
        private Button btn_SignUp;
    }
}
