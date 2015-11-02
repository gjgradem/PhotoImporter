using GalaSoft.MvvmLight;
using PhotoImporter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoImporter.ViewModel
{
    class UsbDeviceVM : ViewModelBase
    {
        private UsbDevice _usbDevice;

        public UsbDeviceVM()
        {
            _usbDevice = new UsbDevice();
        }

        public UsbDeviceVM(UsbDevice device)
        {

        }
        public string DeviceId
        {
            get
            {
                return _usbDevice.DeviceId;  
            }
            set
            {
                _usbDevice.DeviceId = value;
                RaisePropertyChanged("DeviceId");
            }
        }

        public string PnpDeviceId
        {
            get
            {
                return _usbDevice.PnpDeviceId;
            }
            set
            {
                _usbDevice.PnpDeviceId = value;
                RaisePropertyChanged("PnpDeviceId");
            }
        }

        public string Description
        {
            get
            {
                return _usbDevice.Description;  
            }
            set
            {
                _usbDevice.Description = value;
                RaisePropertyChanged("Description");
            }
        }
    }
}
