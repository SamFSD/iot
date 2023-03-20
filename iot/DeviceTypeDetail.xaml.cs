using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iot
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeviceTypeDetail : ContentPage
    {
        public List<IoTDevice> Devices { get; set; }
        public DeviceTypeDetail(string deviceType)
        {
            InitializeComponent();
            Title = deviceType;

            var mockData = new MockData();
            
            var result = DeviceTypeDescriptions.TypeDescriptions.First(type => type.Value.name == deviceType);
            var grouped = mockData.Devices.GroupBy(device => device.Type);
            Devices = grouped.First(group => group.Key == result.Key).ToList();

            BindingContext = this;
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var item = ((Frame)sender).BindingContext as IoTDevice;
            await Navigation.PushAsync(new DeviceDetail { BindingContext = item });
        }
    }
}