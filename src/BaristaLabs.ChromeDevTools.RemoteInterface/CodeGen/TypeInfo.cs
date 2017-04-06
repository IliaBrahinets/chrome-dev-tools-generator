﻿namespace BaristaLabs.ChromeDevTools.RemoteInterface.CodeGen
{
    public sealed class TypeInfo
    {
        public string Namespace
        {
            get;
            set;
        }

        public bool IsPrimitive
        {
            get;
            set;
        }

        public string TypeName
        {
            get;
            set;
        }
    }
}