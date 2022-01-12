namespace CourseWork.Classes.Motherboard
{

    public class Motherboard
    {
        private readonly MotherboardGeneralInfo _motherboardGeneralInfo;

        public string Manufacturer { get; set; }

        public string Product { get; set; }

        public string SerialNumber { get; set; }

        public string BIOSVersion { get; set; }

        public string BIOSManufacturer { get; set; }

        public string BIOSSerialNumber { get; set; }

        public Motherboard()
        {
            //Initialize
            _motherboardGeneralInfo = new MotherboardGeneralInfo();
            _motherboardGeneralInfo.GetGeneralInfo();
        }

        public void GetMotherboardInfo()
        {
            //Manufacturer, product, serial number
            foreach (var item in _motherboardGeneralInfo.MotherboardManager)
            {
                Manufacturer = item["Manufacturer"].ToString();
                Product = item["Product"].ToString();
                SerialNumber = item["SerialNumber"].ToString();
            }

            //BIOS: version, manufacturer, serial number
            foreach (var item in _motherboardGeneralInfo.BiosManager)
            {
                BIOSVersion = item["Caption"].ToString();
                BIOSManufacturer = item["Manufacturer"].ToString();
                BIOSSerialNumber = item["SerialNumber"].ToString();
            }
        }
    }
}
