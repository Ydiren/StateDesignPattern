using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    /// <summary>
    /// This represents a physical door on the Device.
    /// </summary>
    public class Door : DomainObject
    {
        // Door only knows about generic actions on certain
        // states. So, we use the base classes of these 
        // states in order execute these commands. The base
        // classes are abstract classes of the states.
        private DoorState _doorState;

        // We provide access to the owner (the Device). 
        // This is required if we need to check conditions 
        // that are global to the Device such as 
        // configuration settings or even other states.
        private Device _device;

        public Door()
        {
            Initialize();
        }

        public Door(Device device)
        {
            _device = device;

            Initialize();
        }

        public Door(string name) : base(name)
        {
            Initialize();
        }

        private void Initialize()
        {
            // The initial state of the Door is closed
            _doorState = new DoorClosedState(this);
        }

        public Device Device
        {
            get { return _device; }
            set { _device = value; }
        }

        public DoorState DoorState
        {
            get { return _doorState; }
            set { _doorState = value; }
        }

        // The actions that we can perform on the context
        // in relationship to the state. The name of the 
        // methods can be a generic name and not 
        // necessarily related directly to the state we 
        // are trying to manipulate. For example, it 
        // could be public void PowerUp() and inside the
        // PowerUp() method, we can check or manipulate 
        // the DoorState state.
        public void Close()
        {
            _doorState.Close();
        }

        public void Open()
        {
            _doorState.Open();
        }

        public void Break()
        {
            _doorState.Break();            
        }

        public void Lock()
        {
            _doorState.Lock();
        }

        public void Unlock()
        {
            _doorState.Unlock();
        }

        /// <summary>
        /// Fix is a special method on the state of the Door.
        /// There is no Fixed state since we simply reseting 
        /// the door to the initial close state after the 
        /// door has been fixed. Therfore, the implementation
        /// of the Fix() method is in the DoorState base 
        /// class. Since we are using Abstract classes for 
        /// our bases, we can implement functionality that 
        /// works accross all states.
        /// </summary>
        public void Fix()
        {
            _doorState.Fix();
        }
    }
}
