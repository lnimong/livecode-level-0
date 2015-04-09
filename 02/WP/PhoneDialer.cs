using Microsoft.Phone.Tasks;
using SharedCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WP
{
    public class WpPhoneDialer : IPhoneDialer
    {
        public void Call(string name, string number)
        {
            var phoneCallTask = new PhoneCallTask();

            phoneCallTask.PhoneNumber = number;
            phoneCallTask.DisplayName = name;

            phoneCallTask.Show();
        }
    }
}
