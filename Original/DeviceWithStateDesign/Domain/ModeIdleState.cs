using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ModeIdleState : ModeState
    {
        public ModeIdleState(ModeState modeState)
        {
            Initialize();
            this.Device = modeState.Device;
        }

        public ModeIdleState(Device device)
        {
            Initialize();
            this.Device = device;
        }

        private void Initialize()
        {
            Name = "Idle";
        }

        public override void SetModeToPowerUp()
        {
            // Can't switch to power-up mode
        }

        public override void SetModeToIdle()
        {
            // Already in Idle state
        }

        public override void SetModeToBusy()
        {
            this.Device.Mode = new ModeBusyState(this);
        }

        public override void SetModeToPowerDown()
        {
            // We're busy, but we allow to power down.

            // Cleanup any resources and then set the state
            this.Device.Mode = new ModePowerDownState(this);
        }
    }
}
