using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageFeatures
{
    class OperationLogger
    {
        public Task LogOperation(Action action)
        {
            //var name = "no name";
            //if(action != null && action.Method != null)
            //{
            //    name = action.Method.Name;
            //}

            var name = action?.Method?.Name ?? "no name";

            return Task.FromResult(0);
        }
    }
}
