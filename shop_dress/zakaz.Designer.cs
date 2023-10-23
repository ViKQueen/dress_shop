namespace shop_dress
{
    partial class zakaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(zakaz));
            this.orderButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.quanTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.prevPicBox = new System.Windows.Forms.PictureBox();
            this.thingRichTextBox = new System.Windows.Forms.RichTextBox();
            this.clientRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.razmerTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.prevPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // orderButton
            // 
            this.orderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderButton.Location = new System.Drawing.Point(705, 217);
            this.orderButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(276, 53);
            this.orderButton.TabIndex = 0;
            this.orderButton.Text = "Оформить заказ";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Получатель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Товар";
            // 
            // quanTextBox
            // 
            this.quanTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quanTextBox.Location = new System.Drawing.Point(527, 46);
            this.quanTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quanTextBox.Name = "quanTextBox";
            this.quanTextBox.Size = new System.Drawing.Size(240, 34);
            this.quanTextBox.TabIndex = 6;
            this.quanTextBox.Text = "1";
            this.quanTextBox.TextChanged += new System.EventHandler(this.quanTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(521, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введите количество";
            // 
            // costTextBox
            // 
            this.costTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costTextBox.Location = new System.Drawing.Point(527, 129);
            this.costTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.ReadOnly = true;
            this.costTextBox.Size = new System.Drawing.Size(240, 34);
            this.costTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(521, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Цена товара";
            // 
            // dateTextBox
            // 
            this.dateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTextBox.Location = new System.Drawing.Point(807, 129);
            this.dateTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.ReadOnly = true;
            this.dateTextBox.Size = new System.Drawing.Size(272, 34);
            this.dateTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(801, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Дата исполнения";
            // 
            // prevPicBox
            // 
            this.prevPicBox.Image = ((System.Drawing.Image)(resources.GetObject("prevPicBox.Image")));
            this.prevPicBox.Location = new System.Drawing.Point(555, 219);
            this.prevPicBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prevPicBox.Name = "prevPicBox";
            this.prevPicBox.Size = new System.Drawing.Size(100, 50);
            this.prevPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.prevPicBox.TabIndex = 11;
            this.prevPicBox.TabStop = false;
            this.prevPicBox.Click += new System.EventHandler(this.prevPicBox_Click);
            // 
            // thingRichTextBox
            // 
            this.thingRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thingRichTextBox.Location = new System.Drawing.Point(15, 203);
            this.thingRichTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.thingRichTextBox.Name = "thingRichTextBox";
            this.thingRichTextBox.ReadOnly = true;
            this.thingRichTextBox.Size = new System.Drawing.Size(475, 82);
            this.thingRichTextBox.TabIndex = 12;
            this.thingRichTextBox.Text = "";
            // 
            // clientRichTextBox
            // 
            this.clientRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientRichTextBox.Location = new System.Drawing.Point(15, 46);
            this.clientRichTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientRichTextBox.Name = "clientRichTextBox";
            this.clientRichTextBox.ReadOnly = true;
            this.clientRichTextBox.Size = new System.Drawing.Size(475, 117);
            this.clientRichTextBox.TabIndex = 13;
            this.clientRichTextBox.Text = "";
            this.clientRichTextBox.TextChanged += new System.EventHandler(this.clientRichTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(801, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Размер";
            // 
            // razmerTextBox
            // 
            this.razmerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.razmerTextBox.Location = new System.Drawing.Point(807, 46);
            this.razmerTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.razmerTextBox.Name = "razmerTextBox";
            this.razmerTextBox.Size = new System.Drawing.Size(240, 34);
            this.razmerTextBox.TabIndex = 15;
            // 
            // zakaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1100, 294);
            this.Controls.Add(this.razmerTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.clientRichTextBox);
            this.Controls.Add(this.thingRichTextBox);
            this.Controls.Add(this.prevPicBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.quanTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1118, 341);
            this.MinimumSize = new System.Drawing.Size(1118, 341);
            this.Name = "zakaz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оформление заказа в «Shop Dress»";
            this.Load += new System.EventHandler(this.zakaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prevPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox quanTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox prevPicBox;
        private System.Windows.Forms.RichTextBox thingRichTextBox;
        private System.Windows.Forms.RichTextBox clientRichTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox razmerTextBox;
    }
}