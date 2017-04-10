using System;
using System.Collections.Generic;
using System.Text;
using StateDesignPattern.ModeStates;

namespace StateDesignPattern.DoorStates
{
    class DoorUnlockedState : DoorState
    {
        public DoorUnlockedState(DoorState doorState)
        {
            Initialize();
            Door = doorState.Door;
        }

        public DoorUnlockedState(Door door)
        {
            Initialize();
            Door = door;
        }

        private void Initialize()
        {
            Name = "Unlocked";
        }

        public override void Close()
        {
            // Cant close an already locked door
        }

        public override void Open()
        {
            // Cant open a locked door.
        }

        public override void Break()
        {
            // To simulate production vs test configuration scenarios, we can't break the door
            // in test congiguration. So we nee dot check the Device's configurationState.
            // We also want to make sure this is only possible while the device is idle

            // Important
            // =========
            // As you can see if the if statement, we can now use a combination of different states to
            // check business rules and conditions by simply combining the existence of certain class types.
            // This allows for super easy maintenance as it 100% encapsulates these rules in one place 
            // (in the Break() method in this case)
            if ((Door.Device.Configuration is ProductionConfigurationState) && (Door.Device.Mode is ModeIdleState))
            {
                Door.DoorState = new DoorBrokenState(this);
            }
        }

        public override void Lock()
        {
            Door.DoorState = new DoorLockedState(this);
        }

        public override void Unlock()
        {
            // Already unlocked
        }
    }
}
