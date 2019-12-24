using System.Reflection;

namespace Munderwood.Core.Invoker
{
    public class BasicTypeInvoker
    {
        public void CallMethod(object invokingObject, string name, object[] parameters)
        {
            MethodInfo theMethod = invokingObject.GetType().GetMethod(name);
            theMethod.Invoke(invokingObject, parameters);
        }
    }
}