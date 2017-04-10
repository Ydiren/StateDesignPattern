using StateDesignPattern.ConfigurationStates;

namespace StateDesignPattern
{
    internal class ProductionConfigurationState : ConfigurationState
    {
        private readonly Device _device;

        public ProductionConfigurationState(Device device)
        {
            _device = device;
        }

        public override void SetTestConfiguration()
        {
            _device.Configuration = new TestConfigurationState(_device);
        }

        public override void SetProductionConfiguration()
        {
            // Already in production configuration
        }
    }
}