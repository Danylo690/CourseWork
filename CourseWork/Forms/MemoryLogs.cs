using CourseWork.Classes.Memory;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseWork.Forms
{
    public partial class MemoryLogs : Form
    {
        private BindingSource _bindingSource;
        public List<MemoryLog> MemoryLogsInfo { get; set; }
        public MemoryLogs()
        {
            InitializeComponent();
            _bindingSource = new BindingSource();
            this.DGVMemoryLogs.MouseWheel += new MouseEventHandler(this.DGVMemoryLogs_MouseWheel);
        }

        private void DGVMemoryLogs_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && DGVMemoryLogs.FirstDisplayedScrollingRowIndex > 0)
            {
                DGVMemoryLogs.FirstDisplayedScrollingRowIndex--;
            }
            else if (e.Delta < 0)
            {
                DGVMemoryLogs.FirstDisplayedScrollingRowIndex++;
            }
        }

        private void MemoryLogs_Shown(object sender, EventArgs e)
        {
            _bindingSource.DataSource = MemoryLogsInfo;
            DGVMemoryLogs.DataSource = _bindingSource;
            DGVMemoryLogs.Columns[0].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm:ss ";
            DGVMemoryLogs.Columns[1].DefaultCellStyle.Format = "#.0 Gb";
            DGVMemoryLogs.Columns[2].DefaultCellStyle.Format = "#.0 Gb";
            DGVMemoryLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
