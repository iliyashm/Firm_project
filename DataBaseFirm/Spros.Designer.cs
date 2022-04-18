namespace DataBaseFirm
{
    partial class Spros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spros));
            this.firmDataSet = new DataBaseFirm.FirmDataSet();
            this.max_priority_21BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.max_priority_21TableAdapter = new DataBaseFirm.FirmDataSetTableAdapters.max_priority_21TableAdapter();
            this.tableAdapterManager = new DataBaseFirm.FirmDataSetTableAdapters.TableAdapterManager();
            this.max_priority_21BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.max_priority_21BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.goodname1ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.goodname1ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.goodname2ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.goodname2ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.max_priority_21DataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.firmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_priority_21BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_priority_21BindingNavigator)).BeginInit();
            this.max_priority_21BindingNavigator.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max_priority_21DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // firmDataSet
            // 
            this.firmDataSet.DataSetName = "FirmDataSet";
            this.firmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // max_priority_21BindingSource
            // 
            this.max_priority_21BindingSource.DataMember = "max_priority:21";
            this.max_priority_21BindingSource.DataSource = this.firmDataSet;
            // 
            // max_priority_21TableAdapter
            // 
            this.max_priority_21TableAdapter.ClearBeforeFill = true;
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
            // max_priority_21BindingNavigator
            // 
            this.max_priority_21BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.max_priority_21BindingNavigator.BindingSource = this.max_priority_21BindingSource;
            this.max_priority_21BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.max_priority_21BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.max_priority_21BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.max_priority_21BindingNavigatorSaveItem});
            this.max_priority_21BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.max_priority_21BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.max_priority_21BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.max_priority_21BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.max_priority_21BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.max_priority_21BindingNavigator.Name = "max_priority_21BindingNavigator";
            this.max_priority_21BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.max_priority_21BindingNavigator.Size = new System.Drawing.Size(628, 25);
            this.max_priority_21BindingNavigator.TabIndex = 0;
            this.max_priority_21BindingNavigator.Text = "bindingNavigator1";
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
            // max_priority_21BindingNavigatorSaveItem
            // 
            this.max_priority_21BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.max_priority_21BindingNavigatorSaveItem.Enabled = false;
            this.max_priority_21BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("max_priority_21BindingNavigatorSaveItem.Image")));
            this.max_priority_21BindingNavigatorSaveItem.Name = "max_priority_21BindingNavigatorSaveItem";
            this.max_priority_21BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.max_priority_21BindingNavigatorSaveItem.Text = "Save Data";
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goodname1ToolStripLabel,
            this.goodname1ToolStripTextBox,
            this.goodname2ToolStripLabel,
            this.goodname2ToolStripTextBox,
            this.toolStripLabel1,
            this.toolStripTextBox1,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(628, 25);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // goodname1ToolStripLabel
            // 
            this.goodname1ToolStripLabel.Name = "goodname1ToolStripLabel";
            this.goodname1ToolStripLabel.Size = new System.Drawing.Size(93, 22);
            this.goodname1ToolStripLabel.Text = "Начальная дата";
            // 
            // goodname1ToolStripTextBox
            // 
            this.goodname1ToolStripTextBox.Name = "goodname1ToolStripTextBox";
            this.goodname1ToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // goodname2ToolStripLabel
            // 
            this.goodname2ToolStripLabel.Name = "goodname2ToolStripLabel";
            this.goodname2ToolStripLabel.Size = new System.Drawing.Size(86, 22);
            this.goodname2ToolStripLabel.Text = "Конечная дата";
            // 
            // goodname2ToolStripTextBox
            // 
            this.goodname2ToolStripTextBox.Name = "goodname2ToolStripTextBox";
            this.goodname2ToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(17, 22);
            this.toolStripLabel1.Text = "id";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(61, 22);
            this.fillToolStripButton.Text = "Показать";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // max_priority_21DataGridView
            // 
            this.max_priority_21DataGridView.AutoGenerateColumns = false;
            this.max_priority_21DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.max_priority_21DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.max_priority_21DataGridView.DataSource = this.max_priority_21BindingSource;
            this.max_priority_21DataGridView.Location = new System.Drawing.Point(202, 78);
            this.max_priority_21DataGridView.Name = "max_priority_21DataGridView";
            this.max_priority_21DataGridView.Size = new System.Drawing.Size(220, 67);
            this.max_priority_21DataGridView.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "return_value";
            this.dataGridViewTextBoxColumn1.HeaderText = "Прирост спроса";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // Spros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 214);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.max_priority_21DataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.max_priority_21BindingNavigator);
            this.Name = "Spros";
            this.Text = "Spros";
            ((System.ComponentModel.ISupportInitialize)(this.firmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_priority_21BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_priority_21BindingNavigator)).EndInit();
            this.max_priority_21BindingNavigator.ResumeLayout(false);
            this.max_priority_21BindingNavigator.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max_priority_21DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FirmDataSet firmDataSet;
        private System.Windows.Forms.BindingSource max_priority_21BindingSource;
        private FirmDataSetTableAdapters.max_priority_21TableAdapter max_priority_21TableAdapter;
        private FirmDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator max_priority_21BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton max_priority_21BindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel goodname1ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox goodname1ToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel goodname2ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox goodname2ToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView max_priority_21DataGridView;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}