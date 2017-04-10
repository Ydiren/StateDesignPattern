using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DoorBrokenState : DoorState
    {
        public DoorBrokenState(DoorState doorState)
        {
            Initialize();
            this.Door = doorState.Door;
        }

        public DoorBrokenState(Door door)
        {
            Initialize();
            this.Door = door;
        }

        private void Initialize()
        {
            Name = "Broken";
        }

        public override void Close()
        {
            // Since the door is broken, we can't close the
            // door. We might want to notify a repair man.

            // Some other action should be calling the Fix() 
            // method in the DoorState base class simulating
            // a repair and a change to the Door state.
        }

        public override void Open()
        {
            // Since the door is broken, we can't open the 
            // door. We might want to notify a repair man.

            // Some other action should be calling the Fix() 
            // method in the DoorState base class 
            // simulating a repair and a change to the 
            // Door state.
        }

        public override void Break()
        {
            // Since its already broken, we can't break 
            // it much further.
        }

        public override void Lock()
        {
            // Can't lock a broken door.
        }

        public override void Unlock()
        {
            // Can't unlock a broken door.
        }
    }
}
