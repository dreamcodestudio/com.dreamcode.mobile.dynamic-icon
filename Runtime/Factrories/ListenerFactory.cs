using UnityEngine;

namespace DreamCode.EasyShare
{
    public static class ListenerFactory
    {
        public static T? Create<T>() where T : Object
        {
            var listener = Object.FindObjectOfType<T>();
            if (!ReferenceEquals(listener, null))
                return listener;
            const string listenerName = "ShareListener";
            var listenerGo = new GameObject(listenerName);
            listener = listenerGo.AddComponent(typeof(T)) as T;
            Object.DontDestroyOnLoad(listenerGo);

            return listener;
        }
    }
}