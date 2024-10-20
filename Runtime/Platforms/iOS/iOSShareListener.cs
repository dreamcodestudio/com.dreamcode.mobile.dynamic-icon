using System;
using UnityEngine;

namespace DreamCode.EasyShare
{
    public sealed class iOSShareListener : MonoBehaviour
    {
        public Action<string>? ShareCompleted;

        public void OnShareCompleted(string packageName)
        {
            ShareCompleted?.Invoke(packageName);
            ShareCompleted = null;
        }
    }
}