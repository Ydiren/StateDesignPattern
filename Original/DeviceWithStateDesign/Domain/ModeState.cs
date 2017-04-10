using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class ModeState : DomainObject
    {
        protected Device _device;

        public Device Device
        {
            get { return _device; }
            set { _device = value; }
        }

        public abstract void SetModeToPowerUp();
        public abstract void SetModeToIdle();
        public abstract void SetModeToBusy();
        public abstract void SetModeToPowerDown();
    }
}
