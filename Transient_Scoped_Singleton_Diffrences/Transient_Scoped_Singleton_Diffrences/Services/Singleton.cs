using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Transient_Scoped_Singleton_Diffrences.Services
{
    
    public class Singleton : IServices
    {
        private Guid _id;

        public Singleton()
        {
            _id = Guid.NewGuid();
        }
        public Guid ReturnGUID()
        {
            return _id;
        }
    }
}
