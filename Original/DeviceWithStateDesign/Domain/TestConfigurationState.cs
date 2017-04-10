using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class TestConfigurationState : ConfigurationState
    {
        public TestConfigurationState(ConfigurationState configurationState)
        {
            this.Device = configurationState.Device;
            Initialize();
        }

        public TestConfigurationState(Device device)
        {
            this.Device = device;
            Initialize();
        }

        private void Initialize()
        {
            Name = "Test";

            // Here we want to setup the device under the 
            // test configuration and how it should behave.
            // For example, we may want the door to be in 
            // a broken state. To do this, we can either 
            // call the Break() method on the Door or we 
            // can manipulate the DoorState directly and 
            // instantiate an instance of the 
            // DoorBrokenState.
            //this.Device.Door.Break();
        }

        public override void SetProductionConfiguration()
        {
            // We support switching to production 
            // configuration at run-time.
            this.Device.Configuration = new ProductionConfigurationState(this);
        }

        public override void SetTestConfiguration()
        {
            // We're already in test configuration.

            // We could also call the Initialize() method
            // to reset the test configuration or to 
            // re-execute any business logic.
        }
    }
}
