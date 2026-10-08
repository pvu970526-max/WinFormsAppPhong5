namespace WinFormsAppPhong5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private SplitContainer splitContainer1;
        private TabControl tabControlLeft;
        private TabPage tabCustomer;
        private TabPage tabShipping;
        private GroupBox groupCustomer;
        private Label lblCustomerName;
        private TextBox txtCustomerName;
        private Label lblAddress;
        private TextBox txtAddress;
        private GroupBox groupShipping;
        private Label lblShippingType;
        private ComboBox cboShippingType;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colQty;
        private DataGridViewTextBoxColumn colWeight;
        private DataGridViewTextBoxColumn colUnitPrice;
        private DataGridViewTextBoxColumn colTotal;
        private DataGridView dgvItems;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel timerClock;
        private ToolStripStatusLabel toolStripTotals;
        private System.Windows.Forms.Timer timer1;
        private ErrorProvider errorProvider1;

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
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            tabControlLeft = new TabControl();
            tabCustomer = new TabPage();
            groupCustomer = new GroupBox();
            lblCustomerName = new Label();
            txtCustomerName = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            tabShipping = new TabPage();
            groupShipping = new GroupBox();
            lblShippingType = new Label();
            cboShippingType = new ComboBox();
            dgvItems = new DataGridView();
            statusStrip = new StatusStrip();
            timerClock = new ToolStripStatusLabel();
            toolStripTotals = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabControlLeft.SuspendLayout();
            tabCustomer.SuspendLayout();
            groupCustomer.SuspendLayout();
            tabShipping.SuspendLayout();
            groupShipping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tabControlLeft);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvItems);
            splitContainer1.Panel2.Controls.Add(statusStrip);
            splitContainer1.Size = new Size(1206, 450);
            splitContainer1.SplitterDistance = 422;
            splitContainer1.TabIndex = 0;
            // 
            // tabControlLeft
            // 
            tabControlLeft.Controls.Add(tabCustomer);
            tabControlLeft.Controls.Add(tabShipping);
            tabControlLeft.Dock = DockStyle.Fill;
            tabControlLeft.Location = new Point(0, 0);
            tabControlLeft.Name = "tabControlLeft";
            tabControlLeft.SelectedIndex = 0;
            tabControlLeft.Size = new Size(422, 450);
            tabControlLeft.TabIndex = 0;
            // 
            // tabCustomer
            // 
            tabCustomer.Controls.Add(groupCustomer);
            tabCustomer.Location = new Point(4, 29);
            tabCustomer.Name = "tabCustomer";
            tabCustomer.Padding = new Padding(3);
            tabCustomer.Size = new Size(414, 417);
            tabCustomer.TabIndex = 0;
            tabCustomer.Text = "Khách hàng";
            tabCustomer.UseVisualStyleBackColor = true;
            // 
            // groupCustomer
            // 
            groupCustomer.Controls.Add(lblCustomerName);
            groupCustomer.Controls.Add(txtCustomerName);
            groupCustomer.Controls.Add(lblAddress);
            groupCustomer.Controls.Add(txtAddress);
            groupCustomer.Dock = DockStyle.Fill;
            groupCustomer.Location = new Point(3, 3);
            groupCustomer.Name = "groupCustomer";
            groupCustomer.Size = new Size(408, 411);
            groupCustomer.TabIndex = 0;
            groupCustomer.TabStop = false;
            groupCustomer.Text = "Thông tin khách hàng";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(12, 28);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(114, 20);
            lblCustomerName.TabIndex = 0;
            lblCustomerName.Text = "Tên khách hàng:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(12, 46);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(240, 27);
            txtCustomerName.TabIndex = 1;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(12, 82);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(58, 20);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Địa chỉ:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(12, 100);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(240, 120);
            txtAddress.TabIndex = 3;
            // 
            // tabShipping
            // 
            tabShipping.Controls.Add(groupShipping);
            tabShipping.Location = new Point(4, 29);
            tabShipping.Name = "tabShipping";
            tabShipping.Padding = new Padding(3);
            tabShipping.Size = new Size(414, 417);
            tabShipping.TabIndex = 1;
            tabShipping.Text = "Loại vận chuyển";
            tabShipping.UseVisualStyleBackColor = true;
            // 
            // groupShipping
            // 
            groupShipping.Controls.Add(lblShippingType);
            groupShipping.Controls.Add(cboShippingType);
            groupShipping.Dock = DockStyle.Fill;
            groupShipping.Location = new Point(3, 3);
            groupShipping.Name = "groupShipping";
            groupShipping.Size = new Size(408, 411);
            groupShipping.TabIndex = 0;
            groupShipping.TabStop = false;
            groupShipping.Text = "Loại vận chuyển";
            // 
            // lblShippingType
            // 
            lblShippingType.AutoSize = true;
            lblShippingType.Location = new Point(12, 28);
            lblShippingType.Name = "lblShippingType";
            lblShippingType.Size = new Size(117, 20);
            lblShippingType.TabIndex = 0;
            lblShippingType.Text = "Loại vận chuyển:";
            // 
            // cboShippingType
            // 
            cboShippingType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboShippingType.Location = new Point(12, 46);
            cboShippingType.Name = "cboShippingType";
            cboShippingType.Size = new Size(240, 28);
            cboShippingType.TabIndex = 1;
            // 
            // dgvItems
            // 
            dgvItems.Dock = DockStyle.Fill;
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.ColumnHeadersVisible = true;
            dgvItems.RowHeadersVisible = true;
            dgvItems.Name = "dgvItems";
            dgvItems.AllowUserToAddRows = true;
            dgvItems.AllowUserToDeleteRows = true;
            dgvItems.RowHeadersWidth = 51;
            dgvItems.TabIndex = 0;
            dgvItems.BackgroundColor = SystemColors.ControlDark;
            // Columns (defined so designer shows them)
            colName = new DataGridViewTextBoxColumn();
            colQty = new DataGridViewTextBoxColumn();
            colWeight = new DataGridViewTextBoxColumn();
            colUnitPrice = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();

            // 
            // colName
            // 
            colName.HeaderText = "Tên hàng";
            colName.Name = "ItemName";
            // 
            // colQty
            // 
            colQty.HeaderText = "Số lượng";
            colQty.Name = "Quantity";
            // 
            // colWeight
            // 
            colWeight.HeaderText = "Trọng lượng (kg)";
            colWeight.Name = "WeightKg";
            // 
            // colUnitPrice
            // 
            colUnitPrice.HeaderText = "Đơn giá";
            colUnitPrice.Name = "UnitPrice";
            // 
            // colTotal
            // 
            colTotal.HeaderText = "Thành tiền";
            colTotal.Name = "Total";
            colTotal.ReadOnly = true;

            dgvItems.Columns.AddRange(new DataGridViewColumn[] { colName, colQty, colWeight, colUnitPrice, colTotal });
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { timerClock, toolStripTotals });
            statusStrip.Dock = DockStyle.Bottom;
            statusStrip.Name = "statusStrip";
            statusStrip.TabIndex = 1;
            statusStrip.Text = "statusStrip";
            // 
            // timerClock
            // 
            timerClock.Name = "timerClock";
            timerClock.Size = new Size(120, 20);
            timerClock.Text = "Thời gian: --:--:--";
            // 
            // toolStripTotals
            // 
            toolStripTotals.Name = "toolStripTotals";
            toolStripTotals.Size = new Size(645, 20);
            toolStripTotals.Spring = true;
            toolStripTotals.Text = "Số lượng: 0 | Trọng lượng: 0.00 kg | Tổng tiền: 0.00";
            toolStripTotals.TextAlign = ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            ClientSize = new Size(1206, 450);
            Controls.Add(splitContainer1);
            KeyPreview = true;
            Name = "Form1";
            Text = "Bảng điều khiển Quản lý Đơn giao hàng";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabControlLeft.ResumeLayout(false);
            tabCustomer.ResumeLayout(false);
            groupCustomer.ResumeLayout(false);
            groupCustomer.PerformLayout();
            tabShipping.ResumeLayout(false);
            groupShipping.ResumeLayout(false);
            groupShipping.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private TabPage tabPage1;
    }
}
