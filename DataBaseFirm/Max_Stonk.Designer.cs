namespace DataBaseFirm
{
    partial class Max_Stonk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Max_Stonk));
            this.firmDataSet = new DataBaseFirm.FirmDataSet();
            this.max_stonkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.max_stonkTableAdapter = new DataBaseFirm.FirmDataSetTableAdapters.max_stonkTableAdapter();
            this.tableAdapterManager = new DataBaseFirm.FirmDataSetTableAdapters.TableAdapterManager();
            this.max_stonkBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.max_stonkBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.min_dateToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.min_dateToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.max_dateToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.max_dateToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.max_stonkDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.firmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_stonkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_stonkBindingNavigator)).BeginInit();
            this.max_stonkBindingNavigator.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max_stonkDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // firmDataSet
            // 
            this.firmDataSet.DataSetName = "FirmDataSet";
            this.firmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // max_stonkBindingSource
            // 
            this.max_stonkBindingSource.DataMember = "max_stonk";
            this.max_stonkBindingSource.DataSource = this.firmDataSet;
            // 
            // max_stonkTableAdapter
            // 
            this.max_stonkTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.goodsTableAdapter = null;
            this.tableAdapterManager.salesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DataBaseFirm.FirmDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            this.tableAdapterManager.warehouse1TableAdapter = null;
            this.tableAdapterManager.warehouse2TableAdapter = null;
            // 
            // max_stonkBindingNavigator
            // 
            this.max_stonkBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.max_stonkBindingNavigator.BindingSource = this.max_stonkBindingSource;
            this.max_stonkBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.max_stonkBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.max_stonkBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.max_stonkBindingNavigatorSaveItem});
            this.max_stonkBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.max_stonkBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.max_stonkBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.max_stonkBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.max_stonkBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.max_stonkBindingNavigator.Name = "max_stonkBindingNavigator";
            this.max_stonkBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.max_stonkBindingNavigator.Size = new System.Drawing.Size(376, 25);
            this.max_stonkBindingNavigator.TabIndex = 0;
            this.max_stonkBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // max_stonkBindingNavigatorSaveItem
            // 
            this.max_stonkBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.max_stonkBindingNavigatorSaveItem.Enabled = false;
            this.max_stonkBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("max_stonkBindingNavigatorSaveItem.Image")));
            this.max_stonkBindingNavigatorSaveItem.Name = "max_stonkBindingNavigatorSaveItem";
            this.max_stonkBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 20);
            this.max_stonkBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.min_dateToolStripLabel,
            this.min_dateToolStripTextBox,
            this.max_dateToolStripLabel,
            this.max_dateToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(376, 25);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // min_dateToolStripLabel
            // 
            this.min_dateToolStripLabel.Name = "min_dateToolStripLabel";
            this.min_dateToolStripLabel.Size = new System.Drawing.Size(59, 22);
            this.min_dateToolStripLabel.Text = "min_date:";
            // 
            // min_dateToolStripTextBox
            // 
            this.min_dateToolStripTextBox.Name = "min_dateToolStripTextBox";
            this.min_dateToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // max_dateToolStripLabel
            // 
            this.max_dateToolStripLabel.Name = "max_dateToolStripLabel";
            this.max_dateToolStripLabel.Size = new System.Drawing.Size(61, 15);
            this.max_dateToolStripLabel.Text = "max_date:";
            // 
            // max_dateToolStripTextBox
            // 
            this.max_dateToolStripTextBox.Name = "max_dateToolStripTextBox";
            this.max_dateToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 19);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // max_stonkDataGridView
            // 
            this.max_stonkDataGridView.AutoGenerateColumns = false;
            this.max_stonkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.max_stonkDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.max_stonkDataGridView.DataSource = this.max_stonkBindingSource;
            this.max_stonkDataGridView.Location = new System.Drawing.Point(98, 80);
            this.max_stonkDataGridView.Name = "max_stonkDataGridView";
            this.max_stonkDataGridView.Size = new System.Drawing.Size(147, 64);
            this.max_stonkDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "maxstonk";
            this.dataGridViewTextBoxColumn1.HeaderText = "maxstonk";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Max_Stonk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 251);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.max_stonkDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.max_stonkBindingNavigator);
            this.Name = "Max_Stonk";
            this.Text = "Max_Stonk";
            ((System.ComponentModel.ISupportInitialize)(this.firmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_stonkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_stonkBindingNavigator)).EndInit();
            this.max_stonkBindingNavigator.ResumeLayout(false);
            this.max_stonkBindingNavigator.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max_stonkDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FirmDataSet firmDataSet;
        private System.Windows.Forms.BindingSource max_stonkBindingSource;
        private FirmDataSetTableAdapters.max_stonkTableAdapter max_stonkTableAdapter;
        private FirmDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator max_stonkBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton max_stonkBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel min_dateToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox min_dateToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel max_dateToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox max_dateToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView max_stonkDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button1;
    }
}