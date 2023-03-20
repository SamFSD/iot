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
    public partial class DeviceDetail : ContentPage
    {
        public DeviceDetail()
        {
            InitializeComponent();
            BindingContext = this;
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            IoTDevice item = BindingContext as IoTDevice;

            if (item != null)
            {
                Title = item.Name;
            }
        }
    }
}