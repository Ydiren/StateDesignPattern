using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class ConfigurationState : DomainObject
    {
        // We want to provide access to the context for each sub-class
        // that implements a ConfigurationState.
        protected Device _device;

        public abstract void SetProductionConfiguration();
        public abstract void SetTestConfiguration();

        public Device Device
        {
            get { return _device; }
            set { _device = value; }
        }
    }
}
