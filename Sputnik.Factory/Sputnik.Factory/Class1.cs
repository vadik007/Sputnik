using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sputnik.Factory
{
    public class Builder:IBuilder
    {
        public IBuilder AddSystem(ISystem system)
        {
            throw new NotImplementedException();
        }
    }

    public interface IBuilder
    {
        IBuilder AddSystem(ISystem system);
    }

    public interface ISystem
    {
        
    }

    class MyClass
    {
        void m()
        {
            new Builder()
                .AddSystem()
                .AddSystem()
        }
    }
}
