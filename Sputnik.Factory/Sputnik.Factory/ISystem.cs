using System;

namespace Sputnik.Factory
{
    public interface ISystem
    {
        bool IsValid();
    }

    class TemperatureControllModule : ISystem
    {
        public bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
    class PowerSupplyModule : ISystem
    {
        public bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
    class ChassisModule : ISystem
    {
        public bool IsValid()
        {
            throw new NotImplementedException();
        }
    }

    class OrientationModule : ISystem
    {
        public bool IsValid()
        {
            throw new NotImplementedException();
        }
    }

    class ControllModule : ISystem
    {
        private readonly Action<ControllModule> _action;

        public ControllModule(Action<ControllModule> action)
        {
            _action = action;
        }

        public bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}