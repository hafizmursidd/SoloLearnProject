using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism.ProtectedMembers
{
    internal static class RunProtected
    {
        //Main for
        public static void Running()
        {
            string accNumber = "005615216";
            double balance = 1488.36;

            User user = new User(accNumber, balance);

            user.ShowDetails();
        }
    }
}
