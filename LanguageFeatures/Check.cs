using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageFeatures
{
    public class Check
    {
        public static T ArgNotNull<T>(string name, T value)
        {
            if(value == null)
            {
                throw new ArgumentNullException(name);
            }
            return value;
        }

    }
}
