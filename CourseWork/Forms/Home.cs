using CourseWork.Classes;
using CourseWork.Classes.CPU;
using CourseWork.Classes.Motherboard;
using CourseWork.Classes.Voltage;
using CourseWork.Classes.Memory;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Home : Form
    {
        #region Fields
        private Button _currentButton;
        private Form _activeForm;
        private CPU _cpu;
        private Motherboard _motherboard;
        private Voltage _voltage;
        private Memory _memory;
        #endregion

        #region Constructor
        public Home()
        {
            InitializeComponent();
            btnClose.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            _cpu = new CPU();
            _motherboard = new Motherboard();
            _voltage = new Voltage();
            _memory = new Memory();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        #region Methods
        private void CloseCorrectly()
        {
            if (_activeForm != null && _activeForm.GetType() == typeof(Forms.CPU))
            {
                ((Forms.CPU)_activeForm).IsClosed = true;
            }
            if (_activeForm != null && _activeForm.GetType() == typeof(Forms.Voltage))
            {
                ((Forms.Voltage)_activeForm).IsClosed = true;
            }
            if (_activeForm != null && _activeForm.GetType() == typeof(Forms.Memory))
            {
                ((Forms.Memory)_activeForm).IsClosed = true;
            }
        }

        private void ActivateButton(object btnSender, string htmlColor)
        {
            if (btnSender != null)
            {
                if (_currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml(htmlColor);
                    _currentButton = (Button)btnSender;
                    _currentButton.BackColor = color;
                    _currentButton.ForeColor = Color.White;
                    _currentButton.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    labelTitle.Text = _currentButton.Text.ToUpper() + " INFORMATION";
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnClose.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control item in panelMenu.Controls)
            {
                if (item.GetType() == typeof(Button))
                {
                    item.BackColor = Color.FromArgb(51, 51, 76);
                    item.ForeColor = Color.Gainsboro;
                    item.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void btnCPU_Click(object sender, EventArgs e)
        {
            CloseCorrectly();
            var form = new Forms.CPU();
            form.CPUInfo = _cpu;
            ChangeChildForm(form, sender, ThemeColor.ColorList[0]);
            panelTitle.BackColor = ColorTranslator.FromHtml(ThemeColor.ColorList[0]);
        }

        private void btnMotherboard_Click(object sender, EventArgs e)
        {
            CloseCorrectly();
            var form = new Forms.Motherboard();
            form.MotherboardInfo = _motherboard;
            ChangeChildForm(form, sender, ThemeColor.ColorList[1]);
            panelTitle.BackColor = ColorTranslator.FromHtml(ThemeColor.ColorList[1]);
        }

        private void btnVoltage_Click(object sender, EventArgs e)
        {
            CloseCorrectly();
            var form = new Forms.Voltage();
            form.VoltageInfo = _voltage;
            ChangeChildForm(form, sender, ThemeColor.ColorList[2]);
            panelTitle.BackColor = ColorTranslator.FromHtml(ThemeColor.ColorList[2]);
        }

        private void btnMemory_Click(object sender, EventArgs e)
        {
            CloseCorrectly();
            var form = new Forms.Memory();
            form.MemoryInfo = _memory;
            ChangeChildForm(form, sender, ThemeColor.ColorList[3]);
            panelTitle.BackColor = ColorTranslator.FromHtml(ThemeColor.ColorList[3]);
        }

        private void btnCPULogs_Click(object sender, EventArgs e)
        {
            CloseCorrectly();
            var form = new Forms.CPULogs();
            form.CPULogsInfo = _cpu.CPULogs;
            ChangeChildForm(form, sender, ThemeColor.ColorList[0]);
            panelTitle.BackColor = ColorTranslator.FromHtml(ThemeColor.ColorList[0]);
        }

        private void btnMemoryLogs_Click(object sender, EventArgs e)
        {
            CloseCorrectly();
            var form = new Forms.MemoryLogs();
            form.MemoryLogsInfo = _memory.MemoryLogs;
            ChangeChildForm(form, sender, ThemeColor.ColorList[3]);
            panelTitle.BackColor = ColorTranslator.FromHtml(ThemeColor.ColorList[3]);
        }

        private void ChangeChildForm(Form childForm, object btnSender, string HtmlColor)
        {
            if (_activeForm != null)
            {
                _activeForm.Close();
            }
            ActivateButton(btnSender, HtmlColor);
            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelForm.Controls.Add(childForm);
            panelForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseCorrectly();
            if (_activeForm != null)
            {
                _activeForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            labelTitle.Text = "HOME";
            panelTitle.BackColor = Color.FromArgb(107, 14, 84);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            _currentButton = null;
            btnClose.Visible = false;
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void labelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            if (_activeForm != null)
            {
                CloseCorrectly();
                _activeForm.Close();
            }
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion
    }
}
