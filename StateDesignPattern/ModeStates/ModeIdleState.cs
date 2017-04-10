namespace StateDesignPattern.ModeStates
{
    internal class ModeIdleState : ModeState
    {
        public ModeIdleState(ModeState modeState)
        {
            Initialize();
            Device = modeState.Device;
        }

        public ModeIdleState(Device device)
        {
            Initialize();
            Device = device;
        }

        private void Initialize()
        {
            Name = "Idle";
        }

        public override void SetModeToPowerUp()
        {
            // Already powered up
        }

        public override void SetModeToIdle()
        {
            // Already idling
        }

        public override void SetModeToBusy()
        {
            Device.Mode = new ModeBusyState(this);
        }

        public override void SetModeToPowerDown()
        {
            Device.Mode = new ModePowerDownState(this);
        }
    }
}