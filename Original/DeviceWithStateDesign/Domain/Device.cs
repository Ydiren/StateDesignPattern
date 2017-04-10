using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    /// <summary>
    /// The Device class is the owner of the different states
    /// that the Device can be in. The Device is alos the 
    /// owner of actions (methods) that can be applied to the
    /// states. In other words, Device is the thing we are 
    /// trying to manipulate through outside behavior.
    /// </summary>
    public class Device : DomainObject
    {
        // Device has a physical door represented by the 
        // Door class.
        private Door _door;

        // Device only knows about generic actions on 
        // certain states. So, we use the base classes of 
        // these states in order execute these commands. 
        // The base classes are abstract classes of the 
        // states.
        private ConfigurationState _configurationState;
        
        // The current mode that the device is in.
        private ModeState _modeState;

        public Device(string name) : base(name)
        {
            Initialize();
        }

        public Device()
        {
            Initialize();
        }

        private void Initialize()
        {
            // We are starting up for the first time.
            _modeState = new ModePowerUpState(this);

            _door = new Door(this);

            // The initial configuration setting for the 
            // device. This initial configuration can come 
            // from an external configuration file, for 
            // example.
            _configurationState = new ProductionConfigurationState(this);

            // The door is initially closed
            _door.DoorState = new DoorClosedState(_door);

            // We are ready
            _modeState.SetModeToIdle();
        }

        public Door Door
        {
            get { return _door; }
            set { _door = value; }
        }

        public ConfigurationState Configuration
        {
            get { return _configurationState; }
            set { _configurationState = value; }
        }

        public ModeState Mode
        {
            get { return _modeState; }
            set { _modeState = value; }
        }
    }
}
