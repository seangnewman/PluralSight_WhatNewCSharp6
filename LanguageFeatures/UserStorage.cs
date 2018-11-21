using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageFeatures
{
    public class UserStorage : IEnumerable<User>
    {
        public int Capacity { get;   }
        List<User> _users = new List<User>();

        //Dictionary<string, User> _defaultUsers = new Dictionary<string, User>()
        //{
        //    {"admin", new User("admin") },
        //    {"guest", new User("guest") }
        //};
  

        Dictionary<string, User> _defaultUsers = new Dictionary<string, User>()
        {
            ["admin"] = new User("admin") ,
            ["guest"] = new User("guest") 
        };

        public User Insert(User newUser)
        {
            _users.Add(newUser);
            return newUser;
        }


        public IEnumerator<User> GetEnumerator()
        {

            var allUsers = _defaultUsers.Select(kvp => kvp.Value)
                                        .Concat(_users);
            return allUsers.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)this.GetEnumerator();
        }
    }
}
