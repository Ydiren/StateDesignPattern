using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DoorOpenState : DoorState
    {
        public DoorOpenState(DoorState doorState)
        {
            Initialize();
            this.Door = doorState.Door;
        }

        public DoorOpenState(Door door)
        {
            Initialize();
            this.Door = door;
        }

        private void Initialize()
        {
            Name = "Open";
        }

        public override void Close()
        {
            this.Door.DoorState = new DoorClosedState(this);
        }

        public override void Open()
        {
            // Since we are alredy in an Open state, no need
            // for any state changes. We might want to 
            // record this action for audit purposes, for 
            // example.
        }

        public override void Break()
        {
            // To simulate production vs test configuration 
            // scenarios, we can't break a door in test 
            // configuration. So, we need to check the 
            // Device's ConfigurationState.
            if (this.Door.Device.Configuration is ProductionConfigurationState)
                this.Door.DoorState = new DoorBrokenState(this);
        }

        public override void Lock()
        {
            // Can't lock an open door.
        }

        public override void Unlock()
        {
            // Can't unlock an open door.
        }
    }
}
