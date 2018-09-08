using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace SteamWebAPI.ClientSdk
{
    internal class ConversionUtil
    {
        public T ConvertValue<T>(string value, T defaultValue)
        {
            if (value != null)
            {
                try
                {
                    var converter = TypeDescriptor.GetConverter(typeof(T));
                    return (T)(converter.ConvertFromInvariantString(value));
                }
                catch (Exception)
                {
                    return defaultValue;
                }
            }
            else
                return defaultValue;
        }

        public Assembly AssemblyFromType<T>()
        {
            Type type = typeof(T);
            Assembly asm = null;
//#if NETSTANDARD1_4
//                type.GetTypeInfo().Assembly;
//#else
//                type.Assembly;
//#endif
            return asm;
        }
    }
}
