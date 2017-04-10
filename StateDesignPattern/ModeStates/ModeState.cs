using System;

namespace StateDesignPattern.ModeStates
{
    internal abstract class ModeState : DomainObject
    {
        public Device Device { get; protected set; }

        public abstract void SetModeToPowerUp();

        public abstract void SetModeToIdle();

        public abstract void SetModeToBusy();

        public abstract void SetModeToPowerDown();
    }
}