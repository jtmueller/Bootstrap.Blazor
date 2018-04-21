using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootstrap.Blazor
{
    internal static class Util
    {
        public static string ClassNames(params string[] names) => String.Join(" ", names).TrimEnd();

        public static string ClassNames(IEnumerable<string> names) => String.Join(" ", names).TrimEnd();
    }

}
