using System;

namespace Munderwood.Core.Resolver
{
    public class TypeResolver
    {
        public object Resolve(Type type, object[] arguments)
        {
            object resolvedType = Activator.CreateInstance(type,arguments);
            return resolvedType;
        }
    }
}