using System;
using System.Collections.Generic;
using System.Text;

namespace iot
{
    public class DeviceTypeDescriptions
    {

        public static Dictionary<DeviceType, DeviceTypeProperties> TypeDescriptions = new Dictionary<DeviceType, DeviceTypeProperties>
        {
            { DeviceType.CAR,  new DeviceTypeProperties() {name="Car", pluralName="cars" } },
            { DeviceType.TRUCK, new DeviceTypeProperties() {name="Truck", pluralName="trucks" } },
            { DeviceType.GENERATOR, new DeviceTypeProperties() {name="Generator", pluralName="generators" } },
            { DeviceType.FRIDGE, new DeviceTypeProperties() {name="Fridge", pluralName="fridges" } }
        };
    }
}
