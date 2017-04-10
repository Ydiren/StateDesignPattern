using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DoorClosedState : DoorState
    {
        public DoorClosedState(DoorState doorState)
        {
            Initialize();
            this.Door = doorState.Door;
        }

        public DoorClosedState(Door door)
        {
            Initialize();
            this.Door = door;
        }

        private void Initialize()
        {
            Name = "Closed";
        }

        public override void Close()
        {
            // Since we are alredy in a Closed state, no need
            // for any state changes. We might want to record 
            // this action for audit purposes, for example.
        }

        public override void Open()
        {
            this.Door.DoorState = new DoorOpenState(this);
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
            this.Door.DoorState = new DoorLockedState(this);
        }

        public override void Unlock()
        {
            // Can't unlock a closed door. Needs to be 
            // locked.
        }
    }
}
