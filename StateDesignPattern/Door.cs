using StateDesignPattern.DoorStates;

namespace StateDesignPattern
{
    internal class Door : DomainObject
    {
        public Door(Device device)
        {
            Initialize();
            Device = device;
        }

        private void Initialize()
        {
            DoorState = new DoorClosedState(this);
        }

        // Door only knows about generic actions on certain states.
        public DoorState DoorState { get; set; }

        // We provide access to the owner (the Device)
        // This is required if we need to check conditions that are
        // global to the Device such as configuration settings or even other states.
        public Device Device { get; private set; }

        public void Close()
        {
            DoorState = new DoorClosedState(this);
        }

        public void Open()
        {
            DoorState = new DoorOpenedState(this);
        }

        public void Break()
        {
            DoorState = new DoorBrokenState(this);
        }

        public void Lock()
        {
            DoorState = new DoorLockedState(this);
        }

        public void Unlock()
        {
            DoorState = new DoorUnlockedState(this);
        }

        public void Fix()
        {
            DoorState.Fix();
        }
    }
}