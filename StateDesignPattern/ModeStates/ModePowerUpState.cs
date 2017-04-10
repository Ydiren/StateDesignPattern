using System.Reflection.Metadata.Ecma335;

namespace StateDesignPattern.ModeStates
{
    internal class ModePowerUpState : ModeState
    {
        public ModePowerUpState(ModeState modeState)
        {
            Initialize();
            Device = modeState.Device;
        }

        public ModePowerUpState(Device device)
        {
            Initialize();
            Device = device;
        }

        private void Initialize()
        {
            Name = "Powering Up";
        }

        public override void SetModeToPowerUp()
        {
            // Already in this state
        }

        public override void SetModeToIdle()
        {
            Device.Mode = new ModeIdleState(this);
        }

        public override void SetModeToBusy()
        {
            // Can't set mode to busy as we're still powering up
        }

        public override void SetModeToPowerDown()
        {
            // Cleanup any resources and then set the state
            Device.Mode = new ModePowerDownState(this);
        }
    }
}