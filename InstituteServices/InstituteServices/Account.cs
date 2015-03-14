using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InstituteServices
{
    public class Account
    {
        private string eMail;

        public string EMail
        {
            get { return eMail; }
            set { eMail = value; }
        }
        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

    }
}
