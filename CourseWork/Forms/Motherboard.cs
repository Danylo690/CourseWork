using System;
using System.Windows.Forms;

namespace CourseWork.Forms
{
    public partial class Motherboard : Form
    {
        #region Fields
        public Classes.Motherboard.Motherboard MotherboardInfo { get; set; }
        #endregion

        #region Constructor
        public Motherboard()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        private void Motherboard_Shown(object sender, EventArgs e)
        {
            MotherboardInfo.GetMotherboardInfo();
            labelManufacturer.Text = MotherboardInfo.Manufacturer;
            labelPoduct.Text = MotherboardInfo.Product;
            labelSerialNumber.Text = MotherboardInfo.SerialNumber;
            labelBIOSVersion.Text = MotherboardInfo.BIOSVersion;
            labelBIOSManufacturer.Text = MotherboardInfo.BIOSManufacturer;
            labelBIOSSerialNumber.Text = MotherboardInfo.BIOSSerialNumber;
        }
        #endregion
    }
}
