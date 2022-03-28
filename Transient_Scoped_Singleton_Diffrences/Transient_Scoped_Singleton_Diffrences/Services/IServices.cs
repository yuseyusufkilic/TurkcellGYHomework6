using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Transient_Scoped_Singleton_Diffrences.Services
{
    public interface IServices
    {
        Guid ReturnGUID();
    }
}
