using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeroldHaas.Utils.Enums
{
    public static class EnumExtensions
    {
        /// <summary>
        /// Returns the name of the enumeration, as a string.
        /// </summary>
        /// <param name="e">A "self"; generally you don't need to pass this,
        /// as this is an extension method.</param>
        /// <returns>The name of the enumeration, converted to string.</returns>
        public static string Name(this Enum e)
        {
            var t = e.GetType();
            return Enum.GetName(t, e);
        }
    }
}
