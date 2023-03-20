using System;
using System.Collections.Generic;
using System.Text;

namespace iot
{
    public class MockData
    {
        public List<User> Users { get; set; }
        public List<IoTDevice> Devices { get; set; }

        public MockData()
        {
            Users = new List<User>()
            {
                new User() { Username = "sam", Password = "password1" },
            };

            Devices = new List<IoTDevice>()
            {
                new IoTDevice() {Name="Car 1", Type=DeviceType.CAR},
                new IoTDevice() {Name="Car 2", Type=DeviceType.CAR},
                new IoTDevice() {Name="Truck 1", Type=DeviceType.TRUCK},
                new IoTDevice() {Name="Truck 2", Type=DeviceType.TRUCK},
                new IoTDevice() {Name="Truck 3", Type=DeviceType.TRUCK},
                new IoTDevice() {Name="Generator 1", Type=DeviceType.GENERATOR},
                new IoTDevice() {Name="Fridge 1", Type=DeviceType.FRIDGE},
                new IoTDevice() {Name="Fridge 2", Type=DeviceType.FRIDGE},
                new IoTDevice() {Name="Fridge 3", Type=DeviceType.FRIDGE}
            };
        }
    }
}
