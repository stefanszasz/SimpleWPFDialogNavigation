using System;

namespace SimpleWPFDialogNav.Infrastructure
{
    public class DataContextAttribute : Attribute
    {
        private readonly Type _vmType;

        public DataContextAttribute(Type vmType)
        {
            _vmType = vmType;
        }
    }
}