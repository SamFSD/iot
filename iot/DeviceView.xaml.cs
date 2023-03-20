using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iot
{
    public partial class DeviceView : ContentView
    {
        public static readonly BindableProperty TitleProperty =
        BindableProperty.Create(
            nameof(Title),
            typeof(string),
            typeof(DeviceView),
            String.Empty,
            BindingMode.OneWay);

        public static readonly BindableProperty SubTitleProperty =
        BindableProperty.Create(
           nameof(SubTitle),
           typeof(string),
           typeof(DeviceView),
           String.Empty,
           BindingMode.OneWay);

        public static readonly BindableProperty ItemsCountProperty =
        BindableProperty.Create(
           nameof(ItemsCount),
           typeof(string),
           typeof(DeviceView),
           String.Empty,
           BindingMode.OneWay);

        public static readonly BindableProperty PressedCommandProperty =
        BindableProperty.Create(
            nameof(PressedCommand),
            typeof(ICommand),
            typeof(DeviceView),
            null);

        public static readonly BindableProperty CommandParameterProperty =
        BindableProperty.Create(
            nameof(CommandParameter),
            typeof(object),
            typeof(DeviceView),
            null);

        public string Title
        {
            get => (string)GetValue(DeviceView.TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public string SubTitle
        {
            get => (string)GetValue(DeviceView.SubTitleProperty);
            set => SetValue(SubTitleProperty, value);
        }

        public string ItemsCount
        {
            get => (string)GetValue(DeviceView.ItemsCountProperty);
            set => SetValue(ItemsCountProperty, value);
        }

        public ICommand PressedCommand
        {
            get { return (ICommand)GetValue(PressedCommandProperty); }
            set { SetValue(PressedCommandProperty, value); }
        }

        public object CommandParameter
        {
            get { return (string)GetValue(CommandParameterProperty); }
            set { SetValue(CommandParameterProperty, value); }
        }

        public DeviceView()
        {
            InitializeComponent();
            BindingContext = this;
        }

        async void OnFrameTapped(object sender, EventArgs e)
        {
            await frame.ScaleTo(1.03, 100);

            await frame.ScaleTo(1, 100);

            if (PressedCommand != null && PressedCommand.CanExecute(null))
            {
                PressedCommand.Execute(CommandParameter);
            }
        }
    }

}