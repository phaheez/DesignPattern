using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class SingletonDataContainer
    {
        private SingletonDataContainer() { }

        private static Lazy<SingletonDataContainer> _instance = null;

        public static SingletonDataContainer GetInstance()
        {
            if (_instance is null)
            {
                _instance = new Lazy<SingletonDataContainer>(() => new SingletonDataContainer());
            }
            return _instance.Value;
        }

        public string GetCustomerName(string name) => name;
    }
}
