
namespace CourseWork
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMemoryLogs = new System.Windows.Forms.Button();
            this.btnCPULogs = new System.Windows.Forms.Button();
            this.btnMemory = new System.Windows.Forms.Button();
            this.btnVoltage = new System.Windows.Forms.Button();
            this.btnMotherboard = new System.Windows.Forms.Button();
            this.btnCPU = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnMemoryLogs);
            this.panelMenu.Controls.Add(this.btnCPULogs);
            this.panelMenu.Controls.Add(this.btnMemory);
            this.panelMenu.Controls.Add(this.btnVoltage);
            this.panelMenu.Controls.Add(this.btnMotherboard);
            this.panelMenu.Controls.Add(this.btnCPU);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 553);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.labelLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 90);
            this.panelLogo.TabIndex = 1;
            // 
            // labelLogo
            // 
            this.labelLogo.Font = new System.Drawing.Font("Microsoft PhagsPa", 13F);
            this.labelLogo.ForeColor = System.Drawing.Color.LightGray;
            this.labelLogo.Location = new System.Drawing.Point(6, 29);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(211, 30);
            this.labelLogo.TabIndex = 0;
            this.labelLogo.Text = "DanDiagnostic";
            this.labelLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(14)))), ((int)(((byte)(127)))));
            this.panelTitle.Controls.Add(this.btnMinimize);
            this.panelTitle.Controls.Add(this.btnCloseApp);
            this.panelTitle.Controls.Add(this.btnClose);
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(220, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(762, 90);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft PhagsPa", 18F);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(6, 29);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(745, 38);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "HOME";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTitle_MouseDown);
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.pictureBox1);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(220, 90);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(762, 463);
            this.panelForm.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CourseWork.Properties.Resources.MainLogo;
            this.pictureBox1.Location = new System.Drawing.Point(96, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(560, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = global::CourseWork.Properties.Resources.MinimizeApp;
            this.btnMinimize.Location = new System.Drawing.Point(693, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.FlatAppearance.BorderSize = 0;
            this.btnCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseApp.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.btnCloseApp.ForeColor = System.Drawing.Color.White;
            this.btnCloseApp.Image = global::CourseWork.Properties.Resources.CloseApp;
            this.btnCloseApp.Location = new System.Drawing.Point(729, 3);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(30, 30);
            this.btnCloseApp.TabIndex = 2;
            this.btnCloseApp.UseVisualStyleBackColor = true;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::CourseWork.Properties.Resources.Close;
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 90);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMemoryLogs
            // 
            this.btnMemoryLogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMemoryLogs.FlatAppearance.BorderSize = 0;
            this.btnMemoryLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemoryLogs.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMemoryLogs.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMemoryLogs.Image = global::CourseWork.Properties.Resources.LogsLogo;
            this.btnMemoryLogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMemoryLogs.Location = new System.Drawing.Point(0, 390);
            this.btnMemoryLogs.Name = "btnMemoryLogs";
            this.btnMemoryLogs.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnMemoryLogs.Size = new System.Drawing.Size(220, 60);
            this.btnMemoryLogs.TabIndex = 6;
            this.btnMemoryLogs.Text = "   Memory logs";
            this.btnMemoryLogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMemoryLogs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMemoryLogs.UseVisualStyleBackColor = true;
            this.btnMemoryLogs.Click += new System.EventHandler(this.btnMemoryLogs_Click);
            // 
            // btnCPULogs
            // 
            this.btnCPULogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCPULogs.FlatAppearance.BorderSize = 0;
            this.btnCPULogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCPULogs.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCPULogs.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCPULogs.Image = global::CourseWork.Properties.Resources.LogsLogo;
            this.btnCPULogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCPULogs.Location = new System.Drawing.Point(0, 330);
            this.btnCPULogs.Name = "btnCPULogs";
            this.btnCPULogs.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCPULogs.Size = new System.Drawing.Size(220, 60);
            this.btnCPULogs.TabIndex = 5;
            this.btnCPULogs.Text = "   CPU logs";
            this.btnCPULogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCPULogs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCPULogs.UseVisualStyleBackColor = true;
            this.btnCPULogs.Click += new System.EventHandler(this.btnCPULogs_Click);
            // 
            // btnMemory
            // 
            this.btnMemory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMemory.FlatAppearance.BorderSize = 0;
            this.btnMemory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMemory.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMemory.Image = global::CourseWork.Properties.Resources.MemoryLogo;
            this.btnMemory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMemory.Location = new System.Drawing.Point(0, 270);
            this.btnMemory.Name = "btnMemory";
            this.btnMemory.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnMemory.Size = new System.Drawing.Size(220, 60);
            this.btnMemory.TabIndex = 4;
            this.btnMemory.Text = "   Memory";
            this.btnMemory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMemory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMemory.UseVisualStyleBackColor = true;
            this.btnMemory.Click += new System.EventHandler(this.btnMemory_Click);
            // 
            // btnVoltage
            // 
            this.btnVoltage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVoltage.FlatAppearance.BorderSize = 0;
            this.btnVoltage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnVoltage.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVoltage.Image = global::CourseWork.Properties.Resources.VoltageLogo;
            this.btnVoltage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltage.Location = new System.Drawing.Point(0, 210);
            this.btnVoltage.Name = "btnVoltage";
            this.btnVoltage.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnVoltage.Size = new System.Drawing.Size(220, 60);
            this.btnVoltage.TabIndex = 3;
            this.btnVoltage.Text = "   Voltage";
            this.btnVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltage.UseVisualStyleBackColor = true;
            this.btnVoltage.Click += new System.EventHandler(this.btnVoltage_Click);
            // 
            // btnMotherboard
            // 
            this.btnMotherboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMotherboard.FlatAppearance.BorderSize = 0;
            this.btnMotherboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMotherboard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMotherboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMotherboard.Image = global::CourseWork.Properties.Resources.MotherboardLogo;
            this.btnMotherboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMotherboard.Location = new System.Drawing.Point(0, 150);
            this.btnMotherboard.Name = "btnMotherboard";
            this.btnMotherboard.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnMotherboard.Size = new System.Drawing.Size(220, 60);
            this.btnMotherboard.TabIndex = 2;
            this.btnMotherboard.Text = "   Motherboard";
            this.btnMotherboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMotherboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMotherboard.UseVisualStyleBackColor = true;
            this.btnMotherboard.Click += new System.EventHandler(this.btnMotherboard_Click);
            // 
            // btnCPU
            // 
            this.btnCPU.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCPU.FlatAppearance.BorderSize = 0;
            this.btnCPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCPU.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCPU.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCPU.Image = global::CourseWork.Properties.Resources.CPULogo;
            this.btnCPU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCPU.Location = new System.Drawing.Point(0, 90);
            this.btnCPU.Name = "btnCPU";
            this.btnCPU.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCPU.Size = new System.Drawing.Size(220, 60);
            this.btnCPU.TabIndex = 0;
            this.btnCPU.Text = "   CPU";
            this.btnCPU.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCPU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCPU.UseVisualStyleBackColor = true;
            this.btnCPU.Click += new System.EventHandler(this.btnCPU_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(101F, 101F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Text = "DanDiagnostic";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnCPU;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnMemory;
        private System.Windows.Forms.Button btnVoltage;
        private System.Windows.Forms.Button btnMotherboard;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnCloseApp;
        private System.Windows.Forms.Button btnMemoryLogs;
        private System.Windows.Forms.Button btnCPULogs;
    }
}

