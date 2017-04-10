using System;

namespace StateDesignPattern.DoorStates
{
    internal class DoorLockedState : DoorState
    {
        public DoorLockedState(DoorState doorState)
        {
            Initialize();
            Door = doorState.Door;
        }

        public DoorLockedState(Door door)
        {
            Initialize();
            Door = door;
        }
        private void Initialize()
        {
            Name = "Locked";
        }

        public override void Close()
        {
            throw new NotImplementedException();
        }

        public override void Open()
        {
            throw new NotImplementedException();
        }

        public override void Break()
        {
            throw new NotImplementedException();
        }

        public override void Lock()
        {
            throw new NotImplementedException();
        }

        public override void Unlock()
        {
            throw new NotImplementedException();
        }
    }
}