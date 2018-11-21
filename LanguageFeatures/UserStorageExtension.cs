using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageFeatures
{
    public static class UserStorageExtension
    {
        public static User Add(this UserStorage store, User newUser)
        {
            store.Insert(newUser);
            return newUser;
        }
    }
}
