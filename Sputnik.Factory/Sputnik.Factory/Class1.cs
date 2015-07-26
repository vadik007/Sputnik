using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sputnik.Factory
{
    public class SputnikBuilder:IBuilder
    {
        public IBuilder AddSystem(ISystem system)
        {
            throw new NotImplementedException();
        }

        public IBuilder AddFuel(double amount)
        {
            throw new NotImplementedException();
        }
    }

    public interface IBuilder
    {
        IBuilder AddSystem(ISystem system);

        IBuilder AddFuel(double amount);

    }

    class MyClass
    {
        void Test()
        {
            new SputnikBuilder()
                .AddSystem(new ControllModule(
                        module => { module.IsValid()}
                    ))
                .AddSystem(new TemperatureControllModule())
                .AddSystem(new PowerSupplyModule())
                .AddFuel(50);

        }
    }
}
