using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Shomahar
{
    internal class user
    {
        public string _userN { get; set; }
        public string _pass { get; set; }
        public string _name { get; set; }

        public user(string userN, string pass, string name)
        {
            this._userN = userN;
            this._pass = pass;
            this._name = name;
        }
    }
}
