using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralDP.Bridge_DP
{
    public interface IDevice
    {
        void enable();
        void disable();
        void getVolume();
        void setVolume(double volume);

    }
    public class RemoteControl
    {
        private IDevice device;
        public RemoteControl(IDevice device)
        {
            this.device = device;
        }

        public void enable()
        {
            this.device.enable();
        }
        public void disable()
        {
            this.device.disable();
        }
        public void getVolume()
        {
            this.device.getVolume();
        }
        public void setVolume(double volume)
        {
            this.device.setVolume(volume);
        }

    }

    public class AdvancedRemoteControl : RemoteControl
    {
        public IDevice device;
        public AdvancedRemoteControl(IDevice device) : base(device)
        {
            this.device = device;   
        }

        public void mute()
        {
            this.device.setVolume(0);
        }
    }

    public class TV : IDevice
    {
        public void enable()
        {
            Console.WriteLine("TV enabled");
        }
        public void disable()
        {
            Console.WriteLine("TV Disabled");
        }

        public void getVolume()
        {
            Console.WriteLine("Get TV Volume");
        }

        public void setVolume(double volume)
        {
            Console.WriteLine($"TV Volume set to {volume}");
        }
    }


    public class Radio : IDevice
    {
        public void enable()
        {
            Console.WriteLine("Radio enabled");
        }
        public void disable()
        {
            Console.WriteLine("Radio Disabled");
        }

        public void getVolume()
        {
            Console.WriteLine("Get Radio Volume");
        }

        public void setVolume(double volume)
        {
            Console.WriteLine($"Radio Volume set to {volume}");
        }
    }


    public class BridgeDP
    {
        public TV tv;
        public Radio Radio;
        public RemoteControl RemoteControl;
        public AdvancedRemoteControl AdvancedRemoteControl;
        public BridgeDP()
        {
            tv = new TV();  // Instantiate the TV object
            RemoteControl = new RemoteControl(tv);  // Pass the TV object to the RemoteControl

            Radio = new Radio();
            AdvancedRemoteControl = new AdvancedRemoteControl(Radio);

        }

        public void Initialize()
        {
            RemoteControl.enable();  // Call the enable method on the RemoteControl
            AdvancedRemoteControl.mute();
            AdvancedRemoteControl.enable();
        }
    }
}
