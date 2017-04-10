using System;

namespace StateDesignPattern.DoorStates
{
    internal class DoorBrokenState : DoorState
    {
        public DoorBrokenState(DoorState doorState) 
        {
            Initialize();
            Door = doorState.Door;
        }

        public DoorBrokenState(Door door)
        {
            Initialize();
            Door = door;
        }

        private void Initialize()
        {
            Name = "Broken";
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