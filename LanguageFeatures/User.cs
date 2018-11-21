using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageFeatures
{



    public class User
    {
        public User()
        {

        }
        public User(string name)
        {
            Username = name;
        }
        //public Guid Id
        //{
        //    get { return _id; }
        //}

       

        //public string Username
        //{
        //    get { return _username; }
        //    protected set { _username = value;  }
        //}

        
        //private readonly Guid _id;
        //private string _username = string.Empty;

        public Guid Id => Guid.NewGuid();
        public string Username { get; protected set; } = String.Empty;
    }


}
