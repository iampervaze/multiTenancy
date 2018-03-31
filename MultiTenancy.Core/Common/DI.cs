using StructureMap;

namespace MultiTenancy.Core.Common
{
    public class DI
    {
        public static IContainer Container;

        public static T Resolve<T>()
        {
            var obj = Container.GetInstance<T>();
            return obj;
        }
    }
}