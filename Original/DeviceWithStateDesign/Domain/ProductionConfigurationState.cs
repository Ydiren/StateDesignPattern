using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ProductionConfigurationState : ConfigurationState
    {
        public ProductionConfigurationState(ConfigurationState configurationState)
        {
            this.Device = configurationState.Device;
            Initialize();
        }

        public ProductionConfigurationState(Device device)
        {
            this.Device = device;
            Initialize();
        }

        private void Initialize()
        {
            Name = "Production";

            // Here we want to setup the device under the 
            // production configuration and how it should 
            // behave. In this production configuration, we
            // want the door to be in a closed state. To do
            // this, we can either call the Close() method
            // on the Door or we can manipulate the 
            // DoorState directly and instantiate an 
            // instance of the DoorClosedState.
            this.Device.Door.Close();
        }

        public override void SetProductionConfiguration()
        {
            // We're in production configuration.
        }

        public override void SetTestConfiguration()
        {
            // We support switching to test 
            // configuration at run-time.
            this.Device.Configuration = new TestConfigurationState(this);
        }
    }
}
