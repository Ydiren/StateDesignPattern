using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ModeBusyState : ModeState
    {
        public ModeBusyState(ModeState modeState)
        {
            Initialize();
            this.Device = modeState.Device;
        }

        public ModeBusyState(Device device)
        {
            Initialize();
            this.Device = device;
        }

        private void Initialize()
        {
            Name = "Busy";
        }

        public override void SetModeToPowerUp()
        {
            // Not possible
        }

        public override void SetModeToIdle()
        {
            this.Device.Mode = new ModeIdleState(this);
        }

        public override void SetModeToBusy()
        {
            // We're already busy
        }

        public override void SetModeToPowerDown()
        {
            // We're busy, but we allow to power down.
            
            // Cleanup any resources and then set the state
            this.Device.Mode = new ModePowerDownState(this);
        }
    }
}
