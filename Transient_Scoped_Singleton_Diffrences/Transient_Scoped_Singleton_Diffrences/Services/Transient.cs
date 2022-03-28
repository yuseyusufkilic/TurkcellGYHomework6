using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Transient_Scoped_Singleton_Diffrences.Services
{
    
    public class Transient : IServices
    {
        private Guid _id;

        public Transient()
        {
            _id = Guid.NewGuid();
        }
        public Guid ReturnGUID()
        {
            return _id;
        }
    }
}
