using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsAppPhong5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Wire events
            this.Load += Form1_Load;
            this.KeyDown += Form1_KeyDown;
            timer1.Tick += Timer1_Tick;

            dgvItems.CellValidating += DgvItems_CellValidating;
            dgvItems.CellEndEdit += DgvItems_CellEndEdit;
            dgvItems.RowsRemoved += DgvItems_RowsChanged;
            dgvItems.RowsAdded += DgvItems_RowsChanged;
            dgvItems.KeyDown += DgvItems_KeyDown;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            // Designer defines DataGridView columns so they are visible in the Form Designer.
            // sample shipping types
            cboShippingType.Items.Clear();
            cboShippingType.Items.AddRange(new object[] { "Tiêu chuẩn", "Hỏa tốc", "Giao ngay" });
            if (cboShippingType.Items.Count > 0) cboShippingType.SelectedIndex = 0;

            timer1.Start();

            RecalculateTotals();
        }

        private void Timer1_Tick(object? sender, EventArgs e)
        {
            // update the status strip clock
            timerClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void DgvItems_CellValidating(object? sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgvItems.Columns[e.ColumnIndex].Name == "Quantity" || dgvItems.Columns[e.ColumnIndex].Name == "WeightKg")
            {
                var text = e.FormattedValue?.ToString() ?? string.Empty;
                if (!decimal.TryParse(text, out var val) || val <= 0)
                {
                    // show error on editing control if available
                    if (dgvItems.EditingControl is Control c)
                    {
                        errorProvider1.SetError(c, "Value must be a number greater than 0");
                    }
                    e.Cancel = true;
                }
                else
                {
                    if (dgvItems.EditingControl is Control c)
                    {
                        errorProvider1.SetError(c, string.Empty);
                    }
                }
            }
        }

        private void DgvItems_CellEndEdit(object? sender, DataGridViewCellEventArgs e)
        {
            // clear any error for the editing control
            if (dgvItems.EditingControl is Control c)
            {
                errorProvider1.SetError(c, string.Empty);
            }

            // Recalculate row total and status totals
            var row = dgvItems.Rows[e.RowIndex];
            if (row.IsNewRow) return;

            decimal qty = ParseDecimal(row.Cells["Quantity"].Value);
            decimal weight = ParseDecimal(row.Cells["WeightKg"].Value);
            decimal unitPrice = ParseDecimal(row.Cells["UnitPrice"].Value);

            decimal total = qty * unitPrice;
            row.Cells["Total"].Value = total.ToString("0.00");

            RecalculateTotals();
        }

        private void DgvItems_RowsChanged(object? sender, EventArgs e)
        {
            RecalculateTotals();
        }

        private void RecalculateTotals()
        {
            int totalQty = 0;
            decimal totalWeight = 0m;
            decimal totalAmount = 0m;

            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                if (row.IsNewRow) continue;
                int qty = (int)ParseDecimal(row.Cells["Quantity"].Value);
                decimal weight = ParseDecimal(row.Cells["WeightKg"].Value);
                decimal unitPrice = ParseDecimal(row.Cells["UnitPrice"].Value);

                totalQty += qty;
                totalWeight += qty * weight;
                totalAmount += qty * unitPrice;
            }

            toolStripTotals.Text = $"Số lượng: {totalQty} | Trọng lượng: {totalWeight:0.00} kg | Tổng tiền: {totalAmount:0.00}";
        }

        private decimal ParseDecimal(object? value)
        {
            if (value == null) return 0m;
            if (value is decimal d) return d;
            if (value is int i) return i;
            if (decimal.TryParse(value.ToString(), out var r)) return r;
            return 0m;
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                AddNewRow();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Delete)
            {
                DeleteSelectedRows();
                e.Handled = true;
            }
        }

        private void DgvItems_KeyDown(object? sender, KeyEventArgs e)
        {
            // support delete when grid has focus
            if (e.KeyCode == Keys.Delete)
            {
                DeleteSelectedRows();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.F2)
            {
                AddNewRow();
                e.Handled = true;
            }
        }

        private void AddNewRow()
        {
            dgvItems.Rows.Add();
            int idx = dgvItems.Rows.Count - 1;
            if (idx >= 0)
            {
                var r = dgvItems.Rows[idx];
                dgvItems.CurrentCell = r.Cells[0];
                dgvItems.BeginEdit(true);
            }
        }

        private void DeleteSelectedRows()
        {
            if (dgvItems.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow r in dgvItems.SelectedRows)
                {
                    if (!r.IsNewRow) dgvItems.Rows.Remove(r);
                }
            }
            else if (dgvItems.CurrentRow != null && !dgvItems.CurrentRow.IsNewRow)
            {
                dgvItems.Rows.Remove(dgvItems.CurrentRow);
            }
        }
    }
}
