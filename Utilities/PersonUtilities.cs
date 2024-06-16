using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public static class PersonUtilities
    {
        public static string GetFullName(Person person)
        {
            return $"{person.FirstName} {person.LastName}";
        }
    }
}
