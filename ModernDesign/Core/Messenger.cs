using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernDesign.Core
{
    public class Messenger
    {
        private static Messenger _instance;
        public static Messenger Instance => _instance ??= new Messenger();

        private readonly Dictionary<Type, List<Action<object>>> _subscribers = new();

        public void Register<T>(Action<T> callback)
        {
            if (!_subscribers.ContainsKey(typeof(T)))
            {
                _subscribers[typeof(T)] = new List<Action<object>>();
            }
            _subscribers[typeof(T)].Add(o => callback((T)o));
        }

        public void Send<T>(T message)
        {
            if (_subscribers.ContainsKey(typeof(T)))
            {
                foreach (var callback in _subscribers[typeof(T)])
                {
                    callback(message);
                }
            }
        }
    }
}
