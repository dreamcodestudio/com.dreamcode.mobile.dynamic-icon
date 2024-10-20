using UnityEngine;

namespace DreamCode.DynamicIcon
{
    internal sealed class AndroidIconChanger : IIconChanger
    {
        private static readonly AndroidJavaClass _unityPlayer = new("com.unity3d.player.UnityPlayer");
        private readonly AndroidJavaObject _iconChanger = new("dreamcode.unity.dynamicicon.IconChanger");

        public void Setup(string[] iconList)
        {
            _iconChanger.CallStatic("SetUp", iconList);
        }

        public void ApplyAlternateIcon(string iconName)
        {
            using var activity = _unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
            _iconChanger.Call("ApplyAlternateIcon", activity, iconName);
        }
    }
}