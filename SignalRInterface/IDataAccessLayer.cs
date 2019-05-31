using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRInterface
{
    public interface IDataAccessLayer<T>
    {
        List<T> Get();
        bool Save(T type);
    }
}
