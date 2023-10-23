namespace shop_dress
{
    partial class authorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(authorization));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.authButton = new System.Windows.Forms.Button();
            this.labelReg = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.prevPicBox = new System.Windows.Forms.PictureBox();
            this.eyeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(211, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(105, 143);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(105, 236);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(217, 156);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(243, 45);
            this.loginTextBox.TabIndex = 3;
            this.toolTip1.SetToolTip(this.loginTextBox, "Введите логин");
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(217, 247);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(243, 45);
            this.passwordTextBox.TabIndex = 4;
            this.toolTip1.SetToolTip(this.passwordTextBox, "Введите пароль");
            // 
            // authButton
            // 
            this.authButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authButton.Location = new System.Drawing.Point(235, 358);
            this.authButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.authButton.Name = "authButton";
            this.authButton.Size = new System.Drawing.Size(156, 48);
            this.authButton.TabIndex = 5;
            this.authButton.Text = "Войти";
            this.authButton.UseVisualStyleBackColor = true;
            this.authButton.Click += new System.EventHandler(this.authButton_Click);
            // 
            // labelReg
            // 
            this.labelReg.AutoSize = true;
            this.labelReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReg.ForeColor = System.Drawing.Color.Transparent;
            this.labelReg.Location = new System.Drawing.Point(235, 423);
            this.labelReg.Name = "labelReg";
            this.labelReg.Size = new System.Drawing.Size(159, 29);
            this.labelReg.TabIndex = 6;
            this.labelReg.Text = "Регистрация";
            this.labelReg.Click += new System.EventHandler(this.labelReg_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // prevPicBox
            // 
            this.prevPicBox.Image = ((System.Drawing.Image)(resources.GetObject("prevPicBox.Image")));
            this.prevPicBox.Location = new System.Drawing.Point(12, 22);
            this.prevPicBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prevPicBox.Name = "prevPicBox";
            this.prevPicBox.Size = new System.Drawing.Size(50, 50);
            this.prevPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.prevPicBox.TabIndex = 7;
            this.prevPicBox.TabStop = false;
            this.prevPicBox.Click += new System.EventHandler(this.prevPicBox_Click);
            // 
            // eyeButton
            // 
            this.eyeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eyeButton.Location = new System.Drawing.Point(467, 247);
            this.eyeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eyeButton.Name = "eyeButton";
            this.eyeButton.Size = new System.Drawing.Size(76, 46);
            this.eyeButton.TabIndex = 8;
            this.eyeButton.Text = "👁";
            this.eyeButton.UseVisualStyleBackColor = true;
            this.eyeButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.eyeButton_MouseDown);
            this.eyeButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.eyeButton_MouseUp);
            // 
            // authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(611, 497);
            this.Controls.Add(this.eyeButton);
            this.Controls.Add(this.prevPicBox);
            this.Controls.Add(this.labelReg);
            this.Controls.Add(this.authButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(629, 544);
            this.MinimumSize = new System.Drawing.Size(629, 544);
            this.Name = "authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация в «Shop Dress»";
            this.Load += new System.EventHandler(this.authorization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button authButton;
        private System.Windows.Forms.Label labelReg;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox prevPicBox;
        private System.Windows.Forms.Button eyeButton;
    }
}