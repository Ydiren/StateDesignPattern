using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class DoorState : DomainObject
    {
        protected Door _door;

        public Door Door
        {
            get { return _door; }
            set { _door = value; }
        }

        public abstract void Close();
        public abstract void Open();
        public abstract void Break();
        public abstract void Lock();
        public abstract void Unlock();

        /// <summary>
        /// Fix simulates a repair to the Door and resets 
        /// the initial state of the door to closed.
        /// </summary>
        public void Fix()
        {
            _door.DoorState = new DoorClosedState(this);
        }
    }
}
