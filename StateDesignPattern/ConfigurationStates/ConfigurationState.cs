namespace StateDesignPattern.ConfigurationStates
{
    internal abstract class ConfigurationState
    {
        public abstract void SetTestConfiguration();
        public abstract void SetProductionConfiguration();
    }
}
