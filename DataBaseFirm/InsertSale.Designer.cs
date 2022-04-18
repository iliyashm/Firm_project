namespace DataBaseFirm
{
    partial class InsertSale
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
            System.Windows.Forms.Label good_idLabel;
            System.Windows.Forms.Label good_countLabel;
            System.Windows.Forms.Label create_dateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertSale));
            this.firmDataSet = new DataBaseFirm.FirmDataSet();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter = new DataBaseFirm.FirmDataSetTableAdapters.salesTableAdapter();
            this.tableAdapterManager = new DataBaseFirm.FirmDataSetTableAdapters.TableAdapterManager();
            this.salesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.salesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.good_idTextBox = new System.Windows.Forms.TextBox();
            this.good_countTextBox = new System.Windows.Forms.TextBox();
            this.create_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            good_idLabel = new System.Windows.Forms.Label();
            good_countLabel = new System.Windows.Forms.Label();
            create_dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.firmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingNavigator)).BeginInit();
            this.salesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // good_idLabel
            // 
            good_idLabel.AutoSize = true;
            good_idLabel.Location = new System.Drawing.Point(41, 73);
            good_idLabel.Name = "good_idLabel";
            good_idLabel.Size = new System.Drawing.Size(57, 13);
            good_idLabel.TabIndex = 3;
            good_idLabel.Text = "Id товара:";
            // 
            // good_countLabel
            // 
            good_countLabel.AutoSize = true;
            good_countLabel.Location = new System.Drawing.Point(41, 99);
            good_countLabel.Name = "good_countLabel";
            good_countLabel.Size = new System.Drawing.Size(44, 13);
            good_countLabel.TabIndex = 5;
            good_countLabel.Text = "Кол-во:";
            // 
            // create_dateLabel
            // 
            create_dateLabel.AutoSize = true;
            create_dateLabel.Location = new System.Drawing.Point(6, 128);
            create_dateLabel.Name = "create_dateLabel";
            create_dateLabel.Size = new System.Drawing.Size(99, 13);
            create_dateLabel.TabIndex = 7;
            create_dateLabel.Text = "Дата добавления:";
            // 
            // firmDataSet
            // 
            this.firmDataSet.DataSetName = "FirmDataSet";
            this.firmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "sales";
            this.salesBindingSource.DataSource = this.firmDataSet;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.goodsTableAdapter = null;
            this.tableAdapterManager.salesTableAdapter = this.salesTableAdapter;
            this.tableAdapterManager.UpdateOrder = DataBaseFirm.FirmDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            this.tableAdapterManager.warehouse1TableAdapter = null;
            this.tableAdapterManager.warehouse2TableAdapter = null;
            // 
            // salesBindingNavigator
            // 
            this.salesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.salesBindingNavigator.BindingSource = this.salesBindingSource;
            this.salesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.salesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.salesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.salesBindingNavigatorSaveItem});
            this.salesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.salesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.salesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.salesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.salesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.salesBindingNavigator.Name = "salesBindingNavigator";
            this.salesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.salesBindingNavigator.Size = new System.Drawing.Size(311, 25);
            this.salesBindingNavigator.TabIndex = 0;
            this.salesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // salesBindingNavigatorSaveItem
            // 
            this.salesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("salesBindingNavigatorSaveItem.Image")));
            this.salesBindingNavigatorSaveItem.Name = "salesBindingNavigatorSaveItem";
            this.salesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.salesBindingNavigatorSaveItem.Text = "Save Data";
            this.salesBindingNavigatorSaveItem.Click += new System.EventHandler(this.salesBindingNavigatorSaveItem_Click);
            // 
            // good_idTextBox
            // 
            this.good_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesBindingSource, "good_id", true));
            this.good_idTextBox.Location = new System.Drawing.Point(111, 70);
            this.good_idTextBox.Name = "good_idTextBox";
            this.good_idTextBox.Size = new System.Drawing.Size(139, 20);
            this.good_idTextBox.TabIndex = 4;
            // 
            // good_countTextBox
            // 
            this.good_countTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesBindingSource, "good_count", true));
            this.good_countTextBox.Location = new System.Drawing.Point(111, 96);
            this.good_countTextBox.Name = "good_countTextBox";
            this.good_countTextBox.Size = new System.Drawing.Size(139, 20);
            this.good_countTextBox.TabIndex = 6;
            // 
            // create_dateDateTimePicker
            // 
            this.create_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.salesBindingSource, "create_date", true));
            this.create_dateDateTimePicker.Location = new System.Drawing.Point(111, 122);
            this.create_dateDateTimePicker.Name = "create_dateDateTimePicker";
            this.create_dateDateTimePicker.Size = new System.Drawing.Size(139, 20);
            this.create_dateDateTimePicker.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // InsertSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 343);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(good_idLabel);
            this.Controls.Add(this.good_idTextBox);
            this.Controls.Add(good_countLabel);
            this.Controls.Add(this.good_countTextBox);
            this.Controls.Add(create_dateLabel);
            this.Controls.Add(this.create_dateDateTimePicker);
            this.Controls.Add(this.salesBindingNavigator);
            this.Name = "InsertSale";
            this.Text = "InsertSale";
            this.Load += new System.EventHandler(this.InsertSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.firmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingNavigator)).EndInit();
            this.salesBindingNavigator.ResumeLayout(false);
            this.salesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FirmDataSet firmDataSet;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private FirmDataSetTableAdapters.salesTableAdapter salesTableAdapter;
        private FirmDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator salesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton salesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox good_idTextBox;
        private System.Windows.Forms.TextBox good_countTextBox;
        private System.Windows.Forms.DateTimePicker create_dateDateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}