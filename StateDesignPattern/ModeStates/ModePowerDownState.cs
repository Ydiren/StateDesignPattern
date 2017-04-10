namespace StateDesignPattern.ModeStates
{
    internal class ModePowerDownState : ModeState
    {
        public ModePowerDownState(ModeState modeState)
        {
            Initialize();
            Device = modeState.Device;
        }

        private void Initialize()
        {
            Name = "Powering Down";
        }

        public override void SetModeToPowerUp()
        {
            Device.Mode = new ModePowerUpState(this);
        }

        public override void SetModeToIdle()
        {
            // Cant idle as we are powering down
        }

        public override void SetModeToBusy()
        {
            // Cant be busy as we are powering down
        }

        public override void SetModeToPowerDown()
        {
            // already powering down
        }
    }
}