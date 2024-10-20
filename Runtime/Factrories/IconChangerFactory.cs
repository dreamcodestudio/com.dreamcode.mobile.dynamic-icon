namespace DreamCode.DynamicIcon
{
    internal static class IconChangerFactory
    {
        internal static IIconChanger Create()
        {
#if UNITY_EDITOR
            return new EditorIconChanger();
#elif UNITY_ANDROID
            return new AndroidIconChanger();
#elif UNITY_IOS
            return new iOSIconChanger();
#endif
            throw new System.NotImplementedException($"{nameof(IconChangerFactory)}");
        }
    }
}