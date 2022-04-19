using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Registration.Interface
{
    public interface IRegister
    {
        void InsertRegisterRecord(RegistrationModel model);
    }
}
