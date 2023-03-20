using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace iot
{
    public partial class MainPage : ContentPage
    {
        public List<IoTDevice> Devices { get; set; }
        public List<Tuple<DeviceTypeProperties,int>> DeviceTypesProperties { get; set; }


        public MainPage()
        {
            InitializeComponent();

            var mockData = new MockData();

            Devices = mockData.Devices;

            var grouped = Devices.GroupBy(device => device.Type);
            DeviceTypesProperties = grouped.Select(group => Tuple.Create(DeviceTypeDescriptions.TypeDescriptions[group.Key], group.Count())).ToList();

            PressedCommand = new Command<string>(OnPressed);

            BindingContext = this;
        }

        public ICommand PressedCommand { get; }

        async private void OnPressed(object parameter)
        {
            var newPage = new DeviceTypeDetail((string)parameter);
            await Navigation.PushAsync(newPage);
        }

        private async void OnItemClicked(object sender, EventArgs e) {
            Preferences.Remove("username");
            await Navigation.PushAsync(new LoginPage());
        }
    }
}
