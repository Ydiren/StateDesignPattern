namespace StateDesignPattern.ConfigurationStates
{
    internal class TestConfigurationState : ConfigurationState
    {
        private readonly Device _device;

        public TestConfigurationState(Device device)
        {
            _device = device;
        }

        public override void SetTestConfiguration()
        {
            // Already in test configuration
        }

        public override void SetProductionConfiguration()
        {
            _device.Configuration = new ProductionConfigurationState(_device);
        }
    }
}