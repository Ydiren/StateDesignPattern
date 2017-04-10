using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DoorUnlockedState : DoorState
    {
        public DoorUnlockedState(DoorState doorState)
        {
            Initialize();
            this.Door = doorState.Door;
        }

        public DoorUnlockedState(Door door)
        {
            Initialize();
            this.Door = door;
        }

        private void Initialize()
        {
            Name = "Unlocked";
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
            // Device's ConfigurationState. We also want to
            // make sure this is only possible while the 
            // device is Idle.
            //
            // Important:
            // ==========
            // As you can see in the If statement, we can 
            // now use a combination of different states to 
            // check business rules and conditions by simply
            // combining the existence of certain class 
            // types. This is allows for super easy 
            // maintenance as it 100% encapsulates these 
            // rules in one place (in the Break() method in 
            // this case).
            if ((this.Door.Device.Configuration is ProductionConfigurationState) &&
                (this.Door.Device.Mode is ModeIdleState))
            {
                this.Door.DoorState = new DoorBrokenState(this);
            }
        }

        public override void Lock()
        {
            this.Door.DoorState = new DoorLockedState(this);
        }

        public override void Unlock()
        {
            // We are already unlocked
        }
    }
}
