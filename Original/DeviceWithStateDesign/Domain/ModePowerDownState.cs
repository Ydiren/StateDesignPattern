using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ModePowerDownState : ModeState
    {
        public ModePowerDownState(ModeState modeState)
        {
            Initialize();
            this.Device = modeState.Device;
        }

        public ModePowerDownState(Device device)
        {
            Initialize();
            this.Device = device;
        }

        private void Initialize()
        {
            Name = "Powering Down";
        }

        public override void SetModeToPowerUp()
        {
            // We're not allowing this
        }

        public override void SetModeToIdle()
        {
            // Not possible
        }

        public override void SetModeToBusy()
        {
            // Not possible
        }

        public override void SetModeToPowerDown()
        {
            // No need
        }
    }
}
