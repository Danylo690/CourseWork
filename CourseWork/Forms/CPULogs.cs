using CourseWork.Classes.CPU;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseWork.Forms
{
    public partial class CPULogs : Form
    {
        private BindingSource _bindingSource;
        public List<CPULog> CPULogsInfo { get; set; }
        public CPULogs()
        {
            InitializeComponent();
            _bindingSource = new BindingSource();
            this.DGVCPULogs.MouseWheel += new MouseEventHandler(this.DGVCPULogs_MouseWheel);
        }

        private void CPULogs_Shown(object sender, EventArgs e)
        {
            _bindingSource.DataSource = CPULogsInfo;
            DGVCPULogs.DataSource = _bindingSource;
            DGVCPULogs.Columns[0].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm:ss ";
            DGVCPULogs.Columns[1].DefaultCellStyle.Format = "#.0 °C";
            DGVCPULogs.Columns[2].DefaultCellStyle.Format = "#.0 \\%";
            DGVCPULogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void DGVCPULogs_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && DGVCPULogs.FirstDisplayedScrollingRowIndex > 0)
            {
                DGVCPULogs.FirstDisplayedScrollingRowIndex--;
            }
            else if (e.Delta < 0)
            {
                DGVCPULogs.FirstDisplayedScrollingRowIndex++;
            }
        }
    }
}
