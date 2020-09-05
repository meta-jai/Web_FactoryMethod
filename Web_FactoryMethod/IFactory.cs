using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_FactoryMethod
{
    /// <summary>
    /// The 'Product' interface
    /// </summary>
    public interface IFactory
    {
        void Drive(int miles);
    }
}
