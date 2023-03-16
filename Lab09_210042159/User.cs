using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09A_210042149
{
    internal class User
    {
        public string _userN { get; set; }
        public string _pass { get; set; }
        public string _name { get; set; }

        public User(string userN, string pass, string name)
        {
            this._userN = userN;
            this._pass = pass;
            this._name = name;
        }
    }
}
