namespace StateDesignPattern.DoorStates
{
    internal abstract class DoorState : DomainObject
    {
        private Door _door;

        public Door Door
        {
            get => _door;
            set => _door = value;
        }

        public abstract void Close();

        public abstract void Open();

        public abstract void Break();

        public abstract void Lock();

        public abstract void Unlock();

        public void Fix()
        {
            _door.DoorState = new DoorClosedState(this);
        }
    }
}
