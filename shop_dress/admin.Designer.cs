namespace shop_dress
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.katalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazinDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazinDataSet = new shop_dress.magazinDataSet();
            this.zakazBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.katalogTableAdapter = new shop_dress.magazinDataSetTableAdapters.katalogTableAdapter();
            this.zakazTableAdapter = new shop_dress.magazinDataSetTableAdapters.zakazTableAdapter();
            this.prevPicBox = new System.Windows.Forms.PictureBox();
            this.magazinKatalogDataSet = new shop_dress.magazinKatalogDataSet();
            this.katalogBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.katalogTableAdapter1 = new shop_dress.magazinKatalogDataSetTableAdapters.katalogTableAdapter();
            this.bdLabel = new System.Windows.Forms.Label();
            this.katalogBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveButton = new System.Windows.Forms.Button();
            this.zakazyButton = new System.Windows.Forms.Button();
            this.pictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razmerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sostavDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtipeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idkatalogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.katalogDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.katalogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazinDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazinKatalogDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.katalogBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.katalogBindingNavigator)).BeginInit();
            this.katalogBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.katalogDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // katalogBindingSource
            // 
            this.katalogBindingSource.DataMember = "katalog";
            this.katalogBindingSource.DataSource = this.magazinDataSetBindingSource;
            // 
            // magazinDataSetBindingSource
            // 
            this.magazinDataSetBindingSource.DataSource = this.magazinDataSet;
            this.magazinDataSetBindingSource.Position = 0;
            // 
            // magazinDataSet
            // 
            this.magazinDataSet.DataSetName = "magazinDataSet";
            this.magazinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zakazBindingSource
            // 
            this.zakazBindingSource.DataMember = "zakaz";
            this.zakazBindingSource.DataSource = this.magazinDataSetBindingSource;
            // 
            // katalogTableAdapter
            // 
            this.katalogTableAdapter.ClearBeforeFill = true;
            // 
            // zakazTableAdapter
            // 
            this.zakazTableAdapter.ClearBeforeFill = true;
            // 
            // prevPicBox
            // 
            this.prevPicBox.Image = ((System.Drawing.Image)(resources.GetObject("prevPicBox.Image")));
            this.prevPicBox.Location = new System.Drawing.Point(16, 398);
            this.prevPicBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prevPicBox.Name = "prevPicBox";
            this.prevPicBox.Size = new System.Drawing.Size(50, 50);
            this.prevPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.prevPicBox.TabIndex = 8;
            this.prevPicBox.TabStop = false;
            this.prevPicBox.Click += new System.EventHandler(this.prevPicBox_Click);
            // 
            // magazinKatalogDataSet
            // 
            this.magazinKatalogDataSet.DataSetName = "magazinKatalogDataSet";
            this.magazinKatalogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // katalogBindingSource1
            // 
            this.katalogBindingSource1.DataMember = "katalog";
            this.katalogBindingSource1.DataSource = this.magazinKatalogDataSet;
            // 
            // katalogTableAdapter1
            // 
            this.katalogTableAdapter1.ClearBeforeFill = true;
            // 
            // bdLabel
            // 
            this.bdLabel.AutoSize = true;
            this.bdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bdLabel.Location = new System.Drawing.Point(15, 25);
            this.bdLabel.Name = "bdLabel";
            this.bdLabel.Size = new System.Drawing.Size(328, 39);
            this.bdLabel.TabIndex = 21;
            this.bdLabel.Text = "Таблица «Каталог»";
            // 
            // katalogBindingNavigator
            // 
            this.katalogBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.katalogBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.katalogBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.katalogBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.katalogBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.katalogBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.katalogBindingNavigator.Location = new System.Drawing.Point(119, 411);
            this.katalogBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.katalogBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.katalogBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.katalogBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.katalogBindingNavigator.Name = "katalogBindingNavigator";
            this.katalogBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.katalogBindingNavigator.Size = new System.Drawing.Size(369, 39);
            this.katalogBindingNavigator.TabIndex = 22;
            this.katalogBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 36);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(613, 411);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(335, 47);
            this.saveButton.TabIndex = 23;
            this.saveButton.Text = "Сохранить изменения";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // zakazyButton
            // 
            this.zakazyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zakazyButton.Location = new System.Drawing.Point(977, 411);
            this.zakazyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zakazyButton.Name = "zakazyButton";
            this.zakazyButton.Size = new System.Drawing.Size(335, 47);
            this.zakazyButton.TabIndex = 24;
            this.zakazyButton.Text = "Таблица «Заказы»";
            this.zakazyButton.UseVisualStyleBackColor = true;
            this.zakazyButton.Click += new System.EventHandler(this.zakazyButton_Click);
            // 
            // pictureDataGridViewTextBoxColumn
            // 
            this.pictureDataGridViewTextBoxColumn.DataPropertyName = "picture";
            this.pictureDataGridViewTextBoxColumn.HeaderText = "picture";
            this.pictureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pictureDataGridViewTextBoxColumn.Name = "pictureDataGridViewTextBoxColumn";
            this.pictureDataGridViewTextBoxColumn.Width = 125;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "color";
            this.colorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.Width = 125;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.Width = 125;
            // 
            // polDataGridViewTextBoxColumn
            // 
            this.polDataGridViewTextBoxColumn.DataPropertyName = "pol";
            this.polDataGridViewTextBoxColumn.HeaderText = "pol";
            this.polDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.polDataGridViewTextBoxColumn.Name = "polDataGridViewTextBoxColumn";
            this.polDataGridViewTextBoxColumn.Width = 125;
            // 
            // razmerDataGridViewTextBoxColumn
            // 
            this.razmerDataGridViewTextBoxColumn.DataPropertyName = "razmer";
            this.razmerDataGridViewTextBoxColumn.HeaderText = "razmer";
            this.razmerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.razmerDataGridViewTextBoxColumn.Name = "razmerDataGridViewTextBoxColumn";
            this.razmerDataGridViewTextBoxColumn.Width = 125;
            // 
            // sostavDataGridViewTextBoxColumn
            // 
            this.sostavDataGridViewTextBoxColumn.DataPropertyName = "sostav";
            this.sostavDataGridViewTextBoxColumn.HeaderText = "sostav";
            this.sostavDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sostavDataGridViewTextBoxColumn.Name = "sostavDataGridViewTextBoxColumn";
            this.sostavDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // idtipeDataGridViewTextBoxColumn
            // 
            this.idtipeDataGridViewTextBoxColumn.DataPropertyName = "id_tipe";
            this.idtipeDataGridViewTextBoxColumn.HeaderText = "id_tipe";
            this.idtipeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idtipeDataGridViewTextBoxColumn.Name = "idtipeDataGridViewTextBoxColumn";
            this.idtipeDataGridViewTextBoxColumn.Width = 125;
            // 
            // idkatalogDataGridViewTextBoxColumn
            // 
            this.idkatalogDataGridViewTextBoxColumn.DataPropertyName = "id_katalog";
            this.idkatalogDataGridViewTextBoxColumn.HeaderText = "id_katalog";
            this.idkatalogDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idkatalogDataGridViewTextBoxColumn.Name = "idkatalogDataGridViewTextBoxColumn";
            this.idkatalogDataGridViewTextBoxColumn.ReadOnly = true;
            this.idkatalogDataGridViewTextBoxColumn.Width = 125;
            // 
            // katalogDataGridView
            // 
            this.katalogDataGridView.AutoGenerateColumns = false;
            this.katalogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.katalogDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkatalogDataGridViewTextBoxColumn,
            this.idtipeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.sostavDataGridViewTextBoxColumn,
            this.razmerDataGridViewTextBoxColumn,
            this.polDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.pictureDataGridViewTextBoxColumn});
            this.katalogDataGridView.DataSource = this.katalogBindingSource1;
            this.katalogDataGridView.Location = new System.Drawing.Point(16, 80);
            this.katalogDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.katalogDataGridView.Name = "katalogDataGridView";
            this.katalogDataGridView.RowHeadersWidth = 51;
            this.katalogDataGridView.Size = new System.Drawing.Size(1296, 311);
            this.katalogDataGridView.TabIndex = 9;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1328, 471);
            this.Controls.Add(this.zakazyButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.katalogBindingNavigator);
            this.Controls.Add(this.bdLabel);
            this.Controls.Add(this.katalogDataGridView);
            this.Controls.Add(this.prevPicBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1346, 518);
            this.MinimumSize = new System.Drawing.Size(1346, 518);
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование базы данных (Каталог)";
            this.Load += new System.EventHandler(this.admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.katalogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazinDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazinKatalogDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.katalogBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.katalogBindingNavigator)).EndInit();
            this.katalogBindingNavigator.ResumeLayout(false);
            this.katalogBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.katalogDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource magazinDataSetBindingSource;
        private magazinDataSet magazinDataSet;
        private System.Windows.Forms.BindingSource katalogBindingSource;
        private magazinDataSetTableAdapters.katalogTableAdapter katalogTableAdapter;
        private System.Windows.Forms.BindingSource zakazBindingSource;
        private magazinDataSetTableAdapters.zakazTableAdapter zakazTableAdapter;
        private System.Windows.Forms.PictureBox prevPicBox;
        private magazinKatalogDataSet magazinKatalogDataSet;
        private System.Windows.Forms.BindingSource katalogBindingSource1;
        private magazinKatalogDataSetTableAdapters.katalogTableAdapter katalogTableAdapter1;
        private System.Windows.Forms.Label bdLabel;
        private System.Windows.Forms.BindingNavigator katalogBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button zakazyButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn pictureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn polDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razmerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sostavDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtipeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkatalogDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView katalogDataGridView;
    }
}