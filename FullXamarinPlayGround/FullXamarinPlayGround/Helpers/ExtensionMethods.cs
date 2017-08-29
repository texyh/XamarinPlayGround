using System;
using System.Collections.Generic;
using System.Text;

namespace FullXamarinPlayGround.Helpers
{
    public static class ExtensionMethods
    {
        public static bool IsNullOrEmpty(this string item)
        {
            return item == null || item == string.Empty;
        }
    }
}
