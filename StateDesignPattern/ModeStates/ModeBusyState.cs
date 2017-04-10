using System.Threading;

namespace StateDesignPattern.ModeStates
{
    internal class ModeBusyState : ModeState
    {
        public ModeBusyState(ModeState modeState)
        {
            Initialize();
            Device = modeState.Device;
        }

        private void Initialize()
        {
            Name = "Busy";
        }

        public override void SetModeToPowerUp()
        {
            // Already powered up
        }

        public override void SetModeToIdle()
        {
            Device.Mode = new ModeIdleState(this);
        }

        public override void SetModeToBusy()
        {
            // Already busy
        }

        public override void SetModeToPowerDown()
        {
            Device.Mode = new ModePowerDownState(this);
        }
    }
}