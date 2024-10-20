using System;
using UnityEngine;

namespace DreamCode.EasyShare
{
    public sealed class AndroidShareListener : MonoBehaviour
    {
        public Action<string>? ShareCompleted;

        public void OnShareCompleted(string packageName)
        {
            ShareCompleted?.Invoke(packageName);
            ShareCompleted = null;
        }
    }
}