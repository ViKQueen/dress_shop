namespace shop_dress
{
    partial class admZak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admZak));
            this.bdLabel = new System.Windows.Forms.Label();
            this.zakazBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazinZakazDataSet = new shop_dress.magazinZakazDataSet();
            this.zakazTableAdapter = new shop_dress.magazinZakazDataSetTableAdapters.zakazTableAdapter();
            this.prevPicBox = new System.Windows.Forms.PictureBox();
            this.zakazyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.razmerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datevpolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idkatalogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idklientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idzakazaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zakazyDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazinZakazDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazyBindingNavigator)).BeginInit();
            this.zakazyBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zakazyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bdLabel
            // 
            this.bdLabel.AutoSize = true;
            this.bdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bdLabel.Location = new System.Drawing.Point(8, 23);
            this.bdLabel.Name = "bdLabel";
            this.bdLabel.Size = new System.Drawing.Size(318, 39);
            this.bdLabel.TabIndex = 22;
            this.bdLabel.Text = "Таблица «Заказы»";
            // 
            // zakazBindingSource
            // 
            this.zakazBindingSource.DataMember = "zakaz";
            this.zakazBindingSource.DataSource = this.magazinZakazDataSet;
            // 
            // magazinZakazDataSet
            // 
            this.magazinZakazDataSet.DataSetName = "magazinZakazDataSet";
            this.magazinZakazDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zakazTableAdapter
            // 
            this.zakazTableAdapter.ClearBeforeFill = true;
            // 
            // prevPicBox
            // 
            this.prevPicBox.Image = ((System.Drawing.Image)(resources.GetObject("prevPicBox.Image")));
            this.prevPicBox.Location = new System.Drawing.Point(15, 406);
            this.prevPicBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prevPicBox.Name = "prevPicBox";
            this.prevPicBox.Size = new System.Drawing.Size(50, 50);
            this.prevPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.prevPicBox.TabIndex = 24;
            this.prevPicBox.TabStop = false;
            this.prevPicBox.Click += new System.EventHandler(this.prevPicBox_Click);
            // 
            // zakazyBindingNavigator
            // 
            this.zakazyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.zakazyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.zakazyBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.zakazyBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.zakazyBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.zakazyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.zakazyBindingNavigator.Location = new System.Drawing.Point(97, 420);
            this.zakazyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.zakazyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.zakazyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.zakazyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.zakazyBindingNavigator.Name = "zakazyBindingNavigator";
            this.zakazyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.zakazyBindingNavigator.Size = new System.Drawing.Size(369, 39);
            this.zakazyBindingNavigator.TabIndex = 25;
            this.zakazyBindingNavigator.Text = "bindingNavigator1";
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
            this.saveButton.Location = new System.Drawing.Point(581, 421);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(447, 47);
            this.saveButton.TabIndex = 26;
            this.saveButton.Text = "Сохранить изменения";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // razmerDataGridViewTextBoxColumn
            // 
            this.razmerDataGridViewTextBoxColumn.DataPropertyName = "razmer";
            this.razmerDataGridViewTextBoxColumn.HeaderText = "razmer";
            this.razmerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.razmerDataGridViewTextBoxColumn.Name = "razmerDataGridViewTextBoxColumn";
            this.razmerDataGridViewTextBoxColumn.Width = 125;
            // 
            // datevpolDataGridViewTextBoxColumn
            // 
            this.datevpolDataGridViewTextBoxColumn.DataPropertyName = "date_vpol";
            this.datevpolDataGridViewTextBoxColumn.HeaderText = "date_vpol";
            this.datevpolDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datevpolDataGridViewTextBoxColumn.Name = "datevpolDataGridViewTextBoxColumn";
            this.datevpolDataGridViewTextBoxColumn.Width = 125;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.Width = 125;
            // 
            // colicDataGridViewTextBoxColumn
            // 
            this.colicDataGridViewTextBoxColumn.DataPropertyName = "colic";
            this.colicDataGridViewTextBoxColumn.HeaderText = "colic";
            this.colicDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.colicDataGridViewTextBoxColumn.Name = "colicDataGridViewTextBoxColumn";
            this.colicDataGridViewTextBoxColumn.Width = 125;
            // 
            // idkatalogDataGridViewTextBoxColumn
            // 
            this.idkatalogDataGridViewTextBoxColumn.DataPropertyName = "id_katalog";
            this.idkatalogDataGridViewTextBoxColumn.HeaderText = "id_katalog";
            this.idkatalogDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idkatalogDataGridViewTextBoxColumn.Name = "idkatalogDataGridViewTextBoxColumn";
            this.idkatalogDataGridViewTextBoxColumn.Width = 125;
            // 
            // idklientDataGridViewTextBoxColumn
            // 
            this.idklientDataGridViewTextBoxColumn.DataPropertyName = "id_klient";
            this.idklientDataGridViewTextBoxColumn.HeaderText = "id_klient";
            this.idklientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idklientDataGridViewTextBoxColumn.Name = "idklientDataGridViewTextBoxColumn";
            this.idklientDataGridViewTextBoxColumn.Width = 125;
            // 
            // idzakazaDataGridViewTextBoxColumn
            // 
            this.idzakazaDataGridViewTextBoxColumn.DataPropertyName = "id_zakaza";
            this.idzakazaDataGridViewTextBoxColumn.HeaderText = "id_zakaza";
            this.idzakazaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idzakazaDataGridViewTextBoxColumn.Name = "idzakazaDataGridViewTextBoxColumn";
            this.idzakazaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idzakazaDataGridViewTextBoxColumn.Width = 125;
            // 
            // zakazyDataGridView
            // 
            this.zakazyDataGridView.AutoGenerateColumns = false;
            this.zakazyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zakazyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idzakazaDataGridViewTextBoxColumn,
            this.idklientDataGridViewTextBoxColumn,
            this.idkatalogDataGridViewTextBoxColumn,
            this.colicDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.datevpolDataGridViewTextBoxColumn,
            this.razmerDataGridViewTextBoxColumn});
            this.zakazyDataGridView.DataSource = this.zakazBindingSource;
            this.zakazyDataGridView.Location = new System.Drawing.Point(16, 78);
            this.zakazyDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.zakazyDataGridView.Name = "zakazyDataGridView";
            this.zakazyDataGridView.RowHeadersWidth = 51;
            this.zakazyDataGridView.Size = new System.Drawing.Size(1012, 322);
            this.zakazyDataGridView.TabIndex = 23;
            // 
            // admZak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1057, 471);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.zakazyBindingNavigator);
            this.Controls.Add(this.prevPicBox);
            this.Controls.Add(this.zakazyDataGridView);
            this.Controls.Add(this.bdLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1075, 518);
            this.MinimumSize = new System.Drawing.Size(1075, 518);
            this.Name = "admZak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование базы данных (Заказы)";
            this.Load += new System.EventHandler(this.admZak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazinZakazDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazyBindingNavigator)).EndInit();
            this.zakazyBindingNavigator.ResumeLayout(false);
            this.zakazyBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zakazyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bdLabel;
        private magazinZakazDataSet magazinZakazDataSet;
        private System.Windows.Forms.BindingSource zakazBindingSource;
        private magazinZakazDataSetTableAdapters.zakazTableAdapter zakazTableAdapter;
        private System.Windows.Forms.PictureBox prevPicBox;
        private System.Windows.Forms.BindingNavigator zakazyBindingNavigator;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn razmerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datevpolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkatalogDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idklientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idzakazaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView zakazyDataGridView;
    }
}