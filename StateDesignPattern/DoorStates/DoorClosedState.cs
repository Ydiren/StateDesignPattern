namespace StateDesignPattern.DoorStates
{
    internal class DoorClosedState : DoorState
    {
        public DoorClosedState(DoorState doorState)
        {
            Initialize();
            Door = doorState.Door;
        }

        public DoorClosedState(Door door)
        {
            Initialize();
            Door = door;
        }

        private void Initialize()
        {
            Name = "Closed";
        }

        public override void Close()
        {
            // already closed
        }

        public override void Open()
        {
            Door.DoorState = new DoorOpenedState(this);
        }

        public override void Break()
        {
            if(Door.Device.Configuration is ProductionConfigurationState)
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
            // Cant unlock a closed door. Needs to be locked
        }
    }
}