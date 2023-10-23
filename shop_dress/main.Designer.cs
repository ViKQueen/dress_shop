namespace shop_dress
{
    partial class main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.authPicBox = new System.Windows.Forms.PictureBox();
            this.zakazButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.itemPictureBox = new System.Windows.Forms.PictureBox();
            this.nameRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.prevPicBox = new System.Windows.Forms.PictureBox();
            this.nextPicBox = new System.Windows.Forms.PictureBox();
            this.polComboBox = new System.Windows.Forms.ComboBox();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.sostavTextBox = new System.Windows.Forms.TextBox();
            this.razmerTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.logLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.authPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // typeComboBox
            // 
            this.typeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(36, 71);
            this.typeComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(275, 34);
            this.typeComboBox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.typeComboBox, "Вид товара");
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // authPicBox
            // 
            this.authPicBox.Image = ((System.Drawing.Image)(resources.GetObject("authPicBox.Image")));
            this.authPicBox.Location = new System.Drawing.Point(705, -2);
            this.authPicBox.Margin = new System.Windows.Forms.Padding(2);
            this.authPicBox.Name = "authPicBox";
            this.authPicBox.Size = new System.Drawing.Size(60, 58);
            this.authPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.authPicBox.TabIndex = 16;
            this.authPicBox.TabStop = false;
            this.toolTip1.SetToolTip(this.authPicBox, "Кнопка для авторизации");
            this.authPicBox.Click += new System.EventHandler(this.authPicBox_Click);
            // 
            // zakazButton
            // 
            this.zakazButton.Enabled = false;
            this.zakazButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zakazButton.Location = new System.Drawing.Point(36, 426);
            this.zakazButton.Margin = new System.Windows.Forms.Padding(2);
            this.zakazButton.Name = "zakazButton";
            this.zakazButton.Size = new System.Drawing.Size(197, 43);
            this.zakazButton.TabIndex = 7;
            this.zakazButton.Text = "Оформить заказ";
            this.toolTip1.SetToolTip(this.zakazButton, "Чтобы оформить заказ нужно авторизоваться");
            this.zakazButton.UseVisualStyleBackColor = true;
            this.zakazButton.Click += new System.EventHandler(this.zakazButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(508, 10);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Справка");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Tempus Sans ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(566, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 35);
            this.label5.TabIndex = 15;
            this.label5.Text = "Shop Dress";
            this.toolTip1.SetToolTip(this.label5, "О программе");
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // itemPictureBox
            // 
            this.itemPictureBox.Location = new System.Drawing.Point(460, 71);
            this.itemPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.itemPictureBox.Name = "itemPictureBox";
            this.itemPictureBox.Size = new System.Drawing.Size(305, 407);
            this.itemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.itemPictureBox.TabIndex = 1;
            this.itemPictureBox.TabStop = false;
            // 
            // nameRichTextBox
            // 
            this.nameRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameRichTextBox.Location = new System.Drawing.Point(36, 120);
            this.nameRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameRichTextBox.Name = "nameRichTextBox";
            this.nameRichTextBox.Size = new System.Drawing.Size(357, 40);
            this.nameRichTextBox.TabIndex = 1;
            this.nameRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 377);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Цена:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 274);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Состав:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(30, 225);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Цвет:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(32, 324);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Размер:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(32, 178);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Пол:";
            // 
            // prevPicBox
            // 
            this.prevPicBox.Enabled = false;
            this.prevPicBox.Image = ((System.Drawing.Image)(resources.GetObject("prevPicBox.Image")));
            this.prevPicBox.Location = new System.Drawing.Point(305, 419);
            this.prevPicBox.Margin = new System.Windows.Forms.Padding(2);
            this.prevPicBox.Name = "prevPicBox";
            this.prevPicBox.Size = new System.Drawing.Size(50, 50);
            this.prevPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.prevPicBox.TabIndex = 18;
            this.prevPicBox.TabStop = false;
            this.prevPicBox.Click += new System.EventHandler(this.prevPicBox_Click);
            // 
            // nextPicBox
            // 
            this.nextPicBox.Enabled = false;
            this.nextPicBox.Image = ((System.Drawing.Image)(resources.GetObject("nextPicBox.Image")));
            this.nextPicBox.Location = new System.Drawing.Point(376, 419);
            this.nextPicBox.Margin = new System.Windows.Forms.Padding(2);
            this.nextPicBox.Name = "nextPicBox";
            this.nextPicBox.Size = new System.Drawing.Size(50, 50);
            this.nextPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.nextPicBox.TabIndex = 19;
            this.nextPicBox.TabStop = false;
            this.nextPicBox.Click += new System.EventHandler(this.nextPicBox_Click);
            // 
            // polComboBox
            // 
            this.polComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.polComboBox.FormattingEnabled = true;
            this.polComboBox.Location = new System.Drawing.Point(110, 178);
            this.polComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.polComboBox.Name = "polComboBox";
            this.polComboBox.Size = new System.Drawing.Size(175, 30);
            this.polComboBox.TabIndex = 2;
            this.polComboBox.SelectedIndexChanged += new System.EventHandler(this.polComboBox_SelectedIndexChanged);
            // 
            // colorComboBox
            // 
            this.colorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Location = new System.Drawing.Point(110, 225);
            this.colorComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(175, 30);
            this.colorComboBox.TabIndex = 3;
            this.colorComboBox.SelectedIndexChanged += new System.EventHandler(this.colorComboBox_SelectedIndexChanged);
            // 
            // sostavTextBox
            // 
            this.sostavTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sostavTextBox.Location = new System.Drawing.Point(110, 272);
            this.sostavTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.sostavTextBox.Name = "sostavTextBox";
            this.sostavTextBox.Size = new System.Drawing.Size(280, 28);
            this.sostavTextBox.TabIndex = 4;
            // 
            // razmerTextBox
            // 
            this.razmerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.razmerTextBox.Location = new System.Drawing.Point(110, 321);
            this.razmerTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.razmerTextBox.Name = "razmerTextBox";
            this.razmerTextBox.Size = new System.Drawing.Size(280, 28);
            this.razmerTextBox.TabIndex = 5;
            // 
            // costTextBox
            // 
            this.costTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costTextBox.Location = new System.Drawing.Point(110, 374);
            this.costTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(280, 28);
            this.costTextBox.TabIndex = 6;
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logLabel.Location = new System.Drawing.Point(32, 24);
            this.logLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(186, 24);
            this.logLabel.TabIndex = 20;
            this.logLabel.Text = "Вы вошли как гость";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(774, 490);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.razmerTextBox);
            this.Controls.Add(this.sostavTextBox);
            this.Controls.Add(this.colorComboBox);
            this.Controls.Add(this.polComboBox);
            this.Controls.Add(this.nextPicBox);
            this.Controls.Add(this.prevPicBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.authPicBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.zakazButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameRichTextBox);
            this.Controls.Add(this.itemPictureBox);
            this.Controls.Add(this.typeComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(790, 529);
            this.MinimumSize = new System.Drawing.Size(790, 529);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добро пожаловать в «Shop Dress»!";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.authPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox itemPictureBox;
        private System.Windows.Forms.RichTextBox nameRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button zakazButton;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox authPicBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox prevPicBox;
        private System.Windows.Forms.PictureBox nextPicBox;
        private System.Windows.Forms.ComboBox polComboBox;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.TextBox sostavTextBox;
        private System.Windows.Forms.TextBox razmerTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label logLabel;
    }
}

