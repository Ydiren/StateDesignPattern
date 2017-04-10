using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using StateDesignPattern.ConfigurationStates;
using StateDesignPattern.DoorStates;
using StateDesignPattern.ModeStates;

namespace StateDesignPattern
{
    internal class Device : DomainObject
    {
        // Device has a physical dooe represented by the Door class
        private Door _door;

        // Device only knows about generic actiosn on certain states. So we use the base classes of 
        // these states in order to execute these commands.
        // The base classes are abstract classes of the states.
        private ConfigurationState _configurationState;

        // The current mode that the device is in
        private ModeState _modeState;

        public Device()
        {
            Initialize();
        }

        public Device(string name) 
            : base(name)
        {
            Initialize();
        }

        public Door Door
        {
            get => _door;
            set => _door = value;
        }

        public ConfigurationState Configuration
        {
            get => _configurationState;
            set => _configurationState = value;
        }

        public ModeState Mode
        {
            get => _modeState;
            set => _modeState = value;
        }

        private void Initialize()
        {
            // We are starting up for the first time
            _modeState = new ModePowerUpState(this);

            _door = new Door(this);

            // The initial configuration setting for the device. This initial configuration 
            // can come from an external configuration file, for example.
            _configurationState = new ProductionConfigurationState(this);

            // The door is initially closed.
            _door.DoorState = new DoorClosedState(_door);

            // Ready
            _modeState.SetModeToIdle();
        }
    }
}
