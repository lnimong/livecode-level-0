using Microsoft.Phone.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlloWorld.SharedCode
{
    public class DialerModel
    {
        dynamic[] contacts = new dynamic[] {
            new { name = "Jason", number = "00000001"},
            new { name = "Arnaud", number = "00000001"},
            new { name = "Fathi", number = "00000001"},
            new { name = "Thomas", number = "00000001"},
        };


        public void RandomDial()
        {
            var random = new Random ((int)DateTime.Now.Ticks);
            var contact = contacts[random.Next(0, 3000) % contacts.Count()];

            var phoneCallTask = new PhoneCallTask();

            phoneCallTask.PhoneNumber = contact.number;
            phoneCallTask.DisplayName = contact.name;

            phoneCallTask.Show();
        }
    }
}
