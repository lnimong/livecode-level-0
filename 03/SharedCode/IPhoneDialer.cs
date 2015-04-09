using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharedCode
{
    public interface IPhoneDialer
    {
        void Call(string name, string number);
    }
}
