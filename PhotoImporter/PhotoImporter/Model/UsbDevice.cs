using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoImporter.Model
{
    public class UsbDevice
    {
        public string DeviceId { get; set; }
        public string PnpDeviceId { get; set; }
        public string Description { get; set; }
    }
}
