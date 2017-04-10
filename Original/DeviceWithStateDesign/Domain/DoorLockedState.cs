using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Domain
{
    public class DoorLockedState : DoorState
    {
        public DoorLockedState(DoorState doorState)
        {
            Initialize();
            this.Door = doorState.Door;
        }

        public DoorLockedState(Door door)
        {
            Initialize();
            this.Door = door;
        }

        private void Initialize()
        {
            Name = "Locked";
        }

        public override void Close()
        {
            // We can't close an already locked door.
        }

        public override void Open()
        {
            // Can't open a locked door.
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
            // It's already locked.
        }

        public override void Unlock()
        {
            // We can unlock the door with the right key.
            this.Door.DoorState = new DoorUnlockedState(this);
        }
    }
}
