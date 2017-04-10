namespace StateDesignPattern.DoorStates
{
    internal class DoorOpenedState : DoorState
    {
        public DoorOpenedState(DoorState doorState)
        {
            Initialize();
            Door = doorState.Door;
        }

        public DoorOpenedState(Door door)
        {
            Initialize();
            Door = door;
        }
        private void Initialize()
        {
            Name = "Opened";
        }

        public override void Close()
        {
            Door.DoorState = new DoorClosedState(this);
        }

        public override void Open()
        {
            // already open
        }

        public override void Break()
        {
            // no point in breaking an open door
        }

        public override void Lock()
        {
            // no point in locking an open door
        }

        public override void Unlock()
        {
            // No point in unlocking an open door
        }
    }
}